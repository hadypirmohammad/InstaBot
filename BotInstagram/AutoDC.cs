using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp;
using System.Linq;

namespace BotInstagram
{
    public partial class AutoDC : Form
    {
        public Form mainFrm;
        public AutoDC()
        {
            InitializeComponent();
        }
        string[] UserLists;

        private void alignLeftCheck_CheckedChanged(object sender, EventArgs e)
        {
            DcTextbox.TextAlign = HorizontalAlignment.Left;
        }

        private void AlignRightCheck_CheckedChanged(object sender, EventArgs e)
        {
            DcTextbox.TextAlign = HorizontalAlignment.Right;
        }

        private void ChooseListBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opImage = new OpenFileDialog();
            opImage.Title = "Select Text";
            opImage.Filter = "Text files (*.txt) | *.txt";
            opImage.ShowDialog();

            UserLists = (opImage.FileName != "") ? File.ReadAllLines(opImage.FileName) : null;
            if (UserLists == null)
            {
                MessageBox.Show("you don't choose user list");
            }
            else
            {
                Locationlbl.Text = opImage.FileName;
            }

        }

        private async void SendTextBtn_Click(object sender, EventArgs e)
        {
            if (DcTextbox.Text == null && UserLists == null)
            {
                MessageBox.Show("the textbox is null or you don't set userList");
                return;
            }
            else
            {

                try
                {
                    var wait = new WaitForm();
                    toggleOn(wait);

                    Random rnd = new Random();
                    foreach (var item in UserLists)
                    {

                        var user = await ctx.api.UserProcessor.GetUserAsync(item);
                        if (!user.Succeeded)
                            continue;
                        await Task.Delay(rnd.Next(10000, 40000));
                        var direct = await ctx.api.MessagingProcessor.SendDirectTextAsync(user.Value.Pk.ToString(),
                            null, DcTextbox.Text);
                        if (direct.Succeeded)
                        {
                            wait.ShowLogs("comment sent to " + item);
                        }
                        else
                        {
                            wait.ShowLogs("Error found: " + direct.Info.Message);
                            await Task.Delay(rnd.Next(5000, 7000));
                            toggleOff(wait);
                            return;
                        }
                    }
                    toggleOff(wait);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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

        private void AutoDC_Shown(object sender, EventArgs e)
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
