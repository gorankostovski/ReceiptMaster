using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Banking
{
    [Serializable]
    public class Activity
    {
        public string ReceivingTransactionNumber { get; set; }
        public decimal Amount { get; set; }
        public Receipt Receipt { get; set; }


        public Activity(string receivingtransactionnumber, ref Receipt receipt) {
            ReceivingTransactionNumber = receivingtransactionnumber;
            Receipt = receipt;
            Amount = Receipt.Total;
        }

        public Activity(string receivingtransactionnumber, decimal amount)
        {
            ReceivingTransactionNumber = receivingtransactionnumber;
            Amount = amount;
        }
    }
}
