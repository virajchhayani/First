using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    namespace First
    {
        internal class ex15
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
                int sideLength, length, width, radius, baseLength, height;

                Console.WriteLine("Enter the side length of the square:");
                sideLength = int.Parse(Console.ReadLine());
                Square square = new Square(sideLength);
                square.CalculateArea();
                Console.WriteLine("Area of Square: " + square.area);

                Console.WriteLine("\nEnter the length and width of the rectangle:");
                length = int.Parse(Console.ReadLine());
                width = int.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(length, width);
                rectangle.CalculateArea();
                Console.WriteLine("Area of Rectangle: " + rectangle.area);

                Console.WriteLine("\nEnter the radius of the circle:");
                radius = int.Parse(Console.ReadLine());
                Circle circle = new Circle(radius);
                circle.CalculateArea();
                Console.WriteLine("Area of Circle: " + circle.area);

                Console.WriteLine("\nEnter the base length and height of the triangle:");
                baseLength = int.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                Triangle triangle = new Triangle(baseLength, height);
                triangle.CalculateArea();
                Console.WriteLine("Area of Triangle: " + triangle.area);
            }
        }
    }
}
