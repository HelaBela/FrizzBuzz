using System;

namespace HelloWorld
{
    class Program
    {
        static string GetResult(int i)
        {
            var isDivisibleByThree = i % 3 == 0;
            var isDivisibleByFive = i % 5 == 0;
            var result = "";
            
            if (isDivisibleByFive && isDivisibleByThree)
            {
                result = "FrizzBuzz";
            }else if (isDivisibleByThree)
            {
                result = "Frizz";
            } else if (isDivisibleByFive)
            {
                result = "Buzz";
            }
            
            else
            {
                result = i.ToString();
            }
            return result;
        }

        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(GetResult(i));
            }
        }
    }
}