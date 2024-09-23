using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chermak_PA_C969
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CityID { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdatedBy { get; set; }

        private static int count = 0;

        public Address(int addressID, string address1, string address2, int cityID, string postalCode, string phoneNumber, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            AddressID = addressID;
            if (addressID > count)
            {
                count = addressID;
            }
            Address1 = address1;
            Address2 = address2;
            CityID = cityID;
            PostalCode = postalCode;
            PhoneNumber = phoneNumber;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdatedBy;
        }
        public Address(string address1, string address2, int cityID, string postalCode, string phoneNumber, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            count++;
            AddressID = count;
            Address1 = address1;
            Address2 = address2;
            CityID = cityID;
            PostalCode = postalCode;
            PhoneNumber = phoneNumber;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdatedBy;
        }
        public Address(MySqlDataReader reader)
        {
            AddressID = Convert.ToInt32(reader["addressId"]);
            Address1 = reader["address"].ToString();
            Address2 = reader["address2"].ToString();
            CityID = Convert.ToInt32(reader["cityId"]);
            PostalCode = reader["postalCode"].ToString();
            PhoneNumber = reader["phone"].ToString();
            CreateDate = Convert.ToDateTime(reader["createDate"]).ToLocalTime();
            CreatedBy = reader["createdBy"].ToString();
            LastUpdate = Convert.ToDateTime(reader["lastUpdate"]).ToLocalTime();
            LastUpdatedBy = reader["lastUpdateBy"].ToString();
        }
    }
}
