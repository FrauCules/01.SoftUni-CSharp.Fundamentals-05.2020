using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string str = num.ToString();
            int len = str.Length;
            var br = 0;
            var pos = num;
            var sum = 0;
            var sumPos = 1;
            
            for (int i = 1; i <= len; i++)
            {
                br = pos % 10;
                pos = pos / 10;
                for (int j = 1; j <= br; j++)
                {
                    sumPos = sumPos * j;
                }
                sum = sum + sumPos;
                //Console.WriteLine($"{br} - {sumPos}");
                sumPos = 1;
            }

            if(num == sum)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
