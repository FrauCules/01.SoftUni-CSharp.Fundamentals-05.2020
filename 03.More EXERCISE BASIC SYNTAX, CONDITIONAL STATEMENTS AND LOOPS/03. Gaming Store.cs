using System;
using System.Collections.Generic;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new Dictionary<string, decimal>();
            games.Add("OutFall 4", 39.99m);
            games.Add("CS: OG", 15.99m);
            games.Add("Zplinter Zell", 19.99m);
            games.Add("Honored 2", 59.99m);
            games.Add("RoverWatch", 29.99m);
            games.Add("RoverWatch Origins Edition", 39.99m);
            decimal totalSpend = 0;

            double sum = double.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            
            while(line != "Game Time")
            {
                if (games.ContainsKey(line))
                {
                    decimal price = games[line];
                    if (price <= (decimal)sum)
                    {
                        Console.WriteLine($"Bought {line}");
                        totalSpend += games[line];
                        sum -= (double)games[line];
                        if (sum == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        line = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                    line = Console.ReadLine();
                    continue;
                }
                line = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalSpend}. Remaining: ${sum:f2}");
        }

    }
}
