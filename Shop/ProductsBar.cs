using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.Exceptions;

namespace Shop
{
    public partial class ProductsBar : Form
    {
        public ProductsBar()
        {
            InitializeComponent();
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            AddItem_Button.BackColor = Color.Aqua;

            using (ShopContext _context = new ShopContext())
            {

                try
                {
                    Product product = new Product
                    {
                        ItemCode = ItemCode_box.Text,
                        Description = Desc_box.Text,
                        ItemType = ItemType_box.Text,
                        Cost = int.Parse(cost_box.Text),
                        Price = int.Parse(price_box.Text) > int.Parse(cost_box.Text) ?
                            int.Parse(price_box.Text) : throw new PriceToCostException(),
                        Quantity = int.Parse(quantity_box.Text) > 0
                        ? int.Parse(quantity_box.Text) : throw new NegativeInputException()
                    };
                    _context.Products.Add(product);
                    _context.SaveChanges();
                }
                catch (PriceToCostException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                catch (NegativeInputException exc1)
                {
                    MessageBox.Show(exc1.Message);

                }
            }
            ItemCode_box.Text = string.Empty;
            Desc_box.Text = string.Empty;
            ItemType_box.Text = string.Empty;
            cost_box.Text = string.Empty;
            price_box.Text = string.Empty;
            quantity_box.Text = string.Empty;
        }

        private void Back_to_Menu_Click(object sender, EventArgs e)
        {
            Back_to_Menu.BackColor = Color.AliceBlue;
            Hide();
            new MenuBar().Show();
        }

        private void ItemCode_box_TextChanged(object sender, EventArgs e)
        {
            using (ShopContext _context = new ShopContext())
            {
                Product prd = new Product();
                foreach (Product prod in _context.Products)
                {
                    if (ItemCode_box.Text == prod.ItemCode)
                    {
                        Desc_box.Text = prod.Description;
                        ItemType_box.Text = prod.ItemType;
                        cost_box.Text = prod.Cost.ToString();
                        price_box.Text = prod.Price.ToString();
                        quantity_box.Text = prod.Quantity.ToString();
                    }
                }
            }

        }
    }
}

