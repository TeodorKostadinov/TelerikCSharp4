using System;

    class SolvingEquation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter coefficient a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient c: ");
            double c = double.Parse(Console.ReadLine());
            double disc = b * b - 4 * a * c;
            if (a == 0)
            {
                Console.WriteLine("The equation is not quadratic. The root is {0}", -c / b);
            }
            else
            {
                if (disc < 0)
                {
                    Console.WriteLine("The roots are not real.");
                }
                else
                {
                    Console.WriteLine("The roots are {0} and {1}.", (-b + Math.Sqrt(disc)) / (2 * a), (-b - Math.Sqrt(disc)) / (2 * a));
                }
            }

        }
    }

