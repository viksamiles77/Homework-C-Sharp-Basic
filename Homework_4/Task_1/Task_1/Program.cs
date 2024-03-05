namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SumOfEven");
            int[] numbers = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter a number.");
                string input = Console.ReadLine();

                if (input != null && int.TryParse(input, out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    i--;
                }
            }

            int sum = 0;

            for (int i = 0; i < 6; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum = sum + numbers[i];
                }
            }

            Console.WriteLine($"Sum of even numbers is: {sum}");
        }
    }
}
