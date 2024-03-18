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
            Customer[] customers = new Customer[20];

            for (int i = 0; i < customers.Length; i++)
            {
                string name = "Customer" + (i + 1);
                long cardNumber = GenerateCardNumber(random);
                int pin = random.Next(1000, 9999);
                double balance = random.NextDouble() * 10000; // Generate random balance up to $10,000

                customers[i] = new Customer(name, cardNumber, pin, balance);
                Console.WriteLine($"Created Customer: {name}, Card Number: {cardNumber}, Balance: {balance}$");
            }

            Console.WriteLine("Select type of transaction: 0 - Check balance, 1 - Deposit cash, 2 - Withdraw cash");
            string transactionType = Console.ReadLine();
            DoTransaction(customers, (Transaction)int.Parse(transactionType));
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
        private static void DoTransaction(Customer[] customers, Transaction transactionType)
        {
            Console.WriteLine("Input card number:");
            string inputCardNumber = Console.ReadLine();

            Console.WriteLine("Input PIN:");
            string pin = Console.ReadLine();

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
                    customerExists = CheckCardEquality(inputCardNumber, customer.CardNumber);
                    if (customerExists)
                    {
                        selectedCustomer = customer;
                        break;
                    }
                }

                if (selectedCustomer == null)
                {
                    Console.WriteLine("Invalid card! Customer not found!");
                }
                else
                {
                    if (transactionType == Transaction.CheckBalance)
                    {
                        selectedCustomer.GetBalance();
                    }
                    else if (transactionType == Transaction.Deposit)
                    {
                        Console.WriteLine("Enter amount:");
                        var amount = Console.ReadLine();
                        selectedCustomer.Deposit(long.Parse(amount));
                    }
                    else
                    {
                        Console.WriteLine("Enter amount:");
                        var amount = Console.ReadLine();
                        selectedCustomer.Withdraw(long.Parse(amount));
                    }
                }
            }
        }
    }
}
