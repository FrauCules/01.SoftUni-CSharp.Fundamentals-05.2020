using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var typeGroup = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            decimal price = 0.0m;
            decimal disc = 0.0m;
            decimal total = 0.0m;
            switch (typeGroup)
            {
                case "students":
                    if (day == "friday")
                        price = 8.45m;
                    else if (day == "saturday")
                        price = 9.8m;
                    else
                        price = 10.46m;
                    break;
                case "business":
                    if (day == "friday")
                        price = 10.9m;
                    else if (day == "saturday")
                        price = 15.6m;
                    else
                        price = 16;
                    break;
                case "regular":
                    if (day == "friday")
                        price = 15;
                    else if (day == "saturday")
                        price = 20;
                    else
                        price = 22.5m;
                    break;
            }
            total = price * num;
            if ((typeGroup == "students") && (num >= 30))
                disc = total * 0.15m ;
            if ((typeGroup == "business") && (num >= 100))
                disc = price *10;
            if ((typeGroup == "regular") && (num >= 10) && (num <= 20))
                disc = total * 0.05m;
            Console.WriteLine("Total price: {0:f2}", total - disc);
        }
    }
}
