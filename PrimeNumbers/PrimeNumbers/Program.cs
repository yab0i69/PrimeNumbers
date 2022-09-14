﻿namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1000; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
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