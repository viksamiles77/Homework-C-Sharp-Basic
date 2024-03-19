namespace Bonus_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] position = { 1, 2, };
            Rectangle rectangle = new Rectangle("Rectangle", "Red", position, 5, 6);
            Circle circle = new Circle("Circle", "Green", position, 3);

            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}, Perimeter: {rectangle.GetPerimeter()}");
            Console.WriteLine($"Circle Area: {circle.GetArea()}, Perimeter: {circle.GetPerimeter()}");
        }
    }
}
