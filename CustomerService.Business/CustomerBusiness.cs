using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CustomerService.Data;
using CustomerService.Entity.DTO;

namespace CustomerService.Business
{
    public class CustomerBusiness
    {
        private CustomerData _customerData;
        private List<CustomerDTO> _customerDTOs;
        private static Random random;
        private CustomerDTO _customerDTO;

        public CustomerBusiness()
        {
            _customerData = new CustomerData();
            _customerDTOs = new List<CustomerDTO>();
            _customerDTO = new CustomerDTO();
            
        }
        //to-do : check to see if we can make business methods static
        //if so, removie object declaration
        public bool ValidateNewCustomer(CustomerDTO newCustomer)
        {
            
            CustomerDTO customerDTO = new CustomerDTO(); 
            
            customerDTO = _customerData.GetCustomerByName(newCustomer.FirstName, newCustomer.LastName ,newCustomer.EmailAddress);

            if (newCustomer.EmailAddress == customerDTO.EmailAddress)
                return false;
            else
                return true;
            
        }
        public List<CustomerDTO> GetCustomersByEmailorMobile(string emailAddress, string mobileNumber)
        {
            _customerDTOs = _customerData.GetCustomersByEmailOrMobile(emailAddress, mobileNumber);
            return _customerDTOs;
            
        }

        public CustomerDTO GetCustomerByEmailorMobile(string emailAddress, string mobileNumber)
        {
            _customerDTO = _customerData.GetCustomerByEmailorMobile(emailAddress, mobileNumber);
            return _customerDTO;
        }

        public CustomerDTO SaveCustomerInformation(CustomerDTO customer)
        {
            var employeeDTO = (new EmployeeBusiness()).GetEmployeeByEmail(BusinessHelper.LoggedInEmployeeEmailAddress);
            customer.LoggedBy = employeeDTO.FirstName + " " + employeeDTO.LastName;
            if (_customerData.GetCustomerByEmailorMobile(customer.EmailAddress, customer.MobileNumber)?.CustomerID > 0)
                return _customerData.UpdateCustomerInfo(customer);
            else
                return _customerData.InsertCustomerInfo(customer);
        }

        public static string CreateCustRefNum(int numLength)
        {
            
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int charslength = chars.Length;
            StringBuilder stringBuilder = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i< numLength; i++ )
            {
                stringBuilder.Append(chars[rand.Next(0, charslength-1)]);
            }
            return stringBuilder.ToString();

        }
       

  

       


    }
}
