using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Test
{
	[JsonObject(MemberSerialization.OptOut)]
class BookInfo
{
    #region Fields
	
	
    #endregion

    #region Properties 
	
	public string Name {get; set;}
	public int? Price {get; set;}
    
    #endregion

}
}
