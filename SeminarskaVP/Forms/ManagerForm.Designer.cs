namespace SeminarskaVP.Forms
{
    partial class ManagerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SignedInEmployeeSBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.EmployeesBtn = new System.Windows.Forms.Button();
            this.ReceiptsBtn = new System.Windows.Forms.Button();
            this.StockBtn = new System.Windows.Forms.Button();
            this.FinanceBtn = new System.Windows.Forms.Button();
            this.SignOutBtn = new System.Windows.Forms.Button();
            this.MainDG = new System.Windows.Forms.DataGridView();
            this.ReceiptTotalLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.DeleteEmployeeBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignedInEmployeeSBL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(762, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SignedInEmployeeSBL
            // 
            this.SignedInEmployeeSBL.Name = "SignedInEmployeeSBL";
            this.SignedInEmployeeSBL.Size = new System.Drawing.Size(124, 17);
            this.SignedInEmployeeSBL.Text = "SignedInEmployeeSBL";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(192, 377);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // EmployeesBtn
            // 
            this.EmployeesBtn.Location = new System.Drawing.Point(30, 44);
            this.EmployeesBtn.Name = "EmployeesBtn";
            this.EmployeesBtn.Size = new System.Drawing.Size(132, 46);
            this.EmployeesBtn.TabIndex = 3;
            this.EmployeesBtn.Text = "Вработени";
            this.EmployeesBtn.UseVisualStyleBackColor = true;
            this.EmployeesBtn.Click += new System.EventHandler(this.EmployeesBtn_Click);
            // 
            // ReceiptsBtn
            // 
            this.ReceiptsBtn.Location = new System.Drawing.Point(30, 114);
            this.ReceiptsBtn.Name = "ReceiptsBtn";
            this.ReceiptsBtn.Size = new System.Drawing.Size(132, 46);
            this.ReceiptsBtn.TabIndex = 4;
            this.ReceiptsBtn.Text = "Сметки";
            this.ReceiptsBtn.UseVisualStyleBackColor = true;
            this.ReceiptsBtn.Click += new System.EventHandler(this.ReceiptsBtn_Click);
            // 
            // StockBtn
            // 
            this.StockBtn.Location = new System.Drawing.Point(30, 185);
            this.StockBtn.Name = "StockBtn";
            this.StockBtn.Size = new System.Drawing.Size(132, 46);
            this.StockBtn.TabIndex = 5;
            this.StockBtn.Text = "Магацин";
            this.StockBtn.UseVisualStyleBackColor = true;
            this.StockBtn.Click += new System.EventHandler(this.StockBtn_Click);
            // 
            // FinanceBtn
            // 
            this.FinanceBtn.Location = new System.Drawing.Point(30, 254);
            this.FinanceBtn.Name = "FinanceBtn";
            this.FinanceBtn.Size = new System.Drawing.Size(132, 46);
            this.FinanceBtn.TabIndex = 6;
            this.FinanceBtn.Text = "Финансии";
            this.FinanceBtn.UseVisualStyleBackColor = true;
            this.FinanceBtn.Click += new System.EventHandler(this.FinanceBtn_Click);
            // 
            // SignOutBtn
            // 
            this.SignOutBtn.Location = new System.Drawing.Point(30, 324);
            this.SignOutBtn.Name = "SignOutBtn";
            this.SignOutBtn.Size = new System.Drawing.Size(132, 46);
            this.SignOutBtn.TabIndex = 7;
            this.SignOutBtn.Text = "Одјави се";
            this.SignOutBtn.UseVisualStyleBackColor = true;
            this.SignOutBtn.Click += new System.EventHandler(this.SignOutBtn_Click);
            // 
            // MainDG
            // 
            this.MainDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDG.Location = new System.Drawing.Point(240, 44);
            this.MainDG.MultiSelect = false;
            this.MainDG.Name = "MainDG";
            this.MainDG.ReadOnly = true;
            this.MainDG.Size = new System.Drawing.Size(471, 256);
            this.MainDG.TabIndex = 8;
            // 
            // ReceiptTotalLabel
            // 
            this.ReceiptTotalLabel.AutoSize = true;
            this.ReceiptTotalLabel.Location = new System.Drawing.Point(614, 303);
            this.ReceiptTotalLabel.Name = "ReceiptTotalLabel";
            this.ReceiptTotalLabel.Size = new System.Drawing.Size(94, 13);
            this.ReceiptTotalLabel.TabIndex = 9;
            this.ReceiptTotalLabel.Text = "ReceiptTotalLabel";
            this.ReceiptTotalLabel.Visible = false;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(617, 302);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(72, 13);
            this.BalanceLabel.TabIndex = 10;
            this.BalanceLabel.Text = "BalanceLabel";
            this.BalanceLabel.Visible = false;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(240, 324);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(73, 46);
            this.AddEmployee.TabIndex = 11;
            this.AddEmployee.Text = "Додади Вработен";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // DeleteEmployeeBtn
            // 
            this.DeleteEmployeeBtn.Location = new System.Drawing.Point(339, 324);
            this.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            this.DeleteEmployeeBtn.Size = new System.Drawing.Size(73, 46);
            this.DeleteEmployeeBtn.TabIndex = 12;
            this.DeleteEmployeeBtn.Text = "Избриши Вработен";
            this.DeleteEmployeeBtn.UseVisualStyleBackColor = true;
            this.DeleteEmployeeBtn.Click += new System.EventHandler(this.DeleteEmployeeBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(437, 324);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(73, 46);
            this.AddProductBtn.TabIndex = 13;
            this.AddProductBtn.Text = "Додади во магацин";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 423);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.DeleteEmployeeBtn);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.ReceiptTotalLabel);
            this.Controls.Add(this.MainDG);
            this.Controls.Add(this.SignOutBtn);
            this.Controls.Add(this.FinanceBtn);
            this.Controls.Add(this.StockBtn);
            this.Controls.Add(this.ReceiptsBtn);
            this.Controls.Add(this.EmployeesBtn);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SignedInEmployeeSBL;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button ReceiptsBtn;
        private System.Windows.Forms.Button StockBtn;
        private System.Windows.Forms.Button FinanceBtn;
        private System.Windows.Forms.Button SignOutBtn;
        private System.Windows.Forms.Button EmployeesBtn;
        private System.Windows.Forms.DataGridView MainDG;
        private System.Windows.Forms.Label ReceiptTotalLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button DeleteEmployeeBtn;
        private System.Windows.Forms.Button AddProductBtn;
    }
}