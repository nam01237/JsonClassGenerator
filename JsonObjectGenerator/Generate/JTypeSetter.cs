using JsonObjectGenerator.ObjectInfo;
using JsonObjectGenerator.ObjectInfo.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.Generate
{
    public class JTypeSetter
    {
        
        public static JInfo ConvertTypeString(JToken jToken)

        {
            switch (jToken.Type.ToString())
            {
                case "String":
                    return new JValueInfo { Name = jToken.Path, Type = "string" };
                case "Integer":
                    return new JValueInfo { Name = jToken.Path, Type = "int" };
                case "Boolean":
                    return new JValueInfo { Name = jToken.Path, Type = "bool" };
                case "Float":
                    return new JValueInfo { Name = jToken.Path, Type = "double" };
                case "Array":
                    return new JListType { Name = jToken.Path, Type = "list" };
                case "Object":
                    return new JClassType { Name = jToken.Path, Type = "class" };
                case "Null":
                    return new JClassType { Name = jToken.Path, Type = "null" };
            }

            return null;

        }
    }
}
 