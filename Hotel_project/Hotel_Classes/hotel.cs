namespace Hotel_Classes
{
    // Enums
    public enum RoomType { Standard, Luxury }

    // Structures
    public struct RoomDetails
    {
        public RoomType rType;
        public int rnumber;
        public double rPrice;
    }

    // Static Utility Class (Static Type)
    public static class HotelHelper
    {
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Hotel Management System!");
        }
    }

    internal class Hotel
    {
        public string Name { get; set; }
        private List<RoomDetails> rooms = new List<RoomDetails>();
        private List<Customer> customers = new List<Customer>();
        private List<Employee> employees = new List<Employee>();

        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(RoomDetails room) => rooms.Add(room);
        public void AddCustomer(Customer customer) => customers.Add(customer);
        public void AddEmployee(Employee employee) => employees.Add(employee);
    }
}