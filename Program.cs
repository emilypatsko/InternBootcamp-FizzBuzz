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

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string thingToPrint = "";
                FizzRule(i, ref thingToPrint);
                BuzzRule(i, ref thingToPrint);
                Console.WriteLine(thingToPrint != "" ? thingToPrint : i.ToString());
            }
        }
    }
}
