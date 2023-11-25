public class BreathingActivity : Activity
{
    private string _name;
    private string _description ;
    private int _duration;
    public BreathingActivity(string name, string description, int duration) 
        : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.Clear();
        Console.WriteLine("Get ready...");
        int ready =  6;
        Thread.Sleep(ready);
        base.ShowCountDown(ready);

        int breath = 9; 
        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nNow breath in..");
            base.ShowCountDown(breath * 1 / 2);
            Console.Write("\nNow breath out...");
            base.ShowCountDown(breath);
        }
    }
}