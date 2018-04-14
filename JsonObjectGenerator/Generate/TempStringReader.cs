using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.analyze
{
    public class TempStringReader
    {
        public static string GetJsonString(string path)
        {
            string jsonString;

            using (FileStream fs = new FileStream(path, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
            {
                jsonString = sr.ReadToEnd();
            }

            return jsonString;
        }
    }
}
