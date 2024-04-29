using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketPos
{
    public partial class UserInput : Form
    {
        public string userinput = string.Empty;
        public UserInput(string Explain)
        {
            InitializeComponent();
            lbExplain.Text = Explain;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            userinput = txbUserInput.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
