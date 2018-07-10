using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Test
{
	[JsonObject(MemberSerialization.OptOut)]
internal class BookInfo
{
    #region Fields

	
	[JsonProperty]private string Name  {get; set;}
	[JsonProperty]private int Price  {get; set;}    
    
	#endregion

}
}
