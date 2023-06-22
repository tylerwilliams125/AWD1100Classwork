namespace HOT4
{
    partial class Form1
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.pbCard = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rchMessage = new System.Windows.Forms.RichTextBox();
            this.chkMessage = new System.Windows.Forms.CheckBox();
            this.chkStamp = new System.Windows.Forms.CheckBox();
            this.chkEnvelope = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.cboOccasion = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(548, 357);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(119, 398);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 29);
            this.lblCost.TabIndex = 11;
            // 
            // pbCard
            // 
            this.pbCard.BackColor = System.Drawing.SystemColors.Control;
            this.pbCard.Location = new System.Drawing.Point(381, 27);
            this.pbCard.Name = "pbCard";
            this.pbCard.Size = new System.Drawing.Size(387, 378);
            this.pbCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCard.TabIndex = 21;
            this.pbCard.TabStop = false;
            this.pbCard.Click += new System.EventHandler(this.pbCard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cost:";
            // 
            // rchMessage
            // 
            this.rchMessage.Location = new System.Drawing.Point(43, 226);
            this.rchMessage.Name = "rchMessage";
            this.rchMessage.Size = new System.Drawing.Size(276, 160);
            this.rchMessage.TabIndex = 5;
            this.rchMessage.Text = "";
            this.rchMessage.Visible = false;
            this.rchMessage.TextChanged += new System.EventHandler(this.rchMessage_TextChanged);
            // 
            // chkMessage
            // 
            this.chkMessage.AutoSize = true;
            this.chkMessage.Location = new System.Drawing.Point(43, 200);
            this.chkMessage.Name = "chkMessage";
            this.chkMessage.Size = new System.Drawing.Size(176, 20);
            this.chkMessage.TabIndex = 4;
            this.chkMessage.Text = "Custom Message ($0.30)";
            this.chkMessage.UseVisualStyleBackColor = true;
            this.chkMessage.CheckedChanged += new System.EventHandler(this.chkMessage_CheckedChanged);
            // 
            // chkStamp
            // 
            this.chkStamp.AutoSize = true;
            this.chkStamp.Location = new System.Drawing.Point(43, 165);
            this.chkStamp.Name = "chkStamp";
            this.chkStamp.Size = new System.Drawing.Size(110, 20);
            this.chkStamp.TabIndex = 3;
            this.chkStamp.Text = "Stamp ($0.50)";
            this.chkStamp.UseVisualStyleBackColor = true;
            this.chkStamp.CheckedChanged += new System.EventHandler(this.chkStamp_CheckedChanged);
            // 
            // chkEnvelope
            // 
            this.chkEnvelope.AutoSize = true;
            this.chkEnvelope.Location = new System.Drawing.Point(43, 126);
            this.chkEnvelope.Name = "chkEnvelope";
            this.chkEnvelope.Size = new System.Drawing.Size(129, 20);
            this.chkEnvelope.TabIndex = 2;
            this.chkEnvelope.Text = "Envelope ($0.25)";
            this.chkEnvelope.UseVisualStyleBackColor = true;
            this.chkEnvelope.CheckedChanged += new System.EventHandler(this.chkEnvelope_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Occasion";
            // 
            // cboStyle
            // 
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(115, 75);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(121, 24);
            this.cboStyle.TabIndex = 1;
            this.cboStyle.SelectedIndexChanged += new System.EventHandler(this.cboStyle_SelectedIndexChanged);
            // 
            // cboOccasion
            // 
            this.cboOccasion.FormattingEnabled = true;
            this.cboOccasion.Location = new System.Drawing.Point(115, 24);
            this.cboOccasion.Name = "cboOccasion";
            this.cboOccasion.Size = new System.Drawing.Size(121, 24);
            this.cboOccasion.TabIndex = 0;
            this.cboOccasion.SelectedIndexChanged += new System.EventHandler(this.cboOccasion_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(583, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(473, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(593, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.pbCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rchMessage);
            this.Controls.Add(this.chkMessage);
            this.Controls.Add(this.chkStamp);
            this.Controls.Add(this.chkEnvelope);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.cboOccasion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.PictureBox pbCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rchMessage;
        private System.Windows.Forms.CheckBox chkMessage;
        private System.Windows.Forms.CheckBox chkStamp;
        private System.Windows.Forms.CheckBox chkEnvelope;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.ComboBox cboOccasion;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHome;
    }
}

