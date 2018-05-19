using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Test
{
	class SubData
{
    #region Fields
	
	
    #endregion

    #region Properties 
	
	public string Name {get; set;}
	public int? Age {get; set;}
	public int? Birth {get; set;}
    
    #endregion

	#region Constructors

	public SubData()
	{}

	public SubData(JObject jObject)
	{
		
		Name = (string)jObject["name"];
		Age = (int?)jObject["age"];
		Birth = (int?)jObject["birth"];
	}

    #endregion	
}
}
