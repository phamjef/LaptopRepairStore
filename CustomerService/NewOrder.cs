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
    public partial class NewOrder : Form
    {
        private OrderBusiness _orderBusiness;
        public NewOrder()
        {
            _orderBusiness = new OrderBusiness();
            InitializeComponent();
        }
        private void NewOrder_Load(object sender, EventArgs e)
        {
            customerSearch.CustomerSelected += new CustomerSearch.CustomerHandler(GetCustomerInformation); 
            
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            customerSearch.Show();
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void GetCustomerInformation(CustomerDTO customer)
        {
           
            lblCustomerName.Text = customer.FirstName + " " + customer.LastName;
            lblEmailAddress.Text = customer.EmailAddress;
            lblMobileNumber.Text = customer.MobileNumber;


        }
    }

}
