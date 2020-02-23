using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Entity.DTO
{
    public class CustomerDTO
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string MailingAddress { get; set; }
        public string EmailAddress { get; set; }
        public string CustRefNum { get; set; }
        public string LoggedBy { get; set; }
        public DateTime LogDate { get; set; }
    }
}
