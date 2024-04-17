using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba1_2;

public abstract class AbstractDateTimeDecorator : IDateTimePrinter
{
    protected IDateTimePrinter dateTimePrinter;

    public AbstractDateTimeDecorator(IDateTimePrinter dateTimePrinter)
    {
        this.dateTimePrinter = dateTimePrinter;
    }

    public abstract string PrintDateTime();
}