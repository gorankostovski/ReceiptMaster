using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes
{
    public class MeasurableProduct:Product      //  produkt koj se meri vo kologrami ili litri
    {
        public decimal Amount { get; set; }     //  kolicina vo kilogrami/litri



        public decimal Sell(decimal amount) {
            if (!CheckPurchase(amount)) { throw new Exception("Нема толкава количина на залиха"); }
            Amount -= amount;
            return Price * amount;
        }

        public bool CheckPurchase(decimal amount) {
            if (Amount >= amount) { return true; }
            else { return false; }
        }   //  kraj metoda za proverka na kupuvanje

        public MeasurableProduct(int id,string name,decimal price,decimal amount):base(id,name,price) {
            Amount = amount;
        }   //  kraj konstruktor za merlivi produkti
    }
}
