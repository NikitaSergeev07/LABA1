using System;
using System.Dynamic;

namespace Laba1_1
{
    public class RationalNumber
    {
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            _numerator = numerator;
            _denominator = denominator;

            Reduction();
        }

        public override string ToString()
        {
            if (_denominator == 1)
                return _numerator.ToString();
            else
                return $"{_numerator}/{_denominator}";
        }

        private void Reduction()
        {
            int gcd = GCD(Math.Abs(_numerator), Math.Abs(_denominator));
            _numerator /= gcd;
            _denominator /= gcd;

            if (_denominator < 0)
            {
                _numerator = -_numerator;
                _denominator = -_denominator;
            }
        }

        private int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);


        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            int newNumerator = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
            int newDenominator = r1.Denominator * r2.Denominator;
            RationalNumber r3 = new RationalNumber(newNumerator, newDenominator);
            return r3;
        }

        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            int newNumerator = r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator;
            int newDenominator = r1.Denominator * r2.Denominator;
            RationalNumber r3 = new RationalNumber(newNumerator, newDenominator);
            return r3;
        }

        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            int newNumerator = r1.Numerator * r2.Numerator;
            int newDenominator = r1.Denominator * r2.Denominator;
            RationalNumber r3 = new RationalNumber(newNumerator, newDenominator);
            return r3;
        }

        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            if (r2.Numerator == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            int newNumerator = r1.Numerator * r2.Denominator;
            int newDenominator = r1.Denominator * r2.Numerator;
            RationalNumber r3 = new RationalNumber(newNumerator, newDenominator);
            return r3;
        }

        public static RationalNumber operator -(RationalNumber r)
        {
            int newNumerator = -r.Numerator;
            RationalNumber r3 = new RationalNumber(newNumerator, r.Denominator);
            return r3;
        }

        public static bool operator ==(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator == r2.Numerator && r1.Denominator == r2.Denominator;
        }

        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 == r2);
        }

        public static bool operator <(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator < r2.Numerator * r1.Denominator;
        }

        public static bool operator >(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator > r2.Numerator * r1.Denominator;
        }

        public static bool operator <=(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator <= r2.Numerator * r1.Denominator;
        }

        public static bool operator >=(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator >= r2.Numerator * r1.Denominator;
        }

        private int _numerator;
        private int _denominator;

        public int Numerator { get { return _numerator; } }
        public int Denominator { get { return _denominator; } }
    }
}
