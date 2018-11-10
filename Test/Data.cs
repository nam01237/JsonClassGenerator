using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Test
{
    [JsonObject(MemberSerialization.OptOut)]
    class Data
    {
        #region Fields

        [JsonProperty] public string Title { get; set; }
        [JsonProperty] public string Link { get; set; }
        [JsonProperty] public string Description { get; set; }
        [JsonProperty] public string Bloggername { get; set; }
        [JsonProperty] public string Bloggerlink { get; set; }
        [JsonProperty] public string Postdate { get; set; }

        #endregion
    }
}