using System;

    class CalculatingSumOfDecreasingSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 1;
            
            for (int i = 2; i < n; i++)
            {
                double member = (double)1 / i;
                sum = sum + Math.Pow(-1, i) * member;
                
                
            }
            
            Console.WriteLine("The sum is {0}", Math.Round(sum,3));
        }
    }

