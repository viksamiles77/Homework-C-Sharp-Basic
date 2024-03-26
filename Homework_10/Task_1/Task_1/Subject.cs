namespace Task_1
{
    public class Subject
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public Subject(string name)
        {
            Name = name;
        }
    }
}
