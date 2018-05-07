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


        public override bool Equals(JInfo other)
        {
            foreach (var p in Properties)
            {
                if (!((JClassInfo) other).Properties.Contains(p))
                    return false;
            }

            return true;
        }
    }
}
