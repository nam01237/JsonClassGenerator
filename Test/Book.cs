using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Test
{
	class Book
{
    #region Fields
	
	
    #endregion

    #region Properties 
	
	public string Name {get; set;}
	public int? Price {get; set;}
    
    #endregion

	#region Constructors

	public Book()
	{}

	public Book(JObject jObject)
	{
		
		Name = (string)jObject["name"];
		Price = (int?)jObject["price"];
	}

    #endregion	
}
}
