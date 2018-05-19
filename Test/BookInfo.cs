using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Test
{
	class BookInfo
{
    #region Fields
	
	
    #endregion

    #region Properties 
	
	public string Name {get; set;}
	public SubData Data {get; set;}
	public List<string> Friends {get; set;}
	public List<Book> Books {get; set;}
    
    #endregion

	#region Constructors

	public BookInfo()
	{}

	public BookInfo(JObject jObject)
	{
		JArray array;
		Name = (string)jObject["name"];
		Data = new SubData((JObject)jObject["data"]);
		Friends = new List<string>();
		array = JArray.Parse(jObject["friends"].ToString());
		foreach(var item in array)
		{
			Friends.Add(item.Value<string>());
		}
		Books = new List<Book>();
		array = JArray.Parse(jObject["books"].ToString());
		foreach(var item in array)
		{
			Books.Add(new Book((JObject)item));
		}
	}

    #endregion	
}
}
