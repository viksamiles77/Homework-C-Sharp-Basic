namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two numbers and I will swap their values of the variables.");

            int number1;
            int number2;

            while (true)
            {
                Console.WriteLine("Input the first number.");
                string input1 = Console.ReadLine();

                if (int.TryParse(input1, out number1))
                {
                    break;
                }
                Console.WriteLine("Wrong input, please input a number!");
            }

            while (true)
            {
                Console.WriteLine("Input the second number.");
                string input2 = Console.ReadLine();

                if (int.TryParse(input2, out number2))
                {
                    break;
                }
                Console.WriteLine("Wrong input, please input a number");
            }

            Console.WriteLine("Numbers before swap:");
            Console.WriteLine($"First Number: {number1}");
            Console.WriteLine($"Second Number: {number2}");

            int temoporaryNumber = number1;
            number1 = number2;
            number2 = temoporaryNumber;

            Console.WriteLine("Numbers after swap:");
            Console.WriteLine($"First Number: {number1}");
            Console.WriteLine($"Second Number: {number2}");



            //Console.WriteLine("Input two numbers and I will swap their values of the variables.");
            //Console.WriteLine("Input the first number");
            //int number1;
            //string input1 = Console.ReadLine();
            //bool success1 = int.TryParse(input1, out number1);

            //Console.WriteLine("Input the second number");
            //int number2;
            //string input2 = Console.ReadLine();
            //bool success2 = int.TryParse(input2, out number2);

            //if (!success1 || !success2)
            //{
            //    Console.WriteLine("Invalid input somewhere, please write a number!");
            //}
            //else
            //{
            //    Console.WriteLine("Numbers before swap:");
            //    Console.WriteLine($"First Number: {number1}");
            //    Console.WriteLine($"Second Number: {number2}");

            //    int temoporaryNumber = number1;
            //    number1 = number2;
            //    number2 = temoporaryNumber;

            //    Console.WriteLine("Numbers after swap:");
            //    Console.WriteLine($"First Number: {number1}");
            //    Console.WriteLine($"Second Number: {number2}");
            //}

        }
    }
}
