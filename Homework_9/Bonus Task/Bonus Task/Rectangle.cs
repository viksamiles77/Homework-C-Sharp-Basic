namespace Bonus_Task
{
    public class Rectangle : Shape
    {
        public int SideA {  get; set; }
        public int SideB { get; set; }
        public Rectangle(string name, string color, int[] position, int sideA, int sideB)
            : base(name, color, position)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public int GetArea()
        {
            int area = 0;
            area = SideA * SideB;
            return area;
        }

        public int GetPerimeter()
        {
            int perimeter = 0;
            perimeter = 2 * (SideA + SideB);
            return perimeter;
        }
    }

}
