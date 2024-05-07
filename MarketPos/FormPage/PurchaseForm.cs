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
    public partial class PurchaseForm : Form
    {
        public string OName = string.Empty;
        public string RName = string.Empty;
        public string OAddress = string.Empty;
        public string RAddress = string.Empty;
        public int payment = 0;
        public PurchaseForm()
        {
            InitializeComponent();
        }
        public async void SetForm(int orderID)
        {
            lb_OrderNum.Text += orderID.ToString();

            Dictionary<int, string> payments = await DataService.Odr_GetPayment();
            cb_PayMent.DisplayMember = "Value";
            cb_PayMent.ValueMember = "Key";
            cb_PayMent.DataSource = new BindingSource(payments, null);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbO_Name.Text) && string.IsNullOrEmpty(txbO_Address.Text) &&
                string.IsNullOrEmpty(txbR_Name.Text) && string.IsNullOrEmpty(txbR_Address.Text))
            { MessageBox.Show("請填入資料"); return; }

            OName = txbO_Name.Text;
            OAddress = txbO_Address.Text;
            RName = txbR_Name.Text;
            RAddress = txbR_Address.Text;
            payment = cb_PayMent.SelectedValue == null ? 0 : (int)cb_PayMent.SelectedValue;

            DialogResult result = MessageBox.Show($"確認購物清單:\n訂購人:{txbO_Name.Text}\n訂購人地址:{txbO_Address.Text}\n" +
                $"收貨人:{txbR_Name.Text}\n收貨人地址:{txbR_Address.Text}\n付款方式:{cb_PayMent.Text}", "確認清單", MessageBoxButtons.OKCancel);

            if (result != DialogResult.OK) return;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
