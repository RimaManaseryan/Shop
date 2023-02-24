using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.Exceptions;

namespace Shop.Models
{
   public class Customer
    {
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Status { get; set; }
        public int CreditLimit { get; set; }

        public Customer()
        { }

        public Customer(string name, string phone, string addr1, string addr2,
                        string status, int CreditLimit)
        {
            CustomerName = name;
            Phone = phone;
            Address1 = addr1;
            Address2 = addr2;
            Status = status;
            try
            {
                this.CreditLimit = CreditLimit > 0 ? CreditLimit : throw new NegativeInputException();

            }
            catch(NegativeInputException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    };
}
