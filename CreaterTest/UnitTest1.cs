using System;
using JsonObjectGenerator.analyze;
using JsonObjectGenerator.Generate;
using JsonObjectGenerator.ObjectInfo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace CreaterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = TempStringReader.GetJsonString("../../../samplej2.txt");
            JObject jObject = JObject.Parse(str);

            JClassCreater jCreator = new JClassCreater();

            JClassInfo jClassInfo = jCreator.Create(new InClassName(jObject));

        }
    }
}
