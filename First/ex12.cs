using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Employee
    {
        int EmpID;
        string Name;
        string City;
        public Employee()
        {

        }
        public Employee(int EmpID, string Name)
        {
            this.EmpID = EmpID;
            this.Name = Name;
        }
        public Employee(int EmpID, string Name, string City) : this(EmpID, Name)
        {
            this.City = City;
        }
        public void Display()
        {
            Console.WriteLine($"EmpID: {EmpID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"City: {City}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            Employee obj2 = new Employee(101, "Viraj", "Jasdan");

            obj1.Display();
            Console.WriteLine();
            obj2.Display();

            Console.ReadKey();
        }
        
    }
}
