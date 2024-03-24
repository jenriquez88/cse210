class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
    }

    public override void DisplayEndingMessage()
    {
        base.DisplayEndingMessage();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Count)];

        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endtime)
        {

            Console.WriteLine($"Prompt: {prompt}");
            ShowSpinner(5);
            
            

            foreach (var question in _questions)
            {
                Console.WriteLine($"Question: {question}");
                ShowSpinner(5);
                Console.ReadKey();
            }
        }
        
        DisplayEndingMessage();
    }
}