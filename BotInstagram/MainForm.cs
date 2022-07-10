using InstagramApiSharp;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;

using System;
using System.IO;
using System.Windows.Forms;

namespace BotInstagram
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        const string stateFile = "state.bin";

        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }



        void CustomizeDesign()
        {
            AccountManagerSubPnl.Visible = false;
            AutoActionSubPanel.Visible = false;
        }

        void hideSubMenu()
        {
            if (AccountManagerSubPnl.Visible) AccountManagerSubPnl.Visible = false;
            if (AutoActionSubPanel.Visible) AutoActionSubPanel.Visible = false;
        }
        void showMenu(Panel pnl)
        {
            if (!pnl.Visible)
            {
                hideSubMenu();
                pnl.Visible = true;
            }
            else
                pnl.Visible = false;
        }


        #region AutoActions

        private void AutoBtn_Click(object sender, EventArgs e)
        {
            //codes
            var i = new AutoUserPanel();
            i.mainFrm = this;
            openChildForm(i);
            showMenu(AutoActionSubPanel);
        }
        private void AutoDCBtn_Click(object sender, EventArgs e)
        {
            var i = new AutoDC();
            i.mainFrm = this;
            openChildForm(i);
            hideSubMenu();
        }

        #endregion

        #region AccountManager

        private void AccountManagerBtn_Click(object sender, EventArgs e)
        {
            var i = new UserInterface();
            openChildForm(i);
            showMenu(AccountManagerSubPnl);
        }

        private void EditProfilebtn_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEdiotProfile());

            hideSubMenu();
        }



        #endregion

        Form activeForm = null;
        void openChildForm(Form childForm)
        {
            if (activeForm == childForm)
                return;
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPnl.Controls.Add(childForm);
            ChildFormPnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            WaitForm wait = new WaitForm();
            toggleOnPanel(wait);
            wait.ShowLogs("logging in");

            var userSession = new UserSessionData();
            userSession.UserName = UserTxtbox.Text;
            userSession.Password = PasswordTxtbox.Text;

            var delay = RequestDelay.FromSeconds(0, 2);

            ctx.api = InstaApiBuilder.CreateBuilder()
                .SetUser(userSession)
                .UseLogger(new DebugLogger(LogLevel.All))
                .SetRequestDelay(delay)
                .Build();

            if (!ctx.api.IsUserAuthenticated)
            {
                delay.Disable();
                var logInResult = await ctx.api.LoginAsync();
                delay.Enable();
                if (!logInResult.Succeeded)
                {
                    return;
                }
            }

            var auto = new AutoUserPanel();
            auto.mainFrm = this;
            openChildForm(auto);
            AutoBtn.Enabled = true;
            AccountManagerBtn.Enabled = true;
            ActivitiesBtn.Enabled = true;
            LogoutBtn.Enabled = true;
            toggleOffPanel(wait);
        }
        private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (ctx.api != null && ctx.api.IsUserAuthenticated)
                {
                    await ctx.api.LogoutAsync();
                }

                CheckInForm.instance.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void ActivitiesBtn_Click(object sender, EventArgs e)
        {
            (new frmActivity()).ShowDialog();
        }

        void toggleOnPanel(Form frm)
        {
            frm.Show();
            this.Enabled = false;
        }
        void toggleOffPanel(Form frm)
        {
            this.Enabled = true;
            frm.Close();
        }

        private async void LogoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctx.api != null && ctx.api.IsUserAuthenticated)
                {
                    await ctx.api.LogoutAsync();

                    if (File.Exists(stateFile)) File.Delete(stateFile);
                }

                CheckInForm.instance.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        
    }
}
