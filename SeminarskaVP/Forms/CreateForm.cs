using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskaVP.Forms
{
    public partial class CreateForm : Form
    {
        //      user generated

        //      end user generated

        public CreateForm()
        {
            InitializeComponent();
        }

        private void EprNameTB_Validating(object sender, CancelEventArgs e)
        {
            EprNameEP.Clear();
            if (EprNameTB.Text == "") { EprNameEP.SetError(EprNameTB, "Ова поле не смее да биде празно"); return; }

        }

        private void EprTransactionNumberTB_Validating(object sender, CancelEventArgs e)
        {
            EprTNEP.Clear();
            if (EprTransactionNumberTB.Text == "") { EprTNEP.SetError(EprTransactionNumberTB, "Ова поле не смее да биде празно"); return; }

            char[] temp = EprTransactionNumberTB.Text.ToCharArray();
            foreach (char c in temp)
            {
                if (!char.IsDigit(c)) {
                    EprTNEP.SetError(EprTransactionNumberTB,"Трансакциската сметка мора да содржи само цифри");
                    return;
                }
            }   //  kraj foreach proverka za toa dali site znaci se cifri

        }

        private void UserNameTB_Validating(object sender, CancelEventArgs e)
        {
            UserNameEP.Clear();
            if (UserNameTB.Text == "") {
                UserNameEP.SetError(UserNameTB,"Ова поле не смее да биде празно");
                return;
            }   // kraj proverka dali ova pole e prazno

            if (Program.Enterprise==null) { return; }
            foreach (Classes.Employees.Employee employee in Program.Enterprise.Employees)
            {
                if (employee.UserName == UserNameTB.Text) {
                    UserNameEP.SetError(UserNameTB,"Ова корисничко име е зафатено");
                    return;
                }
            }   //  kraj foreach za proverka dali korisnickoto ime e zafateno

        }

        private void FirstNameTB_Validating(object sender, CancelEventArgs e)
        {
            FirstNameEP.Clear();
            if (FirstNameTB.Text == "") {
                FirstNameEP.SetError(FirstNameTB,"Ова поле не смее да биде празно");
                return;
            }
        }

        private void LastNameTB_Validating(object sender, CancelEventArgs e)
        {
            LastNameEP.Clear();
            if (LastNameTB.Text == "") {
                LastNameEP.SetError(LastNameTB,"Ова поле не смее да биде празно");
                return;
            }
        }

        private void EMBGTB_Validating(object sender, CancelEventArgs e)
        {
            EMBGEP.Clear();
            if (EMBGTB.Text == "") { EMBGEP.SetError(EMBGTB,"Ова поле не смее да биде празно"); return; }

            char[] temp = EMBGTB.Text.ToCharArray();
            foreach (char c in temp)
            {
                if (!char.IsDigit(c)) {
                    EMBGEP.SetError(EMBGTB,"Матичниот број мора да содржи само цифри");
                    return;
                }
            }

            if (EMBGTB.Text.Length != 13) { EMBGEP.SetError(EMBGTB, "Матичниот број мора да има точно 13 цифри"); return; }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
            //Program.Exit();
        }

        private void FounderTransactionNumberTB_Validating(object sender, CancelEventArgs e)
        {
            FTNEP.Clear();
            if (FounderTransactionNumberTB.Text == "") {
                FTNEP.SetError(FounderTransactionNumberTB,"Ова поле не смее да биде празно");
                return;
            }

            char[] temp = FounderTransactionNumberTB.Text.ToCharArray();
            foreach (char c in temp)
            {
                if (!char.IsDigit(c))
                {
                    FTNEP.SetError(FounderTransactionNumberTB, "Трансакциската сметка мора да содржи само цифри");
                    return;
                }
            }
        }

        private void SalaryTB_Validating(object sender, CancelEventArgs e)
        {
            SalaryEP.Clear();

            decimal temp;
            if (!decimal.TryParse(SalaryTB.Text,out temp)) {
                SalaryEP.SetError(SalaryTB,"Мора да внесете децимален број");
                return;
            }

            if (temp < 0) {
                SalaryEP.SetError(SalaryTB,"Платата не може да биде негативен број");
                return;
            }
        }

        private void PasswordTB_Validating(object sender, CancelEventArgs e)
        {
            PasswordEP.Clear();
            if (UserNameEP.GetError(UserNameTB) != "") {
                PasswordEP.SetError(PasswordTB,"Корисничкото име не е во ред");
                return;
            }
            if (PasswordTB.Text.Length < 6) {
                PasswordEP.SetError(PasswordTB,"Лозинката мора да има најмалку 6 знаци");
                return;
            }
        }

        private void ChackPasswordTB_Validating(object sender, CancelEventArgs e)
        {
            if (PasswordEP.GetError(PasswordTB) != "")
            {
                PasswordEP.SetError(ChackPasswordTB, PasswordEP.GetError(PasswordTB));
                return;
            }
            if (PasswordTB.Text != ChackPasswordTB.Text)
            {
                PasswordEP.SetError(ChackPasswordTB, "Лозинките не се совпаѓаат");
                return;
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (
                EprNameEP.GetError(EprNameTB) +
                EprTNEP.GetError(EprTransactionNumberTB) +
                UserNameEP.GetError(UserNameTB) +
                FirstNameEP.GetError(FirstNameTB) +
                LastNameEP.GetError(LastNameTB) +
                PasswordEP.GetError(PasswordTB) +
                PasswordEP.GetError(ChackPasswordTB) +
                EMBGEP.GetError(EMBGTB) + 
                FTNEP.GetError(FounderTransactionNumberTB) + 
                SalaryEP.GetError(SalaryTB)
                != ""
            ) {
                return;
            }   //  proverka dali ima pominato validacija
            else {      //  ako se e vo red so validacijata
                Program.Enterprise = new Classes.Enterprise(EprNameTB.Text, EprTransactionNumberTB.Text);
                decimal salary = decimal.Parse(SalaryTB.Text);
                try {
                    Program.Enterprise.AddManager(UserNameTB.Text, PasswordTB.Text, ChackPasswordTB.Text, FirstNameTB.Text, LastNameTB.Text, EMBGTB.Text, FounderTransactionNumberTB.Text, salary);
                    Program.Enterprise.SignIn(UserNameTB.Text);
                    Program.Save();
                    this.Hide();
                    Program.ManagerForm = new ManagerForm();
                    Program.ManagerForm.ShowDialog();

                    Program.Exit();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }   //  kraj CreateBtn

        private void CreateForm_Load(object sender, EventArgs e)
        {
            if (Program.Enterprise != null) {
                SignInForm SignInForm = new SignInForm();
                this.Hide();
                SignInForm.ShowDialog();

                Program.Exit();
            }
        }
    }
}
