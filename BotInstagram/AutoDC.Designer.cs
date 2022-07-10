
namespace BotInstagram
{
    partial class AutoDC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoDC));
            this.ChooseListBtn = new System.Windows.Forms.Button();
            this.Locationlbl = new System.Windows.Forms.Label();
            this.DcTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alignLeftCheck = new System.Windows.Forms.CheckBox();
            this.AlignRightCheck = new System.Windows.Forms.CheckBox();
            this.SendTextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseListBtn
            // 
            this.ChooseListBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ChooseListBtn.FlatAppearance.BorderSize = 0;
            this.ChooseListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseListBtn.ForeColor = System.Drawing.Color.White;
            this.ChooseListBtn.Location = new System.Drawing.Point(59, 67);
            this.ChooseListBtn.Name = "ChooseListBtn";
            this.ChooseListBtn.Size = new System.Drawing.Size(100, 40);
            this.ChooseListBtn.TabIndex = 0;
            this.ChooseListBtn.Text = "Choose";
            this.ChooseListBtn.UseVisualStyleBackColor = false;
            this.ChooseListBtn.Click += new System.EventHandler(this.ChooseListBtn_Click);
            // 
            // Locationlbl
            // 
            this.Locationlbl.AutoSize = true;
            this.Locationlbl.BackColor = System.Drawing.Color.Transparent;
            this.Locationlbl.ForeColor = System.Drawing.Color.White;
            this.Locationlbl.Location = new System.Drawing.Point(175, 76);
            this.Locationlbl.Name = "Locationlbl";
            this.Locationlbl.Size = new System.Drawing.Size(170, 22);
            this.Locationlbl.TabIndex = 1;
            this.Locationlbl.Text = "choose users txt file";
            // 
            // DcTextbox
            // 
            this.DcTextbox.Location = new System.Drawing.Point(59, 149);
            this.DcTextbox.Multiline = true;
            this.DcTextbox.Name = "DcTextbox";
            this.DcTextbox.Size = new System.Drawing.Size(725, 242);
            this.DcTextbox.TabIndex = 2;
            this.DcTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "direct text:";
            // 
            // alignLeftCheck
            // 
            this.alignLeftCheck.AutoSize = true;
            this.alignLeftCheck.BackColor = System.Drawing.Color.Transparent;
            this.alignLeftCheck.Location = new System.Drawing.Point(685, 121);
            this.alignLeftCheck.Name = "alignLeftCheck";
            this.alignLeftCheck.Size = new System.Drawing.Size(101, 26);
            this.alignLeftCheck.TabIndex = 4;
            this.alignLeftCheck.Text = "align-left";
            this.alignLeftCheck.UseVisualStyleBackColor = false;
            this.alignLeftCheck.CheckedChanged += new System.EventHandler(this.alignLeftCheck_CheckedChanged);
            // 
            // AlignRightCheck
            // 
            this.AlignRightCheck.AutoSize = true;
            this.AlignRightCheck.BackColor = System.Drawing.Color.Transparent;
            this.AlignRightCheck.Checked = true;
            this.AlignRightCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlignRightCheck.Location = new System.Drawing.Point(559, 121);
            this.AlignRightCheck.Name = "AlignRightCheck";
            this.AlignRightCheck.Size = new System.Drawing.Size(110, 26);
            this.AlignRightCheck.TabIndex = 5;
            this.AlignRightCheck.Text = "align-right";
            this.AlignRightCheck.UseVisualStyleBackColor = false;
            this.AlignRightCheck.CheckedChanged += new System.EventHandler(this.AlignRightCheck_CheckedChanged);
            // 
            // SendTextBtn
            // 
            this.SendTextBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SendTextBtn.FlatAppearance.BorderSize = 0;
            this.SendTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendTextBtn.ForeColor = System.Drawing.Color.White;
            this.SendTextBtn.Location = new System.Drawing.Point(607, 397);
            this.SendTextBtn.Name = "SendTextBtn";
            this.SendTextBtn.Size = new System.Drawing.Size(176, 39);
            this.SendTextBtn.TabIndex = 6;
            this.SendTextBtn.Text = "SendText";
            this.SendTextBtn.UseVisualStyleBackColor = false;
            this.SendTextBtn.Click += new System.EventHandler(this.SendTextBtn_Click);
            // 
            // AutoDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::BotInstagram.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(843, 594);
            this.ControlBox = false;
            this.Controls.Add(this.SendTextBtn);
            this.Controls.Add(this.AlignRightCheck);
            this.Controls.Add(this.alignLeftCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DcTextbox);
            this.Controls.Add(this.Locationlbl);
            this.Controls.Add(this.ChooseListBtn);
            this.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoDC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.AutoDC_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseListBtn;
        private System.Windows.Forms.Label Locationlbl;
        private System.Windows.Forms.TextBox DcTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox alignLeftCheck;
        private System.Windows.Forms.CheckBox AlignRightCheck;
        private System.Windows.Forms.Button SendTextBtn;
    }
}