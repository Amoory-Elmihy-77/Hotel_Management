using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace Hotel_Classes
{
    public class Customer : Person
    {
        private List<RoomDetails> bookedRooms = new List<RoomDetails>();
        public Customer(int id, string name, string phone) : base(id, name, phone) { }
        public void BookRoom(RoomDetails room)
        {
            bookedRooms.Add(room);
            Console.WriteLine($"{Name} booked Room {room.rnumber}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Customer: {Name}, Phone: {Phone}");
        }
    }
}