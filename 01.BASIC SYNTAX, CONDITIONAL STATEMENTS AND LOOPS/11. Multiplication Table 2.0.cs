using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            //int i = n;
            do
            {
                Console.WriteLine($"{num} X {n} = {num * n}");
                
                n++;
            }
            while(n <= 10);
        }
    }
}
