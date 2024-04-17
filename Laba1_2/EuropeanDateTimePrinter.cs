using System.Globalization;
using Laba1_2;

public class EuropeanDateTimePrinter : IDateTimePrinter
{
    public string PrintDateTime()
    {
        CultureInfo cultureInfo = new CultureInfo("en-GB");
        return DateTime.Now.ToString(cultureInfo);
    }
}
