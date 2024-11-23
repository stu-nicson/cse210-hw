public class Checklist : Goal
{
    //attributes
    private int _timesCompleted;
    private int _timesToComplete;
    private int _bonusPoints;
    //constructor

    //methods
    public override int DisplayGoal(int count)
    {
        Console.WriteLine($"{count}. {IsComplete()} {_name} ({_description}) --- Currently Completed: ({_timesCompleted}/{_timesToComplete})");
        count+=1;
        return count;
    }

    public void ConstructGoal(bool done, string name, string description, int pointValue, int timesCompleted, int timesToComplete, int bonusPoints, int completePoints, int notUsed)
    {
        _done = done;
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _timesCompleted = timesCompleted;
        _timesToComplete = timesToComplete;
        _bonusPoints = bonusPoints;
        _currentPoints = completePoints;
    }
    public void ConstructGoal(int notUsed)
    {
        base.ConstructGoal();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _timesToComplete = int.Parse(Console.ReadLine());
        Console.WriteLine("How many points is the bonus for accomplishing the goal that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override void WriteGoal(string fileName, StreamWriter outputFile)
    {
        outputFile.WriteLine("Checklist");
        outputFile.WriteLine(_done);
        outputFile.WriteLine(_name);
        outputFile.WriteLine(_description);
        outputFile.WriteLine(_pointValue);
        outputFile.WriteLine(_timesCompleted);
        outputFile.WriteLine(_timesToComplete);
        outputFile.WriteLine(_bonusPoints);
        outputFile.WriteLine(_currentPoints);
    
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        _timesCompleted +=1;
        if (_timesCompleted == _timesToComplete)
        {
            _done = true;
            _currentPoints += _bonusPoints;
            System.Console.WriteLine("---------------------------------------------------------");
            System.Console.WriteLine($"                  BONUS POINTS!!!!");
            System.Console.WriteLine($"Congratutlations you earned extra {_bonusPoints} points!");
            System.Console.WriteLine($"Your new total points is {_currentPoints}!!");

        }

    }
}