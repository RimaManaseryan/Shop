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

namespace Shop.Models
{
    public partial class CustomersBar : Form
    {
        public CustomersBar()
        {
            InitializeComponent();
        }

        private void Customer_reg_button_Click(object sender, EventArgs e)
        {
            Customer_reg_button.BackColor = Color.AliceBlue;
            using (ShopContext _context = new ShopContext())
            {
                SalesOrders sales = new SalesOrders();
                try
                {
                    if (Status_box.Text.ToLower() != "inactive")
                    {
                        Customer customer = new Customer
                        {
                            CustomerName = CustomerName_box.Text,
                            Phone = phone_box.Text,
                            Address1 = address1_box.Text,
                            Address2 = address2_box.Text,
                            Status = sales.Amount > int.Parse(CreditLimit_box.Text)
                                    ? "Credit Hold" : Status_box.Text,
                            CreditLimit = int.Parse(CreditLimit_box.Text) > 0
                            ? int.Parse(CreditLimit_box.Text) : throw new NegativeInputException()
                        };
                        _context.Customers.Add(customer);
                        _context.SaveChanges();
                    }
                    else throw new StatusInactiveException();
                }
                catch (StatusInactiveException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                catch (NegativeInputException exc1)
                {
                    MessageBox.Show(exc1.Message);
                };
                CustomerName_box.Text = string.Empty;
                phone_box.Text = string.Empty;
                address1_box.Text= string.Empty;
                address2_box.Text = string.Empty;
                Status_box.Text= string.Empty;
                CreditLimit_box.Text= string.Empty;
            }

        }

        private void Back_To_Menu_Click(object sender, EventArgs e)
        {
            Back_To_Menu.BackColor = Color.AliceBlue;
            Hide();
            new MenuBar().Show();
        }
    }
}
