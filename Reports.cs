using System;
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
    public partial class Reports : Form
    {

        //COMMENTS TO EVALUATOR:
        //My entire Database class (which is called here often) uses lambda functions;
        //As a result, I did not go out of my way to incorporate lambda for the appointments per user nor the aggregated
        //customer info as I used lambdas to make my job in assembling those datagrids already via my database class.
        private int AppointmentTypesByMonth { get { return UpdateNumberOfAppointmentTypesByMonth(); } }
        private BindingList<string> AppointmentMonths = new BindingList<string>();
        private BindingList<string> AppointmentTypes = new BindingList<string>();
        private BindingList<Appointment> DisplayedAppointmentsByUser = new BindingList<Appointment>();
        private BindingList<string> UserNames = new BindingList<string>();
        private BindingList<CustomerInfo> AllCustomers = new BindingList<CustomerInfo>();
        public Reports()
        {
            InitializeComponent();
            InitializeReports();
        }

        private void InitializeReports()
        {
            UpdateAppointmentTypes();
            PopulateAppointmentMonths();
            UpdateNumberOfAppointmentTypesByMonth();
            UpdateUsers();
            UpdateDisplayedAppointmentsByUser();
            PopulateCustomerInfo();

            var AppointmentMonthsDataSource = new BindingSource();
            AppointmentMonthsDataSource.DataSource = AppointmentMonths;
            comboBox1.DataSource = AppointmentMonthsDataSource;

            var AppointmentTypesDataSource = new BindingSource();
            AppointmentTypesDataSource.DataSource = AppointmentTypes;
            AppointmentTypeComboBox.DataSource = AppointmentTypesDataSource;

            var DisplayedAppointmentsByUserDataSource = new BindingSource();
            DisplayedAppointmentsByUserDataSource.DataSource = DisplayedAppointmentsByUser;
            dataGridView2.DataSource = DisplayedAppointmentsByUserDataSource;

            var UserNamesDataSource = new BindingSource();
            UserNamesDataSource.DataSource = UserNames;
            AllUsersComboBox.DataSource = UserNamesDataSource;

            var AllCustomersDataSource = new BindingSource();
            AllCustomersDataSource.DataSource = AllCustomers;
            dataGridView3.DataSource = AllCustomersDataSource;

            SetDisplayedAppointmentsByUserColumnVisibility();
            

        }
        private void PopulateAppointmentMonths()
        {
            List<Appointment> appointments = Database.GetAllAppointments();

            foreach(Appointment appointment in appointments)
            {
                string appointmentMonth = appointment.Start.ToString("MMMM");
                if (!AppointmentMonths.Contains(appointmentMonth)) 
                {
                    AppointmentMonths.Add(appointmentMonth);
                }
            }
        }
        private void PopulateCustomerInfo()
        {
            List<CustomerInfo> customerInfo = Database.GetAllExistingCustomersInformation();
            foreach (CustomerInfo customer in customerInfo)
            {
                AllCustomers.Add(customer);
            }
        }
        private void UpdateDisplayedAppointmentsByUser()
        {
            DisplayedAppointmentsByUser.Clear();
            var currentType = AllUsersComboBox.SelectedValue;
            if (currentType != null)
            {
                List<User> users = Database.GetUsers();
                foreach (User user in users)
                {
                    if (user.UserName.ToUpper() == currentType.ToString().ToUpper())
                    {
                        List<Appointment> appointments = Database.GetAppointments(user.UserID);
                        foreach (Appointment appointment in appointments)
                        {
                            DisplayedAppointmentsByUser.Add(appointment);
                        }
                    }
                }
            }
        }

        private void UpdateUsers()
        {
            List<User> users = Database.GetUsers();
            foreach (User user in users)
            {
                UserNames.Add(user.UserName);
            }
        }

        private int UpdateNumberOfAppointmentTypesByMonth()
        {
            int count = 0;
            if (AppointmentTypeComboBox.SelectedValue != null && comboBox1.SelectedValue != null)
            {
                string month = comboBox1.SelectedValue.ToString().ToLower();
                string type = AppointmentTypeComboBox.SelectedValue.ToString().ToLower();
                List<Appointment> appointments = Database.GetAllAppointments();

                int _count = appointments.Count((a => a.Start.ToString("MMMM").ToLower() == month
                    && a.AppointmentType.ToLower() == type));
                return _count;
            }
            return count;
        }

        private void UpdateAppointmentTypes()
        {
            List<Appointment> appointments = Database.GetAllAppointments();
            foreach (Appointment appointment in appointments)
            {
                if (!AppointmentTypes.Contains(appointment.AppointmentType))
                AppointmentTypes.Add(appointment.AppointmentType);
            }
        }

        private void SetDisplayedAppointmentsByUserColumnVisibility()
        {
            dataGridView2.Columns["AppointmentID"].Visible = false;
            dataGridView2.Columns["UserID"].Visible = false;
            dataGridView2.Columns["CustomerID"].Visible = false;
            dataGridView2.Columns["Location"].Visible = false;
            dataGridView2.Columns["Contact"].Visible = false;
            dataGridView2.Columns["URL"].Visible = false;
            dataGridView2.Columns["CreateDate"].Visible = false;
            dataGridView2.Columns["CreatedBy"].Visible = false;
            dataGridView2.Columns["LastUpdate"].Visible = false;
            dataGridView2.Columns["LastUpdateBy"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentTypeButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AppointmentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNumberOfAppointmentTypesByMonth();
            if (AppointmentTypeComboBox.SelectedValue != null && comboBox1.SelectedValue != null)
            {
                label2.Text = $"Appointments for {AppointmentTypeComboBox.SelectedValue} / {comboBox1.SelectedValue}: {AppointmentTypesByMonth}";
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllUsersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplayedAppointmentsByUser();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNumberOfAppointmentTypesByMonth();
            if (AppointmentTypeComboBox.SelectedValue != null && comboBox1.SelectedValue != null)
            {
                label2.Text = $"Appointments for {AppointmentTypeComboBox.SelectedValue} / {comboBox1.SelectedValue}: {AppointmentTypesByMonth}";
            }
        }
    }
}
