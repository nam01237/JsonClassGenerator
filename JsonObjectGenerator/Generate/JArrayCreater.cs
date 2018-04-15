using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.Generate
{
    public class JArrayCreater
    {
        public string JSonString { get; set; }
        
        public JArrayCreater(string jsonString)
        {
            JSonString = jsonString;
        }
        
    }
}
