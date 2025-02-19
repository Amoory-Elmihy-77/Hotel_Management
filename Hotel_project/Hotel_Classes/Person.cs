using System;

namespace Hotel_Classes
{
    public abstract class Person
    {
        protected int Id;
        protected string Name;
        protected string Phone;

        public Person(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public abstract void DisplayInfo();
    }
}