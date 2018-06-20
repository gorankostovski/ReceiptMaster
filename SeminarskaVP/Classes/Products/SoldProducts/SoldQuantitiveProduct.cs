using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Products
{
    [Serializable]
    public class SoldQuantitiveProduct : SoldProduct
    {
        public decimal Amount { get; set; }


        public SoldQuantitiveProduct(ref Product product, decimal amount):base(ref product) {
            TotalPrice = Amount * Product.Price;
        }   // kraj konstruktor
    }
}
