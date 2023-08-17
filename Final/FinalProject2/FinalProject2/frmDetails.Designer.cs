namespace FinalProject2
{
    partial class frmDetails
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
            this.pboBook = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPublishYear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnSplash = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pboBook
            // 
            this.pboBook.Location = new System.Drawing.Point(12, 12);
            this.pboBook.Name = "pboBook";
            this.pboBook.Size = new System.Drawing.Size(165, 206);
            this.pboBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboBook.TabIndex = 0;
            this.pboBook.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DarkGray;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(212, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 53);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPublishYear
            // 
            this.lblPublishYear.BackColor = System.Drawing.Color.DarkGray;
            this.lblPublishYear.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPublishYear.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPublishYear.Location = new System.Drawing.Point(519, 22);
            this.lblPublishYear.Name = "lblPublishYear";
            this.lblPublishYear.Size = new System.Drawing.Size(172, 53);
            this.lblPublishYear.TabIndex = 2;
            this.lblPublishYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(212, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 65);
            this.label3.TabIndex = 3;
            this.label3.Text = "By:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.BackColor = System.Drawing.Color.DarkGray;
            this.lblAuthorName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthorName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAuthorName.Location = new System.Drawing.Point(346, 98);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(345, 65);
            this.lblAuthorName.TabIndex = 4;
            this.lblAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAuthorName.Click += new System.EventHandler(this.lblAuthorName_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(212, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 65);
            this.label5.TabIndex = 5;
            this.label5.Text = "ISBN:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblISBN
            // 
            this.lblISBN.BackColor = System.Drawing.Color.DarkGray;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblISBN.ForeColor = System.Drawing.Color.DarkRed;
            this.lblISBN.Location = new System.Drawing.Point(346, 199);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(345, 65);
            this.lblISBN.TabIndex = 6;
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMain.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMain.Location = new System.Drawing.Point(44, 326);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(110, 38);
            this.btnMain.TabIndex = 7;
            this.btnMain.Text = "Main Page";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnSplash
            // 
            this.btnSplash.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSplash.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSplash.Location = new System.Drawing.Point(182, 326);
            this.btnSplash.Name = "btnSplash";
            this.btnSplash.Size = new System.Drawing.Size(100, 38);
            this.btnSplash.TabIndex = 8;
            this.btnSplash.Text = "Splash Page";
            this.btnSplash.UseVisualStyleBackColor = true;
            this.btnSplash.Click += new System.EventHandler(this.btnSplash_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHelp.Location = new System.Drawing.Point(334, 326);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(99, 38);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(502, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDetails
            // 
            this.AcceptButton = this.btnMain;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnHelp;
            this.ClientSize = new System.Drawing.Size(706, 390);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSplash);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPublishYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pboBook);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.frmDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pboBook;
        private Label lblTitle;
        private Label lblPublishYear;
        private Label label3;
        private Label lblAuthorName;
        private Label label5;
        private Label lblISBN;
        private Button btnMain;
        private Button btnSplash;
        private Button btnHelp;
        private Button btnExit;
    }
}