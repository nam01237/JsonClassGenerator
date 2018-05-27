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
            string json = TempStringReader.GetJsonString("..//..//..//book.txt");

            Book book = JsonConvert.DeserializeObject<Book>(json);

            Console.WriteLine(book.Name);
            Console.WriteLine(book.Books[0].Name);
            Console.WriteLine(book.Books[0].Price);


        }
    }

}
