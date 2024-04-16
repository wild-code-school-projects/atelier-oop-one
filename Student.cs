namespace Atelier;

internal class Student
{
    public string Name { get; init; }
    public List<double> Notes { get; init; }

    public Student(string name)
    {
        Name = name;
        Notes = new List<double>();
    }

    public void Talk(Student otherStudent, string message)
    {
        Console.WriteLine($"{Name} says to {otherStudent.Name}: {message}");
    }

    public void Shouting(Student otherStudent)
    {
        Console.WriteLine($"{Name} shouts to {otherStudent.Name}: HEY!");
    }
}
