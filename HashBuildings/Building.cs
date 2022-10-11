using System;

namespace HashBuildings
{
    public class Building : IHasValue, IComparable<IHasValue>
    {
        public string Type { get; }
        public float Area { get; }
        public float Value { get; }

        public Building(string type, float area, float value)
        {
            Type = type;
            Area = area;
            Value = value;
        }

        public bool Equals(IHasValue other)
        {
            return other.Value == Value;
        }

        public int CompareTo(IHasValue other)
        {
            if (other == null) return 1;
            if (other.Value > Value) return 1;
            if (other.Value < Value) return -1;
            return 0;
        }

        public override string ToString()
        {
            return $"{Type,-20}\n"
                + $"Value: {Value,8:f2}\n"
                + $"Area: {Area,8:f2}";
        }

        public override bool Equals(object obj)
        {
            Building other = obj as Building;
            if (other == null) return false;
            return other.Value == Value && other.Type == Type;
        }

        public override int GetHashCode()
        {
            return Type.GetHashCode() ^ Value.GetHashCode();
        }
    }
}

