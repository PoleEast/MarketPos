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
            txbWeight.Text=productsData.Weight.ToString();
            txbPrice.Text = Math.Floor(productsData.Price).ToString() + "$";
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
    }
}
