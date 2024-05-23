﻿namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape();
            Console.Read();

        }
        public static void Shape()
        {           
            double area = 0.0;
            double perimeter = 0.0;

            Console.WriteLine("---------------");
            Console.WriteLine("Select a shape:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("---------------");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                case "Rectangle":
                    IShape rec = CreateRectangle();

                    area = rec.Area();
                    Console.WriteLine("Area of Rectangle is : {0:F}", area);

                    perimeter = rec.perimeter();
                    Console.WriteLine("perimeter of Rectangle is : {0:F}", perimeter);
                    break;

                case "2":
                case "Circle":
                    IShape circle = CreateCircle();

                    area = circle.Area();
                    Console.WriteLine("Area of Circle is : {0:F}", area);

                    perimeter = circle.perimeter();
                    Console.WriteLine("perimeter of circle is : {0:F}", perimeter);
                    break;

                case "3":
                case "Triangle":
                    IShape triangle = CreateTriangle();

                    area = triangle.Area();
                    Console.WriteLine("Area of triangle is : {0:F}", area);

                    perimeter = triangle.perimeter();
                    Console.WriteLine("perimeter of triangle is : {0:F}", perimeter);
                    break;

                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("-- Invalid choice --");
                    Console.WriteLine(" ");
                    Shape();
                    break;

            }
        }

        static Rectangle CreateRectangle()
        {
            Console.WriteLine("Enter the width:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the heighte:");
            double height = Convert.ToDouble(Console.ReadLine());

            return new Rectangle { Width = width, Height = height };
        }

        static Circle CreateCircle()
        {
            Console.WriteLine("Enter the radius:");
            double radius = Convert.ToDouble(Console.ReadLine());

            return new Circle { Radius = radius };
        }

        static Triangle CreateTriangle()
        {
            Console.WriteLine("Enter the length of side A:");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of side B:");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of side C:");
            double sideC = Convert.ToDouble(Console.ReadLine());

            return new Triangle { SideA = sideA, SideB = sideB, SideC = sideC };
        }
    }

}
