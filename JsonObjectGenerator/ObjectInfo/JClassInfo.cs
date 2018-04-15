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
    public class JClassInfo  : JObject
    {
        public List<JType> Properties { get; set; }
        //public List<JValueType> ValueTypes { set;  get; }
        //public List<JValueType> ReferenceTypes { set;  get; }
        //public List<JListInfo> ListTypes { set;  get; }
    }
}
