public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _count = 0;

    public GoalManager()
    {

    }

    public void Start()
{
    string theMenu = "\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\n";
    bool keepPlaying = true;

    while (keepPlaying)
    {
        DisplayPlayerPoint();
        Console.WriteLine(theMenu);
        Console.Write("Select a choice from the menu: ");

        if (int.TryParse(Console.ReadLine(), out int userChoice))
        {
            switch (userChoice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    Console.WriteLine();
                    ListGoals();
                    break;
                case 3:
                    SaveGoal();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    keepPlaying = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option from the menu.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}


    private  void DisplayPlayerPoint()
    {
        Console.WriteLine($"\nYou have {_score} points");
    }

    private void ListGoalNames()
    {
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetGoalName()}");
            }
            _count = 0;
        }
        else 
        {
            Console.WriteLine("The list of goals is empty. Either load your saved goals or create new ones");
        }
    }

    private void ListGoalDetails()
    {
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetDetailsString()}");
            }
            _count = 0;
        }
        else 
        {
            Console.WriteLine("The list of goals is empty. Either load your saved goals or create new ones");
        }
    }

    private void CreateGoal()
    {
        string[] goalTypes = {"Simple Goal", "Eternal Goals", "Checklist Goals"};
        Console.WriteLine($"\nThe types of goals are: \n1. {goalTypes[0]} \n2. {goalTypes[1]} \n3. {goalTypes[2]}\n");
        Console.Write("\nWhat type of goal do you want create?: ");
        int typeOfGoal = int.Parse(Console.ReadLine()) - 1;

        if (typeOfGoal == 0)
        {
            SimpleGoal simpleGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[typeOfGoal]);
            _goals.Add(simpleGoal);
        }
        else if (typeOfGoal == 1)
        {
           EternalGoal eternalGoal = new (name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[typeOfGoal]);
           _goals.Add(eternalGoal);
        }
        else if (typeOfGoal == 2)
        {
            CheckListGoal checkListGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalTypes[typeOfGoal], target: SetCheckListCount(), bonus: SetBonusPoint());
            _goals.Add(checkListGoal);
        }
        else
        {
            Console.WriteLine("Invalid: This option does not exist.");
        }
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nWhich goal did you accomplished: ");
        int goalCompleteIndex = int.Parse(Console.ReadLine());

        Goal goalAccomplished = _goals[goalCompleteIndex - 1];
        goalAccomplished.SetIsCompleteToTrue();
        goalAccomplished.RecordEvent();
        _score += goalAccomplished.GetCurrentPoint();

        string congratMessage = $"\nCongratulations!!! You have earned {goalAccomplished.GetSetPoint()}\nYou now have {_score} points";
        Console.WriteLine(congratMessage);
        DisplayPlayerPoint();
    }

    private void ListGoals()
    {
        ListGoalDetails();
    }

    private void SaveGoal()
    {
        Console.Write("\nWhat would you like to name the file? (do not include the .txt) ");
        string file = Console.ReadLine();

        using StreamWriter saveGoals = new StreamWriter($"{file}.txt", true);
        saveGoals.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            saveGoals.WriteLine(goal.GetStringRepresentation());
        }
        _goals.Clear();
    }

    private void LoadGoals()
    {
        Console.WriteLine("Write the file name where you saved the score and the goals? ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        bool fistLine = true;

        foreach (string line in lines)
        {
            if (fistLine == true) {
                _score = Int32.Parse(line);
                fistLine = false; 
                continue;
            }

            string[] parts = line.Split('|');

            if (parts[0].Trim() == "Simple Goal") {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1].Trim(), parts[2].Trim(), Int32.Parse(parts[3].Trim()), parts[0].Trim());
                simpleGoal.setIsComplete(Convert.ToBoolean(parts[4]));
                _goals.Add(simpleGoal);
            }
            else if (parts[0].Trim() == "Eternal Goals") {
                _goals.Add(new EternalGoal(parts[1].Trim(), parts[2].Trim(), Int32.Parse(parts[3].Trim()), parts[0].Trim()));
            }
            else {
                CheckListGoal checkListGoal = new CheckListGoal(parts[1].Trim(), parts[2].Trim(), Int32.Parse(parts[3].Trim()), parts[0], Int32.Parse(parts[4].Trim()), Int32.Parse(parts[5].Trim()));
                checkListGoal.AddSaveAmountCompleted(Int32.Parse(parts[6]));
                checkListGoal.setIsComplete(Convert.ToBoolean(parts[7]));
                _goals.Add(checkListGoal);
            }
        }
    }

    private string SetGoalName()
    {
        Console.Write("\nWhat is the name of the goal? : ");
        string _goalname = Console.ReadLine();
        return _goalname;
    }

    private int SetGoalPoint()
    {
        Console.Write("\nEnter the amount of point you want to achieve: ");
        int _goalPoint = int.Parse(Console.ReadLine());
        return _goalPoint;
    }

    private string SetGoalDescription()
    {
        Console.Write("\nWrite a short description of the goal: ");
        string _goalDescription = Console.ReadLine();
        return _goalDescription;
    }

    private int SetBonusPoint()
    {
        Console.Write("\nEnter the amount of bonus point you want to achieve for this goal: ");
        int _bonusPoint = int.Parse(Console.ReadLine());
        return _bonusPoint;
    }

    private int SetCheckListCount()
    {
        Console.Write("\nHow many times does this goal need to be accomplished for a bonus? : ");
        int _checklistCount = int.Parse(Console.ReadLine());
        return _checklistCount;
    }
}