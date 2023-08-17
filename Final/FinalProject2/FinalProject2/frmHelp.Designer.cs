namespace FinalProject2
{
    partial class frmHelp
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
            this.lblHelpText = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnSplash = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelpText
            // 
            this.lblHelpText.AutoSize = true;
            this.lblHelpText.BackColor = System.Drawing.Color.Black;
            this.lblHelpText.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHelpText.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHelpText.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblHelpText.Location = new System.Drawing.Point(12, 23);
            this.lblHelpText.Name = "lblHelpText";
            this.lblHelpText.Size = new System.Drawing.Size(0, 20);
            this.lblHelpText.TabIndex = 0;
            this.lblHelpText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHelpText.Click += new System.EventHandler(this.lblHelpText_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMain.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMain.Location = new System.Drawing.Point(157, 514);
            this.btnMain.Margin = new System.Windows.Forms.Padding(2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(107, 46);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Main Page";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnSplash
            // 
            this.btnSplash.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSplash.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSplash.Location = new System.Drawing.Point(416, 514);
            this.btnSplash.Margin = new System.Windows.Forms.Padding(2);
            this.btnSplash.Name = "btnSplash";
            this.btnSplash.Size = new System.Drawing.Size(140, 46);
            this.btnSplash.TabIndex = 2;
            this.btnSplash.Text = "Splash Page";
            this.btnSplash.UseVisualStyleBackColor = true;
            this.btnSplash.Click += new System.EventHandler(this.btnSplash_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(722, 519);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 41);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1046, 599);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSplash);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblHelpText);
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Help";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHelpText;
        private Button btnMain;
        private Button btnSplash;
        private Button btnExit;
    }
}