using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NJsonObject.ObjectInfo;

namespace NJsonObject.Generate
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
                case "Bool":
                    return new JValueInfo { Name = jToken.Path, Type = "bool" };
                case "Float":
                    return new JValueInfo { Name = jToken.Path, Type = "double" };
                case "Array":
                    return new JArrayInfo(){ Name = jToken.Path, Type = "list" };
                case "Object":
                    return new JClassInfo() { Name = jToken.Path, Type = "class" };
                case "Null":
                    return new JValueInfo() { Name = jToken.Path, Type = "null" };
            }

            return null;

        }
    }
}
 