using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes
{
    [Serializable]
    public class Receipt
    {
        public Employee Seller { get; set; }
        public DateTime TimeStamp { get; set; }
        public decimal Total { get; set; }
        public List<Products.SoldProduct> Products { get; set; }


        public Receipt(ref Employee seller) {
            Seller = seller;
            TimeStamp = DateTime.Now;
            Total = 0;
            Products = new List<Products.SoldProduct>();
        }

    }
}
