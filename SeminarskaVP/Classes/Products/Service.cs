﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes
{
    [Serializable]
    public class Service : Product      //  uslugi (nemaat kolicina)
    {


        public override object ToDataRow()
        {
            object[] array = new object[6];
            array[0] = Id.ToString();
            array[1] = Name;
            array[2] = Price.ToString();
            array[3] = Discount.ToString();
            array[4] = "";
            array[5] = Description;
            return array;
        }

        public Service(int id,string name,decimal price):base(id,name,price) {
            
        }
    }
}
