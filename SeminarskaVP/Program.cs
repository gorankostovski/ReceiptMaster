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


        public static void Exit() {

            Application.Exit();
        }

        //  end user generated props and methods

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            FileName = @"D:\Teo's Files\Documents\Faks\Predmeti\Vizuelno Programiranje\other\Seminarska\Other\15.06.2018_11h00m\SeminarskaVP\SeminarskaVP\Data\doc.epr";

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
