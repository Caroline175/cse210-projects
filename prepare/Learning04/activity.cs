using System;

//Activty Class (parent)
class Activity 
{
// display animation
Console.Write("+");

Thread.Sleep(500);

Console.Write("\b \b"); // Erase the + character
Console.Write("-"); // Replace it with the - character

    
}

//Breathing Class (child)
class Breathing : Activity
{

}

// Reflecting Class (child)
class Reflecting : Activity
{

}

// Listening Class (child)
class Listing : Activity
{

}

// pausing
Console.WriteLine("Going to sleep for a second...");

Thread.Sleep(1000);

Console.WriteLine("I'm back!!");




//working with time
DateTime startTime = DateTime.Now;
DateTime futureTime = startTime.AddSeconds(5);

Thread.Sleep(3000);

DateTime currentTime = DateTime.Now;
if (currentTime < futureTime)
{
    Console.WriteLine("We have not arrived at our future time yet...");
}

