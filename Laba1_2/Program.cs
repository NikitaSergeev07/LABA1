using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba1_2;
class Program
{
    static void Main(string[] args)
    {
        IDateTimePrinter europeanPrinter = new EuropeanDateTimePrinter();
        IDateTimePrinter decoratedPrinter = new StringDateTimeDecorator(europeanPrinter, " - Additional Info");

        Console.WriteLine(decoratedPrinter.PrintDateTime());
    }
}