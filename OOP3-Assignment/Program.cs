using OOP3_Assignment.Classes;

namespace OOP3_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle My_Circle = new Circle() { Redius = 10 };
            Rectangle rectangle = new Rectangle() { Length = 4, Width = 6 };
            My_Circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
        }
    }
}
