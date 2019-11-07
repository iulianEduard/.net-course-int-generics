using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics.Samples.LinqSamples
{
    public class BasicLinq
    {
        private readonly List<int> _numbers;

        public BasicLinq()
        {
            _numbers = new List<int>();
            
            Fill();
        }

        public void Run()
        {
            /*
             * 1. Query creation
             * It will return an IEnumerable<int>
             */
            var wholeNumbers =
                from number in _numbers
                where (number % 2) == 0
                select number;

            /*
             * 2. Query Execution
             * Only at this point in time the query is being executed
             */
            foreach(var number in wholeNumbers)
            {
                Console.WriteLine($"-> {number}");
            }
        }

        private void Fill()
        {
            for(int i = 1; i <= 20; i++)
            {
                _numbers.Add(i);
            }
        }
    }
}
