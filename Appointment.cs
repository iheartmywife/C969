using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chermak_PA_C969
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string AppointmentType { get; set; }
        public string URL { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        private static int count = 0;

        public Appointment(MySqlDataReader reader)
        {
            AppointmentID = Convert.ToInt32(reader["appointmentId"]);
            CustomerID = Convert.ToInt32(reader["customerId"]);
            UserID = Convert.ToInt32(reader["userId"]);
            Title = reader["title"].ToString();
            Description = reader["description"].ToString();
            Location = reader["location"].ToString();
            Contact = reader["contact"].ToString();
            AppointmentType = reader["type"].ToString();
            URL = reader["url"].ToString();
            Start = Convert.ToDateTime(reader["start"]).ToLocalTime();
            End = Convert.ToDateTime(reader["end"]).ToLocalTime();
            CreateDate = Convert.ToDateTime(reader["createDate"]).ToLocalTime();
            CreatedBy = reader["createdBy"].ToString();
            LastUpdate = Convert.ToDateTime(reader["lastUpdate"]).ToLocalTime();
            LastUpdateBy = reader["lastUpdateBy"].ToString();
        }
        public string GetSqlInsertQuery()
        {
            string query = $"INSERT INTO `appointment` VALUES ({AppointmentID},{CustomerID}," +
                $"{UserID},'{Title}','{Description}','{Location}','{Contact}','{AppointmentType}','{URL}'," +
                $"'{Start.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}'," +
                $"'{End.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}'," +
                $"'{CreateDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}'," +
                $"'{CreatedBy}','{LastUpdate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}'," +
                $"'{LastUpdateBy}')";
            Console.WriteLine(query);
            return query;
        }
    }
}
