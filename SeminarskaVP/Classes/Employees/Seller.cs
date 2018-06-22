using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Employees
{
    [Serializable]
    public class Seller : Employee
    {


        public override EmployeeTypeEnum EmployeeType() {
            return EmployeeTypeEnum.Seller;
        }

        public Seller(
            int id,
            string username,
            string password,
            string firstname,
            string lastname,
            string embg,
            string transactionnumber,
            decimal salary
        ) : base (id, username,password,firstname,lastname,embg,transactionnumber,salary) {

        }   //  kraj konstruktor
    }
}
