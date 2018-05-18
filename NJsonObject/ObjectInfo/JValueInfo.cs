using NJsonObject.etc;

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


            if (Name == ((JValueInfo)other).Name)
            {
                if( (Type == ((JValueInfo)other).Type) )
                    return true;

                if (Type == SharpType.Null)
                {
                    Type = ((JValueInfo) other).Type;
                    return true;
                }

                if (((JValueInfo) other).Type == SharpType.Null)
                {
                    ((JValueInfo) other).Type = Type;
                    return true;
                }
            }

            return false;
        }


        public override int GetHashCode()
        {
            return (Name + Type).GetHashCode() ;
        }
    }
}
