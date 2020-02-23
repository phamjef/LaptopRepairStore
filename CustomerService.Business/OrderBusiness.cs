using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerService.Data;
using CustomerService.Entity.DTO;

namespace CustomerService.Business
{
    //to-do create data-layer for Orders
    

    public class OrderBusiness
    {
        private OrderData _orderData;
        private OrderDTO _orderDTO;
        public OrderBusiness()
        {
            _orderData = new OrderData();
          
        }
        public OrderDTO GetOrderByOrderID(int orderID)
        {
            return _orderData.GetOrderByOrderID(orderID);
            
        }

        public OrderDTO SaveOrderInformation(OrderDTO order)
        {
            EmployeeDTO employeeDTO = (new EmployeeBusiness()).GetEmployeeByEmail(BusinessHelper.LoggedInEmployeeEmailAddress);
            order.LoggedBy = employeeDTO.FirstName + " " + employeeDTO.LastName;
            if (_orderData.GetOrderByOrderID(order.OrderID).OrderID > 0)
                return _orderData.UpdateOrderInformation(order);
            else
                return _orderData.InsertOrderInformation(order);
        }
        
    }
}
