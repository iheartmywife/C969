using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chermak_PA_C969
{
    public static class Validator
    {
        private static bool TextIsNumbersOrHyphen(TextBox textbox)
        {
            var text = textbox.Text;
            return (text.All(c => Char.IsDigit(c) || c == '-'));
        }
        private static bool TextIsLettersOrNumbers(TextBox textbox)
        {
            var text = textbox.Text;
            return (text.All(c => Char.IsLetterOrDigit(c) || c == ' '));
        }
        private static bool TextIsLettersOrHyphen(TextBox textbox)
        {
            var text = textbox.Text;
            return (text.All(c => Char.IsLetter(c) || c == '_' || c == ' '));
        }
        private static bool TextIsTrimmed(TextBox textbox)
        {
            var text = textbox.Text;
            return (text == text.Trim());
        }
        public static void UpdateNameOrCountryOrCityOrAppointmentTypeTextBoxColor(TextBox textbox)
        {
            var color = Color.IndianRed;
            var text = textbox.Text;
            if (TextIsLettersOrHyphen(textbox) && TextIsTrimmed(textbox) && !string.IsNullOrEmpty(text))
            {
                color = Color.White;
            }
            textbox.BackColor = color;
        }
        public static void UpdateAddressTextBoxColor(TextBox textbox)
        {
            var color = Color.IndianRed;
            var text = textbox.Text;
            if (TextIsLettersOrNumbers(textbox) && TextIsTrimmed(textbox) && !string.IsNullOrEmpty(text))
            {
                color = Color.White;
            }
            textbox.BackColor = color;
        }
        public static void UpdatePhoneNumberTextBoxColor(TextBox textbox)
        {
            var color = Color.IndianRed;
            var text = textbox.Text;
            if (TextIsNumbersOrHyphen(textbox) && TextIsTrimmed(textbox) && !string.IsNullOrEmpty(text))
            {
                color = Color.White;
            }
            textbox.BackColor = color;

        }
        //public static void UpdateTextBoxColor(TextBox textbox)
        //{
        //    var color = Color.IndianRed;
        //    var text = textbox.Text;
        //    if (text.Length > 0 && text.All(c => (Char.IsLetter(c) || Char.IsDigit(c)) && !string.IsNullOrEmpty(text) && TextIsTrimmed(textbox))) ;
        //    {
        //        color = Color.White;
        //    }
        //    textbox.BackColor = color;
        //}

        //public static void UpdateTextBoxColor2(TextBox textbox)
        //{
        //    var color = Color.White;
        //    var text = textbox.Text;
        //    //comments to evaluator: This lambda function checks if every char in the textbox is a number or '-'. Saves me lots of space :)
        //    if (!text.All(c => char.IsDigit(c) || c.Equals("-")) && !TextIsTrimmed(textbox))
        //    {
        //        color = Color.IndianRed;
        //    }
        //    textbox.BackColor = color;
        //}

        public static bool EntryIsinvalid(TextBox textbox)
        {
            return (textbox.BackColor == Color.IndianRed);
        }

        public static bool IsBusinessHours(DateTime datetime)
        {
            var localtime = TimeZoneInfo.ConvertTimeToUtc(datetime);
            var est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            var estTime = TimeZoneInfo.ConvertTimeFromUtc(localtime, est);
            var isBusinessHours = true;
            if (estTime.Hour < 9 || estTime.Hour > 17)
            {
                isBusinessHours = false;
            }
            return isBusinessHours;
        }
    }
}
