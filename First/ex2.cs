using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double sub = num1 - num2;
            double mult = num1 * num2;
            double divi = num1 / num2;

            Console.WriteLine("Sum  (+) : " + sum);
            Console.WriteLine("Sub  (-) : " + sub);
            Console.WriteLine("Mult (*) : " + mult);
            Console.WriteLine("Divi (/) : " + divi);
        }
    }
}
