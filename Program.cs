using System;
using System.Collections.Generic;

namespace FizzBuzz_CSharp
{
    class Program
    {
        static void FizzRule(int num, List<string> thingToPrint)
        {
            if (num % 3 == 0)
            {
                thingToPrint.Add("Fizz");
            }
        }

        static void BuzzRule(int num, List<string> thingToPrint)
        {
            if (num % 5 == 0)
            {
                thingToPrint.Add("Buzz");
            }
        }

        static void BangRule(int num, List<string> thingToPrint)
        {
            if (num % 7 == 0)
            {
                thingToPrint.Add("Bang");
            }
        }

        static void BongRule(int num, List<string> thingToPrint)
        {
            if (num % 11 == 0)
            {
                thingToPrint = new List<string>{ "Bong" };
            }
        }

        static void FezzRule(int num, List<string> thingToPrint)
        {
            if (num % 13 == 0)
            {
                int indexOfFirstB = thingToPrint.FindIndex(e => e.StartsWith("B"));
                if (indexOfFirstB > -1)
                {
                    thingToPrint.Insert(indexOfFirstB, "Fezz");
                }
                else
                {
                    thingToPrint.Add("Fezz");
                }
            }
        }

        static void ReverseRule(int num, List<string> thingToPrint)
        {
            if (num % 17 == 0)
            {
                thingToPrint.Reverse();
            }
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 255; i++)
            {
                List<string> thingToPrint = new List<string>();
                FizzRule(i, thingToPrint);
                BuzzRule(i, thingToPrint);
                BangRule(i, thingToPrint);
                BongRule(i, thingToPrint);
                FezzRule(i, thingToPrint);
                ReverseRule(i, thingToPrint);
                Console.WriteLine(thingToPrint.Count == 0 ? i : string.Join("", thingToPrint));
            }
        }
    }
}
