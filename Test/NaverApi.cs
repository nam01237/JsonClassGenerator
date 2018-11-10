using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Test
{
	[JsonObject(MemberSerialization.OptOut)]
class NaverApi
{
    #region Fields
	
	[JsonProperty]public string LastBuildDate  {get; set;}
	[JsonProperty]public int Total  {get; set;}
	[JsonProperty]public int Start  {get; set;}
	[JsonProperty]public int Display  {get; set;}
	[JsonProperty]public List<Data> Items  {get; set;}    
    #endregion

}
}
