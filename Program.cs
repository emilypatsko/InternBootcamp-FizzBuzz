using System;
using System.Collections.Generic;
using System.Linq;

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

        static void FizzBuzz(string[] args)
        {
            Dictionary<string, bool> rules = new Dictionary<string, bool>
            {
                { "fizz", true },
                { "buzz", true },
                { "bang", true },
                { "bong", true },
                { "fezz", true },
                { "reverse", true },
            };
            int length = 100;

            if (args.Length > 0)
            {
                length = Int32.TryParse(args[0], out length) ? length : 100;
            
                if (args.Length > 1)
                {
                    foreach (var rule in rules)
                    {
                        if (Array.IndexOf(args, rule.Key) > -1)
                        {
                            rules[rule.Key] = true;
                        }
                        else 
                        {
                            rules[rule.Key] = false;
                        }
                    }
                }                
            }

            for (int i = 1; i <= length; i++)
            {
                List<string> thingToPrint = new List<string>();
                if (rules["fizz"]) FizzRule(i, thingToPrint);
                if (rules["buzz"]) BuzzRule(i, thingToPrint);
                if (rules["bang"]) BangRule(i, thingToPrint);
                if (rules["bong"]) BongRule(i, thingToPrint);
                if (rules["fezz"]) FezzRule(i, thingToPrint);
                if (rules["reverse"]) ReverseRule(i, thingToPrint);
                Console.WriteLine(thingToPrint.Count == 0 ? i : string.Join("", thingToPrint));
            }
        }
        
        static void Main(string[] args)
        {
            // FizzBuzz(args);

            // Single line version
            Enumerable.Range(1, 100).ToList().ForEach(i => Console.WriteLine(i % 3 != 0 && i % 5 != 0 && i % 7 != 0 ? i.ToString() : $"{(i % 3 == 0 ? "Fizz" : "")}{(i % 5 == 0 ? "Buzz" : "")}{(i % 7 == 0 ? "Bang" : "")}"));
        }
    }
}
