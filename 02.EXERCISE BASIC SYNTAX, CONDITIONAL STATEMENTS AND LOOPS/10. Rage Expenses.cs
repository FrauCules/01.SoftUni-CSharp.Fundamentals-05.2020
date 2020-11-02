using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            var lostGC = decimal.Parse(Console.ReadLine());
            var priceHeadset = decimal.Parse(Console.ReadLine());
            var priceMouse = decimal.Parse(Console.ReadLine());
            var priceKayboarde = decimal.Parse(Console.ReadLine());
            var priceDisplay = decimal.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= lostGC; i++)
            {
                if (i % 2 == 0)
                { 
                    sum = sum + priceHeadset; 
                    //Console.WriteLine(priceHeadset); 
                }
                if (i % 3 == 0)
                { 
                    sum = sum + priceMouse; 
                    //Console.WriteLine(priceMouse); 
                }
                if (i % 6 == 0)
                { 
                    sum = sum + priceKayboarde; 
                    //Console.WriteLine(priceKayboarde); 
                }
                if (i % 12 == 0)
                { 
                    sum = sum + priceDisplay; 
                    //Console.WriteLine(priceDisplay); 
                }
            }
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
