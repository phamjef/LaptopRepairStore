using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Customer
{
	public Customer ()
	{

	}

    public int CustomerID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MobileNumber { get; set; }
    public string EmailAddress { get; set; }
    public string CustRefNum { get; set; }
    public string InsertedBy { get; set; }
    public DateTime InsertedDate { get; set; }

}
