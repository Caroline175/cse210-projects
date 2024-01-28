using System;

public class Job 
{
    public string _jobTitle;
    public string company; 
    public int startYear;
    public int endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({company}) {startYear}{endYear}");
    }

}