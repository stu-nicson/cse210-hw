using System.Runtime.Intrinsics.Arm;

public abstract class Goal
{
    //attributes
    protected bool _done;
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected int _currentPoints;

    //constructor

    //methods
    public int GetName(int count)
    {
        System.Console.WriteLine($"{count}. {_name}");
        count += 1;
        return count;
    }
    public int GetCurrentPoints()
    {
        return _currentPoints;
    }
    public void SetDone(bool done)
    {
        _done = done;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPointValue(int pointValue)
    {
        _pointValue = pointValue;
    }


    public virtual void ConstructGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        _description = Console.ReadLine();
        Console.WriteLine("what is the amount of points associated with this goal?");
        _pointValue = int.Parse(Console.ReadLine());
    }

    public virtual void CompleteGoal()
    {
        Console.WriteLine("The Goals Are: ");
        
    }

    public abstract int DisplayGoal(int count);

    public abstract void WriteGoal(string fileName, StreamWriter outputFile);

    public string IsComplete()
    {
        if (_done)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

    public virtual void RecordEvent()
    {
        _currentPoints += _pointValue;
        Console.WriteLine($"Congratulations!! You earned {_pointValue} points!");
        System.Console.WriteLine($"You now have {_currentPoints}.");
    }

}