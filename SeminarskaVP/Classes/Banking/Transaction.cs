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

        public new object ToDataRow()
        {
            object[] array = new object[5];
            array[0] = SendingTransactionNumber;
            array[1] = ReceivingTransactionNumber;
            array[2] = Amount.ToString();
            array[3] = Date.ToString();
            array[4] = (Receipt == null) ? ("") : (Receipt.ToString());
            return array;
        }

        public Transaction(string sendingtransactionnumber,string receivingtransactionnumber,decimal amount):base(receivingtransactionnumber,amount){
            SendingTransactionNumber = sendingtransactionnumber;
        }   //  kraj konstruktor
    }
}
