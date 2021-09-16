using System;

namespace FizzBuzz_CSharp
{
    class Program
    {
        static string FizzRule(int num, string thingToPrint)
        {
            if (num % 3 == 0)
            {
                thingToPrint = "Fizz";
            }
            return thingToPrint;
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string thingToPrint = i.ToString();
                thingToPrint = FizzRule(i, thingToPrint);

                Console.WriteLine(thingToPrint);
            }
        }
    }
}
