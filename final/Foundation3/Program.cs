using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");
        
        // Lectures
        Console.WriteLine("\n**Lectures**");
        Address address1 = new Address("Street1","City1","State1","Country1");
        Lectures lectures1 = new Lectures("Speaker A", 50, "Event Title 1", "Description 1", "Date 1 - 2023/06/01", "Time1 - 14:00", address1.GetAddressDetail());
        Console.WriteLine($"Standard Details: \n{lectures1.GetStandardDetails()}");
        Console.WriteLine($"Full Details: \n{lectures1.GetFullDetails()}");
        Console.WriteLine($"Short Description: \n{lectures1.GetShortDescription()}");

        //Receptions
        Console.WriteLine("\n**Receptions**");
        Address address2 = new Address("Street2","City2","State2","Country2");
        Receptions receptions1 = new Receptions("email1@mail.com", "Event Title 2", "Description 2", "Date 2 - 2023/07/01", "Time2 - 16:00", address2.GetAddressDetail());
        Console.WriteLine($"Standard Details: \n{receptions1.GetStandardDetails()}");
        Console.WriteLine($"Full Details: \n{receptions1.GetFullDetails()}");
        Console.WriteLine($"Short Description: \n{receptions1.GetShortDescription()}");
        
        //OutdoorGatherings
        Console.WriteLine("\n**OutdoorGatherings**");
        Address address3 = new Address("Street3","City3","State3","Country3");
        OutdoorGatherings outdoorGatherings1 = new OutdoorGatherings("Cloudy", "Event Title 3", "Description 3", "Date 3 - 2023/08/01", "Time3 - 17:00", address3.GetAddressDetail());
        Console.WriteLine($"Standard Details: \n{outdoorGatherings1.GetStandardDetails()}");
        Console.WriteLine($"Full Details: \n{outdoorGatherings1.GetFullDetails()}");
        Console.WriteLine($"Short Description: \n{outdoorGatherings1.GetShortDescription()}");
    }
}