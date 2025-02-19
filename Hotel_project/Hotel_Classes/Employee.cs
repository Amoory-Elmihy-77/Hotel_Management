using System;

namespace Hotel_Classes
{
    // Interface
    interface IEmployeeActions
    {
        double CalculateSalary();
        void Work();
    }
    internal abstract class Employee : Person, IEmployeeActions
    {
        protected double Salary;
        public Employee(int id, string name, string phone, double salary) :base(id, name, phone)
        {
            this.Salary = salary;
        }
        public abstract double CalculateSalary();
        public abstract void Work();
    }
}
