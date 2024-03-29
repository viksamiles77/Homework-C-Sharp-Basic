using Models;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("Admin1");
            Admin admin2 = new Admin("Admin2");
            Trainer trainer = new Trainer("Trainer1");
            Trainer trainer2 = new Trainer("Trainer2");
            Student student1 = new Student("Student1", "Math", new Dictionary<string, int> { { "Math", 100 }, { "Science", 90 } });
            Student student2 = new Student("Student2", "Science", new Dictionary<string, int> { { "Chemistry", 80 }, { "Physics", 95 } });

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Select your role (admin/trainer/student): ");
            string role = Console.ReadLine();

            if (role.ToLower() == "admin")
            {
                Console.Write("Enter 'add' to add user or 'remove' to remove user: ");
                string adminOption = Console.ReadLine();
                if (adminOption.ToLower() == "add")
                {
                    Console.Write("Enter user type (admin/trainer/student): ");
                    string userType = Console.ReadLine();
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();
                    admin.AddUser(userType, username);
                }
                else if (adminOption.ToLower() == "remove")
                {
                    Console.Write("Enter user type (admin/trainer/student): ");
                    string userType = Console.ReadLine();
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();
                    admin.RemoveUser(userType, username);
                }
                else
                {
                    Console.WriteLine("Invalid option for admin.");
                }
            }
            else if (role.ToLower() == "trainer")
            {
                Console.Write("Enter 'students' to view students or 'subjects' to view subjects: ");
                string trainerOption = Console.ReadLine();
                if (trainerOption.ToLower() == "students")
                {
                    trainer.ViewStudents(new List<Student> { student1, student2 });
                }
                else if (trainerOption.ToLower() == "subjects")
                {
                    Dictionary<string, int> subjects = new Dictionary<string, int> { { "Math", 2 }, { "Science", 1 } };
                    trainer.ViewSubjects(subjects);
                }
                else
                {
                    Console.WriteLine("Invalid option for trainer.");
                }
            }
            else if (role.ToLower() == "student")
            {
                student1.ViewCurrentSubject();
                student1.ViewGrades();
            }
            else
            {
                Console.WriteLine("Invalid role.");
            }
        }
    }
}
