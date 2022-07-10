using InstagramApiSharp;

using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotInstagram
{
    public partial class AutoUserPanel : Form
    {
        public Form mainFrm;


        public AutoUserPanel()
        {
            InitializeComponent();
        }

        private async void UnfollowBtn_Click(object sender, EventArgs e)
        {
            WaitForm wait = new WaitForm();
            wait.ShowLogs("wait...");
            toggleOn(wait);

            var user = await ctx.api.GetCurrentUserAsync();
            var users = await ctx.api.UserProcessor.GetUserFollowingAsync(user.Value.UserName, PaginationParameters.MaxPagesToLoad(10));
            if (users.Succeeded)
            {
                foreach (var item in users.Value)
                {
                    if (wait.Is_closed)
                    {
                        toggleOff(wait);
                        return;
                    }
                    Random rnd = new Random();

                    var unfollow = await ctx.api.UserProcessor.UnFollowUserAsync(item.Pk);
                    if(!unfollow.Succeeded)
                    {
                        wait.ShowLogs("Error Found: " + unfollow.Info.Message);
                        await Task.Delay(rnd.Next(3000, 6000));
                        toggleOff(wait);
                        return;
                    }
                    else
                    {
                        wait.ShowLogs(item.UserName + " is unfollowed");
                        
                        await Task.Delay(rnd.Next(7000, 19000));
                    }
                }
                MessageBox.Show("done");
            }

            toggleOff(wait);
        }

        private async void AcceptRequestsBtn_Click(object sender, EventArgs e)
        {
            WaitForm wait = new WaitForm();
            wait.ShowLogs("wait...");
            toggleOn(wait);
            Random rnd = new Random();
            var UsersRequest = await ctx.api.UserProcessor.GetPendingFriendRequestsAsync();
            if (UsersRequest.Succeeded)
            {
                foreach (var user in UsersRequest.Value.Users)
                {
                    if (wait.Is_closed)
                    {
                        toggleOff(wait);
                        return;
                    }
                    
                    var accept = await ctx.api.UserProcessor.AcceptFriendshipRequestAsync(user.Pk);
                    if (!accept.Succeeded)
                    {
                        wait.ShowLogs("Error Found: " + accept.Info.Message);
                        await Task.Delay(rnd.Next(3000, 6000));
                        toggleOff(wait);
                        return;
                    }
                    else
                    {
                        wait.ShowLogs(user.UserName + " is accepted request.");
                    }
                    await Task.Delay(rnd.Next(7000, 19000));

                }
                MessageBox.Show("Done");
            }
            toggleOff(wait);
        }

        private async void Rejectall_Click(object sender, EventArgs e)
        {
            WaitForm wait = new WaitForm();
            wait.ShowLogs("wait...");
            toggleOn(wait);

            var UsersRequest = await ctx.api.UserProcessor.GetPendingFriendRequestsAsync();
            if (UsersRequest.Succeeded)
            {
                foreach (var user in UsersRequest.Value.Users)
                {
                    if (wait.Is_closed)
                    {
                        toggleOff(wait);
                        return;
                    }
                    Random rnd = new Random();

                    var reject = await ctx.api.UserProcessor.IgnoreFriendshipRequestAsync(user.Pk);
                    if (reject.Succeeded)
                    {
                        wait.ShowLogs(user.UserName + " is rejected.");
                        await Task.Delay(rnd.Next(3000, 6000));

                    }
                    else
                    {
                        wait.ShowLogs("Error Found: " + reject.Info.Message);
                        await Task.Delay(rnd.Next(3000, 6000));

                        toggleOff(wait);
                        return;
                    }
                }
                MessageBox.Show("Done");
            }
            toggleOff(wait);
        }

        private async void FollowBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opImage = new OpenFileDialog();
            opImage.Title = "Select Text";
            opImage.Filter = "Text files (*.txt) | *.txt";
            opImage.ShowDialog();

            var found = (opImage.FileName != "") ? File.ReadAllLines(opImage.FileName) : null;
            if (found == null)
                return;
            WaitForm wait = new WaitForm();
            toggleOn(wait);
            wait.ShowLogs("wait...");

            foreach (var item in found)
            {
                if (wait.Is_closed)
                {
                    toggleOff(wait);
                    return;
                }
                Random rnd = new Random();

                var user = await ctx.api.UserProcessor.GetUserAsync(item);

                
                if (user.Succeeded)
                {

                    var userfollowed = await ctx.api.UserProcessor.FollowUserAsync(user.Value.Pk);
                    wait.ShowLogs(user.Value.UserName + " is followed.");

                    if (userfollowed.Succeeded)
                    {
                        await Task.Delay(rnd.Next(9000, 17000));
                        if (fullLike.Checked && !userfollowed.Value.IsPrivate)
                        {
                            var UserMedias = await ctx.api.UserProcessor.GetUserMediaAsync(item, PaginationParameters.MaxPagesToLoad(1));
                            foreach (var media in UserMedias.Value)
                            {
                                if (wait.Is_closed)
                                {
                                    toggleOff(wait);

                                    return;
                                }
                                await Task.Delay(rnd.Next(10000, 40000));
                                if (!userfollowed.Value.IsPrivate && media.HasLiked)
                                {
                                    await ctx.api.MediaProcessor.LikeMediaAsync(media.Pk);
                                }
                            }
                        }
                    }

                }
                else
                {
                    wait.ShowLogs("Error Found: "+user.Info.Message);
                    await Task.Delay(rnd.Next(3000, 5000));
                    toggleOff(wait);
                    return;
                }
            }
            MessageBox.Show("Done");

            toggleOff(wait);
        }



        private async void SetCommentBtn_Click(object sender, EventArgs e)
        {
            WaitForm wait = new WaitForm();
            wait.ShowLogs("wait...");
            toggleOn(wait);

            var RecentMedia = await ctx.api.HashtagProcessor.GetRecentHashtagMediaListAsync(TagAutoComment.Text, PaginationParameters.MaxPagesToLoad(1));
            var comments = CommentAutoSetter.Text.Split(',');
            if (RecentMedia.Succeeded)
            {
                foreach (var post in RecentMedia.Value.Medias)
                {
                    Random rnd = new Random();
                    await Task.Delay(rnd.Next(10000, 30000));

                    if (wait.Is_closed)
                    {
                        toggleOff(wait);

                        return;
                    }
                    if (!post.IsCommentsDisabled)
                    {
                        var res = await ctx.api.CommentProcessor.CommentMediaAsync(post.Pk, comments[rnd.Next(comments.Length - 1)]);
                        
                    }
                }
            }

            var TopMedia = await ctx.api.HashtagProcessor.GetTopHashtagMediaListAsync(TagAutoComment.Text, PaginationParameters.MaxPagesToLoad(1));
            if (TopMedia.Succeeded)
            {
                foreach (var post in TopMedia.Value.Medias)
                {
                    Random rnd = new Random();
                    await Task.Delay(rnd.Next(10000, 30000));

                    if (wait.Is_closed)
                    {
                        toggleOff(wait);

                        return;
                    }
                    if (!post.IsCommentsDisabled)
                    {
                        var res = await ctx.api.CommentProcessor.CommentMediaAsync(post.Pk, comments[rnd.Next(comments.Length - 1)]);
                        

                    }
                }
            }
            var med = await ctx.api.FeedProcessor.GetTagFeedAsync(TagAutoComment.Text, PaginationParameters.MaxPagesToLoad(1));
            if (med.Succeeded)
            {
                foreach (var post in med.Value.Medias)
                {
                    Random rnd = new Random();
                    await Task.Delay(rnd.Next(10000, 30000));

                    if (wait.Is_closed)
                    {
                        toggleOff(wait);

                        return;
                    }
                    if (!post.IsCommentsDisabled)
                    {
                        var res = await ctx.api.CommentProcessor.CommentMediaAsync(post.Pk, comments[rnd.Next(comments.Length - 1)]);
                        
                    }
                }
            }
            MessageBox.Show("done");
            toggleOff(wait);
        }

        private async void FollowerFounderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    sfd.FilterIndex = 2;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (FollowerFounderTxt.Text != null)
                        {
                            WaitForm wait = new WaitForm();

                            wait.ShowLogs("wait...");
                            toggleOn(wait);

                            var follwings = await ctx.api.UserProcessor.GetUserFollowersAsync
                                (FollowerFounderTxt.Text, PaginationParameters.MaxPagesToLoad(100));
                            if (!follwings.Info.Message.Contains("No errors detected"))
                                return;
                            if (follwings.Value.Count == 0)
                            {
                                MessageBox.Show("Done");
                                return;
                            }
                            using (StreamWriter file = new StreamWriter(sfd.FileName + ".txt", append: true))
                            {
                                foreach (var val in follwings.Value)
                                {
                                    if (wait.Is_closed)
                                    {
                                        toggleOff(wait);

                                        return;
                                    }
                                    if (IsPrivateFallower.Checked || !val.IsPrivate)
                                        await file.WriteLineAsync(val.UserName);


                                }
                                MessageBox.Show("Done");

                            }

                            toggleOff(wait);
                        }
                        else
                        {
                            MessageBox.Show("Empty Field!!!!");
                        }
                    }
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
            
        }

        private async void unfollowFlewbackBtn_Click(object sender, EventArgs e)
        {
            WaitForm wait = new WaitForm();
            wait.ShowLogs("wait...");
            toggleOn(wait);

            var user = await ctx.api.GetCurrentUserAsync();
            var followers = await ctx.api.UserProcessor.GetUserFollowersAsync(user.Value.UserName, PaginationParameters.MaxPagesToLoad(10));
            var followings = await ctx.api.UserProcessor.GetUserFollowingAsync(user.Value.UserName, PaginationParameters.MaxPagesToLoad(10));
            Random rnd = new Random();
            foreach (var following in followings.Value)
            {
                if (wait.Is_closed)
                {
                    toggleOff(wait);

                    return;
                }

                var IsFollower = followers.Value.Any(o => o.UserName == following.UserName);
                if (!IsFollower)
                {
                    var unfollow = await ctx.api.UserProcessor.UnFollowUserAsync(following.Pk);
                    if (!unfollow.Succeeded)
                    {
                        wait.ShowLogs(unfollow.Info.Message);
                        await Task.Delay(rnd.Next(7000, 19000));
                        toggleOff(wait);
                        return;
                    }
                    else
                    {
                        wait.ShowLogs(following.UserName + " is unfollowed.");
                    }
                }
                await Task.Delay(rnd.Next(7000, 19000));

            }


        }
        void toggleOn(Form wait)
        {
            mainFrm.Enabled = false;
            this.Enabled = false;
            wait.Show();
        }
        void toggleOff(Form wait)
        {
            mainFrm.Enabled = true;
            this.Enabled = true;
            wait.Close();
        }

        private void AutoUserPanel_Shown(object sender, EventArgs e)
        {
            string stateFile = "state.bin";

            if (!ctx.api.IsUserAuthenticated)
            {
                if (File.Exists(stateFile)) File.Delete(stateFile);
                this.Close();
                CheckInForm.instance.Close();
                
                MessageBox.Show("you can't login app please try again.");
            }
        }
    }
}
