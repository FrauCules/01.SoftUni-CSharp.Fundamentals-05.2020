using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hh = int.Parse(Console.ReadLine());
            var mm = int.Parse(Console.ReadLine());
            mm = mm + 30;
            if (mm >= 60)
            {
                mm = mm - 60;
                hh++;
                if (hh >= 24)
                {
                    hh = hh % 24;
                }
            }
            if (mm<9)
                Console.WriteLine($"{hh}:0{mm}");
            else
                Console.WriteLine($"{hh}:{mm}");
        }
    }
}
