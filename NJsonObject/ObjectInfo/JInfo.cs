namespace NJsonObject.ObjectInfo
{
    public abstract class JInfo
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string UsetDefineName { get; set; }

        public override string ToString()
        {
            return $"{Type} {Name}";
        }

        public abstract override bool Equals(object obj);

        public abstract override int GetHashCode();

    }
}
