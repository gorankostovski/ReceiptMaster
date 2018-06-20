using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes
{
    [Serializable]
    public class Enterprise
    {
        public string Name { get; set; }
        public Banking.BankAccount BankAccount { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Product> Stock { get; set; }
        public List<Receipt> Receipts { get; set; }


        public Employee SignedInEmployee { get; private set; }
        public void SignIn(ref Employee employee) {
            SignedInEmployee = employee;
        }
        public void SignOut() {
            SignedInEmployee = null;
        }



        public Enterprise(string name, string transactionnumber) {
            Name = name;
            BankAccount = new Banking.BankAccount(transactionnumber);
            Employees = new List<Employee>();
            Stock = new List<Product>();
            Receipts = new List<Receipt>();
        }   //  kraj konstruktor
    }
}
