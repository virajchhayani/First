using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class patten
    {
        static void Main()
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
