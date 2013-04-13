using System;

    class CountNumbersWithQualitiesInInterval
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine("Number of numbers divideble by 5 in the interval is {0}",p);
        }
    }

