using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NJsonObject.etc;

namespace NJsonObject.Generate
{
    public class Converter
    {
        public static string TypeStringConverter(string typeString)
        {
            string convertString = "unknown";

            switch (typeString)
            {
                case JsonType.String:
                    convertString = SharpType.String;
                    break;
                case JsonType.Inreger:
                    convertString = SharpType.Int;
                    break;
                case JsonType.Boolean:
                    convertString = SharpType.Bool;
                    break;
                case JsonType.Float:
                    convertString = SharpType.Double;
                    break;
                case JsonType.Property:
                    convertString = SharpType.Class;
                    break;
                case JsonType.Null:
                    convertString = SharpType.Null;
                    break;
                case JsonType.Undefined:
                    convertString = SharpType.Null;
                    break;
            }

            return convertString;
        }

        public static string PathToName(string path)
        {
            int index = path.LastIndexOf(".");

            if (index == -1)
                return path;

            string name = path.Substring(index + 1, path.Length - index - 1);


            return name;
        }
    }
}
