using Models;

namespace Task_2
{
    internal class Program
    {
        static int personID = 0;
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            do
            {
                UI(people);
                Console.WriteLine("Do you want to add another user? (yes/no)");
            } while (Console.ReadLine().ToLower() == "yes" || Console.ReadLine().ToLower() == "y");

            foreach (Person person in people)
            {
                person.GetFavSongs(person.FavouriteSongs);
            }
        }

        public static void UI(List<Person> people)
        {
            Person person = new Person();
            personID++;
            person.Id = personID;

            string firstName;
            do
            {
                Console.Write("Enter your first name: ");
                firstName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(firstName));
            person.FirstName = firstName;

            string lastName;
            do
            {
                Console.Write("Enter your last name: ");
                lastName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(lastName));
            person.LastName = lastName;

            int age;
            while (true)
            {
                Console.Write("Enter your age: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    person.Age = age;
                    break;
                }
                Console.WriteLine("Enter a valid age! (number)");
            }

            List<string> favouriteSongs = new List<string>();
            bool addAnotherSong = false;
            do
            {
                addAnotherSong = false;
                Console.Write("Enter your favourite song: ");
                string favouriteSong = Console.ReadLine();
                favouriteSongs.Add(favouriteSong);
                Console.WriteLine("Do you want to add another song? (yes/no)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes" || answer.ToLower() == "y")
                {
                    addAnotherSong = true;
                }
            } while (addAnotherSong);

            person.FavouriteSongs = favouriteSongs;
            people.Add(person);


        }
    }
}
