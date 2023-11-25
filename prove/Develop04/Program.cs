using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";

        // Setting up Menu loop  with exit on "Quit"
        while (option != "Quit")     
        {    
            Console.Clear();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("\t1. Start breathing activvity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            option = Console.ReadLine();

            if (option == "1")
            {
                // Setting up vaiables
                string name = "Breathing";
                string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                int duration = 60;

                // Creating activity1 object
                BreathingActivity activity1 = new BreathingActivity(name, description, duration);
                // Calling up needed  methods through the object
                activity1.DisplayStartingMessage();
                activity1.Run();
                activity1.EndingMessage();
                activity1.ShowCountDown(3);
            } 

            else if (option == "2")
            {
                // Setting up vaiables                
                string name = "Reflection";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                int duration = 60;

                // Creating activity2 object
                ReflectingActivity activity2 = new ReflectingActivity(name, description, duration);
                // Calling up needed  methods through the object
                activity2.DisplayStartingMessage();
                activity2.Run();
                activity2.EndingMessage();
            }

            else if (option == "3")
            {
                // Setting up vaiables
                string name = "Listing";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
                int duration = 60;
                int count = 0;
                List<string> prompt = new List<string>();

                // Creating activity1 object
                ListingActivity activity3 = new ListingActivity(name, description, duration, count);
                // Calling up needed  methods through the object
                activity3.DisplayStartingMessage();
                activity3.Run();
                activity3.EndingMessage();
            }
            
            else if (option == "4")
            {
                // Ending loop with exit message
                option = "Quit";
                Console.WriteLine("Thank you for ussing this Mindfulnes App.");
                Console.WriteLine("\n\"PEACE OF MIND\" until next session.");
            }

            else  // Handling any other inputs
            {
                Console.WriteLine("Choose a valid option from the menu by clicking the option number at the left.");
            }
        }
    }
}