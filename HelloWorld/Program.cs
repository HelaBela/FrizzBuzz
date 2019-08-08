using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var isDivisibleByThree = i % 3 == 0;
                var isDivisibleByFive = i % 5 == 0;

                if (isDivisibleByThree)
                {
                    Console.Write("Frizz");
                }

                if (isDivisibleByFive)
                {
                    Console.Write("Buzz");
                }

                if (isDivisibleByFive == false && isDivisibleByThree == false)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }
    }
}