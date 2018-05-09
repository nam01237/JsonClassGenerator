using JsonObjectGenerator.ObjectInfo;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.ObjectInfo
{
    public class JClassInfo : JInfo
    {
        public List<JInfo> Properties { get; set; }


        public override bool Equals(object other)
        {
            if (other == null)
                return false;

            if (this.GetType() != other.GetType())

            foreach (var p in Properties)
            {
                if (!((JClassInfo) other).Properties.Contains(p))
                    return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            StringBuilder str = new StringBuilder();
            str.Append(Name);
            str.Append(Type);

            foreach (JInfo jInfo in Properties)
            {
                str.Append(jInfo.ToString());
            }

            return str.ToString().GetHashCode();
        }
    }
}
