using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressLecture = new Address("510 S Center St", "Rexburg", "Idaho", "USA");
        Lecture lectureEvent = new Lecture();
        lectureEvent.SetAddress(addressLecture);
        lectureEvent.SetEvent("Lecture");
        lectureEvent.SetTitle("How to teach your Friends to Code");
        lectureEvent.SetDescription("This lecture will help you be able to teach your family and friends simple ways to code!");
        lectureEvent.SetDate("12/20/24");
        lectureEvent.SetTime("7:00PM");
        lectureEvent.SetSpeaker("Brother Gibbons");
        lectureEvent.SetCapacity("500 people");
        
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("------------------------ Lecture ------------------------");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine(lectureEvent.StandardDetails());
        Console.WriteLine(lectureEvent.ShortDescription());
        Console.WriteLine(lectureEvent.FullDetails());

        Address addressReception = new Address("48 S 2nd E", "Rexburg", "Idaho", "USA");
        Reception receptionEvent = new Reception();
        receptionEvent.SetAddress(addressReception);
        receptionEvent.SetEvent("Reception");
        receptionEvent.SetTitle("Tom and Jenny Wedding Reception");
        receptionEvent.SetDescription("Come support Tom and Jenny celebrate getting married");
        receptionEvent.SetDate("1/1/25");
        receptionEvent.SetTime("6:30PM");
        receptionEvent.SetEmail("tomandjennyweddingplans@weddingplanner.com");

        
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("------------------------ Reception ------------------------");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine(receptionEvent.StandardDetails());
        Console.WriteLine(receptionEvent.ShortDescription());
        Console.WriteLine(receptionEvent.FullDetails());

        Address addressOutdoor = new Address("S 2nd W & 3rd W", "Rexburg", "Idaho", "USA");
        Outdoor outdoorEvent = new Outdoor();
        outdoorEvent.SetAddress(addressOutdoor);
        outdoorEvent.SetEvent("Outdoor Gathering");
        outdoorEvent.SetTitle("Ultimate Ultimate Frisbee");
        outdoorEvent.SetDescription("Join us for the most ultimate game of ultimate frisbee known to man.");
        outdoorEvent.SetDate("12/25/24");
        outdoorEvent.SetTime("5:00PM");
        outdoorEvent.SetWeather("Cloudy; High of 28, Low of 13");

        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("------------------------ Outdoor Gathering ------------------------");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine(outdoorEvent.StandardDetails());
        Console.WriteLine(outdoorEvent.ShortDescription());
        Console.WriteLine(outdoorEvent.FullDetails());
    }

}