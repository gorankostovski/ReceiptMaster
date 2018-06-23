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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void BarCodeTB_Validating(object sender, CancelEventArgs e){
            BarCodeEP.Clear();
            if (BarCodeTB.Text == "") {
                BarCodeEP.SetError(BarCodeTB,"Мора да внесете бар код");
                return;
            }   //  kraj if proverka dali e prazno

            //  proverka dali bar kodot sodrzi samo cifri
            char[] temp = BarCodeTB.Text.ToCharArray();
            foreach (char c in temp){if (!char.IsDigit(c)) { BarCodeEP.SetError(BarCodeTB, "Бар кодот мора да содржи само цифри"); return; }}
            //  kraj proverka dali bar kodot sodrzi samo cifri

            //  proverka dali postoi takov produkt
            foreach (Classes.Products.Product product in Program.Enterprise.Stock){if (product.Id == int.Parse(BarCodeTB.Text)) { return; }}
            BarCodeEP.SetError(BarCodeTB,"Не постои таков продукт");
            //  kraj proverka dali postoi takov produkt

        }   //  kraj BarCode_Validating

        private void AmountTB_Validating(object sender, CancelEventArgs e){
            AmountEP.Clear();
            if (BarCodeEP.GetError(BarCodeTB)!="" || BarCodeTB.Text=="") {
                AmountEP.SetError(AmountTB,"Бар кодот не е во ред");
                return;
            }
            if (true/**/) {
                Classes.Products.Product temp = null;
                Classes.Products.Service tempSvc;
                Classes.Products.QuantitativeProduct tempQuantitive;
                Classes.Products.MeasurableProduct tempMeasurable;
                for (int i = 0; i < Program.Enterprise.Stock.Count; i++)
                {
                    if (Program.Enterprise.Stock[i].Id == int.Parse(BarCodeTB.Text)) {
                        temp = Program.Enterprise.Stock[i];
                        break;
                    }
                }
                if (temp == null) {
                    AmountEP.SetError(AmountTB, "Бар кодот не е во ред");
                    return;
                }
                tempSvc = temp as Classes.Products.Service;
                if (tempSvc != null) { return; }
                tempQuantitive = temp as Classes.Products.QuantitativeProduct;
                if (tempQuantitive != null) {
                    if (AmountTB.Text == "") { AmountEP.SetError(AmountTB, "Ова поле не смее да биде празно"); return; }
                    int tempInt;
                    if (!int.TryParse(AmountTB.Text, out tempInt)) { AmountEP.SetError(AmountTB, "Количината мора да биде цел број"); return; }
                    return;
                }   // kraj ako   e quantitive
                tempMeasurable = temp as Classes.Products.MeasurableProduct;
                if (tempMeasurable != null) {
                    if (AmountTB.Text == "") { AmountEP.SetError(AmountTB, "Ова поле не смее да биде празно"); return; }
                    decimal tempInt;
                    if (!decimal.TryParse(AmountTB.Text, out tempInt)) { AmountEP.SetError(AmountTB, "Количината мора да биде децимален број"); return; }
                    return;
                }   //  kraj ako e measurable
            }
        }// kraj AmountTB_Validating

        private void AcceptBtn_Click(object sender, EventArgs e){
            if (BarCodeEP.GetError(BarCodeTB) + AmountEP.GetError(AmountTB) != "" || BarCodeTB.Text == "" ) {
                return;
            }
            foreach (Classes.Products.Product product in Program.Enterprise.Stock)
            {
                if (product.Id == int.Parse(BarCodeTB.Text)) {
                    Classes.Products.Service tempSvc = product as Classes.Products.Service;
                    if (tempSvc != null) { return; }
                    Classes.Products.QuantitativeProduct tempQuantitive = product as Classes.Products.QuantitativeProduct;
                    if (tempQuantitive != null) { product.AddAmount(AmountTB.Text); }
                    Classes.Products.MeasurableProduct tempMeasurable = product as Classes.Products.MeasurableProduct;
                    if (tempMeasurable != null) { product.AddAmount(AmountTB.Text); }
                    return;
                }   //  kraj ako e najden produktot
            }   //  kraj na for koj go bara produktot
            MessageBox.Show("Нема таков продукт", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("Product with ID=" + AmountTB.Text + " is not found while adding amount");
        }   // kraj AcceptBtn

        private void NewProductBtn_Click(object sender, EventArgs e){
            NewProductForm NewProductFormObject = new NewProductForm();
            NewProductFormObject.ShowDialog();


        }   // kraj metoda NewProductBtn

        private void CancelBtn_Click(object sender, EventArgs e){Close();}
    }   //  kraj na klasata AddProductForm
}
