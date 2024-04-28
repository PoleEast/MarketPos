﻿using System;
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
            GetPicture(productsData.Name);
            this.Visible = true;
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
            ptbProduct.Image=null ;
            this.Visible = false;
        }
    }
}
