namespace ATM_app
{
    public enum Transaction
    {
        CheckBalance,
        Deposit,
        Withdraw
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Customer> customers = new List<Customer>();

            // generates 20 random atm customers
            for (int i = 0; i < 20; i++)
            {
                string name = "Customer " + (i + 1);
                long cardNumber = GenerateCardNumber(random);
                // transforming it to string so i can add "-" between every fourth number, looks better when we print it
                string cardNumberString = cardNumber.ToString();
                string formattedCardNumber = cardNumberString.Insert(4, "-").Insert(9, "-").Insert(14, "-");
                int pin = random.Next(1000, 9999);
                double balance = Math.Round(random.NextDouble() * 10000, 2);

                Customer newCustomer = new Customer(name, cardNumber, pin, balance);
                customers.Add(newCustomer);
                // this WriteLine is here so we can check the info of the customers we generate, not necessary
                Console.WriteLine($"{name} || Card Number: {formattedCardNumber} || Balance: {balance}$ || PIN: {pin}");
            }

            bool exitATM = false;

            while (!exitATM)
            {
                Console.WriteLine("Select type of transaction: \n0 - Check balance \n1 - Deposit cash \n2 - Withdraw cash");

                string transactionTypeInput = Console.ReadLine();
                if (!int.TryParse(transactionTypeInput, out int transactionTypeInt) ||
                    transactionTypeInt < 0 || transactionTypeInt > 2)
                {
                    Console.WriteLine("Invalid transaction type! Please enter the numbers 0, 1 or 2 accordingly.");
                    continue;
                }

                Transaction transactionType = (Transaction)transactionTypeInt;
                DoTransaction(customers, transactionType);

                // we are asking the user if they want to perform another transaction on the atm
                Console.WriteLine("Do you want to keep using the ATM? (yes/no)");
                string response = Console.ReadLine().ToLower();

                if (response != "yes")
                {
                    exitATM = true;
                }
            }
        }
        private static long GenerateCardNumber(Random random)
        {
            string number = $"{random.Next(1000, 9999)}{random.Next(1000, 9999)}{random.Next(1000, 9999)}{random.Next(1000, 9999)}";
            return long.Parse(number);
        }
        private static bool CheckCardEquality(string cardString, long cardInt)
        {
            string cardStringSanitized = cardString.Replace("-", "");
            return long.TryParse(cardStringSanitized, out long cardLong) && cardLong == cardInt;
        }
        private static void DoTransaction(List<Customer> customers, Transaction transactionType)
        {
            string inputCardNumber;
            string pinInput;

            while (true)
            {
                Console.WriteLine("Input your card number:");
                inputCardNumber = Console.ReadLine().Replace(" ", "");

                if (inputCardNumber.Length == 19)
                {
                    if (inputCardNumber[4] == '-' && inputCardNumber[9] == '-' && inputCardNumber[14] == '-')
                    {
                        break;
                    }
                }
                Console.WriteLine("Wrong input, please enter in the format shown (xxxx-xxxx-xxxx-xxxx).");
            }

            while (true)
            {
                Console.Write("Input your PIN: ");
                pinInput = Console.ReadLine().Replace(" ", ""); ;

                if (int.TryParse(pinInput, out _) && pinInput.Length == 4)
                {
                    break;
                }
                Console.WriteLine("Wrong input, please enter 4 numbers in the format shown (xxxx).");
            }

            bool customerExists = false;
            Customer selectedCustomer = null;
            if (inputCardNumber == null)
            {
                Console.WriteLine("Invalid card!");
            }
            else
            {
                foreach (Customer customer in customers)
                {
                    if (customer != null)
                    {
                        customerExists = CheckCardEquality(inputCardNumber, customer.CardNumber);
                        if (customerExists)
                        {
                            selectedCustomer = customer;
                            break;
                        }
                    }
                }

                if (selectedCustomer == null)
                {
                    Console.WriteLine("Invalid card! Customer not found!");
                    Console.WriteLine("Would you like to register as a new user? (yes/no)");
                    string response = Console.ReadLine().ToLower();
                    if (response == "yes" || response == "y")
                    {
                        selectedCustomer = Customer.AddNewUser();
                        customers.Add(selectedCustomer);
                        Console.WriteLine($"New customer {selectedCustomer.Name} is added.");
                    }
                }
                else
                {
                    if (transactionType == Transaction.CheckBalance)
                    {
                        selectedCustomer.GetBalance();
                    }
                    else if (transactionType == Transaction.Deposit)
                    {
                        string amount;
                        while (true)
                        {
                            Console.WriteLine("Enter the amount you want to deposit:");
                            amount = Console.ReadLine();
                            if (float.TryParse(amount, out _))
                            {
                                break;
                            }
                            Console.WriteLine("Invalid input, please input numbers (money).");
                        }
                        selectedCustomer.Deposit(float.Parse(amount));
                    }
                    else
                    {
                        string amount;
                        while (true)
                        {
                            Console.WriteLine("Enter the amount you want to withdraw:");
                            amount = Console.ReadLine();
                            if (float.TryParse(amount, out _))
                            {
                                break;
                            }
                            Console.WriteLine("Invalid input, please input numbers (money).");
                        }
                        selectedCustomer.Withdraw(float.Parse(amount));
                    }
                }
            }
        }
    }
}
