namespace LoginTesting_with_MySql_Dbase
{
    partial class frmAttendance
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
            this.txtTimeIn = new System.Windows.Forms.TextBox();
            this.btnTimeIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTimeIn
            // 
            this.txtTimeIn.Location = new System.Drawing.Point(42, 84);
            this.txtTimeIn.Multiline = true;
            this.txtTimeIn.Name = "txtTimeIn";
            this.txtTimeIn.Size = new System.Drawing.Size(124, 30);
            this.txtTimeIn.TabIndex = 0;
            // 
            // btnTimeIn
            // 
            this.btnTimeIn.Location = new System.Drawing.Point(42, 41);
            this.btnTimeIn.Name = "btnTimeIn";
            this.btnTimeIn.Size = new System.Drawing.Size(93, 37);
            this.btnTimeIn.TabIndex = 1;
            this.btnTimeIn.Text = "TIME IN";
            this.btnTimeIn.UseVisualStyleBackColor = true;
            this.btnTimeIn.Click += new System.EventHandler(this.btnTimeIn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "TIME OUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(42, 178);
            this.txtTimeOut.Multiline = true;
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(124, 30);
            this.txtTimeOut.TabIndex = 2;
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.btnTimeIn);
            this.Controls.Add(this.txtTimeIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAttendance";
            this.Text = "Attendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimeIn;
        private System.Windows.Forms.Button btnTimeIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTimeOut;
    }
}