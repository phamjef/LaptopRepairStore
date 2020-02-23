using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Order
{
    public Order(string modelNumber)
    {
        this.ModelNumber = modelNumber;
    }

    string ModelNumber { get; set; }
    int Size { get; set; }
    string HardDriveType { get; set; }
    int HardDriveSize { get; set; }
    int RAMSize { get; set; }
    string OrderDetails { get; set; }
    DateTime ExpectedDeliveryDate { get; set; }
    DateTime ActualDeliveryDate { get; set; }
    bool IsDelivered { get; set; }
    string LoggedBy { get; set; }
    DateTime LoggedDate {get; set;}
    string TechnicianNotes { get; set; }
}
