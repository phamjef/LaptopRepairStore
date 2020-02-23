using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{ 
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? RoleID { get; set; }
    public string MobileNumber { get; set; }
    public string MailingAddress { get; set; }
    public string EmailAddress { get; set; }
    public string EmployeeNumber { get; set; }
    public string PWD { get; set; }
    public DateTime JoinDate { get; set; }
    public bool IsActive { get; set; }
}
