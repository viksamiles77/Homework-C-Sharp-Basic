namespace Bonus_Task
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(string name, string color, int[] position, int radius)
            : base(name, color, position)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            double area = 0;
            area = 3.14 * Radius * Radius;
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = 0;
            perimeter = 2 * 3.14 * Radius;
            return perimeter;
        }


    }
}
