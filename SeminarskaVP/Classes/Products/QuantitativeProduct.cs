using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Products
{
    [Serializable]
    public class QuantitativeProduct : Product      //  produkt koj se prodava kako cel i nedelliv
    {
        public int Amount { get; set; }


        public override bool AddAmount(string amount)
        {
            int temp;
            if (!int.TryParse(amount, out temp))
            {
                throw new Exception(amount + " can't be parsed to int");
                return false;
            }
            else {
                Amount += temp;
                return true;
            }
        }

        public override object ToDataRow()
        {
            object[] array = new object[6];

            array[0] = Id.ToString();
            array[1] = Name;
            array[2] = Price.ToString();
            array[3] = Discount.ToString();
            array[4] = Amount;
            array[5] = Description;

            return array;
        }

        public decimal Sell(int amount) {   //  metoda koja ja namaluva dadenata kolicina i ja vrakja vkupnata cena na prodedenite produkti
            if (!CheckPurchase(amount)) { throw new Exception("Нема доволно продукти на залиха"); }
            Amount -= amount;
            return Price * amount;
        }

        public bool CheckPurchase(int amount)
        {
            //if (amount % 1 != 0) { throw new Exception("Количината на квантитивните продукти мора да биде цел број!"); }
            if (Amount >= amount) { return true; }
            else { return false; }
        }

        public QuantitativeProduct(int id,string name,decimal price,int amount) :base(id,name,price){
            Amount = amount;
        }   //  kraj konstructor za prebroiv nemerliv produkt

    }
}
