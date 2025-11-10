// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

var person1 = new DotnetMentorshipAssignment2.Person("Alice", 30);

person1.SayHello();
person1.CelebrateBirthday();

var person2 = new DotnetMentorshipAssignment2.Person();

person2.SayHello();
person2.CelebrateBirthday();

Console.WriteLine($"Person 1: Name = {person1.GetName()}, Age = {person1.GetAge()}");
Console.WriteLine($"Person 2: Name = {person2.GetName()}, Age = {person2.GetAge()}");

Console.WriteLine("Updating Person 2's details...");
person2.SetName("Bob");
person2.SetAge(25);
Console.WriteLine($"Person 2: Name = {person2.GetName()}, Age = {person2.GetAge()}");

// The following lines would cause compilation errors due to private fields.

// try
// {
//     person2.Name = "Bob";
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Error: {ex.Message}");
// }

// try
// {
//     person2.Age = 5;
// } catch (Exception ex)
// {
//     Console.WriteLine($"Error: {ex.Message}");
// }

var student1 = new DotnetMentorshipAssignment2.Student();
student1.SetName("Charlie");
student1.SetAge(20);
student1.SetGrade("A");
student1.SayHello();
student1.Study();

var footballPlayer = new DotnetMentorshipAssignment2.FootballPlayer("David", 10);
footballPlayer.Play();

var guitarist = new DotnetMentorshipAssignment2.Guitarist("Eve", "The Rockers");
guitarist.Play();


