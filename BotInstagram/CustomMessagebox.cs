using System;
using System.Diagnostics;

namespace BotInstagram
{
    public partial class CustomMessagebox : MetroFramework.Forms.MetroForm
    {
        const string DargahRedirect = "https://bsite.net/hadyPir/home/pay";
        int id;
        public CustomMessagebox(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void CustomMessagebox_Load(object sender, EventArgs e)
        {

        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            if (DiscountCodeTxtbox.Text != null)
            {
                Process.Start(DargahRedirect + "?id=" + id + "&code=" + DiscountCodeTxtbox.Text);
            }
            else
            {
                Process.Start(DargahRedirect + "?id=" + id);
            }

            this.Close();

        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DiscountCodeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
