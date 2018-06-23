namespace SeminarskaVP.Forms
{
    partial class AddEmployeeForm
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
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ManagerCB = new System.Windows.Forms.CheckBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.CheckPasswordTB = new System.Windows.Forms.TextBox();
            this.EMBGTB = new System.Windows.Forms.TextBox();
            this.TransactionNumberTB = new System.Windows.Forms.TextBox();
            this.SalaryTB = new System.Windows.Forms.TextBox();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.FirstNameEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.LastNameEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.UserNameEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.CheckPasswordEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.EMBGEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.TNEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.SalaryEP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPasswordEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMBGEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryEP)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(186, 39);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(239, 20);
            this.FirstNameTB.TabIndex = 0;
            this.FirstNameTB.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameTB_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Презиме";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Корисничко име";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Лозинка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Повтори лозинка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Матичен број";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Трансакциска сметка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Плата";
            // 
            // ManagerCB
            // 
            this.ManagerCB.AutoSize = true;
            this.ManagerCB.Location = new System.Drawing.Point(52, 372);
            this.ManagerCB.Name = "ManagerCB";
            this.ManagerCB.Size = new System.Drawing.Size(71, 17);
            this.ManagerCB.TabIndex = 9;
            this.ManagerCB.Text = "Менаџер";
            this.ManagerCB.UseVisualStyleBackColor = true;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(186, 80);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(239, 20);
            this.LastNameTB.TabIndex = 10;
            this.LastNameTB.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameTB_Validating);
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(186, 121);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(239, 20);
            this.UserNameTB.TabIndex = 11;
            this.UserNameTB.Validating += new System.ComponentModel.CancelEventHandler(this.UserNameTB_Validating);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(186, 162);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(239, 20);
            this.PasswordTB.TabIndex = 12;
            this.PasswordTB.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTB_Validating);
            // 
            // CheckPasswordTB
            // 
            this.CheckPasswordTB.Location = new System.Drawing.Point(186, 203);
            this.CheckPasswordTB.Name = "CheckPasswordTB";
            this.CheckPasswordTB.Size = new System.Drawing.Size(239, 20);
            this.CheckPasswordTB.TabIndex = 13;
            this.CheckPasswordTB.Validating += new System.ComponentModel.CancelEventHandler(this.CheckPasswordTB_Validating);
            // 
            // EMBGTB
            // 
            this.EMBGTB.Location = new System.Drawing.Point(186, 244);
            this.EMBGTB.Name = "EMBGTB";
            this.EMBGTB.Size = new System.Drawing.Size(239, 20);
            this.EMBGTB.TabIndex = 14;
            this.EMBGTB.Validating += new System.ComponentModel.CancelEventHandler(this.EMBGTB_Validating);
            // 
            // TransactionNumberTB
            // 
            this.TransactionNumberTB.Location = new System.Drawing.Point(186, 285);
            this.TransactionNumberTB.Name = "TransactionNumberTB";
            this.TransactionNumberTB.Size = new System.Drawing.Size(239, 20);
            this.TransactionNumberTB.TabIndex = 15;
            this.TransactionNumberTB.Validating += new System.ComponentModel.CancelEventHandler(this.TransactionNumberTB_Validating);
            // 
            // SalaryTB
            // 
            this.SalaryTB.Location = new System.Drawing.Point(186, 326);
            this.SalaryTB.Name = "SalaryTB";
            this.SalaryTB.Size = new System.Drawing.Size(239, 20);
            this.SalaryTB.TabIndex = 16;
            this.SalaryTB.Validating += new System.ComponentModel.CancelEventHandler(this.SalaryTB_Validating);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(52, 407);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(157, 23);
            this.AcceptBtn.TabIndex = 17;
            this.AcceptBtn.Text = "Додади";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(268, 407);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(157, 23);
            this.CancelBtn.TabIndex = 18;
            this.CancelBtn.Text = "Откажи";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // FirstNameEP
            // 
            this.FirstNameEP.ContainerControl = this;
            // 
            // LastNameEP
            // 
            this.LastNameEP.ContainerControl = this;
            // 
            // UserNameEP
            // 
            this.UserNameEP.ContainerControl = this;
            // 
            // PasswordEP
            // 
            this.PasswordEP.ContainerControl = this;
            // 
            // CheckPasswordEP
            // 
            this.CheckPasswordEP.ContainerControl = this;
            // 
            // EMBGEP
            // 
            this.EMBGEP.ContainerControl = this;
            // 
            // TNEP
            // 
            this.TNEP.ContainerControl = this;
            // 
            // SalaryEP
            // 
            this.SalaryEP.ContainerControl = this;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 449);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.SalaryTB);
            this.Controls.Add(this.TransactionNumberTB);
            this.Controls.Add(this.EMBGTB);
            this.Controls.Add(this.CheckPasswordTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.ManagerCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameTB);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPasswordEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMBGEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ManagerCB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox CheckPasswordTB;
        private System.Windows.Forms.TextBox EMBGTB;
        private System.Windows.Forms.TextBox TransactionNumberTB;
        private System.Windows.Forms.TextBox SalaryTB;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ErrorProvider FirstNameEP;
        private System.Windows.Forms.ErrorProvider LastNameEP;
        private System.Windows.Forms.ErrorProvider UserNameEP;
        private System.Windows.Forms.ErrorProvider PasswordEP;
        private System.Windows.Forms.ErrorProvider CheckPasswordEP;
        private System.Windows.Forms.ErrorProvider EMBGEP;
        private System.Windows.Forms.ErrorProvider TNEP;
        private System.Windows.Forms.ErrorProvider SalaryEP;
    }
}