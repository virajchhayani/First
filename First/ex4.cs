using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max = num1;
            int min = num1;

            if (num2 > max)
            {
                max = num2;
            }
            else if (num3 > max)
            {
                max = num3;
            }
            if (num2 < min)
            {
                min = num2;
            }
            else if (num3 < min)
            {
                min = num3;
            }

            Console.WriteLine($"Maximum number : {max}");
            Console.WriteLine($"Minimum number : {min}");
        }
    }
}
