using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Banking
{
    public class Activity
    {
        public string RecievingTransactionNumber { get; set; }
        public decimal Amount { get; set; }

        public Activity(string recievingtransactionnumber, decimal amount)
        {
            RecievingTransactionNumber = recievingtransactionnumber;
            Amount = amount;
        }
    }
}
