using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programs_11_to_15
{
    internal class Quadratic
    {
        public void Roots(double a, double b, double c)
        {
            double r1 = 0, r2 = 0, d = 0;
            d = b*b-4*a*c;

            if(a==0)
            {
                Console.WriteLine("Not a Quadratic Equation");
            }

            else if(d<0)
            {
                Console.WriteLine("Roots are Imaginary");
                r1 = -b / (2.0 * a);
                r2 = Math.Sqrt(-d) / (2.0 * a);
                Console.WriteLine("First Root: {0:#.##} + {1:#.##}i", r1 ,r2);
                Console.WriteLine("First Root: {0:#.##} - {1:#.##}i", r1 ,r2);
            }

            else if(d>0) 
            {
                Console.WriteLine("Roots are Real and Distinct");
                r1 = (-b + Math.Sqrt(d))/ (2.0 * a);
                r2 = (-b - Math.Sqrt(d)) / (2.0 * a);
                Console.WriteLine("First Root: {0:#.##}", r1);
                Console.WriteLine("Second Root: {0:#.##}", r2);
            }

            else
            {
                Console.WriteLine("Roots are Real and Equal");
                r1 = r2 = -b / (2.0 * a);
                Console.WriteLine("First Root: {0:#.##}" ,r1);
                Console.WriteLine("Second Root: {0:#.##}" ,r2);
            }
        }
    }
}
