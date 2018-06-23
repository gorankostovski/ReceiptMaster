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
    public partial class ManagerForm : Form
    {
        //  user generated props and methods
        private void ResetLables() {
            ReceiptTotalLabel.Text = "ReceiptTotalLabel";ReceiptTotalLabel.Visible = false;
            BalanceLabel.Text = "BalanceLabel";BalanceLabel.Visible = false;
        }
        //  end user generated props and methods

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            ResetLables();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Име");
            dt.Columns.Add("Презиме");
            dt.Columns.Add("ЕМБГ");
            dt.Columns.Add("Трансакциска сметка");
            dt.Columns.Add("Плата");
            dt.Columns.Add("Датум на вработување");

            foreach (Classes.Employees.Employee empl in Program.Enterprise.Employees)
            {
                dt.Rows.Add(empl.Id,empl.FirstName,empl.LastName,empl.EMBG,empl.TransactionNumber,empl.Salary,empl.DayOfEmployment);
            }

            MainDG.DataSource = dt;
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            Program.Save();
            Program.Enterprise.SignOut();
            
            Close();
        }

        private void ReceiptsBtn_Click(object sender, EventArgs e)
        {
            ResetLables();
            DataTable dt = new DataTable();
            dt.Columns.Add("Продавач");
            dt.Columns.Add("Промет");
            dt.Columns.Add("Датум");

            foreach (Classes.Receipt receipt in Program.Enterprise.Receipts)
            {
                dt.Rows.Add(receipt.Seller,receipt.Total,receipt.TimeStamp);
            }

            MainDG.DataSource = dt;
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            ResetLables();
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Име");
            dt.Columns.Add("Цена");
            dt.Columns.Add("Попуст");
            dt.Columns.Add("Количина");
            dt.Columns.Add("Опис");

            foreach (Classes.Products.Product product in Program.Enterprise.Stock)
            {
                dt.Rows.Add(product.ToDataRow());
            }

            MainDG.DataSource = dt;
        }

        private void FinanceBtn_Click(object sender, EventArgs e)
        {
            ResetLables();
            DataTable dt = new DataTable();
            dt.Columns.Add("Сметка на уплатувач");
            dt.Columns.Add("Сметка на примач");
            dt.Columns.Add("Износ");
            dt.Columns.Add("Датум");
            dt.Columns.Add("Цел на исплата");

            foreach (Classes.Banking.Activity activity in Program.Enterprise.BankAccount.Activities)
            {
                dt.Rows.Add(activity.ToDataRow());
            }

            MainDG.DataSource = dt;
            BalanceLabel.Text = Program.Enterprise.BankAccount.Balance.ToString();
            
            BalanceLabel.Visible = true;
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm AddEmployeeForm = new AddEmployeeForm();
            AddEmployeeForm.ShowDialog();
            Program.Save();
            EmployeesBtn_Click(sender, e);
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (MainDG.SelectedRows == null) {
                MessageBox.Show("Одберете кој вработен сакате да го избришете","Грешка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }   //  kraj if

            //MessageBox.Show(MainDG.SelectedRows[0].Cells[0].ToString());

            try
            {
                for (int i = 0; i < Program.Enterprise.Employees.Count; i++)
                {
                    if (Program.Enterprise.Employees[i].Id == MainDG.SelectedRows[0].Cells[0].RowIndex)
                    {
                        Program.Enterprise.Employees.RemoveAt(i);
                        return;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Грешка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }   //  kraj delete employee btn

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm AddProductFormObject = new AddProductForm();
            AddProductFormObject.ShowDialog();
            StockBtn_Click(sender, e);
        }
    }
}
