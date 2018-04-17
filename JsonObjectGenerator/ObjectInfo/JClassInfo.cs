﻿using JsonObjectGenerator.ObjectInfo;
using JsonObjectGenerator.ObjectInfo.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.ObjectInfo
{
    public class JClassInfo
    {
        public string Name { get; set; }
        public List<JType> JTypes { get; set; }
    }
}
