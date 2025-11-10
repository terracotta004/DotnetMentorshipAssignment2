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

    public virtual void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }
    public void CelebrateBirthday()
    {
        Age++;
        Console.WriteLine($"Happy birthday! You are now {Age} years old.");
    }
    // Getter and setter methods for Name and Age
    public string? GetName()
    {
        return Name;
    }

    public void SetName(string? name)
    {
        Name = name;
    }

    public int GetAge()
    {
        return Age;
    }

    public void SetAge(int age)
    {
        if (age < 0) throw new System.ArgumentOutOfRangeException(nameof(age), "Age cannot be negative.");
        Age = age;
    }
}
