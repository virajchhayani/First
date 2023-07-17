using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class patten6
    {
        static void Main()
        {
            int line = 4;
            int number = 1;
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < line - i - 1; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0,-4}", number);
                    number++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
