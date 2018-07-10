using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Test
{
	[JsonObject(MemberSerialization.OptOut)]
internal class Data
{
    #region Fields

	
	[JsonProperty]private string Name  {get; set;}
	[JsonProperty]private int Age  {get; set;}
	[JsonProperty]private int Birth  {get; set;}    
    
	#endregion

}
}
