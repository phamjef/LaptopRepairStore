using CustomerService.Data;
using CustomerService.Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Business
{
    public class EmployeeBusiness
    {
        private string _roleName;
        private List<string> _employeeRoles;
        private EmployeeData _employeeData;


        public EmployeeBusiness()
        {
            _employeeData = new EmployeeData();
        }

        public bool ValidateCredentials(string emailAddress, string password)
        {
            if (string.IsNullOrWhiteSpace(emailAddress) == true || string.IsNullOrWhiteSpace(password) == true)
                return false;

            EmployeeDTO employeeDTO = _employeeData.GetEmployeeByEmail(emailAddress);

            if (employeeDTO != null && employeeDTO.EmailAddress == emailAddress && employeeDTO.PWD == password)
                return true;
            else
                return false;
        }

        public bool ValidateNewEmployee(EmployeeDTO newEmployee)
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();

            employeeDTO = GetEmployeeByEmail(newEmployee.EmailAddress);

            if (newEmployee.EmailAddress == employeeDTO.EmailAddress)
                return false;
            else
                return true;
        }

        public EmployeeDTO GetEmployeeByEmail(string emailAddress)
        {
            EmployeeDTO employeeDTO = _employeeData.GetEmployeeByEmail(emailAddress);
            return employeeDTO;
        }
        public string GetRoleNameByID(int? roleID)
        {
            if (roleID <= 0)
                return null;

            _roleName = _employeeData.GetRoleNameByID(roleID);
            return _roleName;
        }

        public List<string> GetEmployeeRoles()
        {
            _employeeRoles = _employeeData.GetEmployeeRoles();
            return _employeeRoles;

        }

        // to:do create save/update function
        public EmployeeDTO SaveEmployeeInformation(EmployeeDTO employee)
        {
            if (_employeeData.GetEmployeeByEmail(employee.EmailAddress)?.EmployeeID > 0)
                return _employeeData.UpdateEmployeeInfo(employee);
            else
                return _employeeData.InsertEmployeeInfo(employee);
        }

    }
}
