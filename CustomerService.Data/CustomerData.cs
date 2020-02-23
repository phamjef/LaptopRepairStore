using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CustomerService.Entity.DTO;


namespace CustomerService.Data
{
    public class CustomerData
    {
        private string _connectionstring;
        private string _selectStatement;
        private List<CustomerDTO> _customers;
        public CustomerData()
        {
            _connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["LAPTOPREPAIRSTORE"].ConnectionString;
        }

        public CustomerDTO GetCustomerByName(string firstname, string lastname, string emailAddress)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionstring))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand($"SELECT CUSTOMERID, FIRSTNAME, LASTNAME, MOBILENUMBER, MAILADDRESS, EMAILADDRESS, CUSTREFNUM, LOGGEDBY, LOGDATE FROM CUSTOMERS WHERE FIRSTNAME = '{firstname}' AND LASTNAME = '{lastname}' AND EMAILADDRESS ='{emailAddress}'", sqlConnection))
                {
                    IDataReader dataReader = sqlCommand.ExecuteReader();

                    Customer customer = new Customer();

                    while (dataReader.Read())
                    {
                        customer.CustomerID = int.Parse(dataReader["CUSTOMERID"].ToString());
                        customer.FirstName = dataReader["FIRSTNAME"].ToString();
                        customer.LastName = dataReader["LASTNAME"].ToString();
                        customer.MobileNumber = dataReader["MOBILENUMBER"].ToString();
                        customer.MailingAddress = dataReader["MAILADDRESS"].ToString();
                        customer.EmailAddress = dataReader["EMAILADDRESS"].ToString();
                        customer.CustRefNum = dataReader["CUSTREFNUM"].ToString();
                        customer.LoggedBy = dataReader["LOGGEDBY"].ToString();
                        customer.LogDate = DateTime.Parse(dataReader["LOGDATE"].ToString());
                    }
                    return customer.ToCustomerDTO();
                }

            }

        }

        public List<CustomerDTO> GetCustomersByEmailOrMobile(string emailAddress, string mobileNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionstring))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                _selectStatement = "SELECT CUSTOMERID, FIRSTNAME, LASTNAME, MOBILENUMBER, MAILADDRESS, EMAILADDRESS, CUSTREFNUM, LOGGEDBY, LOGDATE FROM CUSTOMERS WHERE ";

                if (string.IsNullOrWhiteSpace(emailAddress) && string.IsNullOrWhiteSpace(mobileNumber))
                    return null;
                else if (!string.IsNullOrWhiteSpace(emailAddress) && string.IsNullOrWhiteSpace(mobileNumber))
                    _selectStatement += $"EMAILADDRESS LIKE '%{emailAddress}%'";
                else if (string.IsNullOrWhiteSpace(emailAddress) && !string.IsNullOrWhiteSpace(mobileNumber))
                    _selectStatement += $"MOBILENUMBER LIKE '%{mobileNumber}%'";
                else
                    _selectStatement += $"EMAILADDRESS LIKE '%{emailAddress}%' AND MOBILENUMBER LIKE '%{mobileNumber}%'";


                using (SqlCommand sqlCommand = new SqlCommand(_selectStatement, sqlConnection))
                {
                    IDataReader dataReader = sqlCommand.ExecuteReader();

                    Customer customer = new Customer();

                    _customers = new List<CustomerDTO>();

                    while (dataReader.Read())
                    {
                        customer.CustomerID = int.Parse(dataReader["CUSTOMERID"].ToString());
                        customer.FirstName = dataReader["FIRSTNAME"].ToString();
                        customer.LastName = dataReader["LASTNAME"].ToString();
                        customer.MobileNumber = dataReader["MOBILENUMBER"].ToString();
                        customer.MailingAddress = dataReader["MAILADDRESS"].ToString();
                        customer.EmailAddress = dataReader["EMAILADDRESS"].ToString();
                        customer.CustRefNum = dataReader["CUSTREFNUM"].ToString();
                        customer.LoggedBy = dataReader["LOGGEDBY"].ToString();
                        customer.LogDate = DateTime.Parse(dataReader["LOGDATE"].ToString());

                        _customers.Add(customer.ToCustomerDTO());
                    }

                    return _customers;
                }
            }
        }

        public CustomerDTO GetCustomerByEmailorMobile(string emailAddress, string mobileNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionstring))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                _selectStatement = $"SELECT CUSTOMERID, FIRSTNAME, LASTNAME, MOBILENUMBER, MAILADDRESS, EMAILADDRESS, CUSTREFNUM, LOGGEDBY, LOGDATE FROM CUSTOMERS WHERE ";

                if (string.IsNullOrWhiteSpace(emailAddress) && string.IsNullOrWhiteSpace(mobileNumber))
                    return null;
                else if (!string.IsNullOrWhiteSpace(emailAddress) && string.IsNullOrWhiteSpace(mobileNumber))
                    _selectStatement += $"EMAILADDRESS LIKE '%{emailAddress}%'";
                else if (string.IsNullOrWhiteSpace(emailAddress) && !string.IsNullOrWhiteSpace(mobileNumber))
                    _selectStatement += $"MOBILENUMBER LIKE '%{mobileNumber}%;";
                else if (!string.IsNullOrWhiteSpace(emailAddress) && !string.IsNullOrWhiteSpace(mobileNumber))
                    _selectStatement += $"EMAILADDRESS LIKE '%{emailAddress}%' AND MOBILENUMBER LIKE '%{mobileNumber}%'";

                    using (SqlCommand sqlCommand = new SqlCommand(_selectStatement, sqlConnection))
                    {
                        IDataReader dataReader = sqlCommand.ExecuteReader();

                        Customer customer = new Customer();

                        while (dataReader.Read())
                        {
                            customer.CustomerID = int.Parse(dataReader["CUSTOMERID"].ToString());
                            customer.FirstName = dataReader["FIRSTNAME"].ToString();
                            customer.LastName = dataReader["LASTNAME"].ToString();
                            customer.MobileNumber = dataReader["MOBILENUMBER"].ToString();
                            customer.MailingAddress = dataReader["MAILADDRESS"].ToString();
                            customer.EmailAddress = dataReader["EMAILADDRESS"].ToString();
                            customer.CustRefNum = dataReader["CUSTREFNUM"].ToString();
                            customer.LoggedBy = dataReader["LOGGEDBY"].ToString();
                            customer.LogDate = DateTime.Parse(dataReader["LOGDATE"].ToString());
                        }

                        return customer.ToCustomerDTO();

                    }
            }
        }


        public CustomerDTO InsertCustomerInfo(CustomerDTO customer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionstring))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand($"INSERT INTO CUSTOMERS (FIRSTNAME, LASTNAME, MOBILENUMBER, MAILADDRESS, EMAILADDRESS, CUSTREFNUM, LOGGEDBY, LOGDATE) Values ('{customer.FirstName}', '{customer.LastName}', '{customer.MobileNumber}', '{customer.MailingAddress}', '{customer.EmailAddress}', '{customer.CustRefNum}', '{customer.LoggedBy}', '{customer.LogDate}')", sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }

                return GetCustomerByName(customer.FirstName, customer.LastName, customer.EmailAddress);
            }
        }

        public CustomerDTO UpdateCustomerInfo(CustomerDTO customer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionstring))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand($"UPDATE CUSTOMERS (FIRSTNAME, LASTNAME, MOBILENUMBER, MAILADDRESS, EMAILADDRESS, LOGGEDBY, LOGDATE) Values ('{customer.FirstName}', '{customer.LastName}', '{customer.MobileNumber}', '{customer.MailingAddress}', '{customer.EmailAddress}', '{customer.LoggedBy}', '{customer.LogDate}')", sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }

                return GetCustomerByName(customer.FirstName, customer.LastName, customer.EmailAddress);
            }
        }


    }
}

