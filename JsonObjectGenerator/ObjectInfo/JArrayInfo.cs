using JsonObjectGenerator.ObjectInfo.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.ObjectInfo
{
    public class JArrayInfo : JInfo
    {
        public JInfo Element { get; set; }
        public List<JClassInfo> ClassTypes { get; set; }
    }
}
