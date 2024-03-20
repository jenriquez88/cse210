    public class Entry
    {
        public string _date;
        public string _promptText;
        public string _entryText;

        public string Date
        {
            get { return _date; }
        }   

        public string PromptText
        {
            get { return _promptText; }
        }

        public string EntryText
        {
            get { return _entryText; }
        }
        
        public Entry(string promptText, string entryText)
        {
            _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            _promptText = promptText;
            _entryText = entryText;
        }

        public Entry(string date, string promptText, string entryText)
        {
            _date = date;
            _promptText = promptText;
            _entryText = entryText;
        }

        public void Display()
        {
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_promptText}");
            Console.WriteLine($"Entry: {_entryText}\n");
        }
    }