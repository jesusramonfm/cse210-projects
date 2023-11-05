using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        Console.WriteLine("Type in your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";        
        }      
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Well done, you pass the course");
        }
        else
        {
            Console.WriteLine("You didn´t pass the course this time. Try again");
        }
    }
}