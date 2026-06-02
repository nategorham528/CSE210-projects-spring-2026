using System;

class Entry
{
    public string _promptNG;
    public string _responseNG;
    public string _dateNG;
    
    public string writeEntryNG(){
        Console.WriteLine($"{_dateNG} {_promptNG}");
        string entryNG = Console.ReadLine();

        return entryNG;
    }

    public void displayEntryNG(){
        Console.WriteLine($"Date: {_dateNG}");
        Console.WriteLine($"Prompt: {_promptNG}");
        Console.WriteLine($"Response: {_responseNG}");
    }
}
