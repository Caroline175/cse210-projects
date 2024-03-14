using System;

class Journal {
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry) {
        entries.Add(entry);
    }

    public void DisplayEntries() {
        foreach (var entry in entries) {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename) {
        using (StreamWriter writer = new StreamWriter(filename)) {
            foreach (var entry in entries) {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename) {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines) {
            string[] parts = line.Split('|');
            if (parts.Length == 3) {
                entries.Add(new Entry(parts[1], parts[2], parts[0]));
            }
        }
    }
}

