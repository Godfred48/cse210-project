using System;
//this system helps in accessing files
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    //This method tEntrykes in entries Entrynd storre them in the Entry list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.");
            return;
        }
          foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine(); // For spacing between entries
        }

    }

    public void SaveToFile(string file)
    {
         using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}||{entry._promptText}||{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
{
    string[] lines = File.ReadAllLines(file);
    foreach (string line in lines)
    {
        string[] parts = line.Split("||");
        if (parts.Length == 3)
        {
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }
    }
}

}