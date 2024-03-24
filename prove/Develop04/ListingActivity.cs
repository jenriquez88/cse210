class ListingActivity : Activity
{
    protected List<string> _prompts;

    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
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
        Console.WriteLine("Think about the prompt and list as many items as you can...");
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        List<string> answers = new List<string>();

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("* ");
            string answer = Console.ReadLine();

            answers.Add(answer);

            Thread.Sleep(200);
        }

        Console.WriteLine("Activity completed!");
        DisplayEndingMessage();
    }
}