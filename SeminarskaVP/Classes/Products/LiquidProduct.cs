using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes
{
    [Serializable]
    public class LiquidProduct:MeasurableProduct
    {


        public LiquidProduct(int id, string name, decimal price, decimal amount):base(id,name,price,amount) {
            Amount = amount;
        }   //  kraj konstruktor za merlivi produkti vo tecna agregatna sostojba (se merat vo litri)
    }
}
