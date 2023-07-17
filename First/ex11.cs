using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex11
    {
        static void change(double a, double b, out double sum, out double mul)
        {
            sum = a + b;
            mul = a * b;
        }
        static void Main(string[] args)
        {
            double a = 20, b = 30, sum, mul;
            change(a, b, out sum, out mul);
            Console.WriteLine("sum : " + sum);
            Console.WriteLine("mul : " + mul);
            Console.ReadKey();
        }
    }
}
