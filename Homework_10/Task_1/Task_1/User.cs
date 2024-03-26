namespace Task_1
{
    public class User
    {
        public string Username { get; set; }
        public RoleEnum Role { get; set; }

        public User(string username, RoleEnum role)
        {
            Username = username;
            Role = role;
        }
    }
}
