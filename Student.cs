namespace DotnetMentorshipAssignment2;

public class Student : Person
{
    private string? Grade;
    public void Study()
    {
        Console.WriteLine($"{GetName()} is studying.");
    }

    public string? GetGrade()
    {
        return Grade;
    }
    public void SetGrade(string grade)
    {
        Grade = grade;
    }

    public override void SayHello()
    {
        base.SayHello();
        Console.WriteLine($"I am also a student in grade {Grade}.");
    }

}
