namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Substrings();
        }

        static void Substrings()
        {

            string str = "Hello from SEDC Codecademy 2024";
            int number;

            while (true)
            {
                Console.WriteLine("Please enter a number.");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    if (number <= 0)
                    {
                        Console.WriteLine("Negative numbers not allowed. Please enter a number larger than 0!");
                        continue;
                    }

                    if (number > str.Length)
                    {

                        Console.WriteLine($"The number exceeds the length of the string. The largest number is I can take is {str.Length}.");
                        continue;
                    }

                    break;
                }
                Console.WriteLine("Wrong input.");
            }

            //str.ToCharArray(0, number);

            //foreach (char c in str.ToCharArray(0, number))
            //{
            //    Console.WriteLine(c);
            //}

            Console.WriteLine(str.ToCharArray(0, number));
            Console.WriteLine(str.ToCharArray(0, number).Length);


        }

    }
}
