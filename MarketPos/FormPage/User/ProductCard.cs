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
using MarketPos.FormPage.Manager;
using MarketPos.Models;

namespace MarketPos
{
    public partial class ProductCard : UserControl
    {
        private string[] imageFiles = [];
        private ProductsData? productsData;
        public int ProductID;

        public ProductCard()
        {
            InitializeComponent();
        }
        public void SetCard(ProductsData Data)
        {
            productsData = Data;
            ProductID = Data.Id;
            lbName.Text = Data.Name;
            lbOrigin.Text += Data.Origin;
            lbPrice.Text += Math.Floor(Data.Price).ToString() + "$";
            lbStock.Text += Data.Stock.ToString();
            lbWeight.Text += Data.Weight.ToString() + "/公克";
            imageFiles = DataService.DS_GetPictures(Data.Name);
            ptbProduct.Image = Bitmap.FromFile(imageFiles[0]);

            this.Visible = true;
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

        private void ProductCard_Click(object sender, EventArgs e)
        {
            if (productsData == null||Form1.member==null) return;

            if (Form1.member.Level < 3)
            {
                //管理者用
                Mem_Detail_PCard mem_Detail_PCard = new(productsData);
                mem_Detail_PCard.StartPosition = FormStartPosition.CenterScreen;
                mem_Detail_PCard.ShowDialog();
            }
            else
            {
                Detail_PCard detail_PCard = new(productsData);
                detail_PCard.StartPosition = FormStartPosition.CenterParent;
                detail_PCard.ShowDialog();
            }
        }
    }
}
