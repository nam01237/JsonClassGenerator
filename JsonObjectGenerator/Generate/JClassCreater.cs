using Newtonsoft.Json.Linq;
using JsonObjectGenerator.ObjectInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonObjectGenerator.ObjectInfo.Properties;

namespace JsonObjectGenerator.Generate
{
    public class JClassCreater
    {
        private JObject _jObject;
        private JClassInfo _jClassInfo;
        private List<JProperty> _jProperties;

        public JClassCreater()
        {
            _jClassInfo = new JClassInfo();
        }

        public JClassInfo Create(JObject jObject, string name = "{CN}")
        {
            _jObject = jObject;
            _jProperties = _jObject.Properties().ToList();

            _jClassInfo.Name = name;
            SetProperties();

            return _jClassInfo;
        }

        private void SetProperties()
        {
            _jClassInfo.JTypes = new List<JType>();

            foreach (JProperty jp in _jProperties)
            {
                switch (jp.Value.Type.ToString())
                {
                    case "String":
                        _jClassInfo.JTypes.Add(
                            new JValueType { Type = "string", Name = jp.Value.ToString() });
                        break;
                    case "Integer":
                        _jClassInfo.JTypes.Add(
                            new JValueType { Type = "int", Name = jp.Value.ToString() });
                        break;
                    case "Boolean":
                        _jClassInfo.JTypes.Add(
                            new JValueType { Type = "bool", Name = jp.Value.ToString() });
                        break;
                    case "Float":
                        _jClassInfo.JTypes.Add(
                            new JValueType { Type = "double", Name = jp.Value.ToString() });
                        break;
                    case "Array":
                        _jClassInfo.JTypes.Add(
                            new JListType { Type = "list", Name = jp.Value.ToString() });
                        break;
                    case "Object":
                        _jClassInfo.JTypes.Add(
                            new JClassType { Type = "class", Name = jp.Value.ToString() });
                        break;
                    case "Null":
                        _jClassInfo.JTypes.Add(
                            new JValueType { Type = "unknwon", Name = jp.Value.ToString() });
                        break;
                }

            }
        }

    }
}
