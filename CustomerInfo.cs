using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chermak_PA_C969
{
    public class CustomerInfo
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public CustomerInfo(MySqlDataReader reader)
        {
            CustomerName = reader["customerName"].ToString();
            Address = reader["address"].ToString();
            PhoneNumber = reader["phone"].ToString();
            City = reader["city"].ToString();
            Country = reader["country"].ToString();
        }
    }
}
