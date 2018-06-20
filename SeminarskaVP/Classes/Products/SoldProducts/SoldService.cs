using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Products.SoldProduct
{
    [Serializable]
    public class SoldService : SoldProduct
    {
        public decimal Price { get; set; }

        public SoldService(ref Product product, decimal price) : base(ref product) {
            TotalPrice = price;
        }
    }
}
