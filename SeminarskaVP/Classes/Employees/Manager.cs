using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Employees
{
    [Serializable]
    public class Manager : Employee
    {

        public Manager(
            int id,
            string username,
            string firstname,
            string lastname,
            string embg,
            string transactionnumber,
            decimal salary
        ) : base (id, username,firstname,lastname,embg,transactionnumber,salary) {

        }   //  kraj konstruktor
    }
}
