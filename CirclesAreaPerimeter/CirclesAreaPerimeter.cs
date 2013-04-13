using System;

    class CirclesAreaPerimeter
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("The circle's perimeter is {0} and its area is {1}", Math.Round(2*r*Math.PI,2),Math.Round(r*r*Math.PI,2));
        }
    }

