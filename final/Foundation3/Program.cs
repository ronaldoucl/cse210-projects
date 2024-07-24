using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 Maple St", "Springfield", "IL", "62704","USA");
        Lecture lecture = new Lecture("Future of Artificial Intelligence", "An insightful discussion on the future implications of AI in various industries.", "2024-09-21", "3:00 PM", address1, "Dr. Emily Watson", 150);
        Console.WriteLine("Event #1");
        Console.WriteLine(lecture.GenerateStandard());
        Console.WriteLine(lecture.GenerateDetailedLecture());
        Console.WriteLine(lecture.GenerateShortLecture());
        Console.WriteLine("-------------------------------");    
        
        Address address2 = new Address("5678 Oak Ave", "Fresno", "CA", "93722", "USA");
        Reception reception = new Reception("Annual Art Gallery Opening", "Join us for the opening night of our annual art exhibition featuring contemporary artists.", "2024-09-30", "6:00 PM", address2, "galleryopening@art");
        Console.WriteLine("Event #2");
        Console.WriteLine(reception.GenerateStandard());
        Console.WriteLine(reception.GenerateDetailedReception());
        Console.WriteLine(reception.GenerateShortReception());
        Console.WriteLine("-------------------------------");  

        Address address3 = new Address("910 Apple Blvd", "Austin", "TX", "78701", "USA");
        Outdoor outdoor = new Outdoor("Summer Park Picnic", "Gather your family and friends for a relaxing day in the park with games, food, and fun.", "2024-08-15", "12:00 PM", address3, "sunny and warm");
        Console.WriteLine("Event #3");
        Console.WriteLine(outdoor.GenerateStandard());
        Console.WriteLine(outdoor.GenerateDetailedOutdoor());
        Console.WriteLine(outdoor.GenerateShortOutdoor());
        Console.WriteLine("-------------------------------");  
    }
}