namespace Models
{
    public class Admin : User
    {
        public Admin(string name) : base (name) {}

        public void AddUser(string userType, string username)
        {
            if (userType.ToLower() == "admin")
            {
                Console.WriteLine("cannot add another admin.");
                return;
            }
            Console.WriteLine($"Added {userType}: {username}");
        }

        public void RemoveUser(string userType, string username) {
            Console.WriteLine($"Removed {userType}: {username}");
        }
    }
}
