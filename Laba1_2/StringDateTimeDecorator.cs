using Laba1_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StringDateTimeDecorator : AbstractDateTimeDecorator
{
    private string additionalString;

    public StringDateTimeDecorator(IDateTimePrinter dateTimePrinter, string additionalString) : base(dateTimePrinter)
    {
        this.additionalString = additionalString;
    }

    public override string PrintDateTime()
    {
        string printedDateTime = dateTimePrinter.PrintDateTime();
        StringBuilder sb = new StringBuilder(printedDateTime);
        sb.Append(additionalString);

        return sb.ToString();
    }
}