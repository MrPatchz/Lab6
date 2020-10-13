using System;
using System.Collections.Specialized;

namespace Lecture6Lab2
{
    class Fraction
    {
        //Members
        private int numerator;
        private int denominator;
        //Default Constructor
        Fraction()
        {
            numerator = 1;
            denominator = 1;
        }
        //Getter and setter methods
        int getNumerator()
        { return numerator; }
        void setNumerator(int newNumerator)
        { this.numerator = newNumerator; }
        int getDenominator()
        { return denominator; }
        void setDenominator(int newDenominator)
        { this.denominator = newDenominator; }
        //Function that divides the two and returns a value
        double divide()
        {
            try
            {
                return (Convert.ToDouble(numerator) / Convert.ToDouble(denominator));
            }
            catch (DivideByZeroException)
            {
                return 0.0;
            }
        }
        void reduce()
        {
            int oldN = this.numerator;
            int oldD = this.denominator;
            int n = this.numerator;
            int d = this.denominator;
            while (n != 0 && d != 0)
            {
                oldD = d;
                oldN = n;
                if (n > d)
                    n = n % d;
                else
                    d = d % n;
            }
            n = this.numerator / oldN ;
            d = this.denominator / oldD;
            Console.WriteLine("Common denominator    is : " + n + "/" + d);
        }

        static void Main(string[] args)
        {
            Fraction test = new Fraction();
            test.setNumerator(2);
            test.setDenominator(4);
            test.reduce();
            Console.WriteLine("This is what it is divided " + test.divide());
        }
    }
}
