using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class t2_3_1
    {
        static void IncrementValue(int num)
        {
            num += 1; // Changes only the local copy of 'num'
        }
        public static void Main(string[] args)
        {
            int number = 10;
            IncrementValue(number);
            Console.WriteLine(number); // Output: 10 (unchanged)
            Console.ReadLine();
        }
    }
}
