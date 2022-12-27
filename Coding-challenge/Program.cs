using System;

namespace Codingchallenge 
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Input number: ");
        long num = long.Parse(Console.ReadLine());

        for (long i = 2; i < num; i++)
        {
            bool isPrime = true;
            
            for (long j= 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(i);
            }
        }
        }
    }
}