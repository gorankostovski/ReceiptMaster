﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes
{
    public class QuantitativeProduct : Product      //  produkt koj se prodava kako cel i nedelliv
    {
        public int Amount { get; set; }




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
