using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class t2_2
    {
        static void Main()
        {
            // Declare and initialize an array of integers with five elements.
            int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

            // Accessing elements using index.
            Console.WriteLine("Element at index 0: " + numbers[0]); // Output: 10
            Console.WriteLine("Element at index 2: " + numbers[2]); // Output: 30

            // Modifying an element using index.
            numbers[1] = 25;
            Console.WriteLine("Modified element at index 1: " + numbers[1]); // Output: 25

            // Iterating through the array using a loop.
            Console.WriteLine("All elements in the array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " "); // Output: 10 25 30 40 50
            }
        }

    }
}
