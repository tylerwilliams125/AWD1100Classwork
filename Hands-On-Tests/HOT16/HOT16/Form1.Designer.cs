namespace HOT16
{
    partial class Form1
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
            this.grpManage = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblRemain = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoShortTerm = new System.Windows.Forms.RadioButton();
            this.rdoLongTerm = new System.Windows.Forms.RadioButton();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.grpManage.SuspendLayout();
            this.grpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpManage
            // 
            this.grpManage.Controls.Add(this.btnPay);
            this.grpManage.Controls.Add(this.lblInterest);
            this.grpManage.Controls.Add(this.lblRemain);
            this.grpManage.Controls.Add(this.lblType);
            this.grpManage.Controls.Add(this.lblName);
            this.grpManage.Location = new System.Drawing.Point(84, 351);
            this.grpManage.Name = "grpManage";
            this.grpManage.Size = new System.Drawing.Size(632, 272);
            this.grpManage.TabIndex = 3;
            this.grpManage.TabStop = false;
            this.grpManage.Text = "Manage Loan";
            this.grpManage.Visible = false;
            this.grpManage.Enter += new System.EventHandler(this.grpManage_Enter);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(36, 135);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(131, 29);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Make Payment";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(36, 234);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(0, 20);
            this.lblInterest.TabIndex = 3;
            this.lblInterest.Click += new System.EventHandler(this.lblInterest_Click);
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.Location = new System.Drawing.Point(36, 178);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(0, 20);
            this.lblRemain.TabIndex = 2;
            this.lblRemain.Click += new System.EventHandler(this.lblRemain_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(36, 80);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 20);
            this.lblType.TabIndex = 1;
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(32, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 31);
            this.lblName.TabIndex = 1;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
          
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(192, 103);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(177, 27);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(192, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 27);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // rdoShortTerm
            // 
            this.rdoShortTerm.AutoSize = true;
            this.rdoShortTerm.Location = new System.Drawing.Point(144, 165);
            this.rdoShortTerm.Name = "rdoShortTerm";
            this.rdoShortTerm.Size = new System.Drawing.Size(140, 24);
            this.rdoShortTerm.TabIndex = 2;
            this.rdoShortTerm.TabStop = true;
            this.rdoShortTerm.Text = "Short-Term Loan";
            this.rdoShortTerm.UseVisualStyleBackColor = true;
            this.rdoShortTerm.CheckedChanged += new System.EventHandler(this.rdoShortTerm_CheckedChanged);
            // 
            // rdoLongTerm
            // 
            this.rdoLongTerm.AutoSize = true;
            this.rdoLongTerm.Location = new System.Drawing.Point(144, 204);
            this.rdoLongTerm.Name = "rdoLongTerm";
            this.rdoLongTerm.Size = new System.Drawing.Size(138, 24);
            this.rdoLongTerm.TabIndex = 3;
            this.rdoLongTerm.TabStop = true;
            this.rdoLongTerm.Text = "Long-Term Loan";
            this.rdoLongTerm.UseVisualStyleBackColor = true;
            this.rdoLongTerm.CheckedChanged += new System.EventHandler(this.rdoLongTerm_CheckedChanged);
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Location = new System.Drawing.Point(46, 261);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(102, 29);
            this.btnCreateLoan.TabIndex = 4;
            this.btnCreateLoan.Text = "Create Loan";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(212, 261);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(183, 20);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Please Enter Valid Amount";
            this.lblError.Visible = false;
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.lblError);
            this.grpCreate.Controls.Add(this.btnCreateLoan);
            this.grpCreate.Controls.Add(this.rdoLongTerm);
            this.grpCreate.Controls.Add(this.rdoShortTerm);
            this.grpCreate.Controls.Add(this.txtName);
            this.grpCreate.Controls.Add(this.txtAmount);
            this.grpCreate.Controls.Add(this.label3);
            this.grpCreate.Controls.Add(this.label1);
            this.grpCreate.Controls.Add(this.label2);
            this.grpCreate.Location = new System.Drawing.Point(100, 18);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(567, 317);
            this.grpCreate.TabIndex = 2;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Create Loan";
            this.grpCreate.Enter += new System.EventHandler(this.grpCreate_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 635);
            this.Controls.Add(this.grpManage);
            this.Controls.Add(this.grpCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpManage.ResumeLayout(false);
            this.grpManage.PerformLayout();
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpManage;
        private Button btnPay;
        private Label lblInterest;
        private Label lblRemain;
        private Label lblType;
        private Label lblName;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtAmount;
        private TextBox txtName;
        private RadioButton rdoShortTerm;
        private RadioButton rdoLongTerm;
        private Button btnCreateLoan;
        private Label lblError;
        private GroupBox grpCreate;
    }
}