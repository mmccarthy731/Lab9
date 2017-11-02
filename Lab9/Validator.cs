using System;

namespace Lab9
{
    class Validator
    {
        public static bool DoAgain(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (input == "y" || input == "yes")
            {
                return true;
            }
            else if (input == "n" || input == "no")
            {
                return false;
            }
            else
            {
                Console.Write("\nInvaid input. ");
                return DoAgain(prompt);
            }
        }

        public static double GetRadius(string prompt)
        { 
            double radius = 0;
            bool success = false;
            while (!success)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                success = double.TryParse(input, out radius);
                if (radius <= 0.0)
                {
                    Console.Write("\nInvalid input. ");
                    success = false;
                }
            }
            return radius;
        }

        public static string IsPlural(int numCircles)
        {
            if (numCircles == 1)
            {
                return "circle";
            }
            else
            {
                return "circles";
            }
        }
    }
}
