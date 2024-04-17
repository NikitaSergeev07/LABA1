using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba1_1;
class Program
{
    static void Main(string[] args)
    {
        RationalNumber r1 = new RationalNumber(5, -10);
        RationalNumber r2 = new RationalNumber(1, 3);

        Console.WriteLine(r1.ToString()); 
        Console.WriteLine(r2.ToString()); 

        Console.WriteLine(r1 + r2); 

        Console.WriteLine(r1 - r2); 

        Console.WriteLine(r1 * r2); 

        Console.WriteLine(r1 / r2); 

        Console.WriteLine(-r1);

        Console.WriteLine(r1 == r2);

        Console.WriteLine(r1 < r2); 

        Console.WriteLine(r1 > r2); 
    }
}