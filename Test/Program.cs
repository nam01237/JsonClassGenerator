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
            soo();
        }

        public static void foo()
        {
            string json = TempStringReader.GetJsonString("..//..//sample.json");

            TestClass test = JsonConvert.DeserializeObject<TestClass>(json);

            test.TestFields();
        }

        public static void goo()
        {
            string test1 = TempStringReader.GetJsonString("..//..//..//test1.txt");
            string test2 = TempStringReader.GetJsonString("..//..//..//test2.txt");

            JClassCreater classCreater = new JClassCreater();

            JObject testObject1 = JObject.Parse(test1);
            JObject testObject2 = JObject.Parse(test2);


            JClassInfo testInfo1 = classCreater.Create(testObject1);
            JClassInfo testInfo2 = classCreater.Create(testObject2);


            if( testInfo2.Equals(testInfo1) )
                Console.WriteLine("asdf!!");


            foreach (var item in testInfo1.Properties)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            foreach (var item in testInfo2.Properties)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void soo()
        {
            string json = TempStringReader.GetJsonString("..//..//..//book.txt");

            JClassCreater creater = new JClassCreater();

            Book book = JsonConvert.DeserializeObject<Book>(json);

            book.Print();

        }

    }




    public class goo
    {

    }

}
