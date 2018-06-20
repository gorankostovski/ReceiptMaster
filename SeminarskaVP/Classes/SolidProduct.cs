using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes
{
    public class SolidProduct : MeasurableProduct       //  se merat vo KG
    {


        public SolidProduct(int id, string name, decimal price, decimal amount):base(id,name,price,amount) {
            Amount = amount;
        }   //  kraj konstruktor za merlivi produkti vo tvrda agregatna sostojba (se merat vo kg) 
    }
}
