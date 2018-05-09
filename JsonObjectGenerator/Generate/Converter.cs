using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.Generate
{
    public class Converter
    {
        public static string TypeStringConverter(string typeString)
        {
            string convertString = "unknown";

            switch (typeString)
            {
                case "String":
                    convertString = "string";
                    break;
                case "Integer":
                    convertString = "int";
                    break;
                case "Boolean":
                    convertString = "bool";
                    break;
                case "Float":
                    convertString = "float";
                    break;
                case "Property":
                    convertString = "class";
                    break;
                case "Null":
                    convertString = "null";
                    break;
            }

            return convertString;
        }

        public static string PathToName(string path)
        {
            int index = path.LastIndexOf(".");

            return path.Substring( index + 1, path.Length - index - 1);
        }
    }
}
