using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Entity.DTO
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public int? CustomerID { get; set; }
        public int? ManufacturerID { get; set; }
        public string ModelNumber { get; set; }
        public int? Size { get; set; }
        public string HardDriveType { get; set; }
        public int? HardDriveSize { get; set; }
        public int? RAMSize { get; set; }
        public string OrderDetails { get; set; }
        public bool IsRepaired { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public DateTime ActualDeliveryDate { get; set; }
        public bool IsDelivered { get; set; }
        public int? TechnicianID { get; set; }
        public string LoggedBy { get; set; }
        public DateTime LoggedDate { get; set; }
        public string TechnicianNotes { get; set; }
    }
}
