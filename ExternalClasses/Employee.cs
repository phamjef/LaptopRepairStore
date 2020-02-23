using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Employee
{
    public Employee(string firstName, string lastName, string employeeNumber )
	{
        this.FirstName = firstName;
        this.LastName = lastName;
        this.EmployeeNumber = employeeNumber;
	}
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmployeeNumber { get; set; }
    public string EmailAddress { get; set; }
    public string PWD { get; set; }
    public DateTime JoinDate { get; set; }
    public string MobileNumber { get; set; }
    public bool IsActive { get; set; }
}
