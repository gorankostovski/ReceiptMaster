using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Employees
{
    [Serializable]
    public abstract class Employee
    {
        public enum EmployeeTypeEnum { Seller, Manager }

        public int Id { get; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMBG { get; set; }        //  edinstven maticen broj na gragjaninot
        public string TransactionNumber { get; set; }   //  transakciska smetka za isplakjane na plata
        public decimal Salary { get; set; }
        public DateTime DayOfEmployment { get; set; }

        public abstract EmployeeTypeEnum EmployeeType();

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

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
            if (id < 0) { throw new Exception("Negative Id"); }
            Id = id;
            if (username == "") { throw new Exception("Blank User Name"); }
            UserName = username;
            if (password.Length < 6) { throw new Exception("Password shorter than 6 characters"); }
            Password = password;
            if (firstname == "") { throw new Exception("Blank First Name"); }
            else { char[] temp = firstname.ToCharArray();foreach (char c in temp){ if (!char.IsLetter(c)) { throw new Exception("First Name contains unsupported characters"); } }}
            FirstName = firstname;
            if (lastname == "") { throw new Exception("Blank Last Name"); }
            else { char[] temp = lastname.ToCharArray(); foreach (char c in temp) { if (!char.IsLetter(c)) { throw new Exception("Last Name contains unsupported characters"); } } }
            LastName = lastname;
            if (embg.Length != 13) { throw new Exception("EMBG does not have 13 digits"); }
            else{ char[] temp = embg.ToCharArray(); foreach (char c in temp) { if (!char.IsDigit(c)) { throw new Exception("EMBG contains unsupported characters"); } } }
            EMBG = embg;
            if (transactionnumber=="") { throw new Exception("Blank transaction number"); }
            else { char[] temp = transactionnumber.ToCharArray();foreach (char c in temp) { if (!char.IsDigit(c)) { throw new Exception("Transaction number contains unsupported characters"); } } }
            TransactionNumber = transactionnumber;
            if (salary < 0) { throw new Exception("Negative salary"); }
            Salary = salary;
            DayOfEmployment = DateTime.Now;
        }   //  kraj konstruktor za vraboten
    }
}
