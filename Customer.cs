using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Chermak_PA_C969
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int AddressID { get; set; }
        public int Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }


        public Customer(int customerID, string customerName, int addressID, int active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            AddressID = addressID;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
        //public Customer(string customerName, int addressID, int active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        //{
        //    count++;
        //    CustomerID = count;
        //    CustomerName = customerName;
        //    AddressID = addressID;
        //    Active = active;
        //    CreateDate = createDate;
        //    CreatedBy = createdBy;
        //    LastUpdate = lastUpdate;
        //    LastUpdateBy = lastUpdateBy;
        //}
        public Customer(MySqlDataReader reader)
        {
            CustomerID = Convert.ToInt32(reader["customerId"]);
            CustomerName = reader["customerName"].ToString();
            AddressID = Convert.ToInt32(reader["addressId"]);
            Active = Convert.ToInt32(reader["active"]);
            CreateDate = Convert.ToDateTime(reader["createDate"]).ToLocalTime();
            CreatedBy = reader["createdBy"].ToString();
            LastUpdate = Convert.ToDateTime(reader["lastUpdate"]).ToLocalTime();
            LastUpdateBy = reader["lastUpdateBy"].ToString();
        }
        public string GetSqlInsertQuery()
        {
            string query = $"INSERT INTO `customer` VALUES ({CustomerID}, '{CustomerName}', {AddressID}, {Active}, " +
                $"'{CreateDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{CreatedBy}', " +
                $"'{LastUpdate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{LastUpdateBy}')";
            Console.WriteLine(query);
            return query;
        }
    }
}
