using System;
using System.Collections.Generic;

namespace HashBuildings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize collections
            List<Building> list = new List<Building>();
            Stack<Building> stack = new Stack<Building>();
            Queue<Building> queue = new Queue<Building>();
            HashSet<Building> set = new HashSet<Building>();

            // Instantiate buildings
            Building mansion = new Building("Mansion", 500f, 8000f);
            Building university = new Building("University", 2000f, 5000f);
            Building fort = new Building("Fort", 300f, 750f);
            Building market = new Building("Market", 700f, 1250f);

            list.Add(mansion);
            list.Add(university);
            list.Add(fort);
            list.Add(fort);
            list.Add(market);

            stack.Push(mansion);
            stack.Push(university);
            stack.Push(fort);
            stack.Push(fort);
            stack.Push(market);

            queue.Enqueue(mansion);
            queue.Enqueue(university);
            queue.Enqueue(fort);
            queue.Enqueue(fort);
            queue.Enqueue(market);

            set.Add(mansion);
            set.Add(university);
            set.Add(fort);
            set.Add(fort);
            set.Add(market);

            PrintBuildings(list);
            PrintBuildings(stack);
            PrintBuildings(queue);
            PrintBuildings(set);
        }

        private static void PrintBuildings(IEnumerable<Building> buildings)
        {
            Console.WriteLine(buildings.GetType());

            foreach (Building b in buildings)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("");
        }
    }
}
