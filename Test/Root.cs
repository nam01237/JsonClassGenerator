using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Test
{
	class Root
{
    #region Fields
	
	
    #endregion

    #region Properties 
	
	public string LastBuildDate {get; set;}
	public int? Total {get; set;}
	public int? Start {get; set;}
	public int? Display {get; set;}
	public Sub1 Type {get; set;}
	public List<int?> Itmes2 {get; set;}
	public List<Sub2> Items {get; set;}
    
    #endregion

	#region Constructors

	public Root()
	{}

	public Root(JObject jObject)
	{
		JArray array;
		LastBuildDate = (string)jObject["lastBuildDate"];
		Total = (int?)jObject["total"];
		Start = (int?)jObject["start"];
		Display = (int?)jObject["display"];
		Type = new Sub1((JObject)jObject["type"]);
		Itmes2 = new List<int?>();
		array = JArray.Parse(jObject["itmes2"].ToString());
		foreach(var item in array)
		{
			Itmes2.Add(item.Value<int?>());
		}
		Items = new List<Sub2>();
		array = JArray.Parse(jObject["items"].ToString());
		foreach(var item in array)
		{
			Items.Add(new Sub2((JObject)item));
		}
	}

    #endregion	
}
}
