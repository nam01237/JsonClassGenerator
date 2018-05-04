using System;
using System.Collections.Generic;
using System.Linq;
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
                case "Null":
                    convertString = "object";
                    break;
            }

            return convertString;
        }
    }
}
