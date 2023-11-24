using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";        
        Scripture verses = new Scripture(reference, text);

        string option = ""; 
        while (option != "quit")
        {
            Console.WriteLine("Volvió a entrar?.");
            Console.Clear();  // This will clear the console
            string memorize = verses.GetDisplayText();
            //Console.WriteLine("Pasó el clear");
            Console.WriteLine(memorize);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type \"quit\" to finish:");
            option = Console.ReadLine();
            if (verses.IsCompletelyHidden())
            {
                option = "quit";
            }
            else if (option == "")
            {
                verses.HideRandomWords(3);
                // Console.WriteLine("Press enter to continue or type \"quit\" to finish:");
                // option = Console.ReadLine();
            }
            else{
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type \"quit\" to finish:");Console.WriteLine("Press enter to continue or type \"quit\" to finish:");
                option = Console.ReadLine();
            }
            Console.WriteLine();
            //Console.WriteLine("Press enter to continue or type \"quit\" to finish:");
            //option = Console.ReadLine();
            Console.WriteLine("nueva option" + option);
        }
    }
}