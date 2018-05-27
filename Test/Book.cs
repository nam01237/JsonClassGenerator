using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Test
{
    [JsonObject(MemberSerialization.OptOut)]
    class Book
    {
        #region Fields


        #endregion

        #region Properties 

        public string Name { get; set; }
        public Data Data { get; set; }
        public List<string> Friends { get; set; }
        public List<BookInfo> Books { get; set; }

        #endregion

    }
}
