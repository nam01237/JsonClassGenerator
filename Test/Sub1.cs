using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Test
{
	class Sub1
{
    #region Fields
	
	
    #endregion

    #region Properties 
	
	public int? Age {get; set;}
	public string Name {get; set;}
    
    #endregion

	#region Constructors

	public Sub1()
	{}

	public Sub1(JObject jObject)
	{
		
		Age = (int?)jObject["age"];
		Name = (string)jObject["name"];
	}

    #endregion	
}
}
