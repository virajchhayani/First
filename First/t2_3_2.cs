using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class t2_3_2
    {
        static void IncrementValueByRef(ref int num)
        {
            num += 1; // Changes the original value of 'num'
        }
        static void Main()
        {
            int number = 10;
            IncrementValueByRef(ref number);
            Console.WriteLine(number); // Output: 11 (modified)
        }
    }
}
