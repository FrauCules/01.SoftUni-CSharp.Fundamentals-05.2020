using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int len = line.Length - 1;

            for (int i = len; i >= 0; i--)
            {
                Console.Write(line[i]);
            }
        }
    }
}
