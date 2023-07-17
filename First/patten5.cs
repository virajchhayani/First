using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class patten5
    {
        static void Main(string[] args)
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
