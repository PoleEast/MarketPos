using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketPos.Models;

namespace MarketPos
{
    public partial class Detail_PCard : Form
    {
        public static event EventHandler<KeyValuePair<int, int>>? OrderItemAdded;
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
            if (imageFiles.Length > 0)
            {
                ptbProduct.Image = Bitmap.FromFile(imageFiles[0]);
            }
            rtbDescription.Text = productsData.Description;
            for (int i = 1; i <= productsData.Stock; i++)
                cbQuantity.Items.Add(i);
            cbQuantity.SelectedIndex = 0;
        }

        private void btnS_Search_Click(object sender, EventArgs e)
        {
            if (Form1.member == null || Form1.member.Id == 0) { MessageBox.Show("請先登入會員"); return; }
            if (!(cbQuantity.SelectedIndex >= 0)) { MessageBox.Show("請選擇數量"); return; }

            KeyValuePair<int, int> orderDetail = new KeyValuePair<int, int>(productsData.Id, cbQuantity.SelectedIndex + 1);
            OrderItemAdded?.Invoke(this, orderDetail);
            this.Close();
        }
    }
}
