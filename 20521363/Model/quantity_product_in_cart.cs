using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20521363.Model
{
    public class quantity_product_in_cart
    {
        public int Quantity { get; set; }
        public quantity_product_in_cart(int quantity)
        {
            Quantity = quantity;
        }
    }
}
