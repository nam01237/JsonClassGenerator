using JsonObjectGenerator.ObjectInfo;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Sockets;
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

            _jArrayInfo.Name = jArray.Path;

            SetType();

            return _jArrayInfo;

        }

        private void SetType()
        {
            var types= (from x in _jArray.Values()
                             group x by x.Type into g
                             select new { type = g.Key.ToString() } );

            if ( types.Count() > 1 )
            {
                _jArrayInfo.Type = "object";
            }
            else
            {
                _jArrayInfo.Type = Converter.TypeStringConverter(types.FirstOrDefault().type);
            }



        }


    }
}
