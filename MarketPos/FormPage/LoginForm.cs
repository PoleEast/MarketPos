using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketPos.FormPage
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            tabControl1.ItemSize = new System.Drawing.Size(0, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
    }
}
