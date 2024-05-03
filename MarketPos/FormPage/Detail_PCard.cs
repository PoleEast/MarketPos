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
        private ProductsData ProductsData = new();
        private string[] imageFiles = [];
        public Detail_PCard(ProductsData productsData)
        {
            InitializeComponent();
            ProductsData = productsData;
            this.Text = ProductsData.Name;
        }
        private void Detail_PCard_Load(object sender, EventArgs e)
        {
            lbName.Text = ProductsData.Name;
            lbOrigin.Text += ProductsData.Origin;
            lbPrice.Text += Math.Floor(ProductsData.Price).ToString() + "$";
            lbStock.Text += ProductsData.Stock.ToString();
            lbWeight.Text += ProductsData.Weight.ToString() + "/公克";
            imageFiles = DataService.DS_GetPictures(ProductsData.Name);
            ptbProduct.Image = Bitmap.FromFile(imageFiles[0]);
            rtbDescription.Text = ProductsData.Description;
            for (int i = 1; i < ProductsData.Stock; i++)
                cbQuantity.Items.Add(i);
            cbQuantity.SelectedIndex = 0;
        }

        private void btnS_Search_Click(object sender, EventArgs e)
        {

        }
    }
}
