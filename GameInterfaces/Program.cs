using System;

namespace GameInterfaces
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
        }
    }
}
