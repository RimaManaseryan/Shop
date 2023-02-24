using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class SalesOrdersBar : Form
    {
        public SalesOrdersBar()
        {
            InitializeComponent();
            //int temp = int.Parse(price_box.Text) * int.Parse(quantity_box.Text);
            //amount_box.Text = temp.ToString();
        }

        private void Back_To_Menu_Click(object sender, EventArgs e)
        {
            Back_To_Menu.BackColor = Color.AliceBlue;
            Hide();
            new MenuBar().Show();
        }

    }
}
