using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Products.SoldProduct
{
    [Serializable]
    public class SoldMeasurableProduct : SoldProduct
    {
        public int Amount { get; set; }

        public SoldMeasurableProduct(ref Product product, int amount) : base(ref product) {
            Amount = amount;
            TotalPrice = Amount * Product.Price;
        }
    }
}
