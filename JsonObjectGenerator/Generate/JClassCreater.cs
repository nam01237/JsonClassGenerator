using Newtonsoft.Json.Linq;
using JsonObjectGenerator.ObjectInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonObjectGenerator.Generate
{
    public class JClassCreater
    {
        private JObject _jObject;
        private JClassInfo _jClassInfo;
        private List<JProperty> _jProperties;

        public JClassCreater()
        {
        }

        public JClassInfo Create(JObject jObject)
        {
            _jClassInfo = new JClassInfo();
            _jObject = jObject;
            _jProperties = _jObject.Properties().ToList();

            _jClassInfo.Name = Converter.PathToName(jObject.Path);
            _jClassInfo.Type = "Class";
            SetProperties();

            return _jClassInfo;
        }

        private void SetProperties()
        {
            _jClassInfo.Properties = new List<JInfo>();
            JClassCreater classCreater = new JClassCreater();
            JArrayCreater arrayCreater = new JArrayCreater();

            List<JToken> jTokens = _jObject.Values().ToList();

            foreach (var item in jTokens)
            {
                if (item.Type.ToString().Equals("Object"))
                {
                    JObject temp = (JObject) item;
                    _jClassInfo.Properties.Add( classCreater.Create(temp) );
                }
                else if (item.Type.ToString().Equals("Array"))
                {
                    JArray temp = (JArray) item;
                    _jClassInfo.Properties.Add( arrayCreater.Create(temp) );
                }
                else
                {
                    _jClassInfo.Properties.Add( new JValueInfo
                    {
                        Name = Converter.PathToName(item.Path),
                        Type = Converter.TypeStringConverter( item.Type.ToString() )
                    } );
                }
            }
        }



    }
}
