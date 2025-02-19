using System;
using System.Xml.Linq;

namespace Hotel_Classes
{
    public sealed class Manager : Employee
    {
        public Manager(int id, string name, string phone, double salary) : base(id, name, phone, salary) { }

        public override double CalculateSalary()
        {
            return Salary * 1.2;
        }

        public override void Work()
        {
            Console.WriteLine("Manager is overseeing hotel operations.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"I am {Name}, and I am The Manager");
        }
    }
}