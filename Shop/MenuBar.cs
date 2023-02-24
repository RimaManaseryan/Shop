using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.Models;

namespace Shop
{
    public partial class MenuBar : Form
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        private void to_products_Click(object sender, EventArgs e)
        {
            Hide();
            new ProductsBar().Show();
        }

        private void to_Customers_Click(object sender, EventArgs e)
        {
            Hide();
            new CustomersBar().Show();
        }

        private void SalesOrders_Click(object sender, EventArgs e)
        {
            Hide();
            new SalesOrdersBar().Show();
        }

        private void to_DailyTotals_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
}
