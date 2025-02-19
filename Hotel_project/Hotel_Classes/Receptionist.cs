using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Classes
{
    public class Receptionist : Employee
    {
        public Receptionist(int id, string name, string phone, double salary) : base(id, name, phone, salary) { }

        public override double CalculateSalary()
        {
            return Salary;
        }

        public override void Work()
        {
            Console.WriteLine("Receptionist is handling guest check-ins.");
        }
        public override void DisplayInfo() {
            Console.WriteLine("Hi Sir, Welcome to Our Hotel");
        }
    }
}