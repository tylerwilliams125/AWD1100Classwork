namespace EX1
{
    partial class frmHOTGUIArray
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(242, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(85, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(272, 235);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(126, 41);
            this.btnSalary.TabIndex = 3;
            this.btnSalary.Text = "Search By Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(272, 182);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(120, 31);
            this.btnLast.TabIndex = 2;
            this.btnLast.Text = "Search By Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(272, 119);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(120, 29);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "Search By First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(138, 126);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(100, 22);
            this.txtFirst.TabIndex = 6;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(138, 182);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(100, 22);
            this.txtLast.TabIndex = 7;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(138, 235);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(138, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(70, 235);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(49, 16);
            this.lblSalary.TabIndex = 11;
            this.lblSalary.Text = "Salary:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(70, 182);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(35, 16);
            this.lblLast.TabIndex = 10;
            this.lblLast.Text = "Last:";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(70, 126);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(35, 16);
            this.lblFirst.TabIndex = 9;
            this.lblFirst.Text = "First:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(135, 34);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(203, 16);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "First Name, Last Name, or Salary";
            // 
            // frmHOTGUIArray
            // 
            this.AcceptButton = this.btnFirst;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(518, 414);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblSearch);
            this.Name = "frmHOTGUIArray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSearch;
    }
}

