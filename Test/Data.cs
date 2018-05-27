using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Test
{
	[JsonObject(MemberSerialization.OptOut)]
class Data
{
    #region Fields
	
	
    #endregion

    #region Properties 
	
	public string Name {get; set;}
	public int? Age {get; set;}
	public int? Birth {get; set;}
    
    #endregion

}
}
