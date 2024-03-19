namespace ATM_app
{
    internal class Customer
    {
        public string Name { get; set; }

        public long CardNumber { get; set; }

        private int Pin { get; set; }

        private double Balance { get; set; }
        public Customer(string name, long cardNumber, int pin, double balance)
        {
            Name = name;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }


        public void GetBalance()
        {
            Console.WriteLine($"You have {Balance:F2}$ left in your account!");
        }

        public void Withdraw(float amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"You withdrew {amount}$ from your account!");
                Console.WriteLine($"You have {Balance:F2}$ left in your account!");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void Deposit(float amount)
        {
            Balance += amount;
            Console.WriteLine($"You deposited {amount}$ in your account!");
            Console.WriteLine($"You have {Balance:F2}$ left in your account!");
        }

        public static Customer AddNewUser()
        {
            Random random = new Random();
            string name;
            do
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));

            Console.WriteLine("Enter car number (xxxx-xxxx-xxxx-xxxx).");
            string cardNumberString;
            do
            {
                cardNumberString = Console.ReadLine();
                if (cardNumberString.Length == 19 && cardNumberString[4] == '-' && cardNumberString[9] == '-' && cardNumberString[14] == '-')
                    break;
                Console.WriteLine("Wrong input, please enter in format xxxx-xxxx-xxxx-xxxx");
            } while (true);
            long cardNumber = long.Parse(cardNumberString.Replace("-", ""));

            Console.Write("Enter PIN (4 digits): ");
            int pin;
            while (!int.TryParse(Console.ReadLine(), out pin) || pin < 1000 || pin > 9999)
            {
                Console.WriteLine("Invalid PIN! Please enter a 4-digit number.");
            }

            double balance = Math.Round(random.NextDouble() * 10000, 2);

            return new Customer(name, cardNumber, pin, balance);
        }
    }
}
