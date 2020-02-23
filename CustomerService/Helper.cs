using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CustomerService.Entity.DTO;


namespace CustomerService
{
    public class Helper
    {
        public DataTable GetCustomerDataTable(List<CustomerDTO> customerDTOs)
        {
            DataTable customerTable = new DataTable("CustomerInfo");

            customerTable.Columns.Add("Customer Ref Num", typeof(System.String));
            customerTable.Columns.Add("Customer Name", typeof(System.String));
            customerTable.Columns.Add("Email Address", typeof(System.String));
            customerTable.Columns.Add("Mobile Number", typeof(System.String));
            //to-do : add MailAddress
            foreach (CustomerDTO customer in customerDTOs)
            {
                DataRow dataRow = customerTable.NewRow();
                dataRow["Customer Ref Num"] = customer.CustRefNum;
                dataRow["Customer Name"] = customer.FirstName + " " + customer.LastName;
                dataRow["Email Address"] = customer.EmailAddress;
                dataRow["Mobile Number"] = customer.MobileNumber;
                customerTable.Rows.Add(dataRow);
            }
            return customerTable;
        }

        public DataTable GetEmployeeDataTable(List<EmployeeDTO> employeeDTOs)
        {
            DataTable employeeTable = new DataTable("EmployeeInfo");

            employeeTable.Columns.Add("Employee Number", typeof(System.String));
            employeeTable.Columns.Add("Employee Name", typeof(System.String));
            employeeTable.Columns.Add("Email Address", typeof(System.String));
            employeeTable.Columns.Add("Mobile Number", typeof(System.String));
            employeeTable.Columns.Add("IsActive", typeof(System.Boolean));

            foreach (EmployeeDTO employee in employeeDTOs)
            {
                DataRow dataRow = employeeTable.NewRow();
                dataRow["Employee Number"] = employee.EmployeeNumber;
                dataRow["Employee Name"] = employee.FirstName + " " + employee.LastName;
                dataRow["Email Address"] = employee.EmailAddress;
                dataRow["Mobile Number"] = employee.MobileNumber;
                dataRow["Is Active"] = employee.IsActive;

            }
            return employeeTable;

        }





    }

    public class ButtonHandler
    {
        
        public event EventHandler buttonClick; 
        
       // public void clickButton()
       // {
       //     buttonClick(); // button implementation 
       // }
    

        public void abc(object sender, EventArgs e)
        {
           
        }

        
    }
}

