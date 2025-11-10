namespace DotnetMentorshipAssignment2;

public class Person
{
    private string? Name;
    private int Age;
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }
    public void CelebrateBirthday()
    {
        Age++;
        Console.WriteLine($"Happy birthday! You are now {Age} years old.");
    }
}
