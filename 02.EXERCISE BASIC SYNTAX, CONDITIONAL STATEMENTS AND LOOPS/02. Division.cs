using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var divNum = 0;

            if (num % 2 == 0)
                divNum = 2;
            if (num % 3 == 0)
                divNum = 3;
            if (num % 6 == 0)
                divNum = 6;
            if (num % 7 == 0)
                divNum = 7;
            if (num % 10 == 0)
                divNum = 10;

            if (divNum==0)
                Console.WriteLine("Not divisible");
            else
                Console.WriteLine("The number is divisible by {0}", divNum);

        }
    }
}
