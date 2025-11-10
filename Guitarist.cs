namespace DotnetMentorshipAssignment2;

public class Guitarist
{
    private string? Name;
    private string? Band;

    public Guitarist(string name, string band)
    {
        Name = name;
        Band = band;
    }

    public void Play()
    {
        Console.WriteLine($"{Name} from {Band} is playing the guitar.");
    }
}
