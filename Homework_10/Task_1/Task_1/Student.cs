namespace Task_1
{
    public class Student : User
    {
        public string Username { get; set; }
        public Subject CurrentSubject { get; set; }
        public Dictionary<Subject, List<int>> Grades { get; set; } = new Dictionary<Subject, List<int>>();

        public Student(string username) : base(username, RoleEnum.Student)
        {
            Username = username;
        }

        public void ShowStudentInfo(Student student)
        {
            Console.WriteLine($"Student: {student.Username}");
            if (student.CurrentSubject != null)
            {
                Console.WriteLine($"Subject: {student.CurrentSubject.Name}");

                if (student.Grades.ContainsKey(student.CurrentSubject))
                {
                    Console.WriteLine("Grades:");
                    foreach (int grade in student.Grades[student.CurrentSubject])
                    {
                        Console.WriteLine($"- {grade}");
                    }
                }
                else
                {
                    Console.WriteLine("No grades available for the current subject.");
                }
            }
            else
            {
                Console.WriteLine("No subject assigned to the student.");
            }
        }
    }
}
