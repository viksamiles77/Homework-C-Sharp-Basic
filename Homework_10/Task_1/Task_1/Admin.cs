namespace Task_1
{
    public class Admin : User
    {
        public string Username { get; set; }
        public List<Admin> Admins = new List<Admin>();
        public List<Trainer> Trainers = new List<Trainer>();
        public List<Student> Students = new List<Student>();

        public Admin(string username) : base(username, RoleEnum.Admin)
        {
            Username = username;
        }

        public void AddAdmin(string username)
        {
            Admins.Add(new Admin(username));
        }

        public void RemoveAdmin(string username)
        {
            Admins.Remove(new Admin(username));
        }

        public void AddTrainer(string username)
        {
            Trainers.Add(new Trainer(username));
        }

        public void RemoveTrainer(string username)
        {
            Trainers.Remove(new Trainer(username));
        }

        public void AddStudent(string username)
        {
            Students.Add(new Student(username));
        }

        public void RemoveStudent(string username)
        {
            Students.Remove(new Student(username));
        }


    }
}
