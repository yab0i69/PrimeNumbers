using System.Diagnostics;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stopwatch watch = new Stopwatch();

            List<int> primes = new();
            primes.Add(2);
            
            watch.Start();
            for (int i = 3; i < 15485863; i+=2)
            {
                bool isPrime = true;
                int max = (int)Math.Sqrt(i);
                
                for (int j = 3; j <= max; j += 2)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                 
                    primes.Add(i);
                }
            }
            watch.Stop();

            Console.WriteLine($"Elapsed time: {watch.ElapsedMilliseconds}ms");
        }
    }
}