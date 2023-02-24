using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Product
    {
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string ItemType { get; set; }
        public int Cost { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        { }

        public Product(string ItemCode, string description, string ItemType,
                        int cost, int price, int quantity)
        {
            this.ItemCode = ItemCode;
            Description = description;
            this.ItemType = ItemType;
            Cost = cost;
            Price = price;
            Quantity = quantity;
        }
    }
}
