using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.ObjectInfo
{
    public class JArrayInfo : JInfo
    {
        public string GenericType;
        public List<JClassInfo> ClassTypes { get; set; }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;

            if (this.GetType() != other.GetType())
                return false;

            if (Name == ((JArrayInfo)other).Name && GenericType == ((JArrayInfo)other).GenericType)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (Name + Type + GenericType).GetHashCode();
        }

        public override string ToString()
        {
            return $"{Type}<{GenericType}> {Name} ";

        }
    }
}
