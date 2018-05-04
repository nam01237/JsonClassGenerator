using JsonObjectGenerator.ObjectInfo;
using JsonObjectGenerator.ObjectInfo.Properties;
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
    }
}
