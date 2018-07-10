using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Test
{
	[JsonObject(MemberSerialization.OptOut)]
internal class Book
{
    #region Fields

	
	[JsonProperty]private string Name  {get; set;}
	[JsonProperty]private Data Data  {get; set;}
	[JsonProperty]private List<string> Friends  {get; set;}
	[JsonProperty]private List<BookInfo> Books  {get; set;}    
    
        public void Print()
        {
            System.Console.WriteLine(Name);

        }

	#endregion

}
}
