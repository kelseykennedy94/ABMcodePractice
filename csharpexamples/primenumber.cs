using System;

class Program
{
    static void Main(string[] args)
    {
        for (int num = 1; num <= 100; num++)
        {
            bool isPrime = true;
            
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
            
            if (isPrime && num > 1)
            {
                Console.WriteLine(num);
            }
        }
    }
}