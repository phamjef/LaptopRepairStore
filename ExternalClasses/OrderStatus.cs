using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class OrderStatus
{
    public OrderStatus(string statusName, bool isActive)
	{
        this.StatusName = statusName;
        this.IsActive = isActive;
	}
    string StatusName { get; set; }
    bool IsActive { get; set; }
}
