using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chermak_PA_C969
{
    public class Country
    {
        public int CountryID { get; }
        public string CountryName { get; }
        public DateTime CreateDate { get; }
        public string CreatedBy { get; }
        public DateTime LastUpdate { get; }
        public string LastUpdatedBy { get; }

        public Country(int countryID, string countryName, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            CountryID = countryID;
            CountryName = countryName;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdatedBy;
        }
        public Country(MySqlDataReader reader)
        {
            CountryID = Convert.ToInt32(reader["countryId"]);
            CountryName = reader["country"].ToString();
            CreateDate = Convert.ToDateTime(reader["createDate"]).ToLocalTime();
            CreatedBy = reader["createdBy"].ToString();
            LastUpdate = Convert.ToDateTime(reader["lastUpdate"]).ToLocalTime();
            LastUpdatedBy = reader["lastUpdateBy"].ToString();
        }
    }
}
