using System;

class Program
{
    static void Main(string[] args)
    {
        PromptsGenerator prompts = new PromptsGenerator();

        string choice = "";
        Journal journal = new Journal();
        Journal todayJournal = new Journal();
        
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do ? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry todayEntry = new Entry();
                DateTime actualTime = new DateTime();

                string dateText =  actualTime.ToShortDateString();

                string sugestion = prompts.GetRandomPrompt();
                Console.WriteLine(sugestion);
                string entry = Console.ReadLine();
                todayEntry._date = dateText;
                todayEntry._prompText = sugestion;
                todayEntry._entryText = entry;
                //todayJournal.AddEntry(todayEntry);
                journal.AddEntry(todayEntry);
        
            }
            else if (choice == "2")
            {
                foreach (Entry journalEntry in journal._entries)
                {
                    journalEntry.Display();
                }

            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            } 
        }
   }
}