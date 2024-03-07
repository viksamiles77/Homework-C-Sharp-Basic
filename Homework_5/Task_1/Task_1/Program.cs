using System.Diagnostics;
using System.Text;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string birthdayInput;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Enter your birthday date (DD MM YYYY)");
                birthdayInput = Console.ReadLine();

                if (IsValidDateFormat(birthdayInput))
                {
                    validInput = true;
                    string[] datePart = birthdayInput.Split(' ');
                    int day = int.Parse(datePart[0]);
                    int month = int.Parse(datePart[1]);
                    int year = int.Parse(datePart[2]);

                    DateTime birthdayDate = new DateTime(year, month, day);

                    int age = AgeCalculator(birthdayDate);
                    Console.WriteLine($"Your age is {age} years old");
                }
                else
                {
                    Console.WriteLine("Invalid date input, please enter a valid date format (DD MM YYYY).");
                }

            }
            

        }

        static bool IsValidDateFormat(string input)
        {
            string[] datePart = input.Split(' ');
            if (datePart.Length != 3)
            {
                return false;
            }

            int day;
            int month;
            int year;

            if (!int.TryParse(datePart[0], out day) || !int.TryParse(datePart[1], out month) || !int.TryParse(datePart[2], out year))
            {
                return false;
            }

            if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1000 || year > 9999)
            {
                return false;
            }
            return true;
        }

        static int AgeCalculator(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;

            if (today.Month < birthday.Month || (today.Month == birthday.Month && today.Day < birthday.Day))
            {
                age--;
            }
            return age;
        }
    }
}
