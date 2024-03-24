using System;
using System.Collections.Generic;

namespace Task_1
{
    public enum Role
    {
        Admin,
        Trainer,
        Student
    }

    internal class Program
    {
        static List<string> trainers = new List<string>
        {
            "Mr. Smith",
            "Ms. Johnson",
            "Dr. Patel",
            "Mrs. Garcia",
            "Professor Williams",
            "Ms. Thompson",
            "Mr. Nguyen",
            "Dr. Lee",
            "Mrs. Rodriguez",
            "Professor Davis"
        };

        static List<string> admins = new List<string>
        {
            "Mrs. Anderson",
            "Mr. Thompson",
            "Dr. Martinez",
            "Ms. White",
            "Mr. Johnson",
            "Mr. Garcia",
            "Dr. Taylor",
            "Mrs. Brown",
            "Mr. Lee",
            "Ms. Clark"
        };

        static List<string> students = new List<string>
        {
            "John Smith",
            "Emily Johnson",
            "Michael Williams",
            "Jessica Brown",
            "Daniel Martinez",
            "Sarah Taylor",
            "David Garcia",
            "Amanda Nguyen",
            "Robert Lee",
            "Olivia Clark"
        };

        static void Main(string[] args)
        {
            string userName;
            do
            {
                Console.Write("Please enter your name: ");
                userName = Console.ReadLine().Trim();
            } while (string.IsNullOrWhiteSpace(userName));

            Role userRole = GetUserRole();

            switch (userRole)
            {
                case Role.Admin:
                    Console.WriteLine($"Welcome, {userName}! Role: Admin");
                    AdminActions();
                    break;
                case Role.Trainer:
                    Console.WriteLine($"Welcome, {userName}! Role: Trainer");
                    trainers.Add(userName);
                    break;
                case Role.Student:
                    Console.WriteLine($"Welcome, {userName}! Role: Student");
                    students.Add(userName);
                    break;
                default:
                    Console.WriteLine("Invalid role!");
                    break;
            }
        }

        static Role GetUserRole()
        {
            Console.WriteLine("Select your role: \n 1. Admin \n 2. Trainer \n 3. Student");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input, please try again!");
            }

            return (Role)(choice - 1);
        }

        static void AdminActions()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Add trainer");
            Console.WriteLine("2. Remove trainer");
            Console.WriteLine("3. Add student");
            Console.WriteLine("4. Remove student");
            Console.WriteLine("5. Add admin");
            Console.WriteLine("6. Remove admin");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
            {
                Console.WriteLine("Invalid input, please try again!");
            }

            switch (choice)
            {
                case 1:
                    AddTrainer();
                    break;
                case 2:
                    RemoveTrainer();
                    break;
                case 3:
                    AddStudent();
                    break;
                case 4:
                    RemoveStudent();
                    break;
                case 5:
                    AddAdmin();
                    break;
                case 6:
                    RemoveAdmin();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        static void AddTrainer()
        {
            string newTrainerName;
            do
            {
                Console.Write("Please enter the name of the new trainer: ");
                newTrainerName = Console.ReadLine().Trim();
            } while (string.IsNullOrWhiteSpace(newTrainerName));

            trainers.Add(newTrainerName);
            Console.WriteLine("Trainer added successfully!");
        }

        static void RemoveTrainer()
        {
            Console.WriteLine("Current trainers:");
            foreach (var trainer in trainers)
            {
                Console.WriteLine(trainer);
            }

            Console.Write("Enter the index of the trainer you want to remove: ");
            int index;
            while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= trainers.Count)
            {
                Console.WriteLine("Invalid index, please try again!");
            }

            string removedTrainer = trainers[index];
            trainers.RemoveAt(index);
            Console.WriteLine($"{removedTrainer} has been removed from the list of trainers.");
        }

        static void AddStudent()
        {
            string newStudentName;
            do
            {
                Console.Write("Please enter the name of the new student: ");
                newStudentName = Console.ReadLine().Trim();
            } while (string.IsNullOrWhiteSpace(newStudentName));

            students.Add(newStudentName);
            Console.WriteLine("Student added successfully!");
        }

        static void RemoveStudent()
        {
            Console.WriteLine("Current students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.Write("Enter the index of the student you want to remove: ");
            int index;
            while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= students.Count)
            {
                Console.WriteLine("Invalid index, please try again!");
            }

            string removedStudent = students[index];
            students.RemoveAt(index);
            Console.WriteLine($"{removedStudent} has been removed from the list of students.");
        }

        static void AddAdmin()
        {
            string newAdminName;
            do
            {
                Console.Write("Please enter the name of the new admin: ");
                newAdminName = Console.ReadLine().Trim();
            } while (string.IsNullOrWhiteSpace(newAdminName));

            admins.Add(newAdminName);
            Console.WriteLine("Admin added successfully!");
        }

        static void RemoveAdmin()
        {
            Console.WriteLine("Current admins:");
            foreach (var admin in admins)
            {
                Console.WriteLine(admin);
            }

            Console.Write("Enter the index of the admin you want to remove: ");
            int index;
            while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= admins.Count)
            {
                Console.WriteLine("Invalid index, please try again!");
            }

            string removedAdmin = admins[index];
            admins.RemoveAt(index);
            Console.WriteLine($"{removedAdmin} has been removed from the list of admins.");
        }
    }
}
