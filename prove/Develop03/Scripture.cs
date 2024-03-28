using System;
using System.ComponentModel.DataAnnotations;
using System.Xml;

public class Scripture 
{
    private string _scriptureText;
    private Word _word;
    private Reference _reference;
    

    public Scripture(string scriptureStr, Reference reference)
    {
        _scriptureText = scriptureStr.TrimEnd();
        _word = new Word (_scriptureText.Split(" "));

        _reference = reference;


    }
   
      public void Display()
    {
        Console.WriteLine($"Scripture: {_scriptureText}");
        System.Console.WriteLine($"Reference: {_reference}");
        Console.WriteLine("Press 'Enter' to reveal a word, or type 'quit' to end:");
        _word.Display();
        
    }
  
    
    
 
  


}    