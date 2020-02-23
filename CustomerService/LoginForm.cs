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
    
    public partial class LoginForm : Form
    { 
        private EmployeeBusiness _employeeBusiness = new EmployeeBusiness();
        public LoginForm()
        {
            InitializeComponent();
        }

        


        private void LoginForm_Load(object sender, EventArgs e)
        {
           // userControl11.LoggedIn += new UserControl1.LoggedInHandler(LoggedInAction); // we are binding the method to the delegate. This delegate will be raised by the event.
            //delegate is a function pointer. This line of code will be written in user code. 
        }
        public void LoggedInAction(bool isSuccessful)
        {
            MessageBox.Show("hello");
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (_employeeBusiness.ValidateCredentials(txtEmailAddress.Text, txtPassword.Text))
            {
                BusinessHelper.LoggedInEmployeeEmailAddress = txtEmailAddress.Text;
                LaptopRepairStoreParent laptopRepairStoreParent = new LaptopRepairStoreParent();
                
                
                //LoggedIn(true); //method was never given to the delegate so this will crash
                this.Hide();
                laptopRepairStoreParent.Show();
                
            }
            else
            {
                MessageBox.Show("Your login info is incorrect.");
                
                //LoggedIn(false); //please call this specific event
            }
               
                

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
