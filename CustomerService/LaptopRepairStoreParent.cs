using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerService.Business;
using CustomerService.Entity.DTO;

namespace CustomerService
{
    public partial class LaptopRepairStoreParent : Form
    {
        private int childFormNumber = 0;
     
        
        public LaptopRepairStoreParent()
        {

            //LoginForm loginForm = new LoginForm();
            //_employeeBusiness = new EmployeeBusiness();
            //employeeDTO = _employeeBusiness.GetEmployeeByEmail(LoginForm.EmployeeEmailAddress);
            InitializeComponent();
        }
        
        //public static EmployeeDTO employeeDTO { get; set; }

        private void ShowNewForm(object sender, EventArgs e)
        {

        }





        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LaptopRepairStoreParent_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void customerSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerSearch customerSearch = new CustomerSearch();
            customerSearch.MdiParent = this;
            customerSearch.Text = "Window " + childFormNumber++;
            customerSearch.Show();
        }

        private void newCustomerMenuStrip_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomerForm = new NewCustomer();
            newCustomerForm.MdiParent = this;
            newCustomerForm.Text = "Window " + childFormNumber++;
            newCustomerForm.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEmployee newEmployeeForm = new NewEmployee();
            newEmployeeForm.MdiParent = this;
            newEmployeeForm.Text = "Window " + childFormNumber++;
            newEmployeeForm.Show();
        }

        private void employeeSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createOrderStrip_Click(object sender, EventArgs e)
        {
            NewOrder newOrderForm = new NewOrder();
            newOrderForm.MdiParent = this;
            newOrderForm.Text = "New Order";
            newOrderForm.Show();

        }
    }
}
