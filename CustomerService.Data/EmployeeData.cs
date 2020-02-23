using CustomerService.Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CustomerService.Data
{
    public class EmployeeData
    {
        private string _connectionString;
        private string _roleName;
        
        private List<EmployeeDTO> _employees;
        private List<string> _employeeRoles;
        public EmployeeData()
        {
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LAPTOPREPAIRSTORE"].ConnectionString;
        }

        public EmployeeDTO GetEmployeeByEmail(string emailAddress)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand($"SELECT EMPLOYEEID, FIRSTNAME, LASTNAME, ROLEID, EMPLOYEENUMBER, EMAILADDRESS, PWD, JOINDATE, MOBILENUMBER, MAILADDRESS, ISACTIVE FROM EMPLOYEES WHERE EMAILADDRESS = '{emailAddress}'", sqlConnection))
                {
                    IDataReader dataReader = sqlCommand.ExecuteReader();

                    Employee employee = new Employee();

                    while (dataReader.Read())
                    {
                        employee.EmployeeID = int.Parse(dataReader["EMPLOYEEID"].ToString());
                        employee.FirstName = dataReader["FIRSTNAME"].ToString();
                        employee.LastName = dataReader["LASTNAME"].ToString();
                        employee.RoleID = (string.IsNullOrWhiteSpace(dataReader["ROLEID"].ToString())  ? 0 : int.Parse(dataReader["ROLEID"].ToString()));
                        employee.EmployeeNumber = dataReader["EMPLOYEENUMBER"].ToString();
                        employee.EmailAddress = dataReader["EmailAddress"].ToString(); 
                        employee.PWD = dataReader["PWD"].ToString();
                        employee.JoinDate = DateTime.Parse(dataReader["JOINDATE"].ToString());
                        employee.MobileNumber = dataReader["MOBILENUMBER"].ToString();
                        employee.MailingAddress = dataReader["MAILADDRESS"].ToString();
                        employee.IsActive = bool.Parse(dataReader["ISACTIVE"].ToString());
                    }
                    return employee.ToEmployeeDTO();
                    
                }
            }
        }

        public List<EmployeeDTO> GetEmployeeByEmailOrMobile(string emailAddress, string mobileNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                string _selectstatement = "SELECT EMPLOYEEID, FIRSTNAME, LASTNAME, ROLEID, EMPLOYEENUMBER, EMAILADDRESS, PWD, JOINDATE, MOBILENUMBER, MAILADDRESS, ISACTIVE FROM EMPLOYEES";
                if (string.IsNullOrWhiteSpace(emailAddress) && string.IsNullOrWhiteSpace(mobileNumber))
                    return null;
                else if (!string.IsNullOrWhiteSpace(emailAddress) && string.IsNullOrWhiteSpace(mobileNumber))
                    _selectstatement += $" WHERE EMAILADDRESS LIKE '%{emailAddress}%'";
                else if (string.IsNullOrWhiteSpace(emailAddress) && !string.IsNullOrWhiteSpace(mobileNumber))
                    _selectstatement += $" WHERE MOBILENUMBER LIKE '%{mobileNumber}%'";
                else
                    _selectstatement += $" WHERE EMAILADDRESS LIKE '%{emailAddress}%' AND MOBILENUMBER LIKE '%{mobileNumber}%'";

                using (SqlCommand sqlCommand = new SqlCommand(_selectstatement, sqlConnection))
                {
                    IDataReader dataReader = sqlCommand.ExecuteReader();

                    Employee employee = new Employee();

                    _employees = new List<EmployeeDTO>();

                    while (dataReader.Read())
                    {
                        employee.EmployeeID = int.Parse(dataReader["EMPLOYEEID"].ToString());
                        employee.FirstName = dataReader["FIRSTNAME"].ToString();
                        employee.LastName = dataReader["LASTNAME"].ToString();
                        employee.RoleID = int.Parse(dataReader["ROLEID"].ToString());
                        employee.EmployeeNumber = dataReader["EMPLOYEENUMBER"].ToString();
                        employee.EmailAddress = dataReader["EMAILADDRESS"].ToString();
                        employee.PWD = dataReader["PWD"].ToString();
                        employee.JoinDate = DateTime.Parse(dataReader["JOINDATE"].ToString());
                        employee.MobileNumber = dataReader["MOBILENUMBER"].ToString();
                        employee.IsActive = Boolean.Parse(dataReader["ISACTIVE"].ToString());
                        
                    }

                    return _employees;
                }
            }
        }

        public string GetRoleNameByID(int? roleID)
        {
            if (roleID == null)
                return null;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                using(SqlCommand sqlCommand = new SqlCommand($"SELECT ROLENAME FROM ROLES WHERE ROLEID = '{roleID}'", sqlConnection))
                {
                    IDataReader dataReader = sqlCommand.ExecuteReader();

                    while(dataReader.Read())
                    {
                        _roleName = dataReader["ROLENAME"].ToString();
                    }
                }
                return _roleName;
            }
        } 

        public List<string> GetEmployeeRoles()
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand($"SELECT ROLENAME FROM ROLES", sqlConnection))
                {
                    IDataReader dataReader = sqlCommand.ExecuteReader();

                    _employeeRoles = new List<string>();
                    
                    while(dataReader.Read())
                    {
                        _roleName = dataReader["ROLENAME"].ToString();
                        _employeeRoles.Add(_roleName);
                    }
                    return _employeeRoles;
                }
            }
        }

        public EmployeeDTO InsertEmployeeInfo(EmployeeDTO employee)
        {

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand($"INSERT INTO EMPLOYEES (FIRSTNAME, LASTNAME, ROLEID, EMPLOYEENUMBER, EMAILADDRESS, PWD, JOINDATE, MOBILENUMBER, MAILADDRESS, ISACTIVE) VALUES ('{employee.FirstName}', '{employee.LastName}','{employee.RoleID}','{employee.EmployeeNumber}','{employee.EmailAddress}','{employee.PWD}','{employee.JoinDate}','{employee.MobileNumber}','{employee.MailingAddress}','{employee.IsActive}')", sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
                return GetEmployeeByEmail(employee.EmailAddress);
            }
        }

        public EmployeeDTO UpdateEmployeeInfo(EmployeeDTO employee)
        {

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand($"UPDATE EMPLOYEES (FIRSTNAME, LASTNAME, ROLEID, EMAILADDRESS, PWD, JOINDATE, MOBILENUMBER, MAILADDRESS, ISACTIVE) VALUES ('{employee.FirstName}', '{employee.LastName}','{employee.RoleID}','{employee.EmailAddress}','{employee.PWD}','{employee.JoinDate}','{employee.MobileNumber}','{employee.MailingAddress}','{employee.IsActive}')", sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
                return GetEmployeeByEmail(employee.EmailAddress);
            }
        }
    }
}
