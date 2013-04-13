using System;
    class SummingNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");

            double n = double.Parse(Console.ReadLine());
            double sum = n;
            string line = n.ToString();
            Console.WriteLine("To stop entering numbers press 0");
            Console.WriteLine("Enter number:");
            while (n != 0)
            {
                 n = double.Parse(Console.ReadLine());
                 sum = sum + n;
                 line = line + " + " + n.ToString() ;
                 Console.WriteLine(line + " = " + sum.ToString());
            }
        }
    }

