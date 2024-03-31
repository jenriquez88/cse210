public class GoalManager
{
    protected List<Goal> _goals;
    protected int _score;


    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    public void Start()
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to Eternal Quest. A goal tracker game");

        bool exit = false;
        while (!exit)
        {

            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.WriteLine("");
            
            

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("");

            switch (choice)
            {
                case 1:
                    DisplayPlayerInfo();
                    break;
                case 2:
                    ListGoalNames();
                    break;
                case 3:
                    ListGoalDetails();
                    break;
                case 4:
                    CreateGoal();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    SaveGoals();
                    break;
                case 7:
                    LoadGoals();
                    break;
                case 8:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.ShortName);
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (choice)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("Enter target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid choice. Goal creation failed.");
                return;
        }

        _goals.Add(goal);
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            _goals[choice].RecordEvent();
            _score += _goals[choice].Points;
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

public void LoadGoals()
{
    _goals.Clear();
    using (StreamReader reader = new StreamReader("goals.txt"))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(',');   
            if (parts.Length < 10)
            {
                Console.WriteLine($"* {line}");
                continue; 
            }

            string name = parts[0];
            string description = parts[1];
            int points;
            int amountCompleted;
            int target;
            int bonus;

            if (!int.TryParse(parts[2], out points) ||
                !int.TryParse(parts[3], out amountCompleted) ||
                !int.TryParse(parts[4], out target) ||
                !int.TryParse(parts[5], out bonus))
            {
                Console.WriteLine($"Error parsing data in line: {line}");
                continue; 
            }

            if (target > 0)
            {
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus)
                {
                    _amountCompleted = amountCompleted
                });
            }
            else
            {
                _goals.Add(new SimpleGoal(name, description, points)
                {
                    _isComplete = amountCompleted == 1
                });
            }
        }
    }
    Console.WriteLine("Goals loaded successfully.");
}
}