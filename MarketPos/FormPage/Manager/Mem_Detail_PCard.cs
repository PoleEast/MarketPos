using MarketPos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarketPos.FormPage.Manager
{
    public partial class Mem_Detail_PCard : Form
    {
        private ProductsData productsData = new();
        private string[] imageFiles = [];

        public Mem_Detail_PCard(ProductsData productsData)
        {
            InitializeComponent();
            this.productsData = productsData;
            this.Text = productsData.Name;
        }
        private void Mem_Detail_PCard_Load(object sender, EventArgs e)
        {
            txbName.Text = productsData.Name;
            txbWeight.Text = productsData.Weight.ToString();
            txbPrice.Text = Math.Floor(productsData.Price).ToString();
            rtbDescription.Text = productsData.Description;

            cbCategory.DisplayMember = "Key";
            cbCategory.ValueMember = "Value";
            cbCategory.DataSource = new BindingSource(DataService.categorysDict, null);
            cbCategory.SelectedValue = DataService.categorysDict[productsData.Category];

            cbOrigin.DisplayMember = "Key";
            cbOrigin.ValueMember = "Value";
            cbOrigin.DataSource = new BindingSource(DataService.originsDict, null);
            cbOrigin.SelectedValue = DataService.originsDict[productsData.Origin];

            txbStock.Text = productsData.Stock.ToString();

            imageFiles = DataService.DS_GetPictures(productsData.Name);
            ptbProduct.Image = Bitmap.FromFile(imageFiles[0]);
        }

        private void checkNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            string change = "確定更改以下資訊?\n";

            change += productsData.Name.Contains(txbName.Text.Trim()) ? "" : $"確認將名字[{productsData.Name}]改成->[{txbName.Text.Trim()}]\n";
            change +=  Math.Abs(productsData.Weight-Double.Parse(txbWeight.Text.Trim()))<0.1F ?
                "" : $"確認將重量[{productsData.Weight}]改成->[{txbWeight.Text.Trim()}]\n";
            change += Math.Floor(productsData.Price) == int.Parse(txbPrice.Text) ? "" : $"確認將價格[{productsData.Price}]改成->[{txbPrice.Text.Trim()}]\n";
            change += rtbDescription.Text == productsData.Description?"": $"確認將描述\n[{productsData.Description}]\n改成->\n[{rtbDescription.Text.Trim()}]\n";
            change += cbCategory.Text==(productsData.Category)?"":$"確認將種類[{productsData.Category}]改成->[{cbCategory.Text}]\n";
            change += cbOrigin.Text==productsData.Origin? "" : $"確認將產地[{productsData.Origin}]改成->[{cbOrigin.Text}]\n";
            change += txbStock.Text == productsData.Stock.ToString() ? "" : $"確認將數量[{productsData.Stock}]改成->[{txbStock.Text}]\n";
            change+=! ckbShelve.Checked? "確認將商品上架?":"確認將商品下架?";

            if (change == "確定更改以下資訊?\n") { MessageBox.Show("您沒更改任何值"); return; }
            MessageBox.Show(change, "確認更改", MessageBoxButtons.OKCancel);
        }
    }
}
