using InstagramApiSharp.Enums;

using System;
using System.Windows.Forms;

namespace BotInstagram
{
    public partial class frmEdiotProfile : Form
    {
        public frmEdiotProfile()
        {
            InitializeComponent();
        }

        private async void frmEdiotProfile_Load(object sender, EventArgs e)
        {
            var editProfile = await ctx.api.AccountProcessor.GetRequestForEditProfileAsync();
            if (editProfile.Succeeded)
            {
                txtBio.Text = editProfile.Value.Biography;
                txtEmail.Text = editProfile.Value.Email;
                txtMobile.Text = editProfile.Value.PhoneNumber;
                txtName.Text = editProfile.Value.FullName;
                txtSite.Text = editProfile.Value.ExternalUrl;
                txtUserName.Text = editProfile.Value.Username;
                if (editProfile.Value.Gender == InstaGenderType.Male)
                    rbMale.Checked = true;
                else
                {
                    rbFemale.Checked = true;
                }
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var edit = await ctx.api.AccountProcessor
                .EditProfileAsync(txtName.Text, txtBio.Text,
                    txtSite.Text, txtEmail.Text, txtMobile.Text,
                    (rbMale.Checked) ? InstaGenderType.Male : InstaGenderType.Female,
                    txtUserName.Text);
            if (edit.Succeeded)
            {
                MessageBox.Show("با موفقیت انجام شد");
                this.Close();
            }
        }

        private void frmEdiotProfile_Shown(object sender, EventArgs e)
        {
            ProfilePic.Load(ctx.api.GetLoggedUser().LoggedInUser.ProfilePicUrl);
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                await ctx.api.AccountProcessor.RemoveProfilePictureAsync();

                byte[] picByte = System.IO.File.ReadAllBytes(op.FileName);
                var result = ctx.api.AccountProcessor.ChangeProfilePictureAsync(picByte).Result;
                if (result.Succeeded)
                {
                    ProfilePic.ImageLocation = op.FileName;
                }
            }
        }
    }
}
