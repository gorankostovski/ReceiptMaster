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
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMBG { get; set; }        //  edinstven maticen broj na gragjaninot
        public string TransactionNumber { get; set; }   //  transakciska smetka za isplakjane na plata
        public decimal Salary { get; set; }


        public void PaySalary() {

        }

        //  konstruktor
        public Employee(
            int id,
            string username,
            string password,
            string firstname,
            string lastname,
            string embg,
            string transactionnumber,
            decimal salary
        ) {
            Id = id;
            UserName = username;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            EMBG = embg;
            TransactionNumber = transactionnumber;
            Salary = salary;
        }   //  kraj konstruktor za vraboten
    }
}
