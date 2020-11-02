using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = Console.ReadLine();
                       
            int lenSt = user.Length;
            int fl = 1;

            char[] passChar = user.ToCharArray();
            Array.Reverse(passChar);
            string password = new string(passChar);

            for (int j = 0; j < 4; j++)
            {
                if (Console.ReadLine() == password)
                {
                    Console.WriteLine($"User {user} logged in.");
                    return;
                }
                else if (j == 3)
                    Console.WriteLine($"User {user} blocked!");
                else
                    Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }
}
