
namespace BotInstagram
{
    partial class RememberPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.CheckEmailBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(124, 70);
            this.emailTextbox.Multiline = true;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(364, 33);
            this.emailTextbox.TabIndex = 1;
            // 
            // CheckEmailBtn
            // 
            this.CheckEmailBtn.BackColor = System.Drawing.Color.White;
            this.CheckEmailBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CheckEmailBtn.FlatAppearance.BorderSize = 2;
            this.CheckEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckEmailBtn.Location = new System.Drawing.Point(194, 152);
            this.CheckEmailBtn.Name = "CheckEmailBtn";
            this.CheckEmailBtn.Size = new System.Drawing.Size(170, 40);
            this.CheckEmailBtn.TabIndex = 2;
            this.CheckEmailBtn.Text = "Check Email";
            this.CheckEmailBtn.UseVisualStyleBackColor = false;
            this.CheckEmailBtn.Click += new System.EventHandler(this.CheckEmailBtn_Click);
            // 
            // RememberPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BotInstagram.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(534, 204);
            this.Controls.Add(this.CheckEmailBtn);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RememberPassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Button CheckEmailBtn;
    }
}