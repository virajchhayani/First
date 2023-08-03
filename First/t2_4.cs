using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class t2_4
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"You entered {args.Length} command-line arguments:");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"Argument {i + 1}: {args[i]}");
                }
            }
            else
            {
                Console.WriteLine("No command-line arguments provided.");
            }
        }
    }
}
