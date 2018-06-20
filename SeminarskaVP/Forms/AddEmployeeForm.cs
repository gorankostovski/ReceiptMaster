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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void FirstNameTB_Validating(object sender, CancelEventArgs e)
        {
            FirstNameEP.Clear();
            if (FirstNameTB.Text == "") {
                FirstNameEP.SetError(FirstNameTB, "Ова поле не смее да биде празно");
                return;
            }
        }

        private void LastNameTB_Validating(object sender, CancelEventArgs e)
        {
            LastNameEP.Clear();
            if (LastNameTB.Text == "")
            {
                LastNameEP.SetError(LastNameTB, "Ова поле не смее да биде празно");
                return;
            }
        }

        private void UserNameTB_Validating(object sender, CancelEventArgs e)
        {
            UserNameEP.Clear();
            if (UserNameTB.Text == "")
            {
                UserNameEP.SetError(UserNameTB, "Ова поле не смее да биде празно");
                return;
            }   // kraj proverka dali ova pole e prazno

            if (Program.Enterprise == null) { return; }
            foreach (Classes.Employees.Employee employee in Program.Enterprise.Employees)
            {
                if (employee.UserName == UserNameTB.Text)
                {
                    UserNameEP.SetError(UserNameTB, "Ова корисничко име е зафатено");
                    return;
                }
            }   //  kraj foreach za proverka dali korisnickoto ime e zafateno
        }

        private void PasswordTB_Validating(object sender, CancelEventArgs e)
        {
            PasswordEP.Clear();
            if (UserNameEP.GetError(UserNameTB) != "")
            {
                PasswordEP.SetError(PasswordTB, "Корисничкото име не е во ред");
                return;
            }
            if (PasswordTB.Text.Length < 6)
            {
                PasswordEP.SetError(PasswordTB, "Лозинката мора да има најмалку 6 знаци");
                return;
            }
        }

        private void CheckPasswordTB_Validating(object sender, CancelEventArgs e)
        {
            CheckPasswordEP.Clear();
            if (PasswordEP.GetError(PasswordTB) != "")
            {
                CheckPasswordEP.SetError(CheckPasswordTB, PasswordEP.GetError(PasswordTB));
                return;
            }
            if (PasswordTB.Text != CheckPasswordTB.Text)
            {
                CheckPasswordEP.SetError(CheckPasswordTB, "Лозинките не се совпаѓаат");
                return;
            }
        }

        private void EMBGTB_Validating(object sender, CancelEventArgs e)
        {
            EMBGEP.Clear();
            if (EMBGTB.Text == "") { EMBGEP.SetError(EMBGTB, "Ова поле не смее да биде празно"); return; }

            char[] temp = EMBGTB.Text.ToCharArray();
            foreach (char c in temp)
            {
                if (!char.IsDigit(c))
                {
                    EMBGEP.SetError(EMBGTB, "Матичниот број мора да содржи само цифри");
                    return;
                }
            }

            if (EMBGTB.Text.Length != 13) { EMBGEP.SetError(EMBGTB, "Матичниот број мора да има точно 13 цифри"); return; }

        }

        private void TransactionNumberTB_Validating(object sender, CancelEventArgs e)
        {
            TNEP.Clear();
            if (TransactionNumberTB.Text == "")
            {
                TNEP.SetError(TransactionNumberTB, "Ова поле не смее да биде празно");
                return;
            }

            char[] temp = TransactionNumberTB.Text.ToCharArray();
            foreach (char c in temp)
            {
                if (!char.IsDigit(c))
                {
                    TNEP.SetError(TransactionNumberTB, "Трансакциската сметка мора да содржи само цифри");
                    return;
                }
            }
        }

        private void SalaryTB_Validating(object sender, CancelEventArgs e)
        {
            SalaryEP.Clear();

            decimal temp;
            if (!decimal.TryParse(SalaryTB.Text, out temp))
            {
                SalaryEP.SetError(SalaryTB, "Мора да внесете децимален број");
                return;
            }

            if (temp < 0)
            {
                SalaryEP.SetError(SalaryTB, "Платата не може да биде негативен број");
                return;
            }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {

            if (
                FirstNameEP.GetError(FirstNameTB) +
                LastNameEP.GetError(LastNameTB) +
                UserNameEP.GetError(UserNameTB) +
                PasswordEP.GetError(PasswordTB) +
                CheckPasswordEP.GetError(CheckPasswordTB) +
                EMBGEP.GetError(EMBGTB) +
                TNEP.GetError(TransactionNumberTB) +
                SalaryEP.GetError(SalaryTB)
                != ""
                && UserNameTB.Text != ""
            )
            {
                return;
            }
            else    //  inaku se e vo red so validacijata
            {
                try
                {
                    if (ManagerCB.Checked)
                    {    //  vraboteniot treba da bide menager
                        Program.Enterprise.AddManager(UserNameTB.Text, PasswordTB.Text, CheckPasswordTB.Text, FirstNameTB.Text, LastNameTB.Text, EMBGTB.Text, TransactionNumberTB.Text, decimal.Parse(SalaryTB.Text));
                        MessageBox.Show("Успешно додадовте нов менаџер", "Честитки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {   //  vraboteniot treba da bide obicen prodavac
                        Program.Enterprise.AddSeller(UserNameTB.Text, PasswordTB.Text, CheckPasswordTB.Text, FirstNameTB.Text, LastNameTB.Text, EMBGTB.Text, TransactionNumberTB.Text, decimal.Parse(SalaryTB.Text));
                        MessageBox.Show("Успешно додадовте нов продавач", "Честитки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }   //  kraj try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Грешка при додавање на вработен", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   //  kraj catch
                finally {
                    Close();
                }
            }   //  kraj else
        }   //  kraj accept Btn

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
