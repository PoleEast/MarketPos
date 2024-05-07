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
    public partial class Detail_PCard : Form
    {
        public static event EventHandler? OrderItemAdded;
        private ProductsData productsData = new();
        private string[] imageFiles = [];
        public Detail_PCard(ProductsData productsData)
        {
            InitializeComponent();
            this.productsData = productsData;
            this.Text = productsData.Name;
        }
        private void Detail_PCard_Load(object sender, EventArgs e)
        {
            lbName.Text = productsData.Name;
            lbOrigin.Text += productsData.Origin;
            lbPrice.Text += Math.Floor(productsData.Price).ToString() + "$";
            lbStock.Text += productsData.Stock.ToString();
            lbWeight.Text += productsData.Weight.ToString() + "/公克";
            lbCategory.Text += productsData.Category.ToString();
            lbPerWeight.Text += ((double)productsData.Price / productsData.Weight).ToString("F2") + "$";
            imageFiles = DataService.DS_GetPictures(productsData.Name);
            ptbProduct.Image = Bitmap.FromFile(imageFiles[0]);
            rtbDescription.Text = productsData.Description;
            for (int i = 1; i <= productsData.Stock; i++)
                cbQuantity.Items.Add(i);
            cbQuantity.SelectedIndex = 0;
        }

        private async void btnS_Search_Click(object sender, EventArgs e)
        {
            if (Form1.member == null) { MessageBox.Show("請先登入會員"); return; }
            if (!(cbQuantity.SelectedIndex >= 0)) { MessageBox.Show("請選擇數量"); return; }

            MessageBox.Show("要處理已有重複商品的情況");
            //要處理已有重複商品的情況

            await DataService.Odr_CreateOrderDetail(Form1.member.OrderId, productsData.Id, cbQuantity.SelectedIndex + 1);
            OrderItemAdded?.Invoke(this, e);
            this.Close();
        }
    }
}
