using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Manufacturer
{
	public Manufacturer(string manufacturerName, bool isActive)
	{
        this.ManufacturerName = manufacturerName;
        this.IsActive = isActive;
	}

    public string ManufacturerName { get; set; }
    public bool IsActive { get; set; }

}
