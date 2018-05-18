using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Test
{
	class class
{
    #region Fields
	
	
    #endregion

    #region Properties 
	
	public string LastBuildDate {get; set;}
	public int? Total {get; set;}
	public int? Start {get; set;}
	public int? Display {get; set;}
	public class Type {get; set;}
	public List Itmes2 {get; set;}
	public List Items {get; set;}
    
    #endregion

	#region Constructors

	public class()
	{}

	public class(JObject jObject)
	{
		JArray array;
		LastBuildDate = (string)jObject["LastBuildDate"];
		Total = (int?)jObject["Total"];
		Start = (int?)jObject["Start"];
		Display = (int?)jObject["Display"];
		Type = new class((JObject)jObject["Type"]);
		Itmes2 = new List<int?>();
		array = JArray.Parse(jObject["Itmes2"].ToString());
		foreach(var item in array)
		{
			Itmes2.Add(item.Value<int?>());
		}
		Items = new List<items1>();
		array = JArray.Parse(jObject["Items"].ToString());
		foreach(var item in array)
		{
			Items.Add(new items1((JObject)item));
		}
	}

    #endregion	
}
}
