public class Eternal : Goal
{
    //attributes

    //constructor

    //methods

    public void ConstructGoal(bool done, string name, string description, int pointValue)
    {
        _done = done;
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }
    public override int DisplayGoal(int count)
    {
        Console.WriteLine($"{count}. {IsComplete()} {_name} ({_description})");
        count+=1;
        return count;
    }

    public override void WriteGoal(string fileName, StreamWriter outputFile)
    {
        outputFile.WriteLine("Eternal");
        outputFile.WriteLine(_done);
        outputFile.WriteLine(_name);
        outputFile.WriteLine(_description);
        outputFile.WriteLine(_pointValue);
        
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }
}