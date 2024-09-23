using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chermak_PA_C969
{
    public class City
    {
        public int CityID { get; }
        public string CityName { get; }
        public int CountryID { get; }
        public DateTime CreateDate { get; }
        public string CreatedBy { get; }
        public DateTime LastUpdate { get; }
        public string LastUpdateBy { get; }
        
        public City(int cityID, string cityName, int countryID, DateTime createDate,  string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CityID = cityID;
            CityName = cityName;
            CountryID = countryID;
            CreateDate = createDate;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
        public City(MySqlDataReader reader)
        {
            CityID = Convert.ToInt32(reader["cityId"]);
            CityName = reader["city"].ToString();
            CountryID = Convert.ToInt32(reader["countryId"]);
            CreateDate = Convert.ToDateTime(reader["createDate"]).ToLocalTime();
            CreatedBy = reader["createdBy"].ToString();
            LastUpdate = Convert.ToDateTime(reader["lastUpdate"]).ToLocalTime();
            LastUpdateBy = reader["lastUpdateBy"].ToString();
        }
    }
}
