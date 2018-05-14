namespace NJsonObject.ObjectInfo
{
    public class JValueInfo : JInfo
    {
        public override bool Equals(object other)
        {
            if (other == null)
                return false;

            if (this.GetType() != other.GetType())
                return false;


            if (Name == ((JValueInfo)other).Name && Type == ((JValueInfo)other).Type)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (Name + Type).GetHashCode() ;
        }
    }
}
