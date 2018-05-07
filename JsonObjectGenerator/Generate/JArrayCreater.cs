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

            _jArrayInfo.Name = Converter.PathToName(jArray.Path);
            _jArrayInfo.Type = "List";

            SetType();
            SetClasses();

            return _jArrayInfo;

        }

        private void SetType()
        {
            var types= (from x in _jArray.Values()
                             group x by x.Type into g
                             select new { type = g.Key.ToString() } );

            if ( types.Count() > 1 )
            {
                _jArrayInfo.GenericType = "object";
            }
            else
            {
                _jArrayInfo.GenericType = Converter.TypeStringConverter(types.FirstOrDefault().type);
            }

        }

        private void SetClasses()
        {
           List<JToken> classes = (from x in _jArray.Values()
                where x.Type.ToString() == "Object"
                select x).ToList();

            if( classes.Count == 0)
                return;

            JClassCreater classCreater = new JClassCreater();

            foreach (var x in classes)
            {
                JClassInfo classInfo = classCreater.Create((JObject)x);

                if (_jArrayInfo.ClassTypes.Contains(classInfo))
                {
                    _jArrayInfo.ClassTypes.Add(classInfo);
                }
            }

            if (_jArrayInfo.ClassTypes.Count == 1 && _jArrayInfo.GenericType == "Class")
            {
                _jArrayInfo.GenericType = _jArrayInfo.ClassTypes[0].Name;
            }
        }

    }
}
