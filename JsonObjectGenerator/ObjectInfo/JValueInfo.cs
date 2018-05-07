using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.ObjectInfo
{
    public class JValueInfo : JInfo
    {
        public override bool Equals(JInfo other)
        {
            if (Name == other.Name && Type == other.Type)
                return true;
            else
                return false;
        }
    }
}
