using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class SalesOrders
    {
        //Header part
        public int OrderNbr { get; set; }
        public string CustomerName { get; set; }
        public DateTime date { get; set; }
        public string Address { get; set; }

        //Details part
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public SalesOrders()
        {
        }
        public SalesOrders(int OrderNbr, string CustomerName, DateTime date, string Address,
                        string ItemCode, string Description, int Quantity, int Price, int Amount)
        {
            this.OrderNbr = OrderNbr;
            this.CustomerName = CustomerName;
            this.date = date;
            this.Address = Address;
            this.ItemCode = ItemCode;
            this.Description = Description;
            this.Price = Price;
            this.Amount = Amount;
        }
    }
}
