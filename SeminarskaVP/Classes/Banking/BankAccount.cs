using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Banking
{
    public class BankAccount
    {
        public string TransactionNumber { get; set; }
        public decimal Balance { get; set; }
        public List<Activity> Activities { get; set; }


        public BankAccount(string transactionnumber) {
            TransactionNumber = transactionnumber;
        }
    }
}
