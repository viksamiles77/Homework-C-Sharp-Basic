namespace Bonus_Task
{
    public class Shape
    {
        public string name;
        public string color;
        public int[] Position {get; set;}

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void GetArea()
        {
            Console.WriteLine("There is no special implementation for area.");
        }

        public void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter.");
        }

        public Shape(string name, string color, int[] position)
        {
            Name = name;
            Color = color;
            Position = position;
        }
    }

}
