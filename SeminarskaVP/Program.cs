using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SeminarskaVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        //  user generated props and methods
        public static Classes.Enterprise Enterprise { get; set; }
        public static string FileName { get; set; }
        public static Forms.ManagerForm ManagerForm { get; set; }


        public static void Save() {
            using (FileStream FileStream = new FileStream(FileName, FileMode.Create)) {
                IFormatter Formatter = new BinaryFormatter();
                Formatter.Serialize(FileStream, Enterprise);
            }
        }

        public static void Exit() {
            Save();
            Enterprise.SignOut();
            Application.Exit();
        }

        //  end user generated props and methods

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            FileName = @"doc.epr";

            if (File.Exists(FileName))      //  proverka dali postoi pretprijatie
            {
                try
                {
                    using (FileStream streamer = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        Enterprise = (Classes.Enterprise)formater.Deserialize(streamer);
                    }
                    Application.Run(new Forms.SignInForm());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Грешка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else {      //  dokolku ne postoi kreirano pretprijatie togas se kreira novo pretprijatie
                Application.Run(new Forms.CreateForm());
            }



            //Application.Run(new Form1());
        }
    }
}
