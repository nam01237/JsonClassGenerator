using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [JsonObject(MemberSerialization.OptOut)]
    public class TestClass
    {
        [JsonProperty]
        private string Name { get; set; }

        public void TestFields()
        {
            Console.WriteLine(Name);
        }
    }
}
