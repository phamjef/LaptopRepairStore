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



    public partial class NewEmployee : Form
    {
        private EmployeeBusiness _employeeBusiness;
        private bool _isEmployeeValid;
       
        public NewEmployee()
        {
            InitializeComponent();
            _employeeBusiness = new EmployeeBusiness();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            List<string> employeeRoles = _employeeBusiness.GetEmployeeRoles();
            foreach (string roles in employeeRoles)
            {
                cbEmployeeRoles.Items.Add(roles);
            }
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeDTO _employeeDTO = new EmployeeDTO();

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) == true || string.IsNullOrWhiteSpace(txtLastName.Text) == true || string.IsNullOrWhiteSpace(txtEmailAddress.Text) == true || string.IsNullOrWhiteSpace(txtMobileNumber.Text))
            {
                MessageBox.Show("Please fill in the required fields");
                return;
            }

            _employeeDTO.FirstName = txtFirstName.Text;
            _employeeDTO.LastName = txtLastName.Text;
            _employeeDTO.EmailAddress = txtEmailAddress.Text;
            _employeeDTO.MobileNumber = txtMobileNumber.Text;
            _employeeDTO.EmployeeNumber = "temporary";
            _employeeDTO.RoleID = cbEmployeeRoles.SelectedIndex + 1;
            _employeeDTO.PWD = txtPassword.Text;
            _employeeDTO.JoinDate = dateTimePicker.Value;
            _employeeDTO.IsActive = checkBoxIsActive.Checked;

            _isEmployeeValid = _employeeBusiness.ValidateNewEmployee(_employeeDTO);
            if (_isEmployeeValid)
            {
                _employeeBusiness.SaveEmployeeInformation(_employeeDTO);
                MessageBox.Show("Employee information has been saved");
            }
            else
                MessageBox.Show("This employee already exists.");

            
        }

        private void cbEmployeeRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

  
}
