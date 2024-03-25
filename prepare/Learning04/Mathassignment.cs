public class MathAssignment : Assignment 
{
    protected string _textbooksSection;
    protected string _problems;

    public  MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbooksSection = textbookSection;
        _problems = problems;
    }
     public string GetHomeworkList()
    {
        return $"Section {_textbooksSection} Problems {_problems}";
    }
}