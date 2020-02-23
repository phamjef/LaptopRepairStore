namespace CustomerService
{
    partial class LaptopRepairStoreParent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaptopRepairStoreParent));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.orderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.orderSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.customerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.customerSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // orderMenu
            // 
            this.orderMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrderStrip,
            this.orderSearchToolStripMenuItem});
            this.orderMenu.Name = "orderMenu";
            this.orderMenu.Size = new System.Drawing.Size(49, 20);
            this.orderMenu.Text = "&Order";
            // 
            // createOrderStrip
            // 
            this.createOrderStrip.Image = ((System.Drawing.Image)(resources.GetObject("createOrderStrip.Image")));
            this.createOrderStrip.ImageTransparentColor = System.Drawing.Color.Black;
            this.createOrderStrip.Name = "createOrderStrip";
            this.createOrderStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.createOrderStrip.Size = new System.Drawing.Size(183, 22);
            this.createOrderStrip.Text = "&Create Order";
            this.createOrderStrip.Click += new System.EventHandler(this.createOrderStrip_Click);
            // 
            // orderSearchToolStripMenuItem
            // 
            this.orderSearchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("orderSearchToolStripMenuItem.Image")));
            this.orderSearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.orderSearchToolStripMenuItem.Name = "orderSearchToolStripMenuItem";
            this.orderSearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.orderSearchToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.orderSearchToolStripMenuItem.Text = "&Search Order";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerMenu,
            this.orderMenu,
            this.administratorToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // customerMenu
            // 
            this.customerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerMenuStrip,
            this.customerSearchToolStripMenuItem,
            this.dashBoardToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.customerMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerMenu.Name = "customerMenu";
            this.customerMenu.Size = new System.Drawing.Size(95, 20);
            this.customerMenu.Text = "&Customer Info";
            // 
            // newCustomerMenuStrip
            // 
            this.newCustomerMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("newCustomerMenuStrip.Image")));
            this.newCustomerMenuStrip.ImageTransparentColor = System.Drawing.Color.Black;
            this.newCustomerMenuStrip.Name = "newCustomerMenuStrip";
            this.newCustomerMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newCustomerMenuStrip.Size = new System.Drawing.Size(196, 22);
            this.newCustomerMenuStrip.Text = "&New Customer";
            this.newCustomerMenuStrip.Click += new System.EventHandler(this.newCustomerMenuStrip_Click);
            // 
            // customerSearchToolStripMenuItem
            // 
            this.customerSearchToolStripMenuItem.Name = "customerSearchToolStripMenuItem";
            this.customerSearchToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.customerSearchToolStripMenuItem.Text = "&Search Customer";
            this.customerSearchToolStripMenuItem.Click += new System.EventHandler(this.customerSearchToolStripMenuItem_Click);
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dashBoardToolStripMenuItem.Image")));
            this.dashBoardToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.dashBoardToolStripMenuItem.Text = "&Dash Board";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.employeeSearchToolStripMenuItem});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addEmployeeToolStripMenuItem.Text = "&Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // employeeSearchToolStripMenuItem
            // 
            this.employeeSearchToolStripMenuItem.Name = "employeeSearchToolStripMenuItem";
            this.employeeSearchToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.employeeSearchToolStripMenuItem.Text = "&Search Employee";
            this.employeeSearchToolStripMenuItem.Click += new System.EventHandler(this.employeeSearchToolStripMenuItem_Click);
            // 
            // LaptopRepairStoreParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "LaptopRepairStoreParent";
            this.Text = "LaptopRepairStoreParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LaptopRepairStoreParent_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem orderMenu;
        private System.Windows.Forms.ToolStripMenuItem createOrderStrip;
        private System.Windows.Forms.ToolStripMenuItem orderSearchToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem customerMenu;
        private System.Windows.Forms.ToolStripMenuItem newCustomerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem customerSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeSearchToolStripMenuItem;
    }
}



