using System;
using System.Collections.Generic;

class Hotel
{
    public string Name { get; set; }
    public string Location { get; set; }
    public List<Room> Rooms { get; set; }

    public Hotel(string name, string location)
    {
        Name = name;
        Location = location;
        Rooms = new List<Room>();
    }

    public void AddRoom(Room room)
    {
        Rooms.Add(room);
    }

    public void RemoveRoom(Room room)
    {
        Rooms.Remove(room);
    }
}

class Room
{
    public int Number { get; set; }
    public string Type { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; }

    public Room(int number, string type, double price, bool isAvailable)
    {
        Number = number;
        Type = type;
        Price = price;
        IsAvailable = isAvailable;
    }

    public override string ToString()
    {
        return $"Room {Number} ({Type}), {Price:C}/night, Available: {IsAvailable}";
    }
}

class Booking
{
    public Room Room { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Booking(Room room, DateTime checkIn, DateTime checkOut)
    {
        Room = room;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public double GetTotalPrice()
    {
        TimeSpan duration = CheckOut - CheckIn;
        int nights = duration.Days;
        return nights * Room.Price;
    }

    public override string ToString()
    {
        return $"Booking for Room {Room.Number} ({Room.Type}), {GetTotalPrice():C}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hotel hotel = new Hotel("Grand Hotel", "New York");

        Room room1 = new Room(101, "Single", 89.99, true);
        Room room2 = new Room(102, "Double", 129.99, true);
        Room room3 = new Room(103, "Suite", 199.99, false);

        hotel.AddRoom(room1);
        hotel.AddRoom(room2);
        hotel.AddRoom(room3);

        Console.WriteLine($"Welcome to {hotel.Name} in {hotel.Location}!");
        Console.WriteLine("Rooms:");
        foreach (Room room in hotel.Rooms)
        {
            Console.WriteLine(room);
        }

        Console.WriteLine();
        Console.WriteLine("Making a booking for Room 101 from 2023-04-05 to 2023-04-07...");

        Booking booking = new Booking(room1, new DateTime(2023, 04, 05), new DateTime(2023, 04, 07));
        room1.IsAvailable = false;

        Console.WriteLine(booking);
        Console.WriteLine($"Room {room1.Number} is now {(room1.IsAvailable ? "available" : "not available")}");

        Console.ReadLine();
    }
}

