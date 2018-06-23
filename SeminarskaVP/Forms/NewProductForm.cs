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
    public partial class NewProductForm : Form
    {
        //  user generated props and methods
        void ProductTypeChanged() {
            if (QuantitiveRB.Checked == true){ AmountTB.Enabled = true; return; }
            if (SolidRB.Checked == true){ AmountTB.Enabled = true; return; }
            if (LiquidRB.Checked == true){ AmountTB.Enabled = true; return; }
            if (ServiceRB.Checked == true){ AmountTB.Enabled = false; return; }
        }
        //  end user generated

        public NewProductForm()
        {
            InitializeComponent();
        }

        private void BarCodeTB_Validating(object sender, CancelEventArgs e){
            BarCodeEP.Clear();
            if (BarCodeTB.Text == "") { BarCodeEP.SetError(BarCodeTB, "Ова поле не смее да биде празно"); return; }

            int temp;if (!int.TryParse(BarCodeTB.Text, out temp)) { BarCodeEP.SetError(BarCodeTB,"Бар кодот мора да биде цел број"); return; }


        }   //  kraj metoda BarCodeTB validating

        private void NameTB_Validating(object sender, CancelEventArgs e){
            NameEP.Clear();
            if (NameTB.Text == "") { NameEP.SetError(NameTB,"Ова поле не смее да биде празно"); return; }
        }   //  kraj metoda NameTB validating

        private void PriceTB_Validating(object sender, CancelEventArgs e){
            PriceEP.Clear();
            if (PriceTB.Text == "") { PriceEP.SetError(PriceTB, "Ова поле не смее да биде празно"); return; }

            decimal temp; if (!decimal.TryParse(PriceTB.Text, out temp)) {PriceEP.SetError(PriceTB, "Цената мора да биде децимален број"); return; }

        }   //  kraj metoda Price Validating

        private void ServiceRB_CheckedChanged(object sender, EventArgs e){ProductTypeChanged();}

        private void AmountTB_Validating(object sender, CancelEventArgs e){
            int tempInt;decimal tempDecimal;
            if (QuantitiveRB.Checked == true){
                if (AmountTB.Text == "") { AmountEP.SetError(AmountTB,"Ова поле не смее да биде празно"); return; }
                if (!int.TryParse(AmountTB.Text, out tempInt)) { AmountEP.SetError(AmountTB, "Количината мора да биде цел број"); return; }
                AmountEP.Clear(); return;
            }   //  kraj ako produktot e Quantitive
            if (SolidRB.Checked || LiquidRB.Checked) {
                if (AmountTB.Text == "") { AmountEP.SetError(AmountTB, "Ова поле не смее да биде празно"); return; }
                if (!decimal.TryParse(AmountTB.Text, out tempDecimal)) { AmountEP.SetError(AmountTB, "Количината мора да биде децимален број"); return; }
                AmountEP.Clear(); return;
            }   //  kraj ako produktot e Measurable
            if (ServiceRB.Checked) {
                throw new Exception("Validating amount of service");
                return;
            }   //  kraj ako produktot e usluga
        }   //  kraj validacija na kolicina

        private void AcceptBtn_Click(object sender, EventArgs e){
            if (
                BarCodeTB.Text == "" ||
                BarCodeEP.GetError(BarCodeTB) + 
                NameEP.GetError(NameTB) + 
                PriceEP.GetError(PriceTB) +
                AmountEP.GetError(AmountTB)
                != ""
            ) {
                return;
            }

            //  ako validacijata e vo red
            if (QuantitiveRB.Checked == true)
            {
                Program.Enterprise.Stock.Add(new Classes.Products.QuantitativeProduct(int.Parse(BarCodeTB.Text), NameTB.Text, decimal.Parse(PriceTB.Text), int.Parse(AmountTB.Text))); return;
            }   //  kraj ako produktot e Quantitive
            else if (SolidRB.Checked)
            {
                Program.Enterprise.Stock.Add(new Classes.Products.SolidProduct(int.Parse(BarCodeTB.Text), NameTB.Text, decimal.Parse(PriceTB.Text), decimal.Parse(AmountTB.Text))); return;
            }   //  kraj ako produktot e Solid
            else if (LiquidRB.Checked)
            {
                Program.Enterprise.Stock.Add(new Classes.Products.LiquidProduct(int.Parse(BarCodeTB.Text), NameTB.Text, decimal.Parse(PriceTB.Text), decimal.Parse(AmountTB.Text))); return;
            }   //  kraj ako produktot e Liquid
            else if (ServiceRB.Checked)
            {
                Program.Enterprise.Stock.Add(new Classes.Products.Service(int.Parse(BarCodeTB.Text), NameTB.Text, decimal.Parse(PriceTB.Text))); return;
            }   //  kraj ako produktot e Service (usluga)
            else {
                MessageBox.Show("Грешка при креирање на нов продукт", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception("Product not created");
            }

            Close();

        }   //  kraj AcceptBtn

        private void CancelBtn_Click(object sender, EventArgs e) { Close(); }
    }   //  kraj klasa NewProductForm
}
