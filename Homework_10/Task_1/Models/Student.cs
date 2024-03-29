using System.Security;

namespace Models
{
    public class Student : User
    {
        public string CurrentSubject { get; set; }
        public Dictionary<string, int> Grades { get; set; }

        public Student(string name, string currentSubject, Dictionary<string, int> grades) : base(name)
        {
            CurrentSubject = currentSubject;
            Grades = grades;
        }

        public void ViewCurrentSubject()
        {
            Console.WriteLine($"Current Subject: {CurrentSubject}");
        }

        public void ViewGrades()
        {
            Console.WriteLine("Grades:");
            foreach(var grade in Grades)
            {
                Console.WriteLine($"{grade.Key}: {grade.Value}");
            }
        }
    }
}
