using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex3
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Enter the first value :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value :");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swapping : a = {a}, b = {b}");

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After swapping : a = {a}, b = {b}");
        }
    }
}
