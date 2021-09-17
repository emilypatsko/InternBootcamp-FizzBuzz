using System;

namespace FizzBuzz_CSharp
{
    class Program
    {
        static void FizzRule(int num, ref string thingToPrint)
        {
            if (num % 3 == 0)
            {
                thingToPrint += "Fizz";
            }
        }

        static void BuzzRule(int num, ref string thingToPrint)
        {
            if (num % 5 == 0)
            {
                thingToPrint += "Buzz";
            }
        }

        static void BangRule(int num, ref string thingToPrint)
        {
            if (num % 7 == 0)
            {
                thingToPrint += "Bang";
            }
        }

        static void BongRule(int num, ref string thingToPrint)
        {
            if (num % 11 == 0)
            {
                thingToPrint = "Bong";
            }
        }

        static void FezzRule(int num, ref string thingToPrint)
        {
            if (num % 13 == 0)
            {
                int indexOfFirstB = thingToPrint.IndexOf("B");
                if (indexOfFirstB > -1)
                {
                    thingToPrint = thingToPrint.Substring(0, indexOfFirstB) + "Fezz" + thingToPrint.Substring(indexOfFirstB);
                }
                else
                {
                    thingToPrint += "Fezz";
                }
            }
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 195; i++)
            {
                string thingToPrint = "";
                FizzRule(i, ref thingToPrint);
                BuzzRule(i, ref thingToPrint);
                BangRule(i, ref thingToPrint);
                BongRule(i, ref thingToPrint);
                FezzRule(i, ref thingToPrint);
                Console.WriteLine(thingToPrint != "" ? thingToPrint : i.ToString());
            }
        }
    }
}
