using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Products
{
    [Serializable]
    public class SoldProduct
    {
        public Product Product { get; set; }
        public decimal TotalPrice { get; set; }

        public SoldProduct(ref Product product) {
            Product = product;
        }   //  kraj konstruktor so argument
    }
}
