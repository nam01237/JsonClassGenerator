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
            goo g = new goo(); ;
            g.foo();

            //string json = TempStringReader.GetJsonString("..//..//..//samplej2.txt");
            
            //JObject jObject = JObject.Parse(json);
            //JArray array = (JArray)jObject["items"];

            //JClassCreater creater = new JClassCreater();

            //JClassInfo jc1 = creater.Create((JObject)array[0]);
            //JClassInfo jc2 = creater.Create((JObject)array[1]);

            //Console.WriteLine(jc1.Equals(jc2));

            //Console.WriteLine(jc2.Properties[0]);
            //Console.WriteLine(jc2.Properties[1]);
        }

    }

    public class goo
    {
        public void foo()
        {
            string json = TempStringReader.GetJsonString("..//..//..//temp.txt");

            JObject jObject = JObject.Parse(json);

            Root root = new Root(jObject);

            Console.WriteLine(root.LastBuildDate);
            Console.WriteLine(root.Total);
            Console.WriteLine(root.Start);
            Console.WriteLine(root.Display);
            Console.WriteLine(root.Type.Name);
            Console.WriteLine(root.Type.Age);
            foreach (var item in root.Itmes2)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            foreach (var item in root.Items)
            {
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Link);
                Console.WriteLine(item.Category);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Telephone);
                Console.WriteLine(item.Address);
                Console.WriteLine(item.RoadAddress);
                Console.WriteLine(item.Mapx);
                Console.WriteLine(item.Mapy);

            }
        }
    }

}
