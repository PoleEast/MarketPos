using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketPos
{
    public partial class ProductCard : UserControl
    {
        private string[] imageFiles = [];
        public ProductCard()
        {
            InitializeComponent();
        }
        public void SetCard(ProductsData productsData)
        {
            lbName.Text = productsData.Name;
            lbOrigin.Text += productsData.Origin;
            lbPrice.Text += productsData.Price.ToString() + "$";
            lbStock.Text += productsData.Stock.ToString();
            lbWeight.Text += productsData.Weight.ToString() + "/公克";
            GetPicture(productsData.Name);
            this.Visible = true;
            MessageBox.Show(productsData.Name);
        }
        private void GetPicture(string pathname)
        {
            var imgString = Form1.Imgpath + @"\" + pathname;
            if (Directory.Exists(imgString))
            {
                imageFiles = Directory.GetFiles(imgString, "*.jpg");
                ptbProduct.Image = Bitmap.FromFile(imageFiles[0]);
            }
        }
        public void init()
        {
            lbName.Text = string.Empty;
            lbOrigin.Text = "生產地:";
            lbPrice.Text = "價格:";
            lbStock.Text = "庫存:";
            ptbProduct.Image = null;
            lbWeight.Text = "重量:";
            this.Visible = false;
        }

        private void lbName_TextChanged(object sender, EventArgs e)
        {
            // 計算文字寬度和標籤寬度的比例
            int minFontSize = 6;
            if (string.IsNullOrEmpty(lbName.Text)) return;
            float ratio = 200f / TextRenderer.MeasureText(lbName.Text, lbName.Font).Width;

            // 如果比例小於1，調整字體大小
            if (ratio < 1)
            {
                int newSize = (int)(lbName.Font.Size * ratio);
                newSize = Math.Max(newSize, minFontSize);
                lbName.Font = new Font(lbName.Font.FontFamily, newSize, lbName.Font.Style);
            }
        }
    }
}
