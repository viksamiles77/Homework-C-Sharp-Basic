namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region printing numbers from 1 to number input
            int number1;

            while (true)
            {
                Console.WriteLine("Enter the first number: ");
                string input1 = Console.ReadLine();

                if (int.TryParse(input1, out number1) && number1 != 0)
                {
                    break;
                }
                Console.WriteLine("Please enter a valid number. (does not accept zero)");
            }
            Console.WriteLine($"I am printing numbers from number 1 to number {number1}:");
            for (int i = 1; i <= number1; i++)
            {
                Console.WriteLine(i);
            }
            #endregion
            #region printing numbers from the input to number 1
            int number2;
            while (true)
            {
                Console.WriteLine("Enter the second number: ");
                string input2 = Console.ReadLine();

                if (int.TryParse(input2, out number2) && number2 != 0)
                {
                    break;
                }
                Console.WriteLine("Please enter a valid number. (does not accept zero)");
            }

            Console.WriteLine($"I am printing numbers from {number2} to number 1:");
            for (int i = number2; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            #endregion

        }
    }
}
