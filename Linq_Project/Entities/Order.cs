using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Project
{
  public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }

        public List<Order> GetOrders()
        {
            List<Order> list = new List<Order>();
            string query = @"select o.CustomerID , o.EmployeeID, o.OrderID, o.OrderDate , (Select ContactName from Customers where CustomerID=o.CustomerID) AS ContactName from Orders o";
            DataTable dt = GetDataTable(query);
            foreach(DataRow item in dt.Rows)
            {
                Order order = new Order();
                order.OrderID = (int)item["OrderID"];
                order.CustomerID = Convert.ToString(item["CustomerID"]);
                order.EmployeeID = Convert.ToInt32(item["EmployeeID"]);
                order.OrderDate = Convert.ToDateTime(item["OrderDate"]);
                order.Customer = new Customer();
                order.Customer.ContactName = Convert.ToString(item["ContactName"]);
                order.Customer.CustomerID = (string)item["CustomerID"];
                list.Add(order);
            }
            return list;
           
        }

        DataTable GetDataTable(string query)
        {
            string connectionstring = @"Server = (localdb)\MSSQLLocalDB; Database = northwind; Trusted_Connection = True; ";

            

            SqlDataAdapter sda = new SqlDataAdapter(query, connectionstring);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }    
    }
}
