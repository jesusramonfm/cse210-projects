using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber;
        int average = 0;
        int largest = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        do
        {
            newNumber = int.Parse(Console.ReadLine());
            numbers.Add(newNumber);
        } while (newNumber != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if (largest < number)
            {
                largest  =  number;
            }
        }
        
        average = sum / (numbers.Count - 1);   // -1  t remove the last 0s 

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}