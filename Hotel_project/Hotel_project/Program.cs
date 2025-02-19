using Hotel_Classes;
using System.Numerics;
using System.Xml.Linq;

HotelHelper.PrintWelcomeMessage();

// Object Initialization Types
Customer customer1 = new Customer(1, "john doe", "111-222-333");
// Customer customer2 = new Customer() { Name = "Alice", Phone = "999-888-777" }; // in version 9.0
// Customer customer2 = new() { Name = "Alice", Phone = "999-888-777" }; // in version 9.0

Manager manager = new(2, "Alice Manager", "555-666-777", 5000);
Receptionist receptionist = new(3, "Bob Receptionist", "444-333-222", 3000);

RoomDetails room1 = new() { rnumber = 101, rType = RoomType.Standard, rPrice = 100 };
RoomDetails room2 = new() { rnumber = 201, rType = RoomType.Luxury, rPrice = 300 };

// Booking Room
customer1.BookRoom(room1);