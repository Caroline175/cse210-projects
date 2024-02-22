using System;

public class Entry
{
    public string response;
    public string prompt;
    public string date;

    public Entry(string response, string prompt)
    {
        this.response = response;
        this.prompt = prompt;
        this.date = DateTime.Now.ToString();
    }

    public Entry(string import)
    {

    }

    public void Display()
    {
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine($"Response: {response}");
    }
    }

