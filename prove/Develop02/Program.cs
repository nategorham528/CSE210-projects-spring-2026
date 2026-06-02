using System;

//Nate Gorham
//References:

//https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-integer-in-c
//https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=net-10.0

class Program
{
    static void Main(string[] args)
    {
        string choiceNG = "0";
        Journal journalNG = new Journal();
        
        Console.WriteLine("Welcome to your journal, What would you like to do today?");

        do{  
            Console.WriteLine("1: Write a Journal Entry.");
            Console.WriteLine("2: Display Journal Entries.");
            Console.WriteLine("3: Save Journal to a File.");
            Console.WriteLine("4: Load Journal From a File.");
            Console.WriteLine("5: Exit program");           
            Console.Write("Please pick an option 1-5: ");
            choiceNG = Console.ReadLine();
            Console.WriteLine("");

            //Write
            if(choiceNG == "1"){
                PromptGenerator pgNG = new PromptGenerator();
                int numNG = pgNG.numGeneratorNG();
                DateTime currentDate = DateTime.Now;
                Entry entryNG = new Entry();
                entryNG._promptNG = pgNG.promptOptionsNG(numNG);
                entryNG._dateNG = currentDate.ToString();
                entryNG._responseNG = entryNG.writeEntryNG();
                journalNG._entriesNG.Add(entryNG);
            }

            //Display
            else if(choiceNG == "2"){
                journalNG.displayEntriesNG();
            }

            //Save
            else if(choiceNG == "3"){                
                Console.WriteLine("What file would you like to save these entries to: ");
                journalNG._filenameNG = Console.ReadLine();
                journalNG.saveFileNG();
            }

            //Load
            else if(choiceNG == "4"){
                Console.WriteLine("What is the name of the file you would like to load: ");
                journalNG._filenameNG = Console.ReadLine();
                journalNG.loadFileNG();
            }

            else if(choiceNG == "5"){
                Console.WriteLine("Thank you for using your Journal today.");
            }

            else{
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
        while(choiceNG != "5");
    }
}
