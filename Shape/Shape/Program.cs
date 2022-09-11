namespace Figurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[] { new Circle(), new Rectangle()};
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            circle.draw(Console.ReadLine());
            rectangle.draw(Console.ReadLine());
            Console.WriteLine(rectangle.Equals(rectangle));
            Console.WriteLine(shapes.Equals(rectangle));
            Console.WriteLine(shapes.Equals(shapes));
            Console.ReadLine();
        }
    }
}