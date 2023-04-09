using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_Day1_VehicleRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Booking booking = new Booking();

            booking.BookVehicle(new FourWheeler {  VehicleRTOnumber = "1234", Color = "Red", SafetyRatings = "5-star" ,});
            booking.CancelBooking();
        }
    }

    public class Vehicle
    {
        public string VehicleRTOnumber { get; set; }
        public string Color { get; set; }
    }

    public class FourWheeler : Vehicle
    {
        public enum FourWheelerType
        {
            Micro = 1,
            Sedan = 2,
            SUV = 3
        }

        public string SafetyRatings { get; set; }
    }

    public class TwoWheeler : Vehicle
    {
        public enum TwoWheelerType
        {
            Motorcycle = 1,
            Scooter = 2
        }

        public string EngineCC { get; set; }
    }

    public class User
    {
        public class UserDetails
        {
            public string UserName { get; set; }
            private string UserId { get; set; }
        }
    }

    public class Booking
    {
        public Vehicle vehicle;
        public User.UserDetails userDetails;

        public void BookVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Vehicle with RTOnumber {0} has been booked.", vehicle.VehicleRTOnumber);
        }

        public void CancelBooking()
        {
            if (vehicle != null)
            {
                Console.WriteLine("Booking for vehicle with RTOnumber {0} has been cancelled.", vehicle.VehicleRTOnumber);
                vehicle = null;
            }
            else
            {
                Console.WriteLine("No booking found to cancel.");
            }
        }
    }
}
