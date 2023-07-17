using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex9
    {
        static void change(ref double a, ref double b)
        {
            a = a + (0.10 * a);
            b = b + (0.20 * b);
        }
        static void Main(string[] args)
        {
            double a = 20, b = 30;
            change(ref a, ref b);
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Console.ReadKey();
        }
    }
}
