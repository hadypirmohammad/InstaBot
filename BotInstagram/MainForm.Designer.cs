
namespace BotInstagram
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ActivitiesBtn = new System.Windows.Forms.Button();
            this.AccountManagerSubPnl = new System.Windows.Forms.Panel();
            this.EditProfile = new System.Windows.Forms.Button();
            this.AccountManagerBtn = new System.Windows.Forms.Button();
            this.AutoActionSubPanel = new System.Windows.Forms.Panel();
            this.AutoDCBtn = new System.Windows.Forms.Button();
            this.AutoBtn = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.ChildFormPnl = new System.Windows.Forms.Panel();
            this.InstaLoginPnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserTxtbox = new System.Windows.Forms.TextBox();
            this.SidePanel.SuspendLayout();
            this.AccountManagerSubPnl.SuspendLayout();
            this.AutoActionSubPanel.SuspendLayout();
            this.ChildFormPnl.SuspendLayout();
            this.InstaLoginPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.AutoScroll = true;
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SidePanel.Controls.Add(this.LogoutBtn);
            this.SidePanel.Controls.Add(this.ActivitiesBtn);
            this.SidePanel.Controls.Add(this.AccountManagerSubPnl);
            this.SidePanel.Controls.Add(this.AccountManagerBtn);
            this.SidePanel.Controls.Add(this.AutoActionSubPanel);
            this.SidePanel.Controls.Add(this.AutoBtn);
            this.SidePanel.Controls.Add(this.LogoPanel);
            this.SidePanel.Location = new System.Drawing.Point(0, 5);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(200, 640);
            this.SidePanel.TabIndex = 1;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoutBtn.Enabled = false;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 386);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LogoutBtn.Size = new System.Drawing.Size(200, 48);
            this.LogoutBtn.TabIndex = 13;
            this.LogoutBtn.Text = "log out";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ActivitiesBtn
            // 
            this.ActivitiesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActivitiesBtn.Enabled = false;
            this.ActivitiesBtn.FlatAppearance.BorderSize = 0;
            this.ActivitiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivitiesBtn.ForeColor = System.Drawing.Color.Black;
            this.ActivitiesBtn.Location = new System.Drawing.Point(0, 334);
            this.ActivitiesBtn.Name = "ActivitiesBtn";
            this.ActivitiesBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ActivitiesBtn.Size = new System.Drawing.Size(200, 52);
            this.ActivitiesBtn.TabIndex = 12;
            this.ActivitiesBtn.Text = "Activities";
            this.ActivitiesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActivitiesBtn.UseVisualStyleBackColor = true;
            this.ActivitiesBtn.Click += new System.EventHandler(this.ActivitiesBtn_Click);
            // 
            // AccountManagerSubPnl
            // 
            this.AccountManagerSubPnl.BackColor = System.Drawing.Color.Purple;
            this.AccountManagerSubPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AccountManagerSubPnl.Controls.Add(this.EditProfile);
            this.AccountManagerSubPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountManagerSubPnl.Location = new System.Drawing.Point(0, 286);
            this.AccountManagerSubPnl.Name = "AccountManagerSubPnl";
            this.AccountManagerSubPnl.Size = new System.Drawing.Size(200, 48);
            this.AccountManagerSubPnl.TabIndex = 11;
            // 
            // EditProfile
            // 
            this.EditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.EditProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditProfile.FlatAppearance.BorderSize = 0;
            this.EditProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.EditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProfile.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EditProfile.Location = new System.Drawing.Point(0, 0);
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.EditProfile.Size = new System.Drawing.Size(196, 46);
            this.EditProfile.TabIndex = 0;
            this.EditProfile.Text = "EditProfile";
            this.EditProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditProfile.UseVisualStyleBackColor = false;
            this.EditProfile.Click += new System.EventHandler(this.EditProfilebtn_Click);
            // 
            // AccountManagerBtn
            // 
            this.AccountManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountManagerBtn.Enabled = false;
            this.AccountManagerBtn.FlatAppearance.BorderSize = 0;
            this.AccountManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountManagerBtn.ForeColor = System.Drawing.Color.Black;
            this.AccountManagerBtn.Location = new System.Drawing.Point(0, 240);
            this.AccountManagerBtn.Name = "AccountManagerBtn";
            this.AccountManagerBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AccountManagerBtn.Size = new System.Drawing.Size(200, 46);
            this.AccountManagerBtn.TabIndex = 10;
            this.AccountManagerBtn.Text = "AccountManager";
            this.AccountManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountManagerBtn.UseVisualStyleBackColor = true;
            this.AccountManagerBtn.Click += new System.EventHandler(this.AccountManagerBtn_Click);
            // 
            // AutoActionSubPanel
            // 
            this.AutoActionSubPanel.BackColor = System.Drawing.Color.Purple;
            this.AutoActionSubPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AutoActionSubPanel.Controls.Add(this.AutoDCBtn);
            this.AutoActionSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoActionSubPanel.Location = new System.Drawing.Point(0, 192);
            this.AutoActionSubPanel.Name = "AutoActionSubPanel";
            this.AutoActionSubPanel.Size = new System.Drawing.Size(200, 48);
            this.AutoActionSubPanel.TabIndex = 7;
            // 
            // AutoDCBtn
            // 
            this.AutoDCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AutoDCBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoDCBtn.FlatAppearance.BorderSize = 0;
            this.AutoDCBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AutoDCBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.AutoDCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoDCBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoDCBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoDCBtn.Location = new System.Drawing.Point(0, 0);
            this.AutoDCBtn.Name = "AutoDCBtn";
            this.AutoDCBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.AutoDCBtn.Size = new System.Drawing.Size(196, 46);
            this.AutoDCBtn.TabIndex = 0;
            this.AutoDCBtn.Text = "AutoDC_sender";
            this.AutoDCBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoDCBtn.UseVisualStyleBackColor = false;
            this.AutoDCBtn.Click += new System.EventHandler(this.AutoDCBtn_Click);
            // 
            // AutoBtn
            // 
            this.AutoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoBtn.Enabled = false;
            this.AutoBtn.FlatAppearance.BorderSize = 0;
            this.AutoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoBtn.ForeColor = System.Drawing.Color.Black;
            this.AutoBtn.Location = new System.Drawing.Point(0, 146);
            this.AutoBtn.Name = "AutoBtn";
            this.AutoBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AutoBtn.Size = new System.Drawing.Size(200, 46);
            this.AutoBtn.TabIndex = 1;
            this.AutoBtn.Text = "AutoActions";
            this.AutoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoBtn.UseVisualStyleBackColor = true;
            this.AutoBtn.Click += new System.EventHandler(this.AutoBtn_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackgroundImage = global::BotInstagram.Properties.Resources.logo;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(200, 146);
            this.LogoPanel.TabIndex = 0;
            // 
            // ChildFormPnl
            // 
            this.ChildFormPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChildFormPnl.BackgroundImage = global::BotInstagram.Properties.Resources.background;
            this.ChildFormPnl.Controls.Add(this.InstaLoginPnl);
            this.ChildFormPnl.Location = new System.Drawing.Point(200, 25);
            this.ChildFormPnl.Name = "ChildFormPnl";
            this.ChildFormPnl.Size = new System.Drawing.Size(869, 620);
            this.ChildFormPnl.TabIndex = 2;
            // 
            // InstaLoginPnl
            // 
            this.InstaLoginPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.InstaLoginPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InstaLoginPnl.Controls.Add(this.pictureBox1);
            this.InstaLoginPnl.Controls.Add(this.LoginBtn);
            this.InstaLoginPnl.Controls.Add(this.label2);
            this.InstaLoginPnl.Controls.Add(this.PasswordTxtbox);
            this.InstaLoginPnl.Controls.Add(this.label1);
            this.InstaLoginPnl.Controls.Add(this.UserTxtbox);
            this.InstaLoginPnl.Location = new System.Drawing.Point(307, 57);
            this.InstaLoginPnl.Name = "InstaLoginPnl";
            this.InstaLoginPnl.Size = new System.Drawing.Size(344, 440);
            this.InstaLoginPnl.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LoginBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.Black;
            this.LoginBtn.Location = new System.Drawing.Point(129, 388);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(104, 46);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PasswordTxtbox.BackColor = System.Drawing.Color.White;
            this.PasswordTxtbox.Location = new System.Drawing.Point(11, 260);
            this.PasswordTxtbox.Multiline = true;
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.PasswordChar = '*';
            this.PasswordTxtbox.Size = new System.Drawing.Size(322, 37);
            this.PasswordTxtbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username / Phone / Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserTxtbox
            // 
            this.UserTxtbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserTxtbox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTxtbox.Location = new System.Drawing.Point(11, 180);
            this.UserTxtbox.Multiline = true;
            this.UserTxtbox.Name = "UserTxtbox";
            this.UserTxtbox.Size = new System.Drawing.Size(322, 36);
            this.UserTxtbox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1069, 646);
            this.Controls.Add(this.ChildFormPnl);
            this.Controls.Add(this.SidePanel);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Movable = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(22, 79, 22, 26);
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SidePanel.ResumeLayout(false);
            this.AccountManagerSubPnl.ResumeLayout(false);
            this.AutoActionSubPanel.ResumeLayout(false);
            this.ChildFormPnl.ResumeLayout(false);
            this.InstaLoginPnl.ResumeLayout(false);
            this.InstaLoginPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button AutoBtn;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel ChildFormPnl;
        private System.Windows.Forms.Panel InstaLoginPnl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserTxtbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel AutoActionSubPanel;
        private System.Windows.Forms.Button AutoDCBtn;
        private System.Windows.Forms.Panel AccountManagerSubPnl;
        private System.Windows.Forms.Button EditProfile;
        private System.Windows.Forms.Button AccountManagerBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ActivitiesBtn;
    }
}