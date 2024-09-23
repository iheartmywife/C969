using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chermak_PA_C969
{
    public partial class AddCustomer : Form
    {
        public string CountryName { get { return CountryTextBox.Text; } }
        public string CityName {  get { return CityTextBox.Text; } }
        public string AddressName { get { return AddressTextBox.Text; } }
        public string PhoneNumber { get { return PhoneNumberTextBox.Text; } }
        public string CustomerName { get { return NameTextBox.Text; } }
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Validator.UpdateNameOrCountryOrCityOrAppointmentTypeTextBoxColor(NameTextBox);
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            Validator.UpdateAddressTextBoxColor(AddressTextBox);
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            Validator.UpdatePhoneNumberTextBoxColor(PhoneNumberTextBox);
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            Validator.UpdateNameOrCountryOrCityOrAppointmentTypeTextBoxColor(CountryTextBox);
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            Validator.UpdateNameOrCountryOrCityOrAppointmentTypeTextBoxColor(CityTextBox);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.EntryIsinvalid(NameTextBox))
                {
                    throw new MyCustomExceptions("Name field is invalid.");
                }
                else if (Validator.EntryIsinvalid(AddressTextBox)) 
                {
                    throw new MyCustomExceptions("Address field is invalid.");
                }
                else if (Validator.EntryIsinvalid(PhoneNumberTextBox))
                {
                    throw new MyCustomExceptions("Phone Number field is invalid.");
                }
                else if (Validator.EntryIsinvalid(CountryTextBox))
                {
                    throw new MyCustomExceptions("Country field is invalid.");
                }
                else if (Validator.EntryIsinvalid(CityTextBox))
                {
                    throw new MyCustomExceptions("City field is invalid.");
                }
                ErrorLabel.Text = "";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MyCustomExceptions error)
            {
                ErrorLabel.Text = error.Message;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
