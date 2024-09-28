using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        List<int> numbersList = new List<int>();
        int number; 

        do
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            if (number != 0)
            {
                numbersList.Add(number);    
            }
        } while ( number != 0);

        // write the sum
        int sum = numbersList.Sum();
        Console.WriteLine($"The sum is: {sum}");

        //write the average
        double average = numbersList.Average();
        Console.WriteLine($"The average is: {average}");

        //write the largest number
        double largestNumber = numbersList.Max();
        Console.WriteLine($"The largest number is: {largestNumber}");
    } 
}