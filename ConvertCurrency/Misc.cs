using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertCurrency
{
    internal class Misc
    {
        public static class InputValidationHelper
        {
            public static void HandleNumericInput(KeyPressEventArgs e, TextBox senderTextBox)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }

                // Only one comma
                if ((e.KeyChar == ',') && (senderTextBox.Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        public class Currency
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public double Rate { get; set; }
            public Currency(string name, string code, double rate) 
            {
                Name = name;
                Code = code;
                Rate = rate;
            }

        }

    }
}
