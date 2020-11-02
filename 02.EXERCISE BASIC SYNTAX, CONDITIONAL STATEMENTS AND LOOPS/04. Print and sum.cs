using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numStart = int.Parse(Console.ReadLine());
            var numEnd = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = numStart; i <= numEnd; i++)
            {
                sum += i;
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
