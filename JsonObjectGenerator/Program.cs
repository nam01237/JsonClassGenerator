using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using JsonObjectGenerator.analyze;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonObjectGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            string json = TempStringReader.GetJsonString("../../../samplej.txt");

            JToken jo = JToken.Parse(json);
            Console.WriteLine(jo.Type);

            JToken jt1 = jo[0];
            JToken jt4 = jo[3];

            Console.WriteLine(jt4.Count());

            JObject jo1 = (JObject)jo[0];
            JObject jo2 = (JObject)jo[1];
            JObject jo3 = (JObject)jo[2];
            //JObject jo4 = (JObject)jo[3];

            List<string> jpn1 = (from p in jo1.Properties()
                                 select p.Name).ToList();
            List<string> jpn2 = (from p in jo2.Properties()
                                 select p.Name).ToList();
            List<string> jpn3 = (from p in jo3.Properties()
                                 select p.Name).ToList();
            //List<string> jpn4 = (from p in jo4.Properties()
            //                     select p.Name).ToList();


            //Console.WriteLine(jpn1.Intersect(jpn2).Count() == jpn1.Count);
            //Console.WriteLine(jpn1.Intersect(jpn3).Count() == jpn1.Count);

            //Console.WriteLine(jpn4.Count);


        }
    }
}
