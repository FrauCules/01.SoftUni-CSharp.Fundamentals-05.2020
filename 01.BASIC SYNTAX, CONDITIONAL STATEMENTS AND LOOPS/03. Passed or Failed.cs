﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade < 3.00)
                Console.WriteLine("Failed!");
            else
                Console.WriteLine("Passed!");
        }
    }
}
