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
        public List<Classes.Employees.Employee> Employees { get; set; }
        public List<Classes.Products.Product> Stock { get; set; }
        public List<Receipt> Receipts { get; set; }



        public Classes.Employees.Employee SignedInEmployee { get; private set; }
        public void SignIn(int id) {
            foreach (Classes.Employees.Employee empl in Employees)
            {
                if (id == empl.Id) {
                    SignedInEmployee = empl;
                    return;
                }
            }
        }
        public void SignIn(string username)
        {
            foreach (Classes.Employees.Employee empl in Employees)
            {
                if (username == empl.UserName)
                {
                    SignedInEmployee = empl;
                    return;
                }
            }
        }
        public void SignOut() {
            SignedInEmployee = null;
        }



        public bool AddManager(string username,string password,string chechpw,string firstname,string lastname,string embg,string transactionnumber,decimal salary) {
            if (password!=chechpw) { throw new Exception("Passwords do not match"); return false; }
            int id = Employees.Count;
            bool repeat = true;

            while (repeat) {
                repeat = false;
                foreach (Classes.Employees.Employee e in Employees){if (e.Id == id) {id++;repeat=true;break;}}
            }

            if (id < 0) { throw new Exception("Negative Id"); return false; }
            try{
                Employees.Add(new Employees.Manager(id,username,password,firstname,lastname,embg,transactionnumber,salary));
                return true;
            }
            catch (Exception ex) {
                throw ex;
                //return false;
            }
        }
        public bool AddSeller(string username, string password, string chechpw, string firstname, string lastname, string embg, string transactionnumber, decimal salary) {
            if (password != chechpw) { throw new Exception("Passwords do not match"); return false; }
            int id = Employees.Count;
            bool repeat = true;

            while (repeat)
            {
                repeat = false;
                foreach (Classes.Employees.Employee e in Employees) { if (e.Id == id) { id++; repeat = true; break; } }
            }

            if (id < 0) { throw new Exception("Negative Id"); return false; }
            try
            {
                Employees.Add(new Employees.Seller(id, username, password, firstname, lastname, embg, transactionnumber, salary));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                //return false;
            }
        }

        public Enterprise(string name, string transactionnumber) {
            Name = name;
            BankAccount = new Banking.BankAccount(transactionnumber);
            //Employees = new List<Employee>();
            Employees = new List<Classes.Employees.Employee>();
            Stock = new List<Classes.Products.Product>();
            Receipts = new List<Receipt>();
        }   //  kraj konstruktor
    }
}
