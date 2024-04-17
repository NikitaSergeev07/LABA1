using System;
using System.Globalization;
using System.Text;
using Laba1_2;

public class AmericanDateTimePrinter : IDateTimePrinter
{
    public string PrintDateTime()
    {
        CultureInfo cultureInfo = new CultureInfo("en-US");
        return DateTime.Now.ToString(cultureInfo);
    }
}
