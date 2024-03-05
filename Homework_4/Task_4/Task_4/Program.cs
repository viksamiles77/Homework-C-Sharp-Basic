namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[0];
            string answer;

            do
            {
                Console.WriteLine("Please enter a name: ");
                string newName = Console.ReadLine();

                while (int.TryParse(newName, out _))
                {
                    Console.WriteLine("Invalid input! Please enter a valid name.");
                    Console.WriteLine("Please enter a name: ");
                    newName = Console.ReadLine();
                }

                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = newName;

                Console.WriteLine("Do you want to enter a new name? y/n");
                answer = Console.ReadLine();


            } while (answer.ToLower() == "y");

            Console.WriteLine("List of names: ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}

