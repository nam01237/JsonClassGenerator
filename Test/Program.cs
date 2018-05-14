using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonObjectGenerator.analyze;
using Newtonsoft.Json.Linq;
using NJsonObject.Generate;
using NJsonObject.ObjectInfo;

namespace Test
{

    class Program
    {
        static void Main(string[] args)
        {
            string str = TempStringReader.GetJsonString("../../../samplej2.txt");
            JObject jo = JObject.Parse(str);

            JClassInfo jc = new JClassInfo();

            int x = (int)jo["age"];

            JArray ja = JArray.Parse(jo["list"].ToString());

            foreach (var item in ja)
            {
                
            }

            Console.WriteLine(ja);
        }
    }
}
