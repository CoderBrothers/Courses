namespace ConsoleApp6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Course math = new Course("Math", new List<Student>());
            Course biology = new Course("Biology", new List<Student>());
            Student alice = new Student("Alice", new List<Course>(), new List<int>());
            Student bob = new Student("Bob", new List<Course>(), new List<int>());
            Student roben = new Student("Roben", new List<Course>(), new List<int>());
            math.Add(alice);
            math.Add(bob);
            biology.Add(roben);
            alice.AddMark(90);
            alice.AddMark(85);
            bob.AddMark(88);
            roben.AddMark(92);
            alice.AddMark(85);
            alice.AddMark(78);
            bob.AddMark(66);
            roben.AddMark(45);
            Console.WriteLine($"{alice.Name} average grade: {alice.ShowAverageGrade()}");
            Console.WriteLine($"{bob.Name} average grade: {bob.ShowAverageGrade()}");
            Console.WriteLine($"{roben.Name} average grade: {roben.ShowAverageGrade()}");
            Console.WriteLine($"Students in {math.CourseName}:");
            foreach (var student in math.Students)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine($"Students in {biology.CourseName}:");
            foreach (var student in biology.Students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
