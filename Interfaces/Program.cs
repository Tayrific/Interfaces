namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();

            double a = 10;
            double b = 20;
            double c = 1.0;
            double area = 0.0;
            double perimeter = 0.0;

            rec.height = a;
            rec.width = b;
            area = rec.Area();
            Console.WriteLine("Area of Rectangle is : {0:F}", area);

            perimeter = rec.perimeter();
            Console.WriteLine("perimeter of Rectangle is : {0:F}", perimeter);

            Console.ReadLine();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Circle area and perimeter");

            circle.radius = c;
            area = circle.Area();
            Console.WriteLine("Area of Circle is : {0:F}", area);

            perimeter = circle.perimeter();
            Console.WriteLine("perimeter of circle is : {0:F}", perimeter);

            Console.ReadLine();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Triangle area and perimeter");

            triangle.height = a;
            triangle.length = b;
            area = triangle.Area();
            Console.WriteLine("Area of triangle is : {0:F}", area);

            perimeter = triangle.perimeter();
            Console.WriteLine("perimeter of triangle is : {0:F}", perimeter);

        }
    }
}
