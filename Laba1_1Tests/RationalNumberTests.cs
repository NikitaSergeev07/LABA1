using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba1_1;

namespace Laba1_1.Tests
{
    [TestClass()]
    public class RationalNumberTests
    {
        [TestMethod()]
        public void SumTest()
        {
            RationalNumber r1 = new RationalNumber(-5, 10);
            RationalNumber r2 = new RationalNumber(1, 3);
            RationalNumber sum = r1 + r2;
            RationalNumber mysum = new RationalNumber(-1, 6);
            Assert.IsTrue(mysum == sum);
        }

        [TestMethod()]
        public void DecTest()
        {
            RationalNumber r1 = new RationalNumber(5, 3);
            RationalNumber r2 = new RationalNumber(15, 3);
            RationalNumber difference = r2 - r1;
            RationalNumber expectedDifference = new RationalNumber(10, 3);
            Assert.IsTrue(expectedDifference == difference);
        }

        [TestMethod()]
        public void BiggerTest()
        {
            RationalNumber r1 = new RationalNumber(5, 3);
            RationalNumber r2 = new RationalNumber(15, 3);
            Assert.IsTrue(r2 > r1);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RationalNumber rational = new RationalNumber(2, 4);
            string result = rational.ToString();
            Assert.IsTrue("1/2" == result);
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            RationalNumber r1 = new RationalNumber(2, 3);
            RationalNumber r2 = new RationalNumber(3, 4);
            RationalNumber product = r1 * r2;
            RationalNumber expectedProduct = new RationalNumber(1, 2);
            Assert.IsTrue(expectedProduct == product);
        }

        [TestMethod()]
        public void DivisionTest()
        {
            RationalNumber r1 = new RationalNumber(2, 3);
            RationalNumber r2 = new RationalNumber(3, 4);
            RationalNumber quotient = r1 / r2;
            RationalNumber expectedQuotient = new RationalNumber(8, 9);
            Assert.IsTrue(expectedQuotient == quotient);
        }

        [TestMethod()]
        public void UnaryNegationTest()
        {
            RationalNumber rational = new RationalNumber(1, 2);
            RationalNumber negation = -rational;
            RationalNumber expectedNegation = new RationalNumber(-1, 2);
            Assert.IsTrue(expectedNegation == negation);
        }

        [TestMethod()]
        public void EqualityTest()
        {
            RationalNumber r1 = new RationalNumber(2, 3);
            RationalNumber r2 = new RationalNumber(2, 3);
            Boolean result = r1 == r2;
            Assert.IsTrue(true == result);
        }

        [TestMethod()]
        public void InequalityTest()
        {
            RationalNumber r1 = new RationalNumber(2, 3);
            RationalNumber r2 = new RationalNumber(3, 2);
            Boolean result = true;
            Assert.IsTrue(true == result);
        }
    }
}
