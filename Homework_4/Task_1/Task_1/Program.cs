namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SumOfEven");
            int[] numbers = new int[6];
            int[] evenNumbers = new int[0];


            while (true)
            {
                Console.WriteLine("Enter the first number");
                string input1 = Console.ReadLine();

                if (int.TryParse(input1, out int number1))
                {
                    numbers[0] = number1;
                    break;
                }
                Console.WriteLine("Wrong input, please try again");
            }

            while (true)
            {
                Console.WriteLine("Enter the second number");
                string input2 = Console.ReadLine();

                if (int.TryParse(input2, out int number2))
                {
                    numbers[1] = number2;
                    break;
                }
                Console.WriteLine("Wrong input, please try again");
            }

            while (true)
            {
                Console.WriteLine("Enter the third number");
                string input3 = Console.ReadLine();

                if (int.TryParse(input3, out int number3))
                {
                    numbers[2] = number3;
                    break;
                }
                Console.WriteLine("Wrong input, please try again");
            }

            while (true)
            {
                Console.WriteLine("Enter the fourth number");
                string input4 = Console.ReadLine();

                if (int.TryParse(input4, out int number4))
                {
                    numbers[3] = number4;
                    break;
                }
                Console.WriteLine("Wrong input, please try again");
            }

            while (true)
            {
                Console.WriteLine("Enter the fifth number");
                string input5 = Console.ReadLine();

                if (int.TryParse(input5, out int number5))
                {
                    numbers[4] = number5;
                    break;
                }
                Console.WriteLine("Wrong input, please try again");
            }

            while (true)
            {
                Console.WriteLine("Enter the sixth number");
                string input6 = Console.ReadLine();

                if (int.TryParse(input6, out int number6))
                {
                    numbers[5] = number6;
                    break;
                }
                Console.WriteLine("Wrong input, please try again");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                //Console.WriteLine(numbers[i]);

                if (numbers[i] % 2 == 0)
                {
                    Array.Resize(ref evenNumbers, evenNumbers.Length + 1);
                    evenNumbers[evenNumbers.Length - 1] = numbers[i];
                }
            }
            Console.WriteLine($"The sum is: {evenNumbers.Sum()}");
        }
    }
}
