using System;

namespace Lab9
{
    class CircleApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester!");

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine();
                double radius = Validator.GetRadius("Please enter the radius of the circle: ");
                Circle circle1 = new Circle(radius);
                double circumference = circle1.GetCircumference();
                double area = circle1.GetArea();
                Console.WriteLine($"\nThe circumference of the circle is {circle1.GetFormattedCircumference()}.");
                Console.WriteLine($"The area of the circle is {circle1.GetFormattedArea()}\n");
                repeat = Validator.DoAgain("Would you like to analyze another circle? (Y or N): ");
            }
            Console.Write($"\nYou created {Circle.numCircles} {Validator.IsPlural(Circle.numCircles)}.\n\nGoodbye.");
            Console.ReadLine();
        }
    }
}
