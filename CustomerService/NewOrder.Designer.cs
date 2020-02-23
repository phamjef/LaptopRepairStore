namespace CustomerService
{
    partial class NewOrder
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOrderDetails = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDriverType = new System.Windows.Forms.ComboBox();
            this.txtRamSize = new System.Windows.Forms.TextBox();
            this.txtDriverSize = new System.Windows.Forms.TextBox();
            this.txtScreenSize = new System.Windows.Forms.TextBox();
            this.txtModelNumber = new System.Windows.Forms.TextBox();
            this.cbManufacturer = new System.Windows.Forms.ComboBox();
            this.txtOrderDetails = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblActualDeliveryDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblExpectedDeliveryDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabOrderHistory = new System.Windows.Forms.TabPage();
            this.tabPaymentHistory = new System.Windows.Forms.TabPage();
            this.customerSearch = new CustomerSearch();
            this.tabControl1.SuspendLayout();
            this.tabOrderDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOrderDetails);
            this.tabControl1.Controls.Add(this.tabOrderHistory);
            this.tabControl1.Controls.Add(this.tabPaymentHistory);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOrderDetails
            // 
            this.tabOrderDetails.Controls.Add(this.groupBox3);
            this.tabOrderDetails.Controls.Add(this.groupBox2);
            this.tabOrderDetails.Controls.Add(this.groupBox1);
            this.tabOrderDetails.Location = new System.Drawing.Point(4, 22);
            this.tabOrderDetails.Name = "tabOrderDetails";
            this.tabOrderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderDetails.Size = new System.Drawing.Size(768, 440);
            this.tabOrderDetails.TabIndex = 0;
            this.tabOrderDetails.Text = "Order Details";
            this.tabOrderDetails.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDriverType);
            this.groupBox3.Controls.Add(this.txtRamSize);
            this.groupBox3.Controls.Add(this.txtDriverSize);
            this.groupBox3.Controls.Add(this.txtScreenSize);
            this.groupBox3.Controls.Add(this.txtModelNumber);
            this.groupBox3.Controls.Add(this.cbManufacturer);
            this.groupBox3.Controls.Add(this.txtOrderDetails);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(324, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 423);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Laptop Details";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cbDriverType
            // 
            this.cbDriverType.FormattingEnabled = true;
            this.cbDriverType.Location = new System.Drawing.Point(101, 131);
            this.cbDriverType.Name = "cbDriverType";
            this.cbDriverType.Size = new System.Drawing.Size(121, 21);
            this.cbDriverType.TabIndex = 22;
            // 
            // txtRamSize
            // 
            this.txtRamSize.Location = new System.Drawing.Point(101, 164);
            this.txtRamSize.Name = "txtRamSize";
            this.txtRamSize.Size = new System.Drawing.Size(100, 20);
            this.txtRamSize.TabIndex = 21;
            // 
            // txtDriverSize
            // 
            this.txtDriverSize.Location = new System.Drawing.Point(301, 131);
            this.txtDriverSize.Name = "txtDriverSize";
            this.txtDriverSize.Size = new System.Drawing.Size(100, 20);
            this.txtDriverSize.TabIndex = 20;
            // 
            // txtScreenSize
            // 
            this.txtScreenSize.Location = new System.Drawing.Point(101, 97);
            this.txtScreenSize.Name = "txtScreenSize";
            this.txtScreenSize.Size = new System.Drawing.Size(100, 20);
            this.txtScreenSize.TabIndex = 19;
            // 
            // txtModelNumber
            // 
            this.txtModelNumber.Location = new System.Drawing.Point(101, 62);
            this.txtModelNumber.Name = "txtModelNumber";
            this.txtModelNumber.Size = new System.Drawing.Size(100, 20);
            this.txtModelNumber.TabIndex = 18;
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.Location = new System.Drawing.Point(101, 27);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(121, 21);
            this.cbManufacturer.TabIndex = 17;
            // 
            // txtOrderDetails
            // 
            this.txtOrderDetails.Location = new System.Drawing.Point(6, 210);
            this.txtOrderDetails.Name = "txtOrderDetails";
            this.txtOrderDetails.Size = new System.Drawing.Size(435, 207);
            this.txtOrderDetails.TabIndex = 16;
            this.txtOrderDetails.Text = "";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 194);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Description";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 167);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "RAM Size:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(237, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Driver Size:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Driver Type:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Screen Size:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Model Number:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Manufacturer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.lblActualDeliveryDate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblExpectedDeliveryDate);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblOrderDate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(21, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Order Status";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(155, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Is Delivered";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(33, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Is Repaired";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblActualDeliveryDate
            // 
            this.lblActualDeliveryDate.AutoSize = true;
            this.lblActualDeliveryDate.Location = new System.Drawing.Point(178, 154);
            this.lblActualDeliveryDate.Name = "lblActualDeliveryDate";
            this.lblActualDeliveryDate.Size = new System.Drawing.Size(0, 13);
            this.lblActualDeliveryDate.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Actual Delivery Date:";
            // 
            // lblExpectedDeliveryDate
            // 
            this.lblExpectedDeliveryDate.AutoSize = true;
            this.lblExpectedDeliveryDate.Location = new System.Drawing.Point(178, 115);
            this.lblExpectedDeliveryDate.Name = "lblExpectedDeliveryDate";
            this.lblExpectedDeliveryDate.Size = new System.Drawing.Size(0, 13);
            this.lblExpectedDeliveryDate.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Expected Delivery Date:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(178, 32);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(0, 13);
            this.lblOrderDate.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Order Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectCustomer);
            this.groupBox1.Controls.Add(this.lblEmailAddress);
            this.groupBox1.Controls.Add(this.lblMobileNumber);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(138, 32);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCustomer.TabIndex = 8;
            this.btnSelectCustomer.Text = "Click Here";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(130, 102);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(0, 13);
            this.lblEmailAddress.TabIndex = 6;
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(130, 136);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(0, 13);
            this.lblMobileNumber.TabIndex = 7;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(130, 67);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Adddress:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Customer";
            // 
            // tabOrderHistory
            // 
            this.tabOrderHistory.Location = new System.Drawing.Point(4, 22);
            this.tabOrderHistory.Name = "tabOrderHistory";
            this.tabOrderHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderHistory.Size = new System.Drawing.Size(768, 440);
            this.tabOrderHistory.TabIndex = 1;
            this.tabOrderHistory.Text = "Order History";
            this.tabOrderHistory.UseVisualStyleBackColor = true;
            // 
            // tabPaymentHistory
            // 
            this.tabPaymentHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPaymentHistory.Name = "tabPaymentHistory";
            this.tabPaymentHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaymentHistory.Size = new System.Drawing.Size(768, 440);
            this.tabPaymentHistory.TabIndex = 2;
            this.tabPaymentHistory.Text = "Payment History";
            this.tabPaymentHistory.UseVisualStyleBackColor = true;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabOrderDetails.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOrderDetails;
        private System.Windows.Forms.TabPage tabOrderHistory;
        private System.Windows.Forms.TabPage tabPaymentHistory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbManufacturer;
        private System.Windows.Forms.RichTextBox txtOrderDetails;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblActualDeliveryDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblExpectedDeliveryDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDriverType;
        private System.Windows.Forms.TextBox txtRamSize;
        private System.Windows.Forms.TextBox txtDriverSize;
        private System.Windows.Forms.TextBox txtScreenSize;
        private System.Windows.Forms.TextBox txtModelNumber;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSelectCustomer;
        private CustomerSearch customerSearch;
    }
}