using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonObjectGenerator.analyze;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NJsonObject.Generate;
using NJsonObject.ObjectInfo;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test()
        {
            string jsonString = TempStringReader.GetJsonString("..//..//naverapi.txt");

            JClassCreater jCreater = new JClassCreater();

            NaverApi api = JsonConvert.DeserializeObject<NaverApi>(jsonString);

            Console.WriteLine(api.Display);
            Console.WriteLine(api.LastBuildDate);
            Console.WriteLine(api.Start);
            Console.WriteLine(api.Total);

            foreach (var item in api.Items)
            {
                Console.WriteLine();
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Bloggerlink);
                Console.WriteLine(item.Bloggername);
            }

        }
    }

}
