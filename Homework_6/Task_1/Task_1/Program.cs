namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dogColors = { "Black", "White", "Brown", "Tan", "Golden", "Gray", "Fawn", "Brindle", "Red", "Cream", "Blue", "Green", "Yellow", "Orange", "Purple", "Pink" };
            string[] dogBreeds = { "Labrador", "German Shepherd", "Golden Retriever", "Bulldog", "Beagle", "Poodle", "Shih Tzu", "Dachshund", "Boxer", "Pug", "Husky", "Chihuahua", "Yorkshire Terrier", "Border Collie", "Australian Shepherd", "Shetland Sheepdog", "Basset Hound", "Corgi", "Miniature Schnauzer", "Shiba Inu", "Boston Terrier", "Bichon Frise", "Maltese", "Cocker Spaniel"
};
            int action;
            Dog kuce = new Dog();

            while (true)
            {
                Console.WriteLine("Enter the dogs name.");
                string nameInput = Console.ReadLine();

                if (ContainsANumber(nameInput))
                {
                    kuce.Name = nameInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid dog name!");
                }
            }


            while (true)
            {
                Console.WriteLine("Enter the dogs breed.");
                string breedInput = Console.ReadLine();

                if (CheckDogBreed(breedInput, dogBreeds))
                {
                    kuce.Breed = breedInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid dog breed!");
                }
            }


            while (true)
            {
                Console.WriteLine("Enter the dogs color.");
                string colorInput = Console.ReadLine();

                if (CheckColor(colorInput, dogColors))
                {
                    kuce.Color = colorInput;
                    break;

                }
                else
                {
                    Console.WriteLine("Please enter a valid dog color!");
                }


            }


            Console.WriteLine("Enter the dogs action: \n 1 - To eat \n 2 - To play \n 3 - To chase it's tail");
            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out action))
                {
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine(kuce.Eat());
                            break;
                        case 2:
                            Console.WriteLine(kuce.Play());
                            break;
                        case 3:
                            Console.WriteLine(kuce.ChaseTail());
                            break;
                        default:
                            Console.WriteLine("Please enter the number 1, 2 or 3!");
                            continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number!");
                }
            }
        }

        static bool ContainsANumber(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckColor(string input, string[] dogColors)
        {
            input = input.ToLower();
            foreach (string color in dogColors)
            {
                if (color.ToLower() == input)
                {
                    return true;
                }
            }
            return false;
        }

        static bool CheckDogBreed(string input, string[] dogBreeds)
        {
            input = input.ToLower();
            foreach (string breed in dogBreeds)
            {
                if (breed.ToLower() == input)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
