using CustomerService.Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Data
{
    public static class Mapper
    {
        public static EmployeeDTO ToEmployeeDTO(this Employee employee) //extension method. Extending it's functionality 
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();
            if (employee != null)
            {
                employeeDTO.EmployeeID = employee.EmployeeID;
                employeeDTO.FirstName = employee.FirstName;
                employeeDTO.LastName = employee.LastName;
                employeeDTO.RoleID = employee.RoleID;
                employeeDTO.EmailAddress = employee.EmailAddress;
                employeeDTO.PWD = employee.PWD;
                employeeDTO.JoinDate = employee.JoinDate;
                employeeDTO.MobileNumber = employee.MobileNumber;
                employeeDTO.MailingAddress = employee.MailingAddress;
                employeeDTO.IsActive = employee.IsActive;
                
            }
            return employeeDTO;
        }

        public static CustomerDTO ToCustomerDTO(this Customer customer)
        {
            CustomerDTO customerDTO = new CustomerDTO();
            if (customer != null)
            {
                customerDTO.CustomerID = customer.CustomerID;
                customerDTO.FirstName = customer.FirstName;
                customerDTO.LastName = customer.LastName;
                customerDTO.MobileNumber = customer.MobileNumber;
                customerDTO.MailingAddress = customer.MailingAddress;
                customerDTO.EmailAddress = customer.EmailAddress;
                customerDTO.CustRefNum = customer.CustRefNum;
                customer.LoggedBy = customer.LoggedBy;
                customerDTO.LogDate = customer.LogDate;
            }
            return customerDTO;
        }

        public static OrderDTO ToOrderDTO(this Order order)
        {
            OrderDTO orderDTO = new OrderDTO();
            if (orderDTO != null)
            {
                orderDTO.OrderID = order.OrderID;
                orderDTO.CustomerID = order.CustomerID;
                orderDTO.ManufacturerID = order.ManufacturerID;
                orderDTO.ModelNumber = order.ModelNumber;
                orderDTO.Size = order.Size;
                orderDTO.HardDriveType = order.HardDriveType;
                orderDTO.HardDriveSize = order.HardDriveSize;
                orderDTO.RAMSize = order.RAMSize;
                orderDTO.OrderDetails = order.OrderDetails;
                orderDTO.IsRepaired = order.IsRepaired;
                orderDTO.ExpectedDeliveryDate = order.ExpectedDeliveryDate;
                orderDTO.ActualDeliveryDate = order.ActualDeliveryDate;
                orderDTO.IsDelivered = order.IsDelivered;
                orderDTO.TechnicianID = order.TechnicianID;
                orderDTO.LoggedBy = order.LoggedBy;
                orderDTO.LoggedDate = order.LoggedDate;
                orderDTO.TechnicianNotes = order.TechnicianNotes;
            }
            return orderDTO;
        }
    }

    
}
