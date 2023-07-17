using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex7
    {
        int EmpID;
        string Name;
        string City;
        string position;
        int salary;
        int bonus;
        int gs;

        public void getdata()
        {
            Console.WriteLine("Employee ID : ");
            EmpID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Employee Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Employee City : ");
            City = Console.ReadLine();

            Console.WriteLine("Employee Position : ");
            position = Console.ReadLine();

            Console.WriteLine("Employee Salary(₹) : ");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Employee Bonus(₹) : ");
            bonus = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Employee ID: " + EmpID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("City: " + City);
            Console.WriteLine("Position: " + position);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("Gross Salary: " + gs);
        }
        public int CalculateSalary()
        {
            gs = salary + bonus;
            return gs;
        }
        public static void Main(string[] args)
        {
            ex7 employee = new ex7();
            employee.getdata();
            employee.CalculateSalary();
            employee.Display();
            Console.ReadLine();
        }
    }
}
