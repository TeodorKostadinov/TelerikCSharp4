using System;

    class FibonacciSequence
    {
        static void Main(string[] args)
        {
            ulong previous = 0;
            ulong current = 1;
            ulong next;
            string line = "Fibonacci: " + previous + ", " + current + ", ";
            for (int i = 0; i < 98; i++)
            {
                next = previous + current;
                line = line + next + ", ";
                previous = current;
                current = next;
            }
            Console.WriteLine(line);
        }
    }

