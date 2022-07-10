//using Instadown;

using BotInstagram.Class;

using InstagramApiSharp;
using InstagramApiSharp.Classes.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotInstagram
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }
        private async void UserInterface_Load(object sender, EventArgs e)
        {
            BlockUsersList.Items.Clear();
            var users = await ctx.api.UserProcessor.GetBlockedUsersAsync(PaginationParameters.MaxPagesToLoad(1));
            foreach (var user in users.Value.BlockedList)
            {
                BlockUsersList.Items.Add(user.UserName);
            }
        }

        #region Follow_Unfollow
        private async void UnfollowBtn_Click(object sender, EventArgs e)
        {
            var user = await ctx.api.UserProcessor.GetUserAsync(UserFollowBlockIdTxtbox.Text);
            var unfollow = await ctx.api.UserProcessor.UnFollowUserAsync(user.Value.Pk);
            if (unfollow.Succeeded)
            {
                MessageBox.Show("successfully Done.");
            }
            else
                MessageBox.Show("Error!");
        }

        private async void FollowBtn_Click(object sender, EventArgs e)
        {
            var user = await ctx.api.UserProcessor.GetUserAsync(UserFollowBlockIdTxtbox.Text);
            var follow = await ctx.api.UserProcessor.FollowUserAsync(user.Value.Pk);
            if (follow.Succeeded)
            {
                MessageBox.Show("successfully Done.");
            }
            else
                MessageBox.Show("Error!");

        }

        private async void BlockBtn_Click(object sender, EventArgs e)
        {
            var user = await ctx.api.UserProcessor.GetUserAsync(UserFollowBlockIdTxtbox.Text);
            var block = await ctx.api.UserProcessor.BlockUserAsync(user.Value.Pk);
            if (block.Succeeded)
                MessageBox.Show("successfully Done.");
            else
                MessageBox.Show("Error!");
        }

        private async void UnblockBtn_Click(object sender, EventArgs e)
        {
            var user = await ctx.api.UserProcessor.GetUserAsync(UserFollowBlockIdTxtbox.Text);
            var block = await ctx.api.UserProcessor.UnBlockUserAsync(user.Value.Pk);
            if (block.Succeeded)
                MessageBox.Show("Successfully Done.");
            else
                MessageBox.Show("Error!");
        }

        #endregion
        #region BlockedUsers
        private async void UnblockAllUsers_Click(object sender, EventArgs e)
        {
            var blockedUsers = await ctx.api.UserProcessor.GetBlockedUsersAsync(PaginationParameters.MaxPagesToLoad(2));
            foreach (var user in blockedUsers.Value.BlockedList)
            {
                await ctx.api.UserProcessor.UnBlockUserAsync(user.Pk);
            }

            MessageBox.Show("Unblock all users Done.");
        }
        #endregion
        #region Profile
        private void AddNewProfileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                byte[] picByte = System.IO.File.ReadAllBytes(op.FileName);
                var result = ctx.api.AccountProcessor.ChangeProfilePictureAsync(picByte).Result;
                if (result.Succeeded)
                {
                    ProfilePic.ImageLocation = op.FileName;
                    MessageBox.Show("Done.");
                }
            }
        }

        private async void DeleteProfileBtn_Click(object sender, EventArgs e)
        {
            var result = await ctx.api.AccountProcessor.RemoveProfilePictureAsync();
            if (result.Succeeded)
            {
                ProfilePic.Image = null;
                MessageBox.Show("Done.");
            }
        }
        #endregion
        #region SendPvMessage
        private async void SendTxtBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            var user = await ctx.api.UserProcessor.GetUserAsync(PvUserIdTxt.Text);
            var direct = await ctx.api.MessagingProcessor.SendDirectTextAsync(user.Value.Pk.ToString(),
                null, PvMessageTxt.Text);
            if (direct.Succeeded)
            {
                MessageBox.Show("Sended ...");
            }

            this.Enabled = true;
        }

        private async void SendImageBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var inbox = await ctx.api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(1));

            var threadId = inbox.Value.Inbox.Threads.FirstOrDefault(i => i.Title == PvUserIdTxt.Text).ThreadId;

            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            var imageUp = new InstaImage()
            {
                Uri = op.FileName
            };

            var image = await ctx.api.MessagingProcessor.SendDirectPhotoAsync(imageUp, threadId);
            if (image.Succeeded)
            {
                MessageBox.Show("Sended ...");
            }
            else
            {
                MessageBox.Show(image.Info.Message);
            }
            this.Enabled = true;
        }

        private async void SendVideoBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            var inbox = await ctx.api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(1));

            var threadId = inbox.Value.Inbox.Threads.FirstOrDefault(i => i.Title == PvUserIdTxt.Text).ThreadId;

            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            var videoUp = new InstaVideo()
            {
                Uri = op.FileName
            };

            var videoUpload = new InstaVideoUpload()
            {
                Video = videoUp
            };

            var directVideo = await ctx.api.MessagingProcessor.SendDirectVideoAsync(videoUpload, threadId);
            if (directVideo.Succeeded)
            {
                MessageBox.Show("Sended ...");
            }
            else
            {
                MessageBox.Show(directVideo.Info.Message);
            }
            this.Enabled = true;
        }
        #endregion
        #region Post
        private async void PostImageBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            string imagePath = op.FileName;

            List<string> tags = new List<string>();
            if (TagsTxtbox.Text != null)
            {
                tags = TagsTxtbox.Text.Split(',').ToList();
                foreach (var tag in tags)
                {
                    var user = await ctx.api.UserProcessor.GetUserAsync(tag);
                    if (!user.Succeeded)
                    {
                        tags.Remove(tag);
                    }
                }
                if (tags == null)
                {
                    MessageBox.Show("user tags not available.");
                    this.Enabled = true;
                    return;
                }

            }

            var media = new InstaImageUpload()
            {
                Height = 1080,
                Width = 1080,
                Uri = imagePath
            };
            foreach (var tag in tags)
            {
                media.UserTags.Add(new InstaUserTagUpload()
                {
                    Username = tag,
                    X = 0.5,
                    Y = 0.5
                });
            }

            var res = await ctx.api.MediaProcessor
                .UploadPhotoAsync(media, PostCaptionTxt.Text);
            if (res.Succeeded)
            {
                PostCaptionTxt.Text = "";
                MessageBox.Show("Done .");
            }
            this.Enabled = true;
        }
        private async void PostVideo_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            List<string> tags = new List<string>();
            if (TagsTxtbox.Text != null)
            {
                tags = TagsTxtbox.Text.Split(',').ToList();
                foreach (var tag in tags)
                {
                    var user = await ctx.api.UserProcessor.GetUserAsync(tag);
                    if (!user.Succeeded)
                    {
                        tags.Remove(tag);
                    }
                }
                if (tags == null)
                {
                    MessageBox.Show("user tags not available.");
                    this.Enabled = true;
                    return;
                }

            }
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "select video";
            string formats = "All Videos Files |*.dat; *.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                             " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm";

            op.Filter = formats;
            op.ShowDialog();
            string videoUri = op.FileName;
            OpenFileDialog opImage = new OpenFileDialog();
            opImage.Title = "Select Image";
            opImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            opImage.ShowDialog();
            string imageUri = opImage.FileName;

            var video = new InstaVideoUpload()
            {
                Video = new InstaVideo(videoUri, 0, 0),
                VideoThumbnail = new InstaImage(imageUri, 0, 0)
            };
            foreach (var tag in tags)
            {
                video.UserTags.Add(new InstaUserTagUpload()
                {
                    Username = tag
                });
            }

            var res = await ctx.api.MediaProcessor
                .UploadVideoAsync(video, PostCaptionTxt.Text);
            if (res.Succeeded)
            {
                MessageBox.Show("Done");
            }
            this.Enabled = true;
        }
        #endregion
        

        private void UserInterface_Shown(object sender, EventArgs e)
        {
            ProfilePic.Load(ctx.api.GetLoggedUser().LoggedInUser.ProfilePicUrl);


            string stateFile = "state.bin";

            if (!ctx.api.IsUserAuthenticated)
            {
                if (File.Exists(stateFile)) File.Delete(stateFile);
                this.Close();
                CheckInForm.instance.Close();

                MessageBox.Show("you can't login app please try again.");
            }
        }

        private void Download_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                using (var sfd = new FolderBrowserDialog())
                {
                    if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(sfd.SelectedPath))
                    {
                        MediaClass m = new MediaClass();
                        m.inputUrl = LinkTxt.Text;
                        if (VideoCheck.Checked) m.DownloadVideo(sfd.SelectedPath);
                        if (ImageCheck.Checked) m.DownloadImage(sfd.SelectedPath);
                    }
                }
                this.Enabled = true;
                MessageBox.Show("Done.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
