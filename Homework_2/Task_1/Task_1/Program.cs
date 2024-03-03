namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // First solution

            int number1;
            int number2;
            int number3;
            int number4;
            Console.WriteLine("Give me four numbers, i will return you the average.");

            while (true)
            {
            Console.WriteLine("Input the first number.");
            string input1 = Console.ReadLine();
                
            if (int.TryParse(input1, out number1))
            {
                break;
            }
                Console.WriteLine("Wrong input, input a number.");

            }

            while (true)
            {
            Console.WriteLine("Input the second number.");
            string input2 = Console.ReadLine();

                if (int.TryParse(input2, out number2))
                {
                    break;
                }
                Console.WriteLine("Wrong input, input a number.");
            }
            
            while (true)
            {
            Console.WriteLine("Input the third number.");
            string input3 = Console.ReadLine();

                if (int.TryParse(input3, out number3))
                {
                    break;
                }
                Console.WriteLine("Wrong input, input a number.");
            }

            while (true)
            {
            Console.WriteLine("Input the fourth number.");
            string input4 = Console.ReadLine();

                if (int.TryParse(input4, out number4))
                {
                    break;
                }
                Console.WriteLine("Wrong input, input a number.");
            }

            int result = number1 + number2 + number3 + number4;
            int finalResult = result / 4;
            Console.WriteLine($"The average of {number1}, {number2}, {number3}, {number4} is: " + finalResult);












            // Second solution 

            //Console.WriteLine("Give me four numbers, i will return you the average.");
            //Console.WriteLine("Input the first number.");
            //string input1 = Console.ReadLine();

            //int number1;
            //bool success1 = int.TryParse(input1, out number1);



            //Console.WriteLine("Input the second number.");
            //string input2 = Console.ReadLine();

            //int number2;
            //bool success2 = int.TryParse(input2, out number2);



            //Console.WriteLine("Input the third number.");
            //string input3 = Console.ReadLine();

            //int number3;
            //bool success3 = int.TryParse(input3, out number3);


            //Console.WriteLine("Input the fourth number.");
            //string input4 = Console.ReadLine();

            //int number4;
            //bool success4 = int.TryParse(input4, out number4);


            //if (!success1)
            //{
            //    Console.WriteLine("Invalid first input, please type a number!");
            //    return;
            //}

            //if (!success2)
            //{
            //    Console.WriteLine("Invalid second input, please type a number!");
            //    return;
            //}

            //if (!success3)
            //{
            //    Console.WriteLine("Invalid third input, please type a number!");
            //    return;
            //}


            //if (!success4)
            //{
            //    Console.WriteLine("Invalid fourth input, please type a number!");
            //    return;
            //}


            //int result = (number1 + number2 + number3 + number4) / 4;
            //Console.WriteLine("The average of your numbers is: " + result);

        }
    }
}
