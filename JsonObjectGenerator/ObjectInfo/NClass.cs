using JsonObjectGenerator.ObjectInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.ObjectInfo
{
    public class NClass
    {
        public List<NValueType> ValueTypes { get; }
        public List<NValueType> ReferenceTypes { get; }
        public List<NList> ListTypes { get; }
    }
}
