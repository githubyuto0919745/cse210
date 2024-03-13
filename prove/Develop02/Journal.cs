using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;

public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void DisplayJournal()
    {
        foreach(Entry entry in entries)
        {
            Console.WriteLine("Date: " + entry._date);
            Console.WriteLine("Prompt: " + entry._prompt);
            Console.WriteLine("Response: " + entry._response);
        }
    
    }


    public void SaveJournal(string fileName)
    {
        try
        {
            System.Console.WriteLine("Saving to file: "+fileName);
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach ( Entry entry in entries)
                {
                    writer.WriteLine(entry._date + "|" + entry._prompt + "|" + entry._response);
                }
            }
            System.Console.WriteLine("Save successful!");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine("Error saving file: " + ex.Message);
        }
    }   

    public void LoadJournal(string fileName)
    {
        entries.Clear();

        try
        {
            

            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while((line = reader.ReadLine()) !=null)
                    {
                        string[] parts = line.Split("|");
                        Entry entry = new Entry();
                        entry._date = parts[0];
                        entry._prompt = parts[1];
                        entry._response = parts[2];
                        entries.Add(entry);
                    }
                }
                System.Console.WriteLine("Load successful!");

            }
            else
            {
                System.Console.WriteLine("File not found.");
            }
        } 
        catch (Exception ex)
        {
            System.Console.WriteLine("Error loading file: " + ex.Message);
        }   
    }
}