﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Test
{
    class Root
    {
        #region Constructors

        public Root()
        { }

        public Root(JObject jObject)
        {

            lastBuildDate = (string)jObject["lastBuildDate"];
            total = (int)jObject["total"];
            start = (int)jObject["start"];
            display = (int)jObject["display"];
            type = new Root1((JObject)jObject["type"]);
            items = (List<items1>)jObject["items"];

        }

        #endregion

        #region Fields

        private string lastBuildDate;
        private int total;
        private int start;
        private int display;
        private Root1 type;
        private List<items1> items;

        #endregion

        #region Properties 

        public string LastBuildDate { get; set; }
        public int Total { get; set; }
        public int Start { get; set; }
        public int Display { get; set; }
        public Root1 Type { get; set; }
        public List<items1> Items { get; set; }

        #endregion
    }

    internal class items1
    {
    }

    internal class Root1
    {
        public Root1(JObject jObject)
        { }
    }
}
