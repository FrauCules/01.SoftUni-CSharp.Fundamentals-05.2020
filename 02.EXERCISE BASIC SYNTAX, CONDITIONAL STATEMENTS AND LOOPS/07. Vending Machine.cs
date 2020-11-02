using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            var inPut = "";
            decimal sum = 0;
            var product = "";
            decimal price = 0;

            while (inPut != "start")
            {
                inPut = Console.ReadLine().ToLower();
                switch (inPut)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        sum = sum + decimal.Parse(inPut);
                        break;
                    case "start":
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {inPut}");
                        break;
                }
            }
            
            inPut = "";
            while (inPut != "end")
            {
                inPut = Console.ReadLine().ToLower();
                switch (inPut)
                {
                    case "nuts":
                        price = 2;
                        break;
                    case "water":
                        price = 0.7m;
                        break;
                    case "crisps":
                        price = 1.5m;
                        break;
                    case "soda":
                        price = 0.8m;
                        break;
                    case "coke":
                        price = 1;
                        break;
                    case "end":
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (price != 0)
                    if (sum >= price)
                        Console.WriteLine($"Purchased {inPut}");
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        break;
                    }
                   
                sum = sum - price;
                price = 0;
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
