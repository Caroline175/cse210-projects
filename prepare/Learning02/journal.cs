namespace journal;
using System;
using System.Data;

public List<Entry> entries;


public Journal()
{
    entries = new List<Entry>();
}

public Journal(string import)
{

}

public void Display()
{
 foreach (var entry in entries)
    {
        Console.WriteLine($"{entry.Date}: {entry.Content}");
    }
}

public string Export()
{
     

     foreach (var entry in entries)
    {
        
    }
    
    return exportString.ToString();
}

