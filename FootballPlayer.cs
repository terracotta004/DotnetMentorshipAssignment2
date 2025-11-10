namespace DotnetMentorshipAssignment2;

public class FootballPlayer : IPlayable
{
    private string? Name;
    private int Number;

    public FootballPlayer(string name, int number)
    {
        Name = name;
        Number = number;
    }

    public void Play()
    {
        Console.WriteLine($"{Name}, wearing number {Number}, is playing football.");
    }
}
