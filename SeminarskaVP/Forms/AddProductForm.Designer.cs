namespace SeminarskaVP.Forms
{
    partial class AddProductForm
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
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.NewProductBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.BarCodeTB = new System.Windows.Forms.TextBox();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.BarCodeEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.AmountEP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarCodeEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountEP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бар код на продуктот:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количина:";
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(29, 109);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(89, 44);
            this.AcceptBtn.TabIndex = 2;
            this.AcceptBtn.Text = "Додади";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // NewProductBtn
            // 
            this.NewProductBtn.Location = new System.Drawing.Point(165, 109);
            this.NewProductBtn.Name = "NewProductBtn";
            this.NewProductBtn.Size = new System.Drawing.Size(89, 44);
            this.NewProductBtn.TabIndex = 3;
            this.NewProductBtn.Text = "Нов продукт";
            this.NewProductBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(306, 109);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(89, 44);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Откажи";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // BarCodeTB
            // 
            this.BarCodeTB.Location = new System.Drawing.Point(165, 21);
            this.BarCodeTB.Name = "BarCodeTB";
            this.BarCodeTB.Size = new System.Drawing.Size(230, 20);
            this.BarCodeTB.TabIndex = 5;
            this.BarCodeTB.Validating += new System.ComponentModel.CancelEventHandler(this.BarCodeTB_Validating);
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(165, 63);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(230, 20);
            this.AmountTB.TabIndex = 6;
            this.AmountTB.Validating += new System.ComponentModel.CancelEventHandler(this.AmountTB_Validating);
            // 
            // BarCodeEP
            // 
            this.BarCodeEP.ContainerControl = this;
            // 
            // AmountEP
            // 
            this.AmountEP.ContainerControl = this;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 177);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.BarCodeTB);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.NewProductBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.BarCodeEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button NewProductBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox BarCodeTB;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.ErrorProvider BarCodeEP;
        private System.Windows.Forms.ErrorProvider AmountEP;
    }
}