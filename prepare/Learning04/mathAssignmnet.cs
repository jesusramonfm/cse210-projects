public class MathAssignment : Assignment  //  " : Assignment" indicate the father class 
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string problem) : base(name, topic)
    {
        // Setting the Mathssignment properties
        _textbookSection = section;
        _problems = problem;
    }

    public string GetHomeworkList() 
    {
        string homework = $"Section {_textbookSection} Problems {_problems}";
        return homework;
    }
}