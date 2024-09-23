using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chermak_PA_C969
{
    public class User
    {
        public int UserID;
        public string UserName;
        public string Password;
        public int Active;
        public DateTime CreateDate;
        public string CreatedBy;
        public DateTime LastUpdate;
        public string LastUpdateBy;

        public User(int userID, string userName, string password, int active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
        public User(MySqlDataReader reader)
        {
            UserID = Convert.ToInt32(reader["userId"]);
            UserName = reader["userName"].ToString();
            Password = reader["password"].ToString();
            Active = Convert.ToInt32(reader["active"]);
            CreateDate = Convert.ToDateTime(reader["createDate"]).ToLocalTime();
            CreatedBy = reader["createdBy"].ToString();
            LastUpdate = Convert.ToDateTime(reader["lastUpdate"]).ToLocalTime();
            LastUpdateBy = reader["lastUpdateBy"].ToString();
        }
    }
}
