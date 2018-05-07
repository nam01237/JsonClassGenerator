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

        public override bool Equals(JInfo other)
        {
            if (Name == other.Name && Type == other.Type)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"{Type}<{GenericType}> {Name} ";

        }
    }
}
