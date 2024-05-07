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
    public partial class ShoppingCard : UserControl
    {
        private ProductsData? productsData;
        public int total;
        public ShoppingCard()
        {
            InitializeComponent();
        }
        public void SetCard(ProductsData data, int quantity)
        {
            productsData = data;
            lbName.Text = data.Name;
            lbPrice.Text += data.Price.ToString() + "$";
            for (int i = 1; i <= data.Stock; i++)
                cbCount.Items.Add(i);
            cbCount.SelectedIndex = quantity - 1;
            txbTotal.Text += (data.Price * quantity) + "$";
            total = Convert.ToInt16(data.Price * quantity);
        }
    }
}
