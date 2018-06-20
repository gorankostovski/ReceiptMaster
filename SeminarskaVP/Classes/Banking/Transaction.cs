using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVP.Classes.Banking
{
    [Serializable]
    public class Transaction : Activity
    {
        public string SendingTransactionNumber { get; set; }

        public Transaction(string sendingtransactionnumber,string receivingtransactionnumber,decimal amount):base(receivingtransactionnumber,amount){
            SendingTransactionNumber = sendingtransactionnumber;
        }   //  kraj konstruktor
    }
}
