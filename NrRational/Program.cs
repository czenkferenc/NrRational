using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrRational
{
    class Program
    {
        static void Main(string[] args)
        {
            rational r1 = new rational(2, 3);
            rational r2 = new rational(3, 6);
            rational r3 = new rational();
            rational r4 = new rational(2);
            //rational r5 = new rational(2,0);

            Console.WriteLine(r1.ToString());
            Console.WriteLine(r2.ToString());
            Console.WriteLine(r3.ToString());
            Console.WriteLine(r4.ToString());
            Console.WriteLine();

            r3 = r1 + r2;
            Console.WriteLine(r3.ToString());

            r3 = r2 - r1;
            Console.WriteLine(r3.ToString());

            r3 = r1 * r2;
            Console.WriteLine(r3.ToString());

            r3 = r1 / r2;
            Console.WriteLine(r3.ToString());

            r3 = r1 ^ 2;
            Console.WriteLine(r3.ToString());
            Console.WriteLine();

            if (r1 > r2) Console.WriteLine("true");
            else Console.WriteLine("false");

            if (r1 == r2) Console.WriteLine("true");
            else Console.WriteLine("false");

            if (r1 <= r2) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
    }
}
