namespace Atelier;

internal class Bootcamp
{
    public Student[] Students { get; init; }

    public Bootcamp(Student[] students)
    {
        Students = students;
    }

    public void ShowStudents()
    {
        foreach (var student in Students)
        {
            Console.WriteLine(student.Name);
            Console.WriteLine("----------------");
        }
    }

    public double CalculateOverallAverage()
    {
        if (Students == null || Students.Length == 0)
            return 0;

        double totalSum = 0;
        int totalCount = 0;

        foreach (var student in Students)
        {
            if (student.Notes.Count > 0)
            {
                totalSum += student.Notes.Sum();
                totalCount += student.Notes.Count;
            }
        }

        return totalCount > 0 ? totalSum / totalCount : 0;
    }

}
