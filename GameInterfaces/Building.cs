namespace GameInterfaces
{
    public class Building : IHasValue
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

        public override string ToString()
        {
            return $"{Type,-20}\n"
                + $"Value: {Value,8:f2}\n"
                + $"Area: {Area,8:f2}";
        }
    }
}

