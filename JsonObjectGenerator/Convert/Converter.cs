using JsonObjectGenerator.ObjectInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.Convert
{
    public class Converter
    {
        public static void TypeConvert(JClassInfo jClass)
        {
            List<String> types = (from p in jClass.Properties()
                                      select p.Value.Type.ToString()).ToList();

            for (int i = 0; i < types.Count; i++)
            {
                switch(types[i])
                {
                    case "String":
                        types[i] = "string";
                        break;
                    case "Integer":
                        types[i] = "int";
                        break;
                    case "Boolean":
                        types[i] = "bool";
                        break;
                    case "Float":
                        types[i] = "double";
                        break;
                    case "Array":
                        types[i] = "List";
                        break;
                    case "Object":
                        types[i] = "Type";
                        break;
                    case "Null":
                        types[i] = "unknown";
                        break;
                }

            }
        }
    }
}
