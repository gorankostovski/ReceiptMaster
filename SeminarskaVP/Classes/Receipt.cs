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
        public Classes.Employees.Employee Seller { get; set; }
        public DateTime TimeStamp { get; set; }
        public decimal Total { get; set; }
        public List<Classes.Products.SoldProduct.SoldProduct> Products { get; set; }


        public override string ToString()
        {
            return Seller.FirstName + " " + Seller.LastName + " - " + Total + " - " + TimeStamp;
        }

        public string TotalToString() { return "Total: " + Total.ToString(); }

        public Receipt(ref Classes.Employees.Employee seller) {
            Seller = seller;
            TimeStamp = DateTime.Now;
            Total = 0;
            Products = new List<Classes.Products.SoldProduct.SoldProduct>();
        }

    }
}
