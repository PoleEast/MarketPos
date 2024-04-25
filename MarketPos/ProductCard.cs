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
    public partial class ProductCard : UserControl
    {
        private string[] imageFiles;
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
            GetPicture(productsData.Name);
            this.Visible = true;
        }
        private void GetPicture(string pathname)
        {
            if (Directory.Exists(Form1.Imgpath))
            {
                var imgString = Form1.Imgpath + @"\" + pathname;
                imageFiles = Directory.GetFiles(imgString, "*.jpg");
                ptbProduct.Image = Bitmap.FromFile(imageFiles[0]);

            }
        }
    }
}
