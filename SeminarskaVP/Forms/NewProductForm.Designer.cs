namespace SeminarskaVP.Forms
{
    partial class NewProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BarCodeTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.ProductTypeGB = new System.Windows.Forms.GroupBox();
            this.QuantitiveRB = new System.Windows.Forms.RadioButton();
            this.SolidRB = new System.Windows.Forms.RadioButton();
            this.LiquidRB = new System.Windows.Forms.RadioButton();
            this.ServiceRB = new System.Windows.Forms.RadioButton();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.BarCodeEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.NameEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.PriceEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.AmountEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductTypeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarCodeEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountEP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бар код";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име на продуктот/услугата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Коментар/опис";
            // 
            // BarCodeTB
            // 
            this.BarCodeTB.Location = new System.Drawing.Point(174, 10);
            this.BarCodeTB.Name = "BarCodeTB";
            this.BarCodeTB.Size = new System.Drawing.Size(196, 20);
            this.BarCodeTB.TabIndex = 5;
            this.BarCodeTB.Validating += new System.ComponentModel.CancelEventHandler(this.BarCodeTB_Validating);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(174, 48);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(196, 20);
            this.NameTB.TabIndex = 6;
            this.NameTB.Validating += new System.ComponentModel.CancelEventHandler(this.NameTB_Validating);
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(174, 86);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(196, 20);
            this.PriceTB.TabIndex = 7;
            this.PriceTB.Validating += new System.ComponentModel.CancelEventHandler(this.PriceTB_Validating);
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(174, 124);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(196, 20);
            this.AmountTB.TabIndex = 8;
            this.AmountTB.Validating += new System.ComponentModel.CancelEventHandler(this.AmountTB_Validating);
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(174, 162);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(196, 20);
            this.DescriptionTB.TabIndex = 9;
            // 
            // ProductTypeGB
            // 
            this.ProductTypeGB.Controls.Add(this.ServiceRB);
            this.ProductTypeGB.Controls.Add(this.LiquidRB);
            this.ProductTypeGB.Controls.Add(this.SolidRB);
            this.ProductTypeGB.Controls.Add(this.QuantitiveRB);
            this.ProductTypeGB.Location = new System.Drawing.Point(16, 209);
            this.ProductTypeGB.Name = "ProductTypeGB";
            this.ProductTypeGB.Size = new System.Drawing.Size(354, 92);
            this.ProductTypeGB.TabIndex = 10;
            this.ProductTypeGB.TabStop = false;
            this.ProductTypeGB.Text = "Тип на продукт/услуга";
            // 
            // QuantitiveRB
            // 
            this.QuantitiveRB.AutoSize = true;
            this.QuantitiveRB.Checked = true;
            this.QuantitiveRB.Location = new System.Drawing.Point(7, 20);
            this.QuantitiveRB.Name = "QuantitiveRB";
            this.QuantitiveRB.Size = new System.Drawing.Size(88, 17);
            this.QuantitiveRB.TabIndex = 0;
            this.QuantitiveRB.TabStop = true;
            this.QuantitiveRB.Text = "QuantitiveRB";
            this.QuantitiveRB.UseVisualStyleBackColor = true;
            // 
            // SolidRB
            // 
            this.SolidRB.AutoSize = true;
            this.SolidRB.Location = new System.Drawing.Point(178, 20);
            this.SolidRB.Name = "SolidRB";
            this.SolidRB.Size = new System.Drawing.Size(63, 17);
            this.SolidRB.TabIndex = 1;
            this.SolidRB.TabStop = true;
            this.SolidRB.Text = "SolidRB";
            this.SolidRB.UseVisualStyleBackColor = true;
            // 
            // LiquidRB
            // 
            this.LiquidRB.AutoSize = true;
            this.LiquidRB.Location = new System.Drawing.Point(7, 55);
            this.LiquidRB.Name = "LiquidRB";
            this.LiquidRB.Size = new System.Drawing.Size(66, 17);
            this.LiquidRB.TabIndex = 2;
            this.LiquidRB.TabStop = true;
            this.LiquidRB.Text = "Течност";
            this.LiquidRB.UseVisualStyleBackColor = true;
            // 
            // ServiceRB
            // 
            this.ServiceRB.AutoSize = true;
            this.ServiceRB.Location = new System.Drawing.Point(178, 55);
            this.ServiceRB.Name = "ServiceRB";
            this.ServiceRB.Size = new System.Drawing.Size(61, 17);
            this.ServiceRB.TabIndex = 3;
            this.ServiceRB.TabStop = true;
            this.ServiceRB.Text = "Услуга";
            this.ServiceRB.UseVisualStyleBackColor = true;
            this.ServiceRB.CheckedChanged += new System.EventHandler(this.ServiceRB_CheckedChanged);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(16, 325);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(149, 23);
            this.AcceptBtn.TabIndex = 11;
            this.AcceptBtn.Text = "Додади";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(221, 325);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(149, 23);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Откажи";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // BarCodeEP
            // 
            this.BarCodeEP.ContainerControl = this;
            // 
            // NameEP
            // 
            this.NameEP.ContainerControl = this;
            // 
            // PriceEP
            // 
            this.PriceEP.ContainerControl = this;
            // 
            // AmountEP
            // 
            this.AmountEP.ContainerControl = this;
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 368);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.ProductTypeGB);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.BarCodeTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewProductForm";
            this.Text = "NewProductForm";
            this.ProductTypeGB.ResumeLayout(false);
            this.ProductTypeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarCodeEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BarCodeTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.GroupBox ProductTypeGB;
        private System.Windows.Forms.RadioButton LiquidRB;
        private System.Windows.Forms.RadioButton SolidRB;
        private System.Windows.Forms.RadioButton QuantitiveRB;
        private System.Windows.Forms.RadioButton ServiceRB;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ErrorProvider BarCodeEP;
        private System.Windows.Forms.ErrorProvider NameEP;
        private System.Windows.Forms.ErrorProvider PriceEP;
        private System.Windows.Forms.ErrorProvider AmountEP;
    }
}