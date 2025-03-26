using System;

public class FlightBooking
{
    private string Destination;
    private string Departure;
    private string Date;

    // Constructor to Initialize Flight Details
    public FlightBooking()
    {
        Destination = "New York";
        Departure = "Tampa";
        Date = "12-03-2025";
    }

    public void Booking()
    {
        Console.WriteLine("Booking Confirmed!");
    }

    public virtual void DisplayFlightInfo()
    {
        Console.WriteLine($"Destination: {Destination}, Departure: {Departure}, Date: {Date}");
    }
}

// Main Method to Execute the Program
class Program
{
    static void Main()
    {
        FlightBooking flight = new FlightBooking();
        flight.Booking();
        flight.DisplayFlightInfo();

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}