namespace Task_1
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }


        public string Eat()
        {
            return $"The dog {Name} is now eating.";
        }
        
        public string Play()
        {
            return $"The dog {Name} is now playing.";
        }
        
        public string ChaseTail()
        {
            return $"The dog {Name} is now chasing it's tail.";
        }
    }
}
