using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Chermak_PA_C969
{
    public class Database
    {
        
        //public static List<User> getAllUsers()
        //{
        //    List<User> listOfUsers = new List<User>();
        //    string query = "SELECT * FROM user";

        //    SQLConnection.Open();
        //    MySqlCommand cmd = new MySqlCommand(query, SQLConnection);
        //    MySqlDataReader dataReader = cmd.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        int userID = Convert.ToInt32(dataReader[0]);
        //        string userName = dataReader[1].ToString();
        //        string password = dataReader[2].ToString();
        //        int active = Convert.ToInt32(dataReader[3]);
        //        DateTime createDate = Convert.ToDateTime(dataReader[4]).ToLocalTime();
        //        string createdBy = dataReader[5].ToString();
        //        DateTime lastUpdate = Convert.ToDateTime(dataReader[6]).ToLocalTime();
        //        string lastUpdateBy = dataReader[7].ToString();

        //        listOfUsers.Add(new User(userID, userName, password, active, createDate, createdBy, lastUpdate, lastUpdateBy));
        //    }

        //    SQLConnection.Close();

        //    return listOfUsers;
        //}



        //goes on mainscreen

        //goes on mainscreen
        public static void PerformActionOnQueryResults<T>(string query, Action<MySqlDataReader> action)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                action(reader);
            }

            connection.Close();
        }
        public static void ExecuteNonQuery(string query)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        //to be deleted... eventually
        //public static void PopulateFromQuery<T>(string query, Action<MySqlDataReader> populate)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        //    MySqlConnection connection = new MySqlConnection(connectionString);
        //    connection.Open();
        //    MySqlCommand command = new MySqlCommand(query, connection);
        //    MySqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        populate(reader);
        //    }

        //    connection.Close();
        //}


        //All GetPlural functions
        public static List<Appointment> GetAllAppointments()
        {
            string query = $"select * from appointment";
            List<Appointment> list = new List<Appointment>();
            Action<MySqlDataReader> action = reader => { list.Add(new Appointment(reader)); };
            PerformActionOnQueryResults<Appointment>(query, action);
            return list;
        }
        public static List<Appointment> GetAllAppointmentsForCustomer(int customerID)
        {
            string query = $"select * from appointment WHERE customerId={customerID}";
            List<Appointment> list = new List<Appointment>();
            Action<MySqlDataReader> action = reader => { list.Add(new Appointment(reader)); };
            PerformActionOnQueryResults<Appointment>(query, action);
            return list;
        }
        public static List<Appointment> GetAppointments(int userID)
        {
            string query = $"select * from appointment WHERE userId={userID}";
            List<Appointment> list = new List<Appointment>();
            Action<MySqlDataReader> action = reader => { list.Add(new Appointment(reader)); };
            PerformActionOnQueryResults<Appointment>(query, action);
            return list;
        }
        public static List<Customer> GetCustomers()
        {
            string query = "select * from customer";
            List<Customer> list = new List<Customer>();
            Action<MySqlDataReader> action = reader => { list.Add(new Customer(reader)); };
            PerformActionOnQueryResults<Customer>(query, action);
            return list;
        }
        public static List<Address> GetAddresses()
        {
            string query = "select * from address";
            List<Address> list = new List<Address>();
            Action<MySqlDataReader> action = reader => { list.Add(new Address(reader)); };
            PerformActionOnQueryResults<Address>(query, action);
            return list;
        }
        public static List<City> GetCities()
        {
            string query = "select * from city";
            List<City> list = new List<City>();
            Action<MySqlDataReader> action = reader => { list.Add(new City(reader)); };
            PerformActionOnQueryResults<City>(query, action);
            return list;
        }
        public static List<Country> GetCountries()
        {
            string query = "select * from country";
            List<Country> list = new List<Country>();
            Action<MySqlDataReader> action = reader => { list.Add(new Country(reader)); };
            PerformActionOnQueryResults<Country>(query, action);
            return list;
        }
        public static List<User> GetUsers()
        {
            string query = "select * from user";
            List<User> list = new List<User>();
            Action<MySqlDataReader> action = reader => { list.Add(new User(reader)); };
            PerformActionOnQueryResults<User>(query, action);
            return list;
        }



        //country functions for adding customer
        public static bool CountryExists(string countryName)
        {
            string query = $"select countryId from country where country='{countryName}'";
            bool found = false;
            Action<MySqlDataReader> action = reader => { found = true; };
            PerformActionOnQueryResults<Country>(query, action);
            return found;
        }

        public static void AddCountry(string countryName, string userName)
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);


            string query = $"insert into country(country, createDate, createdBy, lastUpdate, lastUpdateBy) values('{countryName}', '{nowString}', '{userName}', '{nowString}', '{userName}')";
                

            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static Country GetCountry(string countryName)
        {
            string query = $"select * from country where country='{countryName}'";
            Country country = null;
            Action<MySqlDataReader> action = reader => { country = new Country(reader); };
            PerformActionOnQueryResults<Country>(query, action);
            return country;
        }


        //city functions for adding customer
        public static bool CityExists(int countryID, string cityName)
        {
            string query = $"select cityId from city where countryId='{countryID}' AND city='{cityName}'";
            bool found = false;
            Action<MySqlDataReader> action = reader => { found = true; };
            PerformActionOnQueryResults<City>(query, action);
            return found;
        }

        public static void AddCity(int countryID, string cityName, string userName)
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);


            string query = $"insert into city(city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                $"values('{cityName}', {countryID}, '{nowString}', '{userName}', '{nowString}', '{userName}')";


            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static City GetCity(int countryID, string cityName)
        {
            string query = $"select * from city where countryId='{countryID}' AND city='{cityName}'";
            City city = null;
            Action<MySqlDataReader> action = reader => { city = new City(reader); };
            PerformActionOnQueryResults<City>(query, action);
            return city;
        }


        // all Address functions for adding customer
        // still needs testing
        public static bool AddressExists(int cityID, string address)
        {
            string query = $"select addressId from address where cityId='{cityID}' AND address='{address}'";
            bool found = false;
            Action<MySqlDataReader> action = reader => { found = true; };
            PerformActionOnQueryResults<Address>(query, action);
            return found;
        }
        public static void AddAddress(int cityID, string address, string phoneNumber, string userName)
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);


            string query = $"insert into address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                $"values('{address}', 'not provided', {cityID}, 'not given', '{phoneNumber}', '{nowString}', '{userName}', '{nowString}', '{userName}')";


            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static Address GetAddress(int cityID, string streetAddress)
        {
            string query = $"select * from address where cityId='{cityID}' AND address='{streetAddress}'";
            Address address = null;
            Action<MySqlDataReader> action = reader => { address = new Address(reader); };
            PerformActionOnQueryResults<Address>(query, action);
            return address;
        }

        // all Customer functions for adding customer
        // still needs testing
        public static bool CustomerExists(int addressID, string customerName)
        {
            string query = $"select customerId from customer where addressId='{addressID}' AND customerName='{customerName}'";
            bool found = false;
            Action<MySqlDataReader> action = reader => { found = true; };
            PerformActionOnQueryResults<Customer>(query, action);
            return found;
        }
        public static void AddCustomer(int addressID, string customerName, string userName)
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);


            string query = $"insert into customer(customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                $"values('{customerName}', {addressID}, 1, '{nowString}', '{userName}', '{nowString}', '{userName}')";


            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static Customer GetCustomer(int addressID, string customerName)
        {
            string query = $"select * from customer where addressId='{addressID}' AND customerName='{customerName}'";
            Customer customer = null;
            Action<MySqlDataReader> action = reader => { customer = new Customer(reader); };
            PerformActionOnQueryResults<Customer>(query, action);
            return customer;
        }


        //All Appointment Methods (Add/Update/Delete)
        public static void AddAppointment(int customerID, int userID, string type, DateTime start, DateTime end, string userName)
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            string startString = start.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            string endString = end.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);


            string query = $"insert into appointment values(0, {customerID}, {userID}, 'not needed', 'not needed', 'not needed', 'not needed', '{type}', 'not needed'," +
            $" '{startString}', '{endString}', '{nowString}', '{userName}', '{nowString}', '{userName}')";

            //(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)

            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void UpdateAppointment(int appointmentID, string type, DateTime start, DateTime end, string userName)
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            string startString = start.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            string endString = end.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);

            string query = $"Update appointment SET type='{type}', start='{startString}', end='{endString}', lastUpdate='{nowString}', lastUpdateBy='{userName}' WHERE appointmentId= {appointmentID}";
            
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //for update customer 
        public static List<CustomerInfo> GetAllExistingCustomersInformation()
        {
            string query = $"SELECT customerName, address, phone, city, country FROM customer, address, city, country " +
                $"WHERE customer.addressId = address.addressId AND address.cityId = city.cityId AND city.countryId = country.countryId";
            List<CustomerInfo> list = new List<CustomerInfo>();
            Action<MySqlDataReader> action = reader => { list.Add(new CustomerInfo(reader)); };
            PerformActionOnQueryResults<Appointment>(query, action);
            return list;
        }

        public static CustomerInfo GetCustomerInfo(Customer customer)
        {
            CustomerInfo customerInfo = null;
            List<CustomerInfo> allcustomers = GetAllExistingCustomersInformation();
            foreach(var _customerInfo in allcustomers)
            {
                if (_customerInfo.CustomerName == customer.CustomerName)
                {
                    customerInfo = _customerInfo;
                }
            }
            return customerInfo;
        }
        public static void UpdateCustomer(int customerID, string customerName, int addressID, string userName)
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            string query = $"Update customer SET customerName = '{customerName}', addressId = '{addressID}', lastUpdate = '{nowString}', " +
                $"lastUpdateBy = '{userName}' WHERE customerId = {customerID}";
            
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void UpdateCustomerPhoneNumber(string phoneNumber, int addressID, string userName) 
        {
            DateTime now = DateTime.Now;
            string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            string query = $"Update address SET phone = '{phoneNumber}', lastUpdate = '{nowString}', " +
                $"lastUpdateBy = '{userName}' WHERE addressId = {addressID}";

            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteAppointment(int appointmentID)
        {
            string query = $"DELETE FROM appointment WHERE appointmentId={appointmentID};";

            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void DeleteCustomer(int customerID)
        {
            string query = $"DELETE FROM appointment WHERE customerId={customerID};";
            string query2 = $"DELETE FROM customer WHERE customerId={customerID};";

            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlCommand command2 = new MySqlCommand(query2, connection);
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connection.Close();
        }

        //public static void deleteCustomer(Customer customer)
        //{
        //    conn.Open();
        //    string query = $"DELETE FROM customer WHERE customerId={customer.CustomerId};";
        //    MySqlCommand cmd = new MySqlCommand(query, conn);
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //    MainScreen.ListOfCustomers.Remove(customer);
        //    deleteAddress(customer.AddressId);
        //}

        //public static void updateCustomer(Customer customer, string customerName, string user)
        //{
        //    DateTime now = DateTime.Now;
        //    string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
        //    conn.Open();
        //    string query = $"UPDATE customer SET customerName='{customerName}', lastUpdate='{nowString}', lastUpdateBy='{user}' WHERE customerId={customer.CustomerId};";
        //    MySqlCommand cmd = new MySqlCommand(query, conn);
        //    cmd.ExecuteNonQuery();
        //    conn.Close();

        //    Customer updatedCustomer = new Customer(customer.CustomerId, customerName, customer.AddressId, customer.Active, customer.CreateDate, customer.CreatedBy, now, user);
        //    int indexOfCustomerList = MainScreen.ListOfCustomers.IndexOf(customer);
        //    MainScreen.ListOfCustomers.RemoveAt(indexOfCustomerList);
        //    MainScreen.ListOfCustomers.Insert(indexOfCustomerList, updatedCustomer);
        //}


        //public static int addAddress(string address1, string address2, int cityId, string postalCode, string phone, string userName)
        //{
        //    DateTime now = DateTime.Now;
        //    var addedAddress = new Address(address1, address2, cityId, postalCode, phone, now, userName, now, userName);

        //    conn.Open();
        //    string query = $"INSERT INTO `address` VALUES ({addedAddress.AddressId}, '{addedAddress.AddressLine}', '{addedAddress.AddressLine2}', {addedAddress.CityId}, '{addedAddress.PostalCode}', '{addedAddress.Phone}', '{addedAddress.CreateDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{addedAddress.CreatedBy}', '{addedAddress.LastUpdate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{addedAddress.LastUpdateBy}')";
        //    MySqlCommand cmd = new MySqlCommand(query, conn);
        //    cmd.ExecuteNonQuery();
        //    conn.Close();

        //    MainScreen.AddressDictionary.Add(addedAddress.AddressId, addedAddress);
        //    return addedAddress.AddressId;
        //}

        //public static void deleteAddress(int addressID)
        //{
        //    conn.Open();
        //    string query = $"DELETE FROM address WHERE addressId={addressID};";
        //    MySqlCommand cmd = new MySqlCommand(query, conn);
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //    MainScreen.AddressDictionary.Remove(addressID);
        //}

        //public static void updateAddress(Address address, string address1, string address2, int cityId, string postalCode, string phone, string user)
        //{
        //    DateTime now = DateTime.Now;
        //    string nowString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
        //    conn.Open();
        //    string query = $"UPDATE address SET address='{address1}', address2='{address2}', cityId={cityId}, postalCode='{postalCode}', phone='{phone}', lastUpdate='{nowString}', lastUpdateBy='{user}' WHERE addressId={address.AddressId};";
        //    MySqlCommand cmd = new MySqlCommand(query, conn);
        //    cmd.ExecuteNonQuery();
        //    conn.Close();

        //    MainScreen.AddressDictionary[address.AddressId] = new Address(address.AddressId, address1, address2, cityId, postalCode, phone, address.CreateDate, address.CreatedBy, now, user);
        //}
    }
}
