using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    public void DisplayAll(List<Entry> _entries)
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string file)
    {
        string filename = file;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._prompText}, {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach  (string line in lines)
        {
            Entry entryFile = new Entry();
            string[] parts  = line.Split(",");
            entryFile._date = parts[0];
            entryFile._prompText = parts[1];
            entryFile._entryText = parts[2];
            
            _entries.Add(entryFile);
        }
    }
}