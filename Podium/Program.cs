using System;

namespace Podium
{
    class Program
    {
        static void Main(string[] args)
        {
            Podium<Building> buildingPodium = new Podium<Building>(3);
            buildingPodium.Add(new Building("Building1", 1000f, 200f));
            buildingPodium.Add(new Building("Building2", 800f, 500f));
            buildingPodium.Add(new Building("Building3", 460f, 800f));
            buildingPodium.Add(new Building("Building4", 20000f, 3000f));
            buildingPodium.Add(new Building("Building5", 1350f, 675f));

            Podium<int> intPodium = new Podium<int>(5) { 8, 4, 17, 23, 2, 5, 11 };
        }
    }
}
