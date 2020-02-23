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
    public partial class CustomerSearch : Form
    {
        private CustomerBusiness _customerBusiness;
        private List<CustomerDTO> _customerDTOs;
        private Helper _helper;
        public delegate void CustomerHandler(CustomerDTO customerDTO);
        public event CustomerHandler CustomerSelected;

        public CustomerSearch()
        {
            
            InitializeComponent();
            _customerBusiness = new CustomerBusiness();
            _helper = new Helper();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            _customerDTOs = new List<CustomerDTO>();
            _customerDTOs = _customerBusiness.GetCustomersByEmailorMobile(txtEmail.Text, txtPhone.Text);
             dtCustomerInfo.DataSource = _helper.GetCustomerDataTable(_customerDTOs); 


        }

        private void dtCustomerInfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && CustomerSelected != null)
            {
                
                string emailAddress = dtCustomerInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
                string mobileNumber = dtCustomerInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
                CustomerSelected(_customerBusiness.GetCustomerByEmailorMobile(emailAddress, mobileNumber));
                this.Hide();
            }
            

        }
    }
}
