namespace Atelier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student("Ninja");
            Student studentTwo = new Student("Charlie");

            studentOne.Talk(studentTwo, "Nice to meet you !");
            studentTwo.Shouting(studentOne);

            studentOne.Notes.Add(2.5);
            studentOne.Notes.Add(15.5);
            studentOne.Notes.Add(25.2);
            studentOne.Notes.Add(50.58);

            studentTwo.Notes.Add(10.5);
            studentTwo.Notes.Add(2.8);
            studentTwo.Notes.Add(25.1);
            studentTwo.Notes.Add(0.5);


            Student[] students = { studentOne, studentTwo };
            Bootcamp bootcamp = new Bootcamp(students);

            bootcamp.ShowStudents();

            if (bootcamp.CalculateOverallAverage() > 0)
                Console.WriteLine($"Average is {bootcamp.CalculateOverallAverage()}");
        }
    }
}
