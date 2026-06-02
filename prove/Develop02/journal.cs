using System;

class Journal
{
    public string _filenameNG;
    public List<Entry> _entriesNG = new List<Entry>();

    public void saveFileNG(){
        using (StreamWriter outputFile = new StreamWriter(_filenameNG))
        {
            foreach (Entry entryNG in _entriesNG)
            {
                outputFile.WriteLine(
                    $"{entryNG._dateNG}|" +
                    $"{entryNG._promptNG}|" +
                    $"{entryNG._responseNG}"
                );
            }
        }
    }
    public void loadFileNG(){
        string[] linesNG = File.ReadAllLines(_filenameNG);

        _entriesNG.Clear();

        foreach (string lineNG in linesNG)
        {
            string[] partsNG = lineNG.Split("|");

            Entry entryNG = new Entry();

            entryNG._dateNG = partsNG[0];
            entryNG._promptNG = partsNG[1];
            entryNG._responseNG = partsNG[2];

            _entriesNG.Add(entryNG);
        }

        Console.WriteLine("Journal loaded.");
    }

        public void displayEntriesNG()
    {
        foreach (Entry entryNG in _entriesNG)
        {
            entryNG.displayEntryNG();
            Console.WriteLine();
        }
    }
}
