namespace LoginTesting_with_MySql_Dbase
{
    partial class frmAdminMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmployeeRate = new System.Windows.Forms.Button();
            this.btnSalaryDeductions = new System.Windows.Forms.Button();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdminUserAcc = new System.Windows.Forms.Button();
            this.btnEmployeeUserAcc = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnEmployeeRecords = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEmployeeRate);
            this.groupBox1.Controls.Add(this.btnSalaryDeductions);
            this.groupBox1.Controls.Add(this.btnPayroll);
            this.groupBox1.Location = new System.Drawing.Point(29, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Salary";
            // 
            // btnEmployeeRate
            // 
            this.btnEmployeeRate.Location = new System.Drawing.Point(27, 170);
            this.btnEmployeeRate.Name = "btnEmployeeRate";
            this.btnEmployeeRate.Size = new System.Drawing.Size(116, 63);
            this.btnEmployeeRate.TabIndex = 2;
            this.btnEmployeeRate.Text = "Employee Rates";
            this.btnEmployeeRate.UseVisualStyleBackColor = true;
            // 
            // btnSalaryDeductions
            // 
            this.btnSalaryDeductions.Location = new System.Drawing.Point(27, 101);
            this.btnSalaryDeductions.Name = "btnSalaryDeductions";
            this.btnSalaryDeductions.Size = new System.Drawing.Size(116, 63);
            this.btnSalaryDeductions.TabIndex = 1;
            this.btnSalaryDeductions.Text = "Salary Deductions";
            this.btnSalaryDeductions.UseVisualStyleBackColor = true;
            // 
            // btnPayroll
            // 
            this.btnPayroll.Location = new System.Drawing.Point(27, 29);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(116, 63);
            this.btnPayroll.TabIndex = 0;
            this.btnPayroll.Text = "Payroll";
            this.btnPayroll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdminUserAcc);
            this.groupBox2.Controls.Add(this.btnEmployeeUserAcc);
            this.groupBox2.Location = new System.Drawing.Point(398, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Accounts";
            // 
            // btnAdminUserAcc
            // 
            this.btnAdminUserAcc.Location = new System.Drawing.Point(31, 101);
            this.btnAdminUserAcc.Name = "btnAdminUserAcc";
            this.btnAdminUserAcc.Size = new System.Drawing.Size(116, 63);
            this.btnAdminUserAcc.TabIndex = 5;
            this.btnAdminUserAcc.Text = "Admin User Accounts";
            this.btnAdminUserAcc.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeUserAcc
            // 
            this.btnEmployeeUserAcc.Location = new System.Drawing.Point(31, 29);
            this.btnEmployeeUserAcc.Name = "btnEmployeeUserAcc";
            this.btnEmployeeUserAcc.Size = new System.Drawing.Size(116, 63);
            this.btnEmployeeUserAcc.TabIndex = 4;
            this.btnEmployeeUserAcc.Text = "Employee User Accounts";
            this.btnEmployeeUserAcc.UseVisualStyleBackColor = true;
            // 
            // btnAttendance
            // 
            this.btnAttendance.Location = new System.Drawing.Point(241, 50);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(116, 63);
            this.btnAttendance.TabIndex = 2;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnEmployeeRecords
            // 
            this.btnEmployeeRecords.Location = new System.Drawing.Point(241, 122);
            this.btnEmployeeRecords.Name = "btnEmployeeRecords";
            this.btnEmployeeRecords.Size = new System.Drawing.Size(116, 63);
            this.btnEmployeeRecords.TabIndex = 3;
            this.btnEmployeeRecords.Text = "Employee Records";
            this.btnEmployeeRecords.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(429, 231);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 41);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 307);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEmployeeRecords);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance and Payroll  [Records Department] - ADMINISTRATOR";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmployeeRate;
        private System.Windows.Forms.Button btnSalaryDeductions;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdminUserAcc;
        private System.Windows.Forms.Button btnEmployeeUserAcc;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnEmployeeRecords;
        private System.Windows.Forms.Button btnLogout;
    }
}