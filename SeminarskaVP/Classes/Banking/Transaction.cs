using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Banking
{
    public class Transaction : Activity
    {
        public string SendingTransactionNumber { get; set; }

        public Transaction(string sendingtransactionnumber,string recievingtransactionnumber,decimal amount):base(recievingtransactionnumber,amount){
            SendingTransactionNumber = sendingtransactionnumber;
        }   //  kraj konstruktor
    }
}
