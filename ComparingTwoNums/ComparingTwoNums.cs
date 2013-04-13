using System;

    class ComparingTwoNums
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            bool firstIsGreater = first > second;
            Console.WriteLine("The first number is greater is {0}",firstIsGreater);
        }
    }

