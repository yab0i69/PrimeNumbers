namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2");
            for (int i = 3; i < 15485863; i+=2)
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