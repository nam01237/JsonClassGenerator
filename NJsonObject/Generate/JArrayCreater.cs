using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using NJsonObject.ObjectInfo;

namespace NJsonObject.Generate
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
            _jArrayInfo.ClassTypes = new List<JClassInfo>();

            SetType();
            SetClassInfos();

            return _jArrayInfo;

        }

        private void SetType()
        {
            var types= (from x in _jArray.Values()
                             group x by x.Type into g
                             select new { type = g.Key.ToString() } );

            Console.WriteLine(types.FirstOrDefault().type);



            if ( types.Count() > 1 )
            {
                _jArrayInfo.GenericType = "object";
            }
            else
            {
                _jArrayInfo.GenericType = Converter.TypeStringConverter(types.FirstOrDefault().type);
            }

        }

        private void SetClassInfos()
        {
            var classes = (from x in _jArray.Children()
                          where x.Type.ToString() == "Object"
                          select x).ToList();

            if (classes.Count == 0)
                return;

            JClassCreater classCreater = new JClassCreater();

            foreach (var x in classes)
            {
                JClassInfo tempInfo = classCreater.Create((JObject)x);
                tempInfo.Parent = _jArrayInfo;

                tempInfo.Type = _jArrayInfo.Name + (_jArrayInfo.ClassTypes.Count + 1);
                tempInfo.Name = "";

                if (!_jArrayInfo.ClassTypes.Contains(tempInfo))
                    _jArrayInfo.ClassTypes.Add(tempInfo);

            }

            if (_jArrayInfo.GenericType == "class" && _jArrayInfo.ClassTypes.Count == 1)
                _jArrayInfo.GenericType = _jArrayInfo.ClassTypes[0].Type;
            else
                _jArrayInfo.GenericType = "object";


        }

    }
}
