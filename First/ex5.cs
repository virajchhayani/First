using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex5
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("age of the candidate : ");
            a = int.Parse(Console.ReadLine());

            if (a >= 18)
            {
                Console.WriteLine("18 Congratulation!");
                Console.Write("You are eligible to caste your vote");
            }
            else
            {
                Console.Write("You would be able to vote after " + (18 - a) + " years");
            }
        }
    }
}
