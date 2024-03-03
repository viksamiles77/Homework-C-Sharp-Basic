namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            while (true)
            {
                Console.WriteLine("Please enter the number: ");
                string input1 = Console.ReadLine();
                Console.WriteLine("Please enter the second number: ");
                string input2 = Console.ReadLine();


                if (int.TryParse(input1, out number1) && int.TryParse(input2, out number2))
                {
                    break;
                }

                Console.WriteLine("Wrong input, please try again.");
            }

            while (true)
            {
                Console.WriteLine("Please enter the operator: ");
                string inputOperator = Console.ReadLine();


                switch (inputOperator)
                {
                    case "+":
                        Console.WriteLine($"Result: {number1 + number2}");
                        break;
                    case "-":
                        Console.WriteLine($"Result: {number1 - number2}");
                        break;
                    case "*":
                        Console.WriteLine($"Result: {number1 * number2}");
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            Console.WriteLine($"Result: {number1 / number2}");
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        };
                        break;
                    default:
                        Console.WriteLine("Please use a valid operator (+, -, *, /)");
                        continue;
                }
                break;
            }

        }
    }
}


