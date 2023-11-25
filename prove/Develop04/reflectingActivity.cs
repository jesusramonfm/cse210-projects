public  class ReflectingActivity : Activity
{
    // Defining needed properties
    private string _name;
    private string _description;
    private int _duration;
    private List<string> _prompt = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    
    private List<string> _questions = new List<string>
    { 
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    }; 

    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Run()
    {
        // Manaing a lenght of time 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("\nGet ready...");
        int ready = 3;
        Thread.Sleep(ready);    // Making a pause
        base.ShowCountDown(ready);   // Accesing method from Parent class 
        
        DisplayPrompt();
        // Provide questions while time is not ended 
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
        }
    }

    public string GetRandomPrompt()
    // Choose a ranndom prompt from the list
    {
        var rand = new Random();
        int number = rand.Next(0, _prompt.Count - 1);
        string prompt = _prompt[number];
        return prompt;
    }

    public string GetRandomQuestions()
    // Choose a random question from the list
    {
        var rand = new Random();
        int number = rand.Next(0, _questions.Count);
        string question = _questions[number];
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n -- {GetRandomPrompt()} --");
        Console.WriteLine("\nWhen  you have something in mind, press enter to continune.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following  questons as they related to this experieence.");
        Console.Write("You may begin in: ");
        base.ShowCountDown(3);
        Console.Clear();
    }

    public void DisplayQuestions()
    {
        Console.Write($"\n{GetRandomQuestions()}");
        base.ShowCountDown(30);
    }
}