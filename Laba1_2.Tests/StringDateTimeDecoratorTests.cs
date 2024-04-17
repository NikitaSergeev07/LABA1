using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace Laba1_2.Tests
{
    [TestClass]
    public class StringDateTimeDecoratorTests
    {
        [TestMethod]
        public void PrintDateTime_AdditionalStringAppended()
        {
            IDateTimePrinter dateTimePrinter = new EuropeanDateTimePrinter();
            string additionalString = " - Additional Info";
            StringDateTimeDecorator decorator = new StringDateTimeDecorator(dateTimePrinter, additionalString);

            string printedDateTime = decorator.PrintDateTime();

            CultureInfo cultureInfo = new CultureInfo("en-GB");
            string expectedDateTime = DateTime.Now.ToString(cultureInfo) + additionalString;
            Assert.IsTrue(expectedDateTime == printedDateTime);
        }
    }
}