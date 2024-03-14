namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = false;
            decimal number;

            do
            {
                Console.WriteLine("Please enter a number.");
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out number))
                {
                    Console.WriteLine(NumberStats(number));
                    Console.WriteLine("Press \"y\" to try again with another number.");
                    string inputTryAgain = Console.ReadLine();
                    if (inputTryAgain.ToUpper() == "Y")
                    {
                        tryAgain = true;
                    }
                    else
                    {
                        tryAgain = false;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            } while (tryAgain == true);
        }
        static string NumberStats(decimal number)
        {
            string positiveOrNegative;
            //string oddOrEven;
            //string decimalOrInteger;

            if (number > 0)
            {
                positiveOrNegative = "Positive";
            }
            else if (number == 0)
            {
                positiveOrNegative = "It is neither positive nor negative";
            }
            else
            {
                positiveOrNegative = "Negative";
            }

            string oddOrEven = number % 2 == 0 ? "Even" : "Odd";
            //if (number % 2 == 0)
            //{
            //    oddOrEven = "Even";
            //}
            //else
            //{
            //    oddOrEven = "Odd";
            //}

            string decimalOrInteger = number % 1 == 0 ? "Integer" : "Decimal";
            //if (number % 1 == 0)
            //{
            //    decimalOrInteger = "Integer";
            //}
            //else
            //{
            //    decimalOrInteger = "Decimal";
            //}

            return $"Stats for number: {number} \n{positiveOrNegative}\n{decimalOrInteger}\n{oddOrEven}";
        }
    }
}