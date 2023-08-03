using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex16
    {
        interface Ishap
        {
            int Area();

        }
        interface Ishap2 : Ishap
        {
            int Cost();
        }
        class Square : Ishap2
        {
            protected int h;
            public Square(int h)
            {
                this.h = h;
            }
            public int Area()
            {
                return (2 * h);
            }
            public int Cost()
            {
                return (2 * 100 * h);
            }
        }

        class Rect : Ishap2
        {
            protected int h;
            protected int w;
            public Rect(int h, int w)
            {
                this.h = h;
                this.w = w;
            }
            public int Area()
            {
                return (w * h);
            }
            public int Cost()
            {
                return (w * h * 100);
            }
        }
        class Interface
        {
            static void Main(string[] args)
            {
                Square s1 = new Square(30);
                Console.WriteLine(s1.Area());
                Console.WriteLine(s1.Cost());

                Rect s2 = new Rect(7, 4);
                Console.WriteLine(s2.Area());
                Console.WriteLine(s2.Cost());
                //s2.test(); // error
            }
        }
    }
}
