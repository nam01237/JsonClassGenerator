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
        }

        public JArrayInfo Create(JArray jArray)
        {
            _jArrayInfo = new JArrayInfo();
            _jArray = jArray;

            SetType();

            return _jArrayInfo;

        }

        private void SetType()
        {
            int objCount = _jArray.Count(x => x.Type.ToString().Equals("Object"));

            var typeList = _jArray.Select(x => x.Type.ToString())
                           .Distinct();

            if ( objCount == 0 )
            {
                if (typeList.Count() <= 0)
                {
                    
                }

            }


           

            var count = from x in _jArray
                        group x by x.Type into g
                        select g;


        }


    }
}
