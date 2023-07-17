using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex6
    {
        public static void Main(string[] args)
        {
            int p, m, c;
            Console.Write("Enter mark of Physics : ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Enter mark of Chemistry : ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Enter mark of Maths : ");
            m = int.Parse(Console.ReadLine());


            if (p >= 40 && c >= 40 && m >= 40)
            {
                Console.WriteLine("You are pass");
            }
            else
            {
                Console.WriteLine("Batter luck next time");
            }
        }
    }
}
