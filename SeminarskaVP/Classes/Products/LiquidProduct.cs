using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Products
{
    [Serializable]
    public class LiquidProduct:MeasurableProduct
    {


        public override object ToDataRow()
        {
            object[] array = new object[6];

            array[0] = Id;
            array[1] = Name;
            array[2] = Price.ToString();
            array[3] = Discount.ToString();
            array[4] = AmountToString();
            array[5] = Description;

            return array;
        }

        public new string AmountToString() { return Amount.ToString() + "l"; }

        public LiquidProduct(int id, string name, decimal price, decimal amount):base(id,name,price,amount) {
            Amount = amount;
        }   //  kraj konstruktor za merlivi produkti vo tecna agregatna sostojba (se merat vo litri)
    }
}
