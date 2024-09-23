using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chermak_PA_C969
{
    public partial class Mainscreen : Form
    {
        protected bool ValidPhoneNumber = false;
        protected bool ValidName = false;
        protected bool ValidAddress = false;
        protected bool ValidCountry = false;
        protected bool ValidCity = false;

        private LoginScreen CurrentLoginScreen;
        private User CurrentUser;
        private BindingList<Appointment> DisplayedAppointments = new BindingList<Appointment>();
        private BindingList<Customer> DisplayedCustomers = new BindingList<Customer>();
        public Mainscreen(User user, LoginScreen loginScreen)
        {
            CurrentLoginScreen = loginScreen;
            CurrentUser = user;
            InitializeComponent();
            InitializeMainScreen();
            CheckForUpcomingAppointments();

        }

        private void InitializeMainScreen()
        {
            UpdateDisplayedAppointments();
            UpdateDisplayedCustomers();

            var appointmentsDataSource = new BindingSource();
            appointmentsDataSource.DataSource = DisplayedAppointments;
            AppointmentsDGV.DataSource = appointmentsDataSource;

            var customersDataSource = new BindingSource();
            customersDataSource.DataSource = DisplayedCustomers;
            CustomersDGV.DataSource = customersDataSource;

            SetAppointmentsDGVColumnVisibility();
            SetCustomersDGVColumnVisibility();

            CustomersDGV.ClearSelection();
        }
        private void CheckForUpcomingAppointments()
        {
            foreach (Appointment appointment in DisplayedAppointments)
            {
                Double _timeToAppointment = (appointment.Start - DateTime.Now).TotalMinutes;
                if (_timeToAppointment <= 15.00 && _timeToAppointment > 0.00)
                {
                    var _customer = DisplayedCustomers.First(c => c.CustomerID == appointment.CustomerID);
                    MessageBox.Show($"You only have {_timeToAppointment} minutes until your appointment with {_customer.CustomerName}");
                }
            }
        }
        //Comments to Evaluator:
        //I spoke with my CI to clarify the requirements for the calendar view, and she(Lauren Provost) said that my approach,
        //wherein I provide a separate DateTimePicker with checkboxes to filter by the selected month or day on the DateTimePicker,
        //is acceptable.
        private void UpdateDisplayedAppointments()
        {
            DisplayedAppointments.Clear();
            var selectedDate = monthCalendar1.SelectionStart.ToShortDateString();
            var selectedMonth = monthCalendar1.SelectionStart.Month.ToString();

            List<Appointment> appointments = Database.GetAppointments(CurrentUser.UserID);
            if (checkBox1.Checked)
            {
                foreach (Appointment appointment in appointments)
                {
                    if (appointment.Start.ToShortDateString() == selectedDate)
                    {
                        DisplayedAppointments.Add(appointment);
                    }
                }
            }
            else if (checkBox2.Checked)
            {
                foreach (Appointment appointment in appointments)
                {
                    if (appointment.Start.Month.ToString() == selectedMonth)
                    {
                        DisplayedAppointments.Add(appointment);
                    }
                }
            }
            else
            {
                foreach (Appointment appointment in appointments)
                {
                    DisplayedAppointments.Add(appointment);
                }
            }

            //foreach (Appointment appointment in appointments)
            //{
            //    if ((!checkBox1.Checked) || (appointment.Start.ToShortDateString() == selectedDate))
            //    {

            //        DisplayedAppointments.Add(appointment);
            //    }
            //}
        }

        public void UpdateDisplayedCustomers()
        {
            DisplayedCustomers.Clear();
            List<Customer> customers = Database.GetCustomers();
            foreach (Customer customer in customers)
            {
                List<Appointment> appointments = Database.GetAppointments(CurrentUser.UserID);
                foreach (Appointment appointment in appointments)
                {
                    //lambda function at the end saves me some space. It checks if any customer is already in the DisplayedCustomers list
                    //this prevents adding the same customer twice to the DisplayedCustomers list.
                    if (customer.CustomerID == appointment.CustomerID && !DisplayedCustomers.Any(cust => cust == customer))
                    {
                        DisplayedCustomers.Add(customer);
                    }
                }
            }
        }

        public void SetAppointmentsDGVColumnVisibility()
        {
            AppointmentsDGV.Columns["AppointmentID"].Visible = false;
            AppointmentsDGV.Columns["Title"].Visible = false;
            this.AppointmentsDGV.Columns["Description"].Visible = false;
            this.AppointmentsDGV.Columns["Location"].Visible = false;
            this.AppointmentsDGV.Columns["Contact"].Visible = false;
            this.AppointmentsDGV.Columns["URL"].Visible = false;
            this.AppointmentsDGV.Columns["CreateDate"].Visible = false;
            this.AppointmentsDGV.Columns["CreatedBy"].Visible = false;
            this.AppointmentsDGV.Columns["LastUpdate"].Visible = false;
            this.AppointmentsDGV.Columns["LastUpdateBy"].Visible = false;
        }
        public void SetCustomersDGVColumnVisibility()
        {
            this.CustomersDGV.Columns["Active"].Visible = false;
            this.CustomersDGV.Columns["CreateDate"].Visible = false;
            this.CustomersDGV.Columns["CreatedBy"].Visible = false;
            this.CustomersDGV.Columns["LastUpdate"].Visible = false;
            this.CustomersDGV.Columns["LastUpdateBy"].Visible = false;
        }

        private void Mainscreen_Load(object sender, EventArgs e)
        {

        }
        public static DateTime ConvertToEST(DateTimePicker dateTimePicker)
        {
            var localtime = TimeZoneInfo.ConvertTimeToUtc(dateTimePicker.Value);
            var est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            var estTime = TimeZoneInfo.ConvertTimeFromUtc(localtime, est);

            return estTime;
        }

        private void AppointmentsAddButton_Click(object sender, EventArgs e)
        {
            AddAppointment form = new AddAppointment(CurrentUser.UserID);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Database.AddAppointment(form.CurrentCustomer.CustomerID, CurrentUser.UserID,
                    form.AppointmentType, form.StartTime, form.EndTime, CurrentUser.UserName);
                UpdateDisplayedAppointments();
                UpdateDisplayedCustomers();
            }
        }

        private void AppointmentsUpdateButton_Click(object sender, EventArgs e)
        {
            var cr = AppointmentsDGV.CurrentRow;
            Appointment _appointment = null;
            foreach (Appointment appointment in DisplayedAppointments)
            {
                if (cr.Cells["CustomerID"].Value.ToString() == appointment.CustomerID.ToString()
                    && cr.Cells["UserID"].Value.ToString() == appointment.UserID.ToString()
                    && cr.Cells["AppointmentType"].Value.ToString() == appointment.AppointmentType.ToString()
                    && cr.Cells["Start"].Value.ToString() == appointment.Start.ToString())
                {
                    _appointment = appointment;
                }
            }
            UpdateAppointment form = new UpdateAppointment(_appointment);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Database.UpdateAppointment(_appointment.AppointmentID, form.AppointmentType, form.StartTime, form.EndTime, CurrentUser.UserName);
                UpdateDisplayedAppointments();
                UpdateDisplayedCustomers();
            }
        }

        private void AppointmentsDeleteButton_Click(object sender, EventArgs e)
        {
            var _appointmentID = int.Parse(AppointmentsDGV.CurrentRow.Cells["AppointmentID"].Value.ToString());

            var confirmResult = MessageBox.Show($"Are you sure you'd like to delete this appointment?",
                "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                    Database.DeleteAppointment(_appointmentID);
                    UpdateDisplayedAppointments();
                UpdateDisplayedCustomers();
            }
        }

        //Comments to evaluator
        //PLEASE NOTE: My CI told me to only show customers in the datagridview that have an appointment with the current user
        //As a result, when a new customer is added, they will not show on the main form until an appointment is made with them.
        private void CustomersAddButton_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (!Database.CountryExists(form.CountryName))
                {
                    Database.AddCountry(form.CountryName, CurrentUser.UserName);
                }
                Country country = Database.GetCountry(form.CountryName);
                if (!Database.CityExists(country.CountryID, form.CityName))
                {
                    Database.AddCity(country.CountryID, form.CityName, CurrentUser.UserName);
                }
                City city = Database.GetCity(country.CountryID, form.CityName);
                if (!Database.AddressExists(city.CityID, form.AddressName))
                {
                    Database.AddAddress(city.CityID, form.AddressName, form.PhoneNumber, CurrentUser.UserName);
                }
                Address address = Database.GetAddress(city.CityID, form.AddressName);
                if (!Database.CustomerExists(address.AddressID, form.CustomerName))
                {
                    Database.AddCustomer(address.AddressID, form.CustomerName, CurrentUser.UserName);
                }
                UpdateDisplayedCustomers();
                UpdateDisplayedAppointments();
            }
        }

        private void CustomersUpdateButton_Click(object sender, EventArgs e)
        {
            var cr = CustomersDGV.CurrentRow;
            Customer _customer = null;
            foreach (Customer customer in DisplayedCustomers)
            {
                if (cr.Cells["CustomerID"].Value.ToString() == customer.CustomerID.ToString())
                {
                    _customer = customer;
                }
            }
            UpdateCustomer form = new UpdateCustomer(_customer);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (!Database.CountryExists(form.CountryName))
                {
                    Database.AddCountry(form.CountryName, CurrentUser.UserName);
                }
                Country country = Database.GetCountry(form.CountryName);
                if (!Database.CityExists(country.CountryID, form.CityName))
                {
                    Database.AddCity(country.CountryID, form.CityName, CurrentUser.UserName);
                }
                City city = Database.GetCity(country.CountryID, form.CityName);
                if (!Database.AddressExists(city.CityID, form.AddressName))
                {
                    Database.AddAddress(city.CityID, form.AddressName, form.PhoneNumber, CurrentUser.UserName);
                }
                Address address = Database.GetAddress(city.CityID, form.AddressName);
                if (address.PhoneNumber != form.PhoneNumber)
                {
                    Database.UpdateCustomerPhoneNumber(form.PhoneNumber, address.AddressID, CurrentUser.UserName);
                }
                Database.UpdateCustomer(_customer.CustomerID, form.CustomerName, address.AddressID, CurrentUser.UserName);
                UpdateDisplayedCustomers();
                UpdateDisplayedAppointments();
            }
        }


        //comments to evaluator:
        //My CI told me to only show the customers that the user has appointments scheduled with.
        //Because of this, currently a user can only delete a customer that is scheduled with them.
        private void CustomersDeleteButton_Click(object sender, EventArgs e)
        {
            
            var customerName = CustomersDGV.CurrentRow.Cells["CustomerName"].Value.ToString();
            var customerID = int.Parse(CustomersDGV.CurrentRow.Cells["CustomerID"].Value.ToString());
            //var listOfAllAppointments = Database.GetAllAppointmentsForCustomer(customerID);
            var confirmResult = MessageBox.Show($"Are you sure you'd like to delete customer: {customerName}?",
                "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (CustomersDGV.SelectedRows.Count == 0) 
                    {
                        throw new MyCustomExceptions($"No customer is currently selected");
                    }
                    else
                    {
                        Database.DeleteCustomer(customerID);
                        UpdateDisplayedCustomers();
                    }
                }
                catch (MyCustomExceptions error)
                {
                    ErrorLabel.Text = error.Message;
                }
            }
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            new Reports().ShowDialog();

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateDisplayedAppointments();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplayedAppointments();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplayedAppointments();
        }
        private void Mainscreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentLoginScreen.Show();
        }

        // here lies all dead methods I am afraid to delete because I the assembly code does things I do not understand :)
        private void AppointmentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AllAppointmentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CurrentMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CurrentWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void ClearCalendarSelectionButton_Click(object sender, EventArgs e)
        {
        }

        private void ShowLocalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ShowEasternRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CustomersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
