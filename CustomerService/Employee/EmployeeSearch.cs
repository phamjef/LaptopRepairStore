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

namespace CustomerService
{
    public partial class EmployeeSearch : Form
    {
        private EmployeeBusiness _employeeBusiness;
        public EmployeeSearch()
        {
            InitializeComponent();
            _employeeBusiness = new EmployeeBusiness();
        
        }

        private void EmployeeSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
