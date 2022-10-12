using System;
using System.Collections.Generic;

namespace MyGenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IHasValue[] valuables = {
                new MilitaryUnit(15, 2, 8),
                new MilitaryUnit(20, 3, 10),
                new Building("Barracks", 3, 10),
                new SettlerUnit(10, 4),
                new Building("Library", 4, 18)
            };

            IHasValue prev = null;

            foreach (IHasValue v in valuables)
            {
                Console.WriteLine(v.GetType());
                Console.WriteLine(v);
                if (prev != null)
                {
                    Console.WriteLine($"Equates previous: {v.Equals(prev)}");
                }
                Console.WriteLine("");

                prev = v;
            }

            Console.WriteLine("{0} military units",
                CountValuablesOfType<MilitaryUnit>(valuables));

            Console.WriteLine("{0} buildings",
                CountValuablesOfType<Building>(valuables));

            Console.WriteLine("{0} settlers",
                CountValuablesOfType<SettlerUnit>(valuables));
        }

        private static int CountValuablesOfType<T>(
            IEnumerable<IHasValue> valuables) where T : IHasValue
        {
            int count = 0;

            foreach (IHasValue v in valuables)
            {
                if (v is T) count++;
            }

            return count;
        }
    }
}
