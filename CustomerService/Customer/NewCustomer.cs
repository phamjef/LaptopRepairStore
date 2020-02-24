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
    public partial class NewCustomer : Form
    {
        private CustomerBusiness _customerBusiness;
        private CustomerDTO _customerDTO;
        private bool _isCustomerValid;
        
        public NewCustomer()
        {
            InitializeComponent();
            _customerBusiness = new CustomerBusiness();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mobileNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _customerDTO = new CustomerDTO();

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) == true || string.IsNullOrWhiteSpace(txtLastName.Text) == true || string.IsNullOrWhiteSpace(txtEmailAddress.Text) == true || string.IsNullOrWhiteSpace(txtMobileNumber.Text))
            {
                MessageBox.Show("Please fill in the required fields"); //to-do : UI label names should change colors if empty
                return;
            }
            //to-do : test functionality
            //to-do : later add Mailing Address
            _customerDTO.FirstName = txtFirstName.Text;
            _customerDTO.LastName = txtLastName.Text;
            _customerDTO.EmailAddress = txtEmailAddress.Text;
            _customerDTO.MobileNumber = txtMobileNumber.Text;
            _customerDTO.CustRefNum = CustomerBusiness.CreateCustRefNum(10);
            //_customerDTO.LoggedBy = 
            _customerDTO.LogDate = DateTime.Now;


            //to-do : create a function that generates a customerID = 8 digit/number
            _isCustomerValid = _customerBusiness.ValidateNewCustomer(_customerDTO);
            if (_isCustomerValid)
            {
                _customerBusiness.SaveCustomerInformation(_customerDTO);
                MessageBox.Show("Customer information has been saved.");
            }
            else
                MessageBox.Show("This customer account already exists.");
        }

        private void customerInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
