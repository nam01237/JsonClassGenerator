using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Test
{
    class Root
    {
        #region Fields

        private string _lastBuildDate;
        private int _total;
        private int _start;
        private int _display;
        private Root1 _type;
        private List<int> _itmes2;
        private List<items1> _items;

        #endregion

        #region Properties 

        public string LastBuildDate { get; set; }
        public int Total { get; set; }
        public int Start { get; set; }
        public int Display { get; set; }
        public Root1 Type { get; set; }
        public List<int> Itmes2 { get; set; }
        public List<items1> Items { get; set; }

        #endregion

        #region Constructors

        public Root()
        { }

        public Root(JObject jObject)
        {
            JArray array;
            _lastBuildDate = (string)jObject["lastBuildDate"];
            _total = (int)jObject["total"];
            _start = (int)jObject["start"];
            _display = (int)jObject["display"];
            _type = new Root1((JObject)jObject["type"]);
            _itmes2 = new List<int>();
            array = JArray.Parse(jObject["itmes2"].ToString());
            foreach (var item in array)
            {
                _itmes2.Add(item.Value<int>());
            }
            _items = new List<items1>();
            array = JArray.Parse(jObject["items"].ToString());
            foreach (var item in array)
            {
                _items.Add(new items1((JObject)item));
            }
        }

        #endregion
    }

    internal class items1
    {
        public items1(JObject jObject)
        { }
    }

    internal class Root1
    {
        public Root1(JObject jObject)
        { }
    }
}
