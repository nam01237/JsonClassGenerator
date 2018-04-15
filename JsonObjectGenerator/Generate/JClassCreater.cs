using Newtonsoft.Json.Linq;
using JsonObjectGenerator.ObjectInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonObjectGenerator.Convert;

namespace JsonObjectGenerator.Generate
{
    public class JClassCreater
    {
        public JClassInfo Create(JObject jObject)
        {
            JClassInfo nClass = (JClassInfo)jObject;

            Converter.TypeConvert(nClass);

            foreach (var item in nClass)
            {
                Console.WriteLine(item);
            }
            return nClass;
        }


    }
}
