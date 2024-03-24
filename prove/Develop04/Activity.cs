class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public virtual void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the  {_name} activity:");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        Console.Write("Please set the duration for this activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.Clear();
        Console.WriteLine($"Prepare to begin {_name} activity...");
        ShowSpinner(3);
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine("Congratulations!");
        Console.WriteLine($"You've completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {

        List<string> animationStrings =new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");


        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endtime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}