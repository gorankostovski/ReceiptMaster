using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes
{
    [Serializable]
    public abstract class Employee
    {
        public int Id { get; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMBG { get; set; }        //  edinstven maticen broj na gragjaninot
        public string BankAccount { get; set; }
        public decimal Salary { get; set; }


        public void PaySalary() {

        }

        //  konstruktor
        public Employee(
            int id,
            string username,
            string firstname,
            string lastname,
            string embg,
            string bankaccount,
            decimal salary
        ) {
            Id = id;
            UserName = username;
            FirstName = firstname;
            LastName = lastname;
            EMBG = embg;
            BankAccount = bankaccount;
            Salary = salary;
        }   //  kraj konstruktor za vraboten
    }
}
