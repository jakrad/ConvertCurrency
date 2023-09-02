using static ConvertCurrency.Misc;
using System.Xml;
using System.Globalization;

namespace ConvertCurrency;

public partial class Form1 : Form
{
    private bool convertToPLN = true; // Domyœlnie przeliczaj na PLN

    public Form1()
    {
        InitializeComponent();
    }

    private void amountToConvert_KeyPress(object sender, KeyPressEventArgs e)
    {
        InputValidationHelper.HandleNumericInput(e, amountToConvert);
    }

    /*    private void GetExchangeRates(object sender, EventArgs e)
        {
            string url = "https://api.nbp.pl/api/exchangerates/tables/a/?format=xml";
            XmlDocument xml = new XmlDocument();
            xml.Load(url);
            XmlNodeList xnList = xml.SelectNodes("/ArrayOfExchangeRatesTable/ExchangeRatesTable/Rates/Rate");
            List<Currency> currencies = new List<Currency>();
            foreach (XmlNode xn in xnList)
            {
                string name = xn["Currency"].InnerText;
                string code = xn["Code"].InnerText;
                double rate = double.Parse(xn["Mid"].InnerText, CultureInfo.InvariantCulture);
                currencies.Add(new Currency(name, code, rate));
            }
            selectCurrency.DataSource = currencies;
            selectCurrency.DisplayMember = "Name";
            selectCurrency.SelectedIndex = 0;
            UpdateExchangeRate();
        }*/

    private void GetExchangeRates(object sender, EventArgs e)
    {
        string url = "https://api.nbp.pl/api/exchangerates/tables/a/?format=xml";
        XmlDocument xml = new XmlDocument();
        xml.Load(url);
        XmlNodeList xnList = xml.SelectNodes("/ArrayOfExchangeRatesTable/ExchangeRatesTable/Rates/Rate");
        List<Currency> currencies = new List<Currency>();
        foreach (XmlNode xn in xnList)
        {
            string name = xn["Currency"].InnerText;
            string code = xn["Code"].InnerText;
            double rate = double.Parse(xn["Mid"].InnerText, CultureInfo.InvariantCulture);

            // Przygotowanie pe³nej nazwy z kodem w nawiasach kwadratowych
            string displayName = $"{name} [{code}]";

            currencies.Add(new Currency(displayName, code, rate));
        }

        selectCurrency.DataSource = currencies;
        selectCurrency.DisplayMember = "Name"; // Wyœwietlaj nazwy walut z kodem w nawiasach
        selectCurrency.SelectedIndex = 0;
    }





    private void UpdateExchangeRate()
    {
        // Pobierz wybran¹ walutê docelow¹
        Currency selectedCurrency = (Currency)selectCurrency.SelectedItem;

        // Pobierz kurs waluty docelowej
        double exchangeRate = selectedCurrency.Rate;

        // Aktualizuj wartoœæ w TextBox
        rateCurrency.Text = exchangeRate.ToString(CultureInfo.InvariantCulture);
    }

    private void selectCurrency_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateExchangeRate();
    }

    private void buttonConvert_Click(object sender, EventArgs e)
    {
        // proof of concept,
        // There are apps for converting all currencies to other currencies,
        // but I don't feel like doing that.
       
            if (convertToPLN)
            {
            try
            {
                double amount = double.Parse(amountToConvert.Text, CultureInfo.InvariantCulture);
                double rate = double.Parse(rateCurrency.Text, CultureInfo.InvariantCulture);
                double result = amount * rate;
                result = Math.Round(result, 2);
                resultConvert.Text = result.ToString() + " PLN";
            }
            catch (Exception)
            {
                resultConvert.Text = "B³¹d";
            }
            }
            else
            {
            try
            {
                Currency selectedCurrency = (Currency)selectCurrency.SelectedItem;
                string currencyCode = selectedCurrency.Code; // Pobierz kod waluty
                double amount = double.Parse(amountToConvert.Text, CultureInfo.InvariantCulture);
                double rate = double.Parse(rateCurrency.Text, CultureInfo.InvariantCulture);
                double result = amount / rate;
                result = Math.Round(result, 2);
                resultConvert.Text = result.ToString() + $" {currencyCode}";
            }
            catch (Exception)
            {
                resultConvert.Text = "B³¹d";
            }
            }
        }
        
    

    private void radioButton_FromCurrencyToPLN_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton_FromCurrencyToPLN.Checked)
        {
            convertToPLN = true;
        }
    }

    private void radioButton_FromPLNToCurrency_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton_FromPLNToCurrency.Checked)
        {
            convertToPLN = false;
        }
    }
}