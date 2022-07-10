using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotInstagram
{
    public partial class WaitForm : Form
    {
        public bool Is_closed = false;
        public WaitForm()
        {
            InitializeComponent();
        }
        public void ShowLogs(string log)
        {
            logs.Text = log;
        }


        private void circullatePicturebox1_Click_1(object sender, EventArgs e)
        {
            Is_closed = true;
        }
    }
}


