using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex14
    {
        class Shape
        {
            protected internal int area;
            public virtual void CalculateArea()
            {
            }
        }
        class Square : Shape
        {
            int side;
            public Square(int sideLength)
            {
                side = sideLength;
            }
            public override void CalculateArea()
            {
                area = side * side;
            }
        }
        class Rectangle : Shape
        {
            int length;
            int width;
            public Rectangle(int length, int width)
            {
                this.length = length;
                this.width = width;
            }
            public override void CalculateArea()
            {
                area = length * width;
            }
        }
        class Circle : Shape
        {
            int radius;
            public Circle(int radius)
            {
                this.radius = radius;
            }
            public override void CalculateArea()
            {
                area = (int)(Math.PI * radius * radius);
            }
        }
        class Triangle : Shape
        {
            int baseLength;
            int height;
            public Triangle(int baseLength, int height)
            {
                this.baseLength = baseLength;
                this.height = height;
            }
            public override void CalculateArea()
            {
                area = (baseLength * height) / 2;   
            }
        }
        public static void Main(string[] args)
        {
            Square square = new Square(7);
            square.CalculateArea();
            Console.WriteLine("Side = 7");
            Console.WriteLine("Area of Square: " + square.area);

            Rectangle rectangle = new Rectangle(2, 8);
            rectangle.CalculateArea();
            Console.WriteLine("Length = 2 and Width = 8");
            Console.WriteLine("Area of Rectangle: " + rectangle.area);

            Circle circle = new Circle(5);
            circle.CalculateArea();
            Console.WriteLine("Radius = 5");
            Console.WriteLine("Area of Circle: " + circle.area);

            Triangle triangle = new Triangle(6, 8);
            triangle.CalculateArea();
            Console.WriteLine("BaseLength = 6 and Height = 8");
            Console.WriteLine("Area of Triangle: " + triangle.area);
        }
    }
}
