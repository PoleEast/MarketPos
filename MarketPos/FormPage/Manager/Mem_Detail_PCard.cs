using MarketPos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarketPos.FormPage.Manager
{
    public partial class Mem_Detail_PCard : Form
    {
        public static event EventHandler? ChangeProduct;
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

            ckbShelve.Checked = productsData.IsShelve;

            imageFiles = DataService.DS_GetPictures(productsData.Id.ToString());
            if (imageFiles.Length > 0)
            {
                ptbProduct.Image = Bitmap.FromFile(imageFiles[0]);
            }
        }

        private void checkNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private async void btnChange_Click(object sender, EventArgs e)
        {
            ProductsData data = new();

            string change = "確定更改以下資訊?\n";

            if (!productsData.Name.Contains(txbName.Text.Trim()))
            {
                change += $"確認將名字[{productsData.Name}]改成->[{txbName.Text.Trim()}]\n";
                data.Name = txbName.Text.Trim();
            }
            if (!(Math.Abs(productsData.Weight - Double.Parse(txbWeight.Text.Trim())) < 0.1F))
            {
                change += $"確認將重量[{productsData.Weight}]改成->[{txbWeight.Text.Trim()}]\n";
                data.Weight = Double.Parse(txbWeight.Text.Trim());
            }
            if (!(Math.Floor(productsData.Price) == int.Parse(txbPrice.Text)))
            {
                change += $"確認將價格[{productsData.Price}]改成->[{txbPrice.Text.Trim()}]\n";
                data.Price = decimal.Parse(txbPrice.Text);
            }
            if (productsData.Description != rtbDescription.Text)
            {
                change += $"確認將描述\n[{productsData.Description}]\n改成->\n[{rtbDescription.Text.Trim()}]\n";
                data.Description = rtbDescription.Text;
            }
            if (productsData.Category != cbCategory.Text)
            {
                change += $"確認將種類[{productsData.Category}]改成->[{cbCategory.Text}]\n";
                data.Category = cbCategory.Text;
            }
            if (productsData.Origin != cbOrigin.Text)
            {
                change += $"確認將產地[{productsData.Origin}]改成->[{cbOrigin.Text}]\n";
                data.Origin = cbOrigin.Text;
            }
            if (productsData.Stock.ToString() != txbStock.Text)
            {
                change += $"確認將數量[{productsData.Stock}]改成->[{txbStock.Text}]\n";
                data.Stock = int.Parse(txbStock.Text);
            }
            else { data.Stock = productsData.Stock; }
            if (ckbShelve.Checked)
            {
                change += "確認將商品上架?";
                data.IsShelve = true;
            }
            else
            {
                change += "確認將商品下架?";
                data.IsShelve = false;
            }

            data.Id = productsData.Id;

            if (change == "確定更改以下資訊?\n") { MessageBox.Show("您沒更改任何值"); return; }
            DialogResult result = MessageBox.Show(change, "確認更改", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK) return;

            if (await DataService.MP_UpdateProduct(data))
            {
                MessageBox.Show($"商品:{data.Name} 更改成功!!");
                ChangeProduct?.Invoke(this, EventArgs.Empty);

                this.Close();
            }
            else { MessageBox.Show($"商品:{data.Name} 更改失敗!!"); }
        }
    }
}
