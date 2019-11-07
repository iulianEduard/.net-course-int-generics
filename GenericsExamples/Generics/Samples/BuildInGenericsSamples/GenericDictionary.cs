using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics.Samples.BuildInGenericsSamples
{
    public class GenericDictionary
    {
        private readonly Dictionary<int, int> PrimeDictionary;

        public GenericDictionary()
        {
            PrimeDictionary = new Dictionary<int, int>();
        }

        public void Run()
        {
            Console.WriteLine("--> Show prime numbers to 20");
            ShowPrimeNumbers(20);
            Console.WriteLine(Environment.NewLine);

            Console.ReadKey();
            Console.WriteLine("--> Show prime numbers to 60");
            ShowPrimeNumbers(60);
            Console.WriteLine(Environment.NewLine);

            Console.ReadKey();
            Console.WriteLine("--> Show prime numbers to 40");
            ShowPrimeNumbers(40);
            Console.WriteLine(Environment.NewLine);
        }

        private void ShowPrimeNumbers(int upToThisNumber)
        {
            for (int i = 1; i <= upToThisNumber; i++)
            {
                if(NumberExistsInDictionary(i))
                {
                    Console.WriteLine($"Number: {i} is prime. Value from dictionary, not calculated again!");
                    continue;
                }

                if(IsPrime(i))
                {
                    Console.WriteLine($"Adding number: {i} to dictionary. Value is calculated");
                    AddNumberInDictionary(i);
                }
            }
        }

        private bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

        private void AddNumberInDictionary(int number)
        {
            if(!PrimeDictionary.Values.Where(pd => pd == number).Any())
            {
                var lastIndex = PrimeDictionary.Keys.Count;
                PrimeDictionary.Add(lastIndex++, number);
            }
        }

        private bool NumberExistsInDictionary(int number)
        {
            return PrimeDictionary.Values.Where(p => p == number).Any();
        }
    }
}
