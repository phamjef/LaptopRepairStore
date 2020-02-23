using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerService.Entity.DTO;

namespace CustomerService.Business
{
    public class BusinessHelper
    {
        public static string LoggedInEmployeeEmailAddress {get; set;}
        public static CustomerDTO SelectedCustomerEmailAddress {get; set;}

    }
}
