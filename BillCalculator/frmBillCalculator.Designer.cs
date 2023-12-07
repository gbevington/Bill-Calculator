namespace Lab2Fixed
{
    partial class frmBillCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddToDB = new Button();
            txtAccNum = new TextBox();
            txtKwh = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            txtAvgBillAmount = new TextBox();
            txtKwhUsed = new TextBox();
            txtNumOfCust = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listExistingCust = new ListBox();
            btnAcctGen = new Button();
            SuspendLayout();
            // 
            // btnAddToDB
            // 
            btnAddToDB.Location = new Point(579, 237);
            btnAddToDB.Name = "btnAddToDB";
            btnAddToDB.Size = new Size(166, 23);
            btnAddToDB.TabIndex = 0;
            btnAddToDB.Text = "Add To Database";
            btnAddToDB.UseVisualStyleBackColor = true;
            btnAddToDB.Click += btnAddToDB_Click;
            // 
            // txtAccNum
            // 
            txtAccNum.Location = new Point(607, 110);
            txtAccNum.Name = "txtAccNum";
            txtAccNum.Size = new Size(100, 23);
            txtAccNum.TabIndex = 1;
            // 
            // txtKwh
            // 
            txtKwh.Location = new Point(607, 197);
            txtKwh.Name = "txtKwh";
            txtKwh.Size = new Size(100, 23);
            txtKwh.TabIndex = 2;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(607, 168);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(100, 23);
            txtLName.TabIndex = 3;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(607, 139);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(100, 23);
            txtFName.TabIndex = 4;
            // 
            // txtAvgBillAmount
            // 
            txtAvgBillAmount.Location = new Point(171, 356);
            txtAvgBillAmount.Name = "txtAvgBillAmount";
            txtAvgBillAmount.ReadOnly = true;
            txtAvgBillAmount.Size = new Size(100, 23);
            txtAvgBillAmount.TabIndex = 5;
            // 
            // txtKwhUsed
            // 
            txtKwhUsed.Location = new Point(171, 316);
            txtKwhUsed.Name = "txtKwhUsed";
            txtKwhUsed.ReadOnly = true;
            txtKwhUsed.Size = new Size(100, 23);
            txtKwhUsed.TabIndex = 6;
            // 
            // txtNumOfCust
            // 
            txtNumOfCust.Location = new Point(171, 278);
            txtNumOfCust.Name = "txtNumOfCust";
            txtNumOfCust.ReadOnly = true;
            txtNumOfCust.Size = new Size(100, 23);
            txtNumOfCust.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 316);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 8;
            label1.Text = "Total kWh Used:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 356);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 9;
            label2.Text = "Average Bill Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 278);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 10;
            label3.Text = "Total # of Customers:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(521, 110);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 11;
            label4.Text = "Account #:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(521, 139);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 12;
            label5.Text = "First Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(521, 168);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 13;
            label6.Text = "Last Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(521, 197);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 14;
            label7.Text = "kWh Used:";
            // 
            // listExistingCust
            // 
            listExistingCust.FormattingEnabled = true;
            listExistingCust.ItemHeight = 15;
            listExistingCust.Location = new Point(45, 39);
            listExistingCust.Name = "listExistingCust";
            listExistingCust.Size = new Size(424, 199);
            listExistingCust.TabIndex = 17;
            // 
            // btnAcctGen
            // 
            btnAcctGen.Location = new Point(730, 110);
            btnAcctGen.Name = "btnAcctGen";
            btnAcctGen.Size = new Size(140, 23);
            btnAcctGen.TabIndex = 18;
            btnAcctGen.Text = "Generate Account #";
            btnAcctGen.UseVisualStyleBackColor = true;
            btnAcctGen.Click += btnAcctGen_Click;
            // 
            // frmBillCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 450);
            Controls.Add(btnAcctGen);
            Controls.Add(listExistingCust);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumOfCust);
            Controls.Add(txtKwhUsed);
            Controls.Add(txtAvgBillAmount);
            Controls.Add(txtFName);
            Controls.Add(txtLName);
            Controls.Add(txtKwh);
            Controls.Add(txtAccNum);
            Controls.Add(btnAddToDB);
            Name = "frmBillCalculator";
            Text = "Bill Calculator";
            Load += frmBillCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddToDB;
        private TextBox txtAccNum;
        private TextBox txtKwh;
        private TextBox txtLName;
        private TextBox txtFName;
        private TextBox txtAvgBillAmount;
        private TextBox txtKwhUsed;
        private TextBox txtNumOfCust;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listExistingCust;
        private Button btnAcctGen;
    }
}