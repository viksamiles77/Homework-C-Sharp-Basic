namespace Task_1
{
    public class Trainer : User
    {
        public string Username { get; set; }

        public Trainer(string username) : base(username, RoleEnum.Trainer)
        {
            Username = username;
        }

        public void DisplayStudents(List<Student> students)
        {
            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine(student.Username);
            }
        }

        public void DisplaySubjects(List<Subject> subjects)
        {
            Console.WriteLine("Subjects:");
            foreach (var subject in subjects)
            {
                Console.WriteLine($"{subject.Name}: {subject.Students.Count} students");
            }
        }
    }
}
