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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Exit();
        }

        private void UserNameTB_Validating(object sender, CancelEventArgs e)
        {
            UserNameEP.Clear();
            if (UserNameTB.Text == "") { UserNameEP.SetError(UserNameTB,"Мора да внесете корисничко име"); return; }

            foreach (Classes.Employee employee in Program.Enterprise.Employees)
            {
                if (employee.UserName == UserNameTB.Text) {
                    return;
                }
            }
            UserNameEP.SetError(UserNameTB,"Не постои таков корисник");
        }

        private void PasswordTB_Validating(object sender, CancelEventArgs e)
        {
            if (UserNameEP.GetError(UserNameTB) != "") {
                UserNameEP.SetError(PasswordTB,"Корисничкото име не е во ред");
                return;
            }

            UserNameEP.Clear();
            if () { }
        }
    }
}
