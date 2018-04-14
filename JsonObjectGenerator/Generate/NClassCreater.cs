using Newtonsoft.Json.Linq;
using JsonObjectGenerator.ObjectInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.Generate
{
    public class NClassCreater
    {
        private JObject _sourceObject;

        public NClassCreater(JObject sourceObject)
        {
            _sourceObject = sourceObject;
        }

        public NClass Create()
        {
            NClass nClass = new NClass();


            return nClass;
        }
    }
}
