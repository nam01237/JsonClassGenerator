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
            JObject jObject = JObject.Parse(str);

            JClassCreater jCreator = new JClassCreater();

            JClassInfo jClassInfo = jCreator.Create(jObject);

            foreach (var item in jClassInfo.Properties)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var property in 
            ((JClassInfo)jClassInfo.Properties[2]).Properties)

            {
                Console.WriteLine(property);
            }

            //JArray jArray = JArray.Parse(str);
            //JArrayCreater jArrayCreater = new JArrayCreater();
            //jArrayCreater.Create(jArray);

            Console.WriteLine();

            JValueInfo v1 = new JValueInfo { Name = "name", Type = "string" };
            JValueInfo v2 = new JValueInfo { Name = "name", Type = "string" };


            Console.WriteLine(v1.Equals(v2));

            JClassInfo c1 = new JClassInfo { Name = "c1", Type = "class", Properties = new List<JInfo>() };
            c1.Properties.Add(v1);

            JClassInfo c2 = new JClassInfo { Name = "c1", Type = "class", Properties = new List<JInfo>() };
            c2.Properties.Add(v2);

            Console.WriteLine(c1.Equals(c2));
        }
    }
}
