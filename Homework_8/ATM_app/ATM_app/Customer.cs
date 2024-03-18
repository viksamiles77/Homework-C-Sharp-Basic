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
            Console.WriteLine($"You have {Balance}$ left in your account!");
        }

        public void Withdraw(float amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"You withdrew {amount}$ left in your account!");
                Console.WriteLine($"You have {Balance}$ left in your account!");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void Deposit(float amount)
        {
            Balance += amount;
            Console.WriteLine($"You deposited {amount}$ left in your account!");
            Console.WriteLine($"You have {Balance}$ left in your account!");
        }
    }
}
