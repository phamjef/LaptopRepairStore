using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CustomerService.Entity.DTO;

namespace CustomerService.Data
{
    
    public class OrderData
    {
        private string _connectionString;
        private List<OrderDTO> orders;
        private string _selectStatement;
        private OrderDTO orderDTO;
        public OrderData()
        {
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LAPTOPREPAIRSTORE"].ConnectionString;
        }

        public OrderDTO GetOrderByOrderID(int orderID)
        {
            using (SqlConnection sqlconnection = new SqlConnection(_connectionString))
            {
                if (sqlconnection.State == ConnectionState.Closed)
                    sqlconnection.Open();

                using (SqlCommand sqlcommand = new SqlCommand($"SELECT MODELNUMBER, SIZE, HARDDRIVETYPE, HARDDRIVESIZE, RAMSIZE, ORDERDETAILS, ISREPAIRED, ORDERDATE, EXPECTEDDELIVERYDATE, ACTUALDELIVERYDATE, ISDELIVERED, TECHNICIANID, LOGGEDBY, LOGDATE, TECHNICIANNOTES FROM ORDERS WHERE ORDERID = '{orderID}'", sqlconnection))
                {
                    IDataReader dataReader = sqlcommand.ExecuteReader();

                    Order order = new Order();

                    while(dataReader.Read())
                    {
                        order.OrderID = int.Parse(dataReader["ORDERID"].ToString());
                        order.CustomerID = (string.IsNullOrWhiteSpace(dataReader["CUSTOMERID"].ToString()) ? 0 : int.Parse(dataReader["CUSTOMERID"].ToString()));
                        order.ManufacturerID = (string.IsNullOrWhiteSpace(dataReader["MANUFACTERERID"].ToString()) ? 0 : int.Parse(dataReader["MANUFACTURERID"].ToString()));
                        order.ModelNumber = dataReader["MODELNUMBER"].ToString();
                        order.Size = (string.IsNullOrWhiteSpace(dataReader["SIZE"].ToString()) ? 0 : int.Parse(dataReader["SIZE"].ToString())); 
                        order.HardDriveType = dataReader["HARDDRIVETYPE"].ToString();
                        order.HardDriveSize = (string.IsNullOrWhiteSpace(dataReader["HARDRIVESIZE"].ToString()) ? 0 : int.Parse(dataReader["HARDDRIVESIZE"].ToString()));
                        order.RAMSize = (string.IsNullOrWhiteSpace(dataReader["RAMSIZE"].ToString()) ? 0 : int.Parse(dataReader["RAMSIZE"].ToString()));
                        order.OrderDetails = dataReader["ORDERDETAILS"].ToString();
                        order.IsRepaired = bool.Parse(dataReader["ISREPAIRED"].ToString());
                        order.ExpectedDeliveryDate = DateTime.Parse(dataReader["EXPECTEDDELIVERYDATE"].ToString());
                        order.ActualDeliveryDate = DateTime.Parse(dataReader["ACTUALDELIVERYDATE"].ToString());
                        order.IsDelivered = bool.Parse(dataReader["ISDELIVERED"].ToString());
                        order.TechnicianID = (string.IsNullOrWhiteSpace(dataReader["TECHNICIANID"].ToString()) ? 0 : int.Parse(dataReader["TECHNICIANID"].ToString()));
                        order.LoggedBy = dataReader["LOGGEDBY"].ToString();
                        order.LoggedDate = DateTime.Parse(dataReader["LOGGEDDATE"].ToString());

                    }
                    return order.ToOrderDTO();

                }


                
            }
        }
        public List<OrderDTO> GetOrdersByOrderID(int orderID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand($"SELECT ORDERID, CUSTOMERID, MANUFACTERERID, MODELNUMBER, SIZE, HARDDRIVETYPE, HARDDRIVESIZE, RAMSIZE, ORDERDETAILS, ISREPAIRED, ORDERDATE, EXPECTEDDELIVERYDATE, ACTUALDELIVERYDATE, ISDELIVERED, TECHNICIANID, LOGGEDBY, LOGDATE, TECHNICIANNOTES WHERE ORDERID = '{orderID}'", sqlConnection))
                {
                    IDataReader dataReader = sqlCommand.ExecuteReader();

                    orders = new List<OrderDTO>();
                    orderDTO = new OrderDTO();

                    while (dataReader.Read())
                    {
                        orderDTO.OrderID = int.Parse(dataReader["ORDERID"].ToString());
                        orderDTO.CustomerID = int.Parse(dataReader["CustomerID"].ToString());
                        orderDTO.ManufacturerID = int.Parse(dataReader["ManufactererID"].ToString());
                        orderDTO.ModelNumber = dataReader["MODELNUMBER"].ToString();
                        orderDTO.Size = int.Parse(dataReader["SIZE"].ToString());
                        orderDTO.HardDriveType = dataReader["HARDDRIVETYPE"].ToString();
                        orderDTO.HardDriveSize = int.Parse(dataReader["HARDDRIVESIZE"].ToString());
                        orderDTO.RAMSize = int.Parse(dataReader["RAMSIZE"].ToString());
                        orderDTO.OrderDetails = dataReader["ORDERDETAILS"].ToString();
                        orderDTO.IsRepaired = bool.Parse(dataReader["ISREPAIRED"].ToString());
                        orderDTO.ExpectedDeliveryDate = DateTime.Parse(dataReader["EXPECTEDDELIVERYDATE"].ToString());
                        orderDTO.ActualDeliveryDate = DateTime.Parse(dataReader["ACTUALDELIVERYDATE"].ToString());
                        orderDTO.IsDelivered = bool.Parse(dataReader["ISDELIVERED"].ToString());
                        orderDTO.TechnicianID = int.Parse(dataReader["TECHNICIANID"].ToString());
                        orderDTO.LoggedBy = dataReader["LOGGEDBY"].ToString();
                        orderDTO.LoggedDate = DateTime.Parse(dataReader["LOGGEDDATE"].ToString());
                        orderDTO.TechnicianNotes = dataReader["TECHNICIANNOTES"].ToString();
                        orders.Add(orderDTO);
                    }

                    return orders;
                }
            }
        }

        public OrderDTO InsertOrderInformation(OrderDTO order)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand($"UPDATE ORDERS (MODELNUMBER, SIZE, HARDDRIVETYPE, HARDDRIVESIZE, RAMSIZE, ORDERDETAILS, ISREPAIRED, ORDERDATE, EXPECTEDDELIVERYDATE, ACTUALDELIVERYDATE, ISDELIVERED, TECHNICIANID, LOGGEDBY, LOGDATE, TECHNICIANNOTES) VALUES ('{order.ModelNumber}','{order.Size}','{order.HardDriveType}','{order.HardDriveSize}','{order.RAMSize}','{order.OrderDetails}','{order.IsRepaired}','{order.ExpectedDeliveryDate}','{order.ActualDeliveryDate}','{order.IsDelivered}','{order.LoggedBy}','{order.LoggedDate}','{order.TechnicianNotes}')", sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
                return GetOrderByOrderID(order.OrderID);
      
            }
        }
        public OrderDTO UpdateOrderInformation(OrderDTO order)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand($"UPDAT ORDERS (MODELNUMBER, SIZE, HARDDRIVETYPE, HARDDRIVESIZE, RAMSIZE, ORDERDETAILS, ISREPAIRED, ORDERDATE, EXPECTEDDELIVERYDATE, ACTUALDELIVERYDATE, ISDELIVERED, TECHNICIANID, LOGGEDBY, LOGDATE, TECHNICIANNOTES) VALUES ('{order.ModelNumber}','{order.Size}','{order.HardDriveType}','{order.HardDriveSize}','{order.RAMSize}','{order.OrderDetails}','{order.IsRepaired}','{order.ExpectedDeliveryDate}','{order.ActualDeliveryDate}','{order.IsDelivered}','{order.LoggedBy}','{order.LoggedDate}','{order.TechnicianNotes}')", sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
                return GetOrderByOrderID(order.OrderID);
            }
        }

        





    }
}
