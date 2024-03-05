namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student groups");
            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = new string[] { "Viktor", "Martin", "Stefan", "Nikola", "Aleksandar" };
            int number;

            while (true)
            {
                Console.WriteLine("Which group do you want to get: 1 or 2 ?");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    if (number == 1 || number == 2)
                    {
                        break;
                    }
                }
                Console.WriteLine("Invalid input, please select group 1 or 2!");
            }

            if (number == 1)
            {
                Console.WriteLine("The students in G1 are:");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("The students in G2 are:");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }

            Console.WriteLine("Do you want to get the other group too? y/n");
            string input2 = Console.ReadLine();

            if (input2 == "y" || input2 == "Y")
            {
                if (number == 1)
                {
                    Console.WriteLine("Here is the other group. G2: ");
                    foreach (string student in studentsG2)
                    {
                        Console.WriteLine(student);
                    }
                }

                if (number == 2)
                {
                    Console.WriteLine("Here is the other group. G1: ");
                    foreach (string student in studentsG1)
                    {
                        Console.WriteLine(student);
                    }
                }
            }

        }
    }
}
