using System.Transactions;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            bool addNumbers = false;

            do
            {
                addNumbers = false;
                while (true)
                {
                    Console.Write("Enter number: ");
                    string input = Console.ReadLine();

                    int number;
                    if (int.TryParse(input, out number))
                    {
                        numbers.Enqueue(number);
                        break;
                    }
                    Console.WriteLine("Invalid iput. Please enter a valid number.");
                }
                Console.WriteLine("Do you want to add another number? (yes/no)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes" || answer.ToLower() == "y")
                {
                    addNumbers = true;
                }
            } while (addNumbers);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
