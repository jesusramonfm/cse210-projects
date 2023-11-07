using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        Random  randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,100);
        int yourNumber;
        do
        {
            Console.WriteLine("What is your guess? ");
            yourNumber = int.Parse(Console.ReadLine());

            if (magicNumber < yourNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > yourNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You  guessed it!");
            }
        } while (magicNumber != yourNumber);
    }
}