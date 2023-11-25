using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private string _name;
    private string _description ;
    private int _duration;
    int  _count;
    List<string> _prompts = new List<string> 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration, int count)
        : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _count = count;
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        int ready =  3;
        Thread.Sleep(ready);
        base.ShowCountDown(ready);

        Console.WriteLine("List as many responses you can to the foollowing prompt:");

        Console.WriteLine($"-- {GetRandomPrompt()} --");
        Console.Write("You may began in: ");
        base.ShowCountDown(3);
        _prompts = GetListFromUser();
        _count = _prompts.Count;
        Console.WriteLine($"You listed {_count} items!\n");     
        base.EndingMessage(); 
    }

    public string GetRandomPrompt()
    {
        var rand = new Random();
        int number = rand.Next(0, _prompts.Count - 1);
        string prompt = _prompts[number];
        return prompt;   
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            userList.Add(item);
        }
        Console.WriteLine("Fin");
        return userList;
    }

}