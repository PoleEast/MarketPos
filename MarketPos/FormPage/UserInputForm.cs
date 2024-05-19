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
    public partial class UserInputForm : Form
    {
        public string userinputStr = string.Empty;
        private RichTextBox? richTextBox;
        public UserInputForm(string Explain)
        {
            InitializeComponent();
            lbExplain.Text = Explain;
        }
        public UserInputForm(string Explain, string comment)
        {
            InitializeComponent();
            lbExplain.Text = Explain;
            richTextBox = new RichTextBox();
            richTextBox.Text = comment;
            richTextBox.Name = "rtbUserInput";
            richTextBox.Size = new Size(300, 400);
            richTextBox.Location = txbUserInput.Location;
            txbUserInput.Enabled = false;
            txbUserInput.Visible = false;
            this.Size = new Size(350, 550);
            this.Controls.Add(richTextBox);
            btnCancel.Location = new Point(btnCancel.Location.X, this.Size.Height - 90);
            btnOk.Location = new Point(btnOk.Location.X, this.Size.Height - 90);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (richTextBox == null)
                userinputStr = txbUserInput.Text.Trim();
            else
                userinputStr = richTextBox.Text;
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
