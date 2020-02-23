namespace CustomerService
{
    partial class NewEmployee
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
            this.EmployeeInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmployeeRoles = new System.Windows.Forms.ComboBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.mobileNumberLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.EmployeeInfoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeInfoGroupBox
            // 
            this.EmployeeInfoGroupBox.Controls.Add(this.label4);
            this.EmployeeInfoGroupBox.Controls.Add(this.dateTimePicker);
            this.EmployeeInfoGroupBox.Controls.Add(this.checkBoxIsActive);
            this.EmployeeInfoGroupBox.Controls.Add(this.txtPassword);
            this.EmployeeInfoGroupBox.Controls.Add(this.label3);
            this.EmployeeInfoGroupBox.Controls.Add(this.label1);
            this.EmployeeInfoGroupBox.Controls.Add(this.cbEmployeeRoles);
            this.EmployeeInfoGroupBox.Controls.Add(this.txtEmailAddress);
            this.EmployeeInfoGroupBox.Controls.Add(this.lblEmailAddress);
            this.EmployeeInfoGroupBox.Controls.Add(this.btnClear);
            this.EmployeeInfoGroupBox.Controls.Add(this.label2);
            this.EmployeeInfoGroupBox.Controls.Add(this.btnSave);
            this.EmployeeInfoGroupBox.Controls.Add(this.lblCustomerID);
            this.EmployeeInfoGroupBox.Controls.Add(this.groupBox1);
            this.EmployeeInfoGroupBox.Controls.Add(this.mobileNumberLabel);
            this.EmployeeInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.EmployeeInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.EmployeeInfoGroupBox.Controls.Add(this.txtFirstName);
            this.EmployeeInfoGroupBox.Controls.Add(this.txtMobileNumber);
            this.EmployeeInfoGroupBox.Controls.Add(this.txtLastName);
            this.EmployeeInfoGroupBox.Location = new System.Drawing.Point(29, 35);
            this.EmployeeInfoGroupBox.Name = "EmployeeInfoGroupBox";
            this.EmployeeInfoGroupBox.Size = new System.Drawing.Size(737, 388);
            this.EmployeeInfoGroupBox.TabIndex = 4;
            this.EmployeeInfoGroupBox.TabStop = false;
            this.EmployeeInfoGroupBox.Text = "Employee Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Join Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(112, 297);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 17;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Location = new System.Drawing.Point(400, 269);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(67, 17);
            this.checkBoxIsActive.TabIndex = 16;
            this.checkBoxIsActive.Text = "Is Active";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(113, 254);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(157, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee Role:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbEmployeeRoles
            // 
            this.cbEmployeeRoles.FormattingEnabled = true;
            this.cbEmployeeRoles.Location = new System.Drawing.Point(113, 211);
            this.cbEmployeeRoles.Name = "cbEmployeeRoles";
            this.cbEmployeeRoles.Size = new System.Drawing.Size(157, 21);
            this.cbEmployeeRoles.TabIndex = 12;
            this.cbEmployeeRoles.SelectedIndexChanged += new System.EventHandler(this.cbEmployeeRoles_SelectedIndexChanged);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(113, 129);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(157, 20);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(31, 132);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.lblEmailAddress.TabIndex = 11;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(552, 317);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "EmployeeID:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(405, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(596, 270);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(23, 13);
            this.lblCustomerID.TabIndex = 9;
            this.lblCustomerID.Text = "null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbState);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lblZipCode);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblAddressLine2);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.txtAddressLine1);
            this.groupBox1.Controls.Add(this.lblAddressLine1);
            this.groupBox1.Location = new System.Drawing.Point(325, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 219);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mailing Address";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(104, 177);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(140, 21);
            this.cbState.TabIndex = 11;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(63, 180);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 14;
            this.lblState.Text = "State:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 20);
            this.textBox2.TabIndex = 10;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(45, 140);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(53, 13);
            this.lblZipCode.TabIndex = 12;
            this.lblZipCode.Text = "Zip Code:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(104, 99);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(236, 20);
            this.txtCity.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(21, 63);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 9;
            this.lblAddressLine2.Text = "Address Line2:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(71, 102);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City:";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(104, 23);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(236, 20);
            this.txtAddressLine1.TabIndex = 7;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(21, 26);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 7;
            this.lblAddressLine1.Text = "Address Line1:";
            // 
            // mobileNumberLabel
            // 
            this.mobileNumberLabel.AutoSize = true;
            this.mobileNumberLabel.Location = new System.Drawing.Point(23, 172);
            this.mobileNumberLabel.Name = "mobileNumberLabel";
            this.mobileNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.mobileNumberLabel.TabIndex = 5;
            this.mobileNumberLabel.Text = "Mobile Number :";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(46, 90);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(44, 48);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(63, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(113, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(157, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(113, 169);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(157, 20);
            this.txtMobileNumber.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(113, 87);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(157, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.EmployeeInfoGroupBox);
            this.Name = "NewEmployee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NewEmployee_Load);
            this.EmployeeInfoGroupBox.ResumeLayout(false);
            this.EmployeeInfoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EmployeeInfoGroupBox;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label mobileNumberLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmployeeRoles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
    }
}