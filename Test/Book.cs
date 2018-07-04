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

        private string Name { get; set; }
        private Data Data { get; set; }
        private List<string> Friends { get; set; }
        private List<BookInfo> Books { get; set; }

        #endregion

    }
}
