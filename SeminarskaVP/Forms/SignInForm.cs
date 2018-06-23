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

            foreach (Classes.Employees.Employee employee in Program.Enterprise.Employees)
            {
                if (employee.UserName == UserNameTB.Text) {
                    return;
                }
            }
            UserNameEP.SetError(UserNameTB,"Не постои таков корисник");
        }

        private void PasswordTB_Validating(object sender, CancelEventArgs e)
        {
            if (UserNameEP.GetError(UserNameTB) != "") { UserNameEP.SetError(PasswordTB, "Корисничкото име не е во ред"); return; }
            foreach(Classes.Employees.Employee empl in Program.Enterprise.Employees){
                if ((empl.UserName == UserNameTB.Text) && (empl.Password == PasswordTB.Text)){
                    //Program.Enterprise.SignIn(ref empl);    //  nemozam empl da go predadam kako referenca
                    UserNameEP.Clear();
                    return;
                } else {
                    
                }   //  kraj proverka dali se raboti za toj korisnik
            }   //  kraj foreach

            //  sleduva deka nema korisnik so toa korisnicko ime i lozinka
            UserNameEP.SetError(PasswordTB, "Погрешна лозинка");

        }   //  kraj metoda za validacija na password

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTB.Text == "") { UserNameEP.SetError(UserNameTB,"Мора да внесете корисничко име"); return; }
            if (UserNameEP.GetError(UserNameTB) + UserNameEP.GetError(PasswordTB) != "")
            {
                //UserNameEP.UpdateBinding();
                return;
            }

            foreach (Classes.Employees.Employee empl in Program.Enterprise.Employees)
            {
                if ((empl.UserName == UserNameTB.Text) && (empl.Password == PasswordTB.Text))
                {
                    Program.Enterprise.SignIn(UserNameTB.Text);    //  nemozam empl da go predadam kako referenca
                    if (Program.Enterprise.SignedInEmployee.EmployeeType() == Classes.Employees.Employee.EmployeeTypeEnum.Manager) {
                        Program.ManagerForm = new ManagerForm();
                        this.Hide();
                        Program.ManagerForm.ShowDialog();
                        this.Show();
                    }
                }
                else {
                    
                }   //  kraj proverka dali se raboti za toj korisnik

            }   // kraj foreach

            //  sleduva deka ne postoi korisnik so toa korisnicko ime i so vnesenata lozinka
            UserNameEP.SetError(PasswordTB, "Погрешна лозинка");
        }

        /*  //  nemam ideja zosto dava error
        private void PasswordTB_Validating(object sender, CancelEventArgs e)
        {
            if (UserNameEP.GetError(UserNameTB) != "") {
                UserNameEP.SetError(PasswordTB,"Корисничкото име не е во ред");
                return;
            }

            UserNameEP.Clear();

            foreach (Classes.Employee employee in Program.Enterprise.Employees)
            {
                if (employee.UserName == UserNameTB.Text) {
                    if (employee.Password == PasswordTB.Text) {
                    ref var temp = employee;
                        Program.Enterprise.SignIn(ref temp);
                        return;
                    }
                    else {
                        UserNameEP.SetError(PasswordTB,"Лозинката не се совпаѓа");
                        return;
                    }
                }
            }   //  kraj foreach za proverka na lozinka

            //  se nadevam deka nikogas nema da stigne do tuka

            //

        }   //  kraj metoda za validacija na password
        */

    }
}
