namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AcademyManager academyManager = new AcademyManager();

            Admin admin1 = new Admin("admin1");
            academyManager.Admins.Add(new Admin("admin1"));
            Admin admin2 = new Admin("admin2");
            academyManager.Admins.Add(new Admin("admin2"));

            Trainer trainer1 = new Trainer("trainer1");
            academyManager.Trainers.Add(new Trainer("trainer1"));
            Trainer trainer2 = new Trainer("trainer2");
            academyManager.Trainers.Add(new Trainer("trainer2"));

            Student student1 = new Student("student1");
            academyManager.Students.Add(new Student("student1"));
            student1.CurrentSubject = new Subject("Math");
            student1.Grades.Add(student1.CurrentSubject, new List<int> { 2, 4, 5 });

            Student student2 = new Student("student2");
            academyManager.Students.Add(new Student("student2"));
            student2.CurrentSubject = new Subject("Science");
            student2.Grades.Add(student2.CurrentSubject, new List<int> { 4, 2, 3 });

            Console.WriteLine("Welcome to the Academy Management App!");

            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            User user = academyManager.GetUser(username);
            if (user == null)
            {
                Console.WriteLine("User not found.");
                Console.WriteLine("Select your role:");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Trainer");
                Console.WriteLine("3. Student");
                Console.Write("Enter the number corresponding to your role: ");
                int roleChoice = int.Parse(Console.ReadLine());
                RoleEnum role = (RoleEnum)(roleChoice - 1);

                switch (role)
                {
                    case RoleEnum.Admin:
                        Admin admin = new Admin(username);
                        admin.AddAdmin(username);
                        break;
                    case RoleEnum.Trainer:
                        Trainer trainer = new Trainer(username);
                        //trainer.AddTrainer(username);
                        break;
                    case RoleEnum.Student:
                        Student student = new Student(username);
                        //student.AddStudent(username);
                        break;
                    default:
                        Console.WriteLine("Invalid role selection.");
                        break;
                }
            }

            user = academyManager.GetUser(username);

            if (user != null)
            {
                switch (user.Role)
                {
                    case RoleEnum.Admin:
                        Console.WriteLine("Admin actions:");
                        Console.WriteLine("1. Add admin \n 2. Remove admin \n 3. Add trainer \n 4. Remove trainer \n 5. Add student \n 6. Remove student");
                        break;
                    case RoleEnum.Trainer:
                        Console.WriteLine("Trainer actions:");
                        Console.WriteLine("1. Display students \n 2. Display subjects");
                        break;
                    case RoleEnum.Student:
                        Console.WriteLine("Student actions:");
                        Student student = academyManager.GetUser(username) as Student;
                        if (student != null)
                        {
                            student.ShowStudentInfo(student);
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid role selection.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}
