using System;

namespace First
{
    internal class ex13
    {
        class Person
        {
            protected int ID;
            protected string Name;
            protected string City;

            public Person(int ID, string Name, string City)
            {
                this.ID = ID;
                this.Name = Name;
                this.City = City;
            }
        }

        class Employee : Person
        {
            protected int Salary;

            public Employee(int ID, string Name, string City, int Salary) : base(ID, Name, City)
            {
                this.Salary = Salary;
            }
        }

        class Manager : Employee
        {
            protected int Allowance;

            public Manager(int ID, string Name, string City, int Salary, int Allowance) : base(ID, Name, City, Salary)
            {
                this.Allowance = Allowance;
            }

            public void Display()
            {
                Console.WriteLine("Manager Information:");
                Console.WriteLine("ID: " + ID);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("City: " + City);
                Console.WriteLine("Salary: " + Salary);
                Console.WriteLine("Allowance: " + Allowance);
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                Manager m1 = new Manager(1, "Viraj", "Jasdan", 25000, 1);
                m1.Display();
                Console.ReadKey();
            }
        }
    }
}
