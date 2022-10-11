using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityManager4
{
    public class CompareByType : IComparer<Building>
    {
        private readonly bool ascending;

        public CompareByType(bool ascending)
        {
            this.ascending = ascending;
        }

        public int Compare(Building b1, Building b2)
        {
            if (ascending)
                return b1.Type.CompareTo(b2.Type);
            return b2.Type.CompareTo(b1.Type);
        }
    }
}
