using System;
using System.Collections.Generic;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var push = new Dictionary<string, string>();
            push["2"] = "a";
            push["22"] ="b";
            push["222"] = "c";
            push["3"] ="d";
            push["33"] ="e";
            push["333"] ="f";
            push["4"] ="g";
            push["44"] ="h";
            push["444"] ="i";
            push["5"] ="j";
            push["55"] ="k";
            push["555"] ="l";
            push["6"] ="m";
            push["66"] ="n";
            push["666"] ="o";
            push["7"] ="p";
            push["77"] ="q";
            push["777"] ="r";
            push["7777"] ="s";
            push["8"] ="t";
            push["88"] ="u";
            push["888"] ="v";
            push["9"] ="w";
            push["99"] ="x";
            push["999"] ="y";
            push["9999"] ="z";
            push["0"] = " ";

            int num = int.Parse(Console.ReadLine());
            string text ="";

            for (int i = 1; i <= num; i++)
            {
                string digit = Console.ReadLine();
                if (push.ContainsKey(digit))
                {
                    string newtext = text + push[digit];
                    text = newtext;
                }
            }

            Console.WriteLine(text);
        }
    }
}
