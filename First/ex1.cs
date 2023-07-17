    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            Int32 number = 10;
            Console.WriteLine("Number : " + number);
            double pi = 3.14;
            Console.WriteLine("Pi Value : " + pi);
            string name = "Viraj";
            Console.WriteLine("Your Name :  " + name);
            if (number > 5)
            {
                Console.WriteLine("Number is greater than 5");
            }
            else
            {
                Console.WriteLine("Number is less than or equal to 5");
            }

            for (Int32 i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
