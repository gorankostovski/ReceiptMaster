using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes
{
    [Serializable]
    public class Service : Product      //  uslugi (nemaat kolicina)
    {

        public Service(int id,string name,decimal price):base(id,name,price) {

        }
    }
}
