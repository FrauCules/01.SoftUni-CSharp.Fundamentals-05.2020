using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = decimal.Parse(Console.ReadLine());
            var count = int.Parse(Console.ReadLine());
            var priceLigh = decimal.Parse(Console.ReadLine());
            var priceRobe = decimal.Parse(Console.ReadLine());
            var priceBelt = decimal.Parse(Console.ReadLine());
            decimal sum = 0;

            int brLigh = 0;
            if ((count * 11) % 10 != 0)
                brLigh = (count * 11) / 10 + 1;
            else
                brLigh = (count * 11) / 10;
            decimal brBelt = count - (count / 6);

            sum = count * priceRobe + brBelt * priceBelt + brLigh * priceLigh;

            if(sum <= amount)
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            else
                Console.WriteLine($"Ivan Cho will need {sum - amount:f2}lv more.");
        }
    }
}
