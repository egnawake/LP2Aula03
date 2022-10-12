using System.Collections;
using System.Collections.Generic;

namespace Podium
{
    public class Podium<T> : IEnumerable<T>
    {
        private List<T> podium;
        private int spaces;

        public Podium(int spaces)
        {
            this.spaces = spaces;
            podium = new List<T>();
        }

        public bool Add(T element)
        {
            if (podium.Count >= spaces)
                return false;

            podium.Add(element);
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T element in podium)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

