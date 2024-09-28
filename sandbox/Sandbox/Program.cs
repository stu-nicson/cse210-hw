using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> x = new(); 
        // x.Add(100.5);

        Console.WriteLine("Hello Sandbox World!");

        //Gather data to fill up a list

        double input = -1;

        while(input != 0)
        {
            Console.Write("Enter Something: ");
            string input_string = Console.ReadLine();
            input = double.Parse(input_string);
            x.Add(input);
        }

        foreach (double number in x)
        {
            Console.WriteLine(number);
        }
    }
}
