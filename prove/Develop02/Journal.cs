public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.PromptText}");
            Console.WriteLine($"Entry: {entry.EntryText}");
            Console.WriteLine("");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                sw.WriteLine($"{entry.Date},{entry.PromptText},{entry.EntryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        using (StreamReader sr = new StreamReader(file))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                Entry loadedEntry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(loadedEntry);
            }
        }
    }
}