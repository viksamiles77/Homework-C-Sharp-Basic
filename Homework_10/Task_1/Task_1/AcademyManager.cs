namespace Task_1
{
    public class AcademyManager
    {
        public List<Admin> Admins { get; set; } = new List<Admin>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();

        public User GetUser(string username)
        {
            foreach (var admin in Admins)
            {
                if (admin.Username == username)
                    return admin;
            }

            foreach (var trainer in Trainers)
            {
                if (trainer.Username == username)
                    return trainer;
            }

            foreach (var student in Students)
            {
                if (student.Username == username)
                    return student;
            }

            return null;
        }
    }
}
