using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class patten7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms: ");
            int numberOfTerms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int term = number;
            string series = "";

            for (int i = 1; i <= numberOfTerms; i++)
            {
                sum += term;
                series += term;

                if (i < numberOfTerms)
                {
                    series += "+";
                }

                term = term * 10 + number;
            }

            Console.WriteLine("Series: " + series);
            Console.WriteLine("The sum is: " + sum);

            Console.ReadLine();
        }
    }
}