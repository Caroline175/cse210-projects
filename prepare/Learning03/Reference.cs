using System;
public class Reference
{
    private int chapter;
    private int verse;
    private string book;

    
    public Reference(int chapter, int verse, string book)
    {
        this.chapter = chapter;
        this.verse = verse;
        this.book = book;
    }

    
    public void Display()
    {
        Console.WriteLine($"{book} {chapter}:{verse}");
    }
}

