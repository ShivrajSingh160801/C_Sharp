using System;

public class ParkingSpace
{
    private int number;
    private bool isOccupied;
    private string vehicleType;

    public ParkingSpace(int number, bool isOccupied, string vehicleType)
    {
     //Declaration and Implementation
    }

    public int Number
    {
        get { return number; }
        set { number = value; }
    }

    public bool IsOccupied
    {
        get { return isOccupied; }
        set { isOccupied = value; }
    }

    public string VehicleType
    {
        get { return vehicleType; }
        set { vehicleType = value; }
    }

    public void OccupySpace(string vehicleType)
    {
        if (isOccupied)
        {
            Console.WriteLine("Error: This space is already occupied.");
        }
        else
        {
            isOccupied = true;
            Console.WriteLine("Success: Parking space {0} has been occupied by a {1}.", number, vehicleType);
        }
    }

    public void FreeSpace()
    {
        if (!isOccupied)
        {
            Console.WriteLine("Error: This space is already free.");
        }
        else
        {
            isOccupied = false;
            vehicleType = "";
            Console.WriteLine("Success: Parking space {0} has been freed.", number);
        }
    }
}
