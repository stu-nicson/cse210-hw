public class SimpleGoal : Goal
{
    //attributes

    //constructor

    //methods
    // public override void ConstructGoal(string name, string description, int pointValue)
    // {
    //     Console.WriteLine("What is the name of your goal? ");
    //     name = Console.ReadLine();
    //     Console.WriteLine("What is a short description of it?");
    //     description = Console.ReadLine();
    //     Console.WriteLine("what is the amount of points associated with this goal?");
    //     pointValue = int.Parse(Console.ReadLine());
    // }
    public void ConstructGoal(bool done, string name, string description, int pointValue, int completePoints)
    {
        _done = done;
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _currentPoints = completePoints;

    }
    public override int DisplayGoal(int count)
    {
        Console.WriteLine($"{count}. {IsComplete()} {_name} ({_description})");
        count+=1;
        return count;
    }
    public override void WriteGoal(string fileName, StreamWriter outputFile)
    {
        outputFile.WriteLine("SimpleGoal");
        outputFile.WriteLine(_done);
        outputFile.WriteLine(_name);
        outputFile.WriteLine(_description);
        outputFile.WriteLine(_pointValue);
        outputFile.WriteLine(_currentPoints);
    }

    public override void CompleteGoal()
    {
        
    }

    public override void RecordEvent()
    {
        _done = true;
        base.RecordEvent();
        
    }
}