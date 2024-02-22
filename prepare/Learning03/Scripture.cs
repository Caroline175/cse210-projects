using System;
using System.Collections.Generic;


public class Randomizer
{
    
}


public class WordManager
{
    private List<string> words;

    
    public WordManager()
    {
        words = new List<string>();
    }

    
    public void DisplayWords()
    {
        
    }

    
    public void HideWords()
    {
        
    }
}


public class Scripture
{
    private string text;
    private Reference reference;

    
    public Scripture(string text, List<string> words, Reference reference)
    {
        this.text = text;
        this.reference = reference;
    }
}


