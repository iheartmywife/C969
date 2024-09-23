﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Chermak_PA_C969
{
    public partial class AddAppointment : Form
    {
        public string AppointmentType { get { return textBox1.Text; } }
        public DateTime StartTime { get { return CreateAppointmentTime(StartTimePicker, AppointmentDay); } }
        public DateTime EndTime { get { return CreateAppointmentTime(EndTimePicker, AppointmentDay); } }
        public Customer CurrentCustomer { get { return currentCustomer; } }

        private BindingList<Appointment> Appointments = new BindingList<Appointment>();
        private BindingList<Customer> AllCustomers = new BindingList<Customer>();
        private DateTime AppointmentDay;
        private Customer currentCustomer;
        private int UserID;
        public AddAppointment(int userID)
        {
            this.UserID = userID;
            InitializeComponent();
            InitializeAddAppointment();
        }

        private void InitializeAddAppointment()
        {
            UpdateDisplayedCustomers();
            UpdateDisplayedAppointments();

            var customersDataSource = new BindingSource();
            customersDataSource.DataSource = AllCustomers;
            CustomerListDGV.DataSource = customersDataSource;

            var appointmentsDataSource = new BindingSource();
            appointmentsDataSource.DataSource = Appointments;
            AppointmentsDGV.DataSource = appointmentsDataSource;

            SetAppointmentsDGVColumnVisibility();
            SetCustomersDGVColumnVisibility();

            StartESTLabel.Text = Mainscreen.ConvertToEST(StartTimePicker).ToString();
            EndESTLabel.Text = Mainscreen.ConvertToEST(StartTimePicker).ToString();
        }

        private void UpdateDisplayedCustomers()
        {
            AllCustomers.Clear();
            List<Customer> customers = Database.GetCustomers();
            foreach (Customer customer in customers)
            {
                AllCustomers.Add(customer);
            }
        }

        private void UpdateDisplayedAppointments()
        {
            Appointments.Clear();
            List<Appointment> appointments = Database.GetAppointments(UserID);
            foreach (Appointment appointment in appointments)
            {
                if (appointment.Start.Day == AppointmentDay.Day)
                {
                    Appointments.Add(appointment);
                }
            }
        }

        private DateTime CreateAppointmentTime(DateTimePicker dateTimePicker, DateTime Date)
        {
            var today = Date.Date;
            var estValue = Mainscreen.ConvertToEST(dateTimePicker);
            return today.Add(estValue.TimeOfDay);
        }

        private bool AppointmentOverlaps(DateTime startDate, DateTime endDate)
        {
            var appointmentOverlaps = false;
            foreach (Appointment appointment in Appointments)
            {
                if (startDate < appointment.Start && endDate > appointment.Start)
                {
                    appointmentOverlaps = true;
                }
                else if (startDate == appointment.Start)
                {
                    appointmentOverlaps = true;
                }
                else if (startDate > appointment.Start && startDate < appointment.End)
                {
                    appointmentOverlaps = true;
                }
                else if ((startDate > appointment.Start && startDate < appointment.End) && endDate > appointment.End)
                {
                    appointmentOverlaps = true;
                }
                else if (startDate < appointment.Start && endDate > appointment.End)
                {
                    appointmentOverlaps = true;
                }
            }
            return appointmentOverlaps;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentCustomer = (Customer)CustomerListDGV.CurrentRow.DataBoundItem;
            textBox4.Text = CustomerListDGV.CurrentRow.Cells["CustomerName"].Value.ToString();
            textBox5.Text = CustomerListDGV.CurrentRow.Cells["AddressID"].Value.ToString();
        }

        private void SetAppointmentsDGVColumnVisibility()
        {
            AppointmentsDGV.Columns["AppointmentID"].Visible = false;
            AppointmentsDGV.Columns["Title"].Visible = false;
            this.AppointmentsDGV.Columns["location"].Visible = false;
            this.AppointmentsDGV.Columns["description"].Visible = false;
            this.AppointmentsDGV.Columns["userId"].Visible = false;
            this.AppointmentsDGV.Columns["Contact"].Visible = false;
            this.AppointmentsDGV.Columns["URL"].Visible = false;
            this.AppointmentsDGV.Columns["CreateDate"].Visible = false;
            this.AppointmentsDGV.Columns["CreatedBy"].Visible = false;
            this.AppointmentsDGV.Columns["LastUpdate"].Visible = false;
            this.AppointmentsDGV.Columns["LastUpdateBy"].Visible = false;
        }
        private void SetCustomersDGVColumnVisibility()
        {
            this.CustomerListDGV.Columns["Active"].Visible = false;
            this.CustomerListDGV.Columns["CreateDate"].Visible = false;
            this.CustomerListDGV.Columns["CreatedBy"].Visible = false;
            this.CustomerListDGV.Columns["LastUpdate"].Visible = false;
            this.CustomerListDGV.Columns["LastUpdateBy"].Visible = false;
        }

        //appointmentType text box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Validator.UpdateNameOrCountryOrCityOrAppointmentTypeTextBoxColor(textBox1);
        }
        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {

            StartESTLabel.Text = Mainscreen.ConvertToEST(StartTimePicker).ToString();
        }

        private void EndTimePicker_ValueChanged(object sender, EventArgs e)
        {

            EndESTLabel.Text = Mainscreen.ConvertToEST(EndTimePicker).ToString();
        }

        //selected customer text box
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Database.CustomerExists(currentCustomer.AddressID, currentCustomer.CustomerName))
            {
                textBox4.BackColor = Color.White;
            }

        }
        //selected customer address ID text box
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (Database.CustomerExists(currentCustomer.AddressID, currentCustomer.CustomerName))
            {
                textBox5.BackColor = Color.White;
            }
        }

        private void SaveAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.EntryIsinvalid(textBox1))
                {
                    throw new MyCustomExceptions("Appointment Type field is invalid.");
                }
                else if (AppointmentOverlaps(StartTime, EndTime))
                {
                    throw new MyCustomExceptions("Your input appointment time overlaps an existing appointment.");
                }
                else if (Validator.IsBusinessHours(StartTime) == false)
                {
                    throw new MyCustomExceptions("Start time must be within 9am to 5pm EST.");
                }
                else if (Validator.IsBusinessHours(EndTime) == false)
                {
                    throw new MyCustomExceptions("End time must be within 9am to 5pm EST.");
                }
                else if (AppointmentDate.Value.DayOfWeek == DayOfWeek.Sunday || AppointmentDate.Value.DayOfWeek == DayOfWeek.Saturday) 
                {
                    throw new MyCustomExceptions("Appointments cannot be set on Sunday or Saturday, or outside of 9am to 5pm.");
                }
                else if (Validator.EntryIsinvalid(textBox4) || Validator.EntryIsinvalid(textBox5))
                {
                    throw new MyCustomExceptions("Please Select a customer from the list for the appointment.");
                }
                ErrorTextLabel.Text = "";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MyCustomExceptions error)
            {
                ErrorTextLabel.Text = error.Message;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            AppointmentDay = AppointmentDate.Value;
        }

        private void AppointmentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}
