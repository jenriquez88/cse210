class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description){}

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
        int remainingTime = _duration;

        while (remainingTime > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            remainingTime -= 4;

            if (remainingTime <= 0)
                break;

            Console.WriteLine("Breathe out...");
            ShowCountDown(6);
            remainingTime -= 6;
        }

        DisplayEndingMessage();
    }
}