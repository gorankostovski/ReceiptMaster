using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Banking
{
    [Serializable]
    public class BankAccount
    {
        public string TransactionNumber { get; set; }
        public decimal Balance { get; set; }
        public List<Activity> Activities { get; set; }

        public bool Transfer(string receivingtransactionnumber, decimal amount) {
            if (Balance < amount)
            {
                throw new Exception("Нема доволно средства на сметката");
                //return false;
            }
            else {
                Activities.Add(new Transaction(TransactionNumber,receivingtransactionnumber,amount));
                return true;
            }
        }   //  kraj metoda transfer koja najcesto ke se koristi za isplakjanje na plata na vrabotente

        public bool DepositCapital(decimal amount) {
            Activities.Add(new Activity(TransactionNumber, amount));
            return true;
        }   //  kraj metoda so koja sopstvenikot na biznisot vnesuva kapital na smetkata na biznisot vo kes
        public bool DepositCapital(string sendingtransactionnumber,decimal amount) {
            Activities.Add(new Transaction(sendingtransactionnumber,TransactionNumber,amount));
            return true;
        }   //  kraj metoda so koja sopstvenikot vnesuva kapital preku prefrlanje od edna smetka na druga smetka

        public bool Recieve(string sendingtransactionnumber, decimal amount) {
            Activities.Add(new Transaction(sendingtransactionnumber, TransactionNumber, amount));
            return true;
        }   //  metoda so koja se primaat pari od nekoja smetka na smetkata na pretprijatieto za random potrebi (algoritmot e ist so deposit capital)

        public bool WithdrawProfit(ref Employee Manager, decimal amount) {
            Classes.Employee temp = Manager as Classes.Employees.Manager;
            if (temp == null) {
                throw new Exception("Лицето не е менаџер на претпријатието");
                //return false;
            }
            if (Balance >= amount)
            {
                Activities.Add(new Transaction(TransactionNumber,Manager.TransactionNumber,amount));
                Balance -= amount;
                return true;
            }
            else {
                throw new Exception("Нема доволно средства на сметката");
                //return false;
            }
        }

        public BankAccount(string transactionnumber) {
            TransactionNumber = transactionnumber;
            Activities = new List<Activity>();
        }   //  kraj konstruktor
    }
}
