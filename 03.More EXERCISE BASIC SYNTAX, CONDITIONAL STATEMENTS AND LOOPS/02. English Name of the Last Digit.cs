using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int digit = num % 10;

            LastDigit(digit);
        }

        static void LastDigit(int digit)
        {
            if (digit == 1)
            {
                Console.WriteLine("one");
                return;
            }
            if (digit == 2)
            {
                Console.WriteLine("two");
                return;
            }
            if (digit == 3)
            {
                Console.WriteLine("three");
                return;
            }
            if (digit == 4)
            {
                Console.WriteLine("four");
                return;
            }
            if (digit == 5)
            {
                Console.WriteLine("five");
                return;
            }
            if (digit == 6)
            {
                Console.WriteLine("six");
                return;
            }
            if (digit == 7)
            {
                Console.WriteLine("seven");
                return;
            }
            if (digit == 8)
            {
                Console.WriteLine("eight");
                return;
            }
            if (digit == 9)
            {
                Console.WriteLine("nine");
                return;
            }
            if (digit == 0)
            {
                Console.WriteLine("zero");
                return;
            }


        }
    }
}
