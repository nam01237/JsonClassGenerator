using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Test
{
	class Sub2
{
    #region Fields
	
	
    #endregion

    #region Properties 
	
	public string Title {get; set;}
	public string Link {get; set;}
	public string Category {get; set;}
	public string Description {get; set;}
	public string Telephone {get; set;}
	public string Address {get; set;}
	public string RoadAddress {get; set;}
	public string Mapx {get; set;}
	public string Mapy {get; set;}
    
    #endregion

	#region Constructors

	public Sub2()
	{}

	public Sub2(JObject jObject)
	{
		
		Title = (string)jObject["title"];
		Link = (string)jObject["link"];
		Category = (string)jObject["category"];
		Description = (string)jObject["description"];
		Telephone = (string)jObject["telephone"];
		Address = (string)jObject["address"];
		RoadAddress = (string)jObject["roadAddress"];
		Mapx = (string)jObject["mapx"];
		Mapy = (string)jObject["mapy"];
	}

    #endregion	
}
}