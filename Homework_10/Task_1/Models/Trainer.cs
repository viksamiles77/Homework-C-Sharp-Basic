namespace Models
{
    public class Trainer : User
    {
        public Trainer(string name) : base(name) { }

        public void ViewStudents(List<Student> students)
        {
            Console.WriteLine("Students: ");
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void ViewSubjects(Dictionary<string, int> subjects)
        {
            Console.WriteLine("Subjects:");
            foreach(var subject in subjects)
            {
                Console.WriteLine($"{subject.Key} - {subject.Value} students");
            }
        }
    }
}
