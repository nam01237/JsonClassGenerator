using JsonObjectGenerator.ObjectInfo;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.Generate
{
    public class JArrayCreater
    {
        private JArray _jArray;
        private JArrayInfo _jArrayInfo;

        public JArrayCreater()
        {
            _jArrayInfo = new JArrayInfo();
        }

        public JArrayInfo Create(JArray jArray)
        {
            _jArray = jArray;
            SetType();

            JArrayInfo jArrayInfo = new JArrayInfo();
            return jArrayInfo;

        }

        private void SetType()
        {
           var count = from x in _jArray
                        group x by x.Type into g
                        select g;

            Console.WriteLine(count.Count());
        }

    }
}
