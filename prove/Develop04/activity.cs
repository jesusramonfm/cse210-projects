public class Activity
{
    // Defining the common paramenters
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would yo like for your session?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void EndingMessage()
    {
        Console.WriteLine("\n\nWell done!!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
    }
    public void ShowSpinner()
    {
        List<string> symbols = new List<string>(){"/", "-", "\\", "|"}; 
        foreach (string c in symbols) 
        {
            Console.Write(c);
            Thread.Sleep(250);  // Pause execution for 0.25 seconds
            Console.Write("\b \b");  // Erase the previous character
        }
    }

    public void ShowCountDown(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        while (DateTime.Now <  endTime)
        {
            this.ShowSpinner();
        }
    }
}