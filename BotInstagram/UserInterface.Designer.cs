
namespace BotInstagram
{
    partial class UserInterface
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnblockBtn = new System.Windows.Forms.Button();
            this.BlockBtn = new System.Windows.Forms.Button();
            this.UnfollowBtn = new System.Windows.Forms.Button();
            this.FollowBtn = new System.Windows.Forms.Button();
            this.UserFollowBlockIdTxtbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BlockUsersList = new System.Windows.Forms.ListBox();
            this.UnblockAllUsers = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProfilePic = new BotInstagram.Class.CircullatePicturebox();
            this.AddNewProfileBtn = new System.Windows.Forms.Button();
            this.DeleteProfileBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SendTxtBtn = new System.Windows.Forms.Button();
            this.SendImageBtn = new System.Windows.Forms.Button();
            this.SendVideoBtn = new System.Windows.Forms.Button();
            this.PvMessageTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PvUserIdTxt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TagsTxtbox = new System.Windows.Forms.TextBox();
            this.PostImageBtn = new System.Windows.Forms.Button();
            this.PostVideo = new System.Windows.Forms.Button();
            this.PostCaptionTxt = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.VideoCheck = new System.Windows.Forms.CheckBox();
            this.ImageCheck = new System.Windows.Forms.CheckBox();
            this.Download = new System.Windows.Forms.Button();
            this.LinkTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UnblockBtn);
            this.groupBox1.Controls.Add(this.BlockBtn);
            this.groupBox1.Controls.Add(this.UnfollowBtn);
            this.groupBox1.Controls.Add(this.FollowBtn);
            this.groupBox1.Controls.Add(this.UserFollowBlockIdTxtbox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Un/follow * Un/block";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "User ID:";
            // 
            // UnblockBtn
            // 
            this.UnblockBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UnblockBtn.BackColor = System.Drawing.Color.Coral;
            this.UnblockBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.UnblockBtn.FlatAppearance.BorderSize = 2;
            this.UnblockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnblockBtn.Location = new System.Drawing.Point(149, 169);
            this.UnblockBtn.Name = "UnblockBtn";
            this.UnblockBtn.Size = new System.Drawing.Size(86, 33);
            this.UnblockBtn.TabIndex = 4;
            this.UnblockBtn.Text = "Unblock";
            this.UnblockBtn.UseVisualStyleBackColor = false;
            this.UnblockBtn.Click += new System.EventHandler(this.UnblockBtn_Click);
            // 
            // BlockBtn
            // 
            this.BlockBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BlockBtn.BackColor = System.Drawing.Color.Coral;
            this.BlockBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BlockBtn.FlatAppearance.BorderSize = 2;
            this.BlockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlockBtn.Location = new System.Drawing.Point(22, 169);
            this.BlockBtn.Name = "BlockBtn";
            this.BlockBtn.Size = new System.Drawing.Size(91, 33);
            this.BlockBtn.TabIndex = 3;
            this.BlockBtn.Text = "Block";
            this.BlockBtn.UseVisualStyleBackColor = false;
            this.BlockBtn.Click += new System.EventHandler(this.BlockBtn_Click);
            // 
            // UnfollowBtn
            // 
            this.UnfollowBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UnfollowBtn.BackColor = System.Drawing.Color.Coral;
            this.UnfollowBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.UnfollowBtn.FlatAppearance.BorderSize = 2;
            this.UnfollowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnfollowBtn.Location = new System.Drawing.Point(149, 117);
            this.UnfollowBtn.Name = "UnfollowBtn";
            this.UnfollowBtn.Size = new System.Drawing.Size(86, 37);
            this.UnfollowBtn.TabIndex = 2;
            this.UnfollowBtn.Text = "Unfollow";
            this.UnfollowBtn.UseVisualStyleBackColor = false;
            this.UnfollowBtn.Click += new System.EventHandler(this.UnfollowBtn_Click);
            // 
            // FollowBtn
            // 
            this.FollowBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FollowBtn.BackColor = System.Drawing.Color.Coral;
            this.FollowBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.FollowBtn.FlatAppearance.BorderSize = 2;
            this.FollowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FollowBtn.Location = new System.Drawing.Point(22, 117);
            this.FollowBtn.Name = "FollowBtn";
            this.FollowBtn.Size = new System.Drawing.Size(91, 37);
            this.FollowBtn.TabIndex = 1;
            this.FollowBtn.Text = "Follow";
            this.FollowBtn.UseVisualStyleBackColor = false;
            this.FollowBtn.Click += new System.EventHandler(this.FollowBtn_Click);
            // 
            // UserFollowBlockIdTxtbox
            // 
            this.UserFollowBlockIdTxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserFollowBlockIdTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserFollowBlockIdTxtbox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.UserFollowBlockIdTxtbox.Location = new System.Drawing.Point(77, 50);
            this.UserFollowBlockIdTxtbox.Multiline = true;
            this.UserFollowBlockIdTxtbox.Name = "UserFollowBlockIdTxtbox";
            this.UserFollowBlockIdTxtbox.Size = new System.Drawing.Size(174, 37);
            this.UserFollowBlockIdTxtbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BlockUsersList);
            this.groupBox2.Controls.Add(this.UnblockAllUsers);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(307, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 217);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BlockedUsers";
            // 
            // BlockUsersList
            // 
            this.BlockUsersList.BackColor = System.Drawing.SystemColors.Menu;
            this.BlockUsersList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BlockUsersList.FormattingEnabled = true;
            this.BlockUsersList.ItemHeight = 17;
            this.BlockUsersList.Location = new System.Drawing.Point(3, 27);
            this.BlockUsersList.Name = "BlockUsersList";
            this.BlockUsersList.Size = new System.Drawing.Size(278, 157);
            this.BlockUsersList.TabIndex = 1;
            // 
            // UnblockAllUsers
            // 
            this.UnblockAllUsers.BackColor = System.Drawing.Color.Coral;
            this.UnblockAllUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UnblockAllUsers.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.UnblockAllUsers.FlatAppearance.BorderSize = 2;
            this.UnblockAllUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnblockAllUsers.Location = new System.Drawing.Point(3, 184);
            this.UnblockAllUsers.Name = "UnblockAllUsers";
            this.UnblockAllUsers.Size = new System.Drawing.Size(278, 30);
            this.UnblockAllUsers.TabIndex = 0;
            this.UnblockAllUsers.Text = "UnblockAllUsers";
            this.UnblockAllUsers.UseVisualStyleBackColor = false;
            this.UnblockAllUsers.Click += new System.EventHandler(this.UnblockAllUsers_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.ProfilePic);
            this.groupBox3.Controls.Add(this.AddNewProfileBtn);
            this.groupBox3.Controls.Add(this.DeleteProfileBtn);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(608, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 217);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ProfilePic";
            // 
            // ProfilePic
            // 
            this.ProfilePic.BackColor = System.Drawing.Color.Gray;
            this.ProfilePic.Location = new System.Drawing.Point(62, 35);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(129, 119);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePic.TabIndex = 3;
            this.ProfilePic.TabStop = false;
            // 
            // AddNewProfileBtn
            // 
            this.AddNewProfileBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddNewProfileBtn.BackColor = System.Drawing.Color.Coral;
            this.AddNewProfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.AddNewProfileBtn.FlatAppearance.BorderSize = 2;
            this.AddNewProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProfileBtn.Location = new System.Drawing.Point(6, 178);
            this.AddNewProfileBtn.Name = "AddNewProfileBtn";
            this.AddNewProfileBtn.Size = new System.Drawing.Size(75, 33);
            this.AddNewProfileBtn.TabIndex = 2;
            this.AddNewProfileBtn.Text = "Add";
            this.AddNewProfileBtn.UseVisualStyleBackColor = false;
            this.AddNewProfileBtn.Click += new System.EventHandler(this.AddNewProfileBtn_Click);
            // 
            // DeleteProfileBtn
            // 
            this.DeleteProfileBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteProfileBtn.BackColor = System.Drawing.Color.Coral;
            this.DeleteProfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.DeleteProfileBtn.FlatAppearance.BorderSize = 2;
            this.DeleteProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProfileBtn.Location = new System.Drawing.Point(169, 178);
            this.DeleteProfileBtn.Name = "DeleteProfileBtn";
            this.DeleteProfileBtn.Size = new System.Drawing.Size(75, 33);
            this.DeleteProfileBtn.TabIndex = 1;
            this.DeleteProfileBtn.Text = "Delete";
            this.DeleteProfileBtn.UseVisualStyleBackColor = false;
            this.DeleteProfileBtn.Click += new System.EventHandler(this.DeleteProfileBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.SendTxtBtn);
            this.groupBox4.Controls.Add(this.SendImageBtn);
            this.groupBox4.Controls.Add(this.SendVideoBtn);
            this.groupBox4.Controls.Add(this.PvMessageTxt);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.PvUserIdTxt);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(17, 283);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 263);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SendPrivateMessage";
            // 
            // SendTxtBtn
            // 
            this.SendTxtBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendTxtBtn.BackColor = System.Drawing.Color.Coral;
            this.SendTxtBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.SendTxtBtn.FlatAppearance.BorderSize = 2;
            this.SendTxtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendTxtBtn.Location = new System.Drawing.Point(172, 210);
            this.SendTxtBtn.Name = "SendTxtBtn";
            this.SendTxtBtn.Size = new System.Drawing.Size(74, 32);
            this.SendTxtBtn.TabIndex = 6;
            this.SendTxtBtn.Text = "Text";
            this.SendTxtBtn.UseVisualStyleBackColor = false;
            this.SendTxtBtn.Click += new System.EventHandler(this.SendTxtBtn_Click);
            // 
            // SendImageBtn
            // 
            this.SendImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendImageBtn.BackColor = System.Drawing.Color.Coral;
            this.SendImageBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.SendImageBtn.FlatAppearance.BorderSize = 2;
            this.SendImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendImageBtn.Location = new System.Drawing.Point(91, 208);
            this.SendImageBtn.Name = "SendImageBtn";
            this.SendImageBtn.Size = new System.Drawing.Size(69, 34);
            this.SendImageBtn.TabIndex = 5;
            this.SendImageBtn.Text = "Image";
            this.SendImageBtn.UseVisualStyleBackColor = false;
            this.SendImageBtn.Click += new System.EventHandler(this.SendImageBtn_Click);
            // 
            // SendVideoBtn
            // 
            this.SendVideoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendVideoBtn.BackColor = System.Drawing.Color.Coral;
            this.SendVideoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.SendVideoBtn.FlatAppearance.BorderSize = 2;
            this.SendVideoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendVideoBtn.Location = new System.Drawing.Point(11, 208);
            this.SendVideoBtn.Name = "SendVideoBtn";
            this.SendVideoBtn.Size = new System.Drawing.Size(64, 34);
            this.SendVideoBtn.TabIndex = 4;
            this.SendVideoBtn.Text = "Video";
            this.SendVideoBtn.UseVisualStyleBackColor = false;
            this.SendVideoBtn.Click += new System.EventHandler(this.SendVideoBtn_Click);
            // 
            // PvMessageTxt
            // 
            this.PvMessageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PvMessageTxt.Location = new System.Drawing.Point(4, 67);
            this.PvMessageTxt.Multiline = true;
            this.PvMessageTxt.Name = "PvMessageTxt";
            this.PvMessageTxt.Size = new System.Drawing.Size(250, 135);
            this.PvMessageTxt.TabIndex = 3;
            this.PvMessageTxt.Text = "message";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID:";
            // 
            // PvUserIdTxt
            // 
            this.PvUserIdTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PvUserIdTxt.ForeColor = System.Drawing.SystemColors.MenuText;
            this.PvUserIdTxt.Location = new System.Drawing.Point(77, 26);
            this.PvUserIdTxt.Multiline = true;
            this.PvUserIdTxt.Name = "PvUserIdTxt";
            this.PvUserIdTxt.Size = new System.Drawing.Size(173, 34);
            this.PvUserIdTxt.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.TagsTxtbox);
            this.groupBox5.Controls.Add(this.PostImageBtn);
            this.groupBox5.Controls.Add(this.PostVideo);
            this.groupBox5.Controls.Add(this.PostCaptionTxt);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(304, 283);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(287, 263);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Post";
            // 
            // TagsTxtbox
            // 
            this.TagsTxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TagsTxtbox.Location = new System.Drawing.Point(5, 167);
            this.TagsTxtbox.Multiline = true;
            this.TagsTxtbox.Name = "TagsTxtbox";
            this.TagsTxtbox.Size = new System.Drawing.Size(277, 37);
            this.TagsTxtbox.TabIndex = 6;
            this.TagsTxtbox.Text = "Tags";
            // 
            // PostImageBtn
            // 
            this.PostImageBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PostImageBtn.BackColor = System.Drawing.Color.Coral;
            this.PostImageBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.PostImageBtn.FlatAppearance.BorderSize = 2;
            this.PostImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostImageBtn.Location = new System.Drawing.Point(161, 210);
            this.PostImageBtn.Name = "PostImageBtn";
            this.PostImageBtn.Size = new System.Drawing.Size(98, 32);
            this.PostImageBtn.TabIndex = 5;
            this.PostImageBtn.Text = "Image";
            this.PostImageBtn.UseVisualStyleBackColor = false;
            this.PostImageBtn.Click += new System.EventHandler(this.PostImageBtn_Click);
            // 
            // PostVideo
            // 
            this.PostVideo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PostVideo.BackColor = System.Drawing.Color.Coral;
            this.PostVideo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.PostVideo.FlatAppearance.BorderSize = 2;
            this.PostVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostVideo.Location = new System.Drawing.Point(28, 210);
            this.PostVideo.Name = "PostVideo";
            this.PostVideo.Size = new System.Drawing.Size(96, 32);
            this.PostVideo.TabIndex = 4;
            this.PostVideo.Text = "Video";
            this.PostVideo.UseVisualStyleBackColor = false;
            this.PostVideo.Click += new System.EventHandler(this.PostVideo_Click);
            // 
            // PostCaptionTxt
            // 
            this.PostCaptionTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PostCaptionTxt.Location = new System.Drawing.Point(4, 27);
            this.PostCaptionTxt.Multiline = true;
            this.PostCaptionTxt.Name = "PostCaptionTxt";
            this.PostCaptionTxt.Size = new System.Drawing.Size(277, 134);
            this.PostCaptionTxt.TabIndex = 3;
            this.PostCaptionTxt.Text = "Caption";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.VideoCheck);
            this.groupBox6.Controls.Add(this.ImageCheck);
            this.groupBox6.Controls.Add(this.Download);
            this.groupBox6.Controls.Add(this.LinkTxt);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(608, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox6.Size = new System.Drawing.Size(250, 263);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "PostShow";
            // 
            // VideoCheck
            // 
            this.VideoCheck.AutoSize = true;
            this.VideoCheck.Location = new System.Drawing.Point(18, 181);
            this.VideoCheck.Name = "VideoCheck";
            this.VideoCheck.Size = new System.Drawing.Size(70, 22);
            this.VideoCheck.TabIndex = 9;
            this.VideoCheck.Text = "Video";
            this.VideoCheck.UseVisualStyleBackColor = true;
            // 
            // ImageCheck
            // 
            this.ImageCheck.AutoSize = true;
            this.ImageCheck.Checked = true;
            this.ImageCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ImageCheck.Location = new System.Drawing.Point(163, 181);
            this.ImageCheck.Name = "ImageCheck";
            this.ImageCheck.Size = new System.Drawing.Size(72, 22);
            this.ImageCheck.TabIndex = 8;
            this.ImageCheck.Text = "Image";
            this.ImageCheck.UseVisualStyleBackColor = true;
            // 
            // Download
            // 
            this.Download.BackColor = System.Drawing.Color.Coral;
            this.Download.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Download.FlatAppearance.BorderSize = 2;
            this.Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download.Location = new System.Drawing.Point(75, 208);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(96, 32);
            this.Download.TabIndex = 7;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = false;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // LinkTxt
            // 
            this.LinkTxt.Location = new System.Drawing.Point(6, 30);
            this.LinkTxt.Multiline = true;
            this.LinkTxt.Name = "LinkTxt";
            this.LinkTxt.Size = new System.Drawing.Size(238, 145);
            this.LinkTxt.TabIndex = 6;
            this.LinkTxt.Text = "Link";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BotInstagram.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(870, 628);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInterface";
            this.Text = "gr";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.Shown += new System.EventHandler(this.UserInterface_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox UserFollowBlockIdTxtbox;
        private System.Windows.Forms.Button UnblockBtn;
        private System.Windows.Forms.Button BlockBtn;
        private System.Windows.Forms.Button UnfollowBtn;
        private System.Windows.Forms.Button FollowBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UnblockAllUsers;
        private System.Windows.Forms.ListBox BlockUsersList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddNewProfileBtn;
        private System.Windows.Forms.Button DeleteProfileBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PvUserIdTxt;
        private System.Windows.Forms.Button SendVideoBtn;
        private System.Windows.Forms.TextBox PvMessageTxt;
        private System.Windows.Forms.Button SendTxtBtn;
        private System.Windows.Forms.Button SendImageBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button PostImageBtn;
        private System.Windows.Forms.Button PostVideo;
        private System.Windows.Forms.TextBox PostCaptionTxt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox LinkTxt;
        private System.Windows.Forms.Label label2;
        private Class.CircullatePicturebox ProfilePic;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.CheckBox VideoCheck;
        private System.Windows.Forms.CheckBox ImageCheck;
        private System.Windows.Forms.TextBox TagsTxtbox;
    }
}