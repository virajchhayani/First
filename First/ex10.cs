using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex10
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Before swap: a = {a}, b = {b}");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After swap: a = {a}, b = {b}");
            Console.ReadLine();
        }
    }
}
