using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Patten1234
    {
        static void Main()
        {
            int n = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
