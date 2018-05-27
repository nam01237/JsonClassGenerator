using System.Collections.Generic;
using System.IO;
using System.Text;
using NJsonObject.ObjectInfo;
using System.Diagnostics;

namespace NJsonObject.Generate
{
    public class ClassCodeGenerator
    {

        public static void GenerateClassCode(string fieldFormat, string propertyFormat, JClassInfo jClassInfo, int declareMember)
        {
            string fields = "";

            if ((declareMember & (int) DeclareContent.Filed) == (int) DeclareContent.Filed)
                fields = CreateMemberString(jClassInfo.Properties, fieldFormat);

            string properties = "";

            if ((declareMember & (int) DeclareContent.Property) == (int) DeclareContent.Property)
                properties = CreateMemberString(jClassInfo.Properties, propertyFormat, true);

            //jClassInfo.Properties.ConvertAll(x => x.Name = char.ToUpper(x.Name[0]) + x.Name.Substring(1));

           // string constructor = CreateConstructorString(jClassInfo.Properties);

            string classTemplate = TemplateString.ClassTemplate;

            classTemplate = classTemplate.Replace("{CN}", jClassInfo.Type);
            classTemplate = classTemplate.Replace("{FD}", fields);
            classTemplate = classTemplate.Replace("{PROP}", properties);
            //classTemplate = classTemplate.Replace("{CONS}", constructor);

            File.WriteAllText("..//..//temp.txt", classTemplate);

            jClassInfo.ClassCode =  classTemplate;
        }

        private static string CreateMemberString(List<JInfo> members, string formatString, bool upperFirst = false)
        {
            StringBuilder fieldString = new StringBuilder();

            foreach (var item in members)
            {
                string tempString = formatString;

                tempString = tempString.Replace("{TYPE}", item.Type);
                int nameStart = tempString.IndexOf("{NAME}");

                if (!upperFirst)
                    tempString = tempString.Replace("{NAME}", item.Name);
                else
                    tempString = tempString.Replace("{NAME}", (char.ToUpper(item.Name[0]) + item.Name.Substring(1)) );

                tempString = tempString.Replace("{MNAME}", item.UsetDefineName);

                item.UsetDefineName = ExtractName(tempString, nameStart);
                fieldString.AppendLine();
                fieldString.Append("\t");
                fieldString.Append(tempString);

            }

            return fieldString.ToString();
        }

        private static string CreateConstructorString(List<JInfo> members)
        {
            StringBuilder constructorString = new StringBuilder();

            if (members.Exists(x => x.Type.StartsWith("List")))
            {
                constructorString.Append("JArray array;");
            }

            foreach (var item in members)
            {
                string tempString;

                if (item is JClassInfo)
                {
                    tempString = TemplateString.RefTypeInit;
                    tempString = tempString.Replace("{TYPE}", item.Type);
                    tempString = tempString.Replace("{NAME}", item.Name);
                    tempString = tempString.Replace("{MNAME}", item.UsetDefineName);
                }
                else if (item is JArrayInfo)
                {
                    tempString = CreateListInitString((JArrayInfo)item);
                }
                else
                {
                    tempString = TemplateString.ValueTypeInit;
                    tempString = tempString.Replace("{TYPE}", item.Type);
                    tempString = tempString.Replace("{NAME}", item.Name);
                    tempString = tempString.Replace("{MNAME}", item.UsetDefineName);

                }

                constructorString.AppendLine();
                constructorString.Append("\t\t");
                constructorString.Append(tempString);
            }

            return constructorString.ToString();
        }

        private static string CreateListInitString(JArrayInfo jArrayInfo)
        {
            string tempString;

            if (jArrayInfo.GenericType != SharpType.Object)
            {
                if (jArrayInfo.ClassTypes.Count == 1)
                {
                    tempString = TemplateString.RefTypeListInit;

                    tempString = tempString.Replace("{NAME}", jArrayInfo.Name);
                    tempString = tempString.Replace("{MNAME}", jArrayInfo.UsetDefineName);
                    tempString = tempString.Replace("{CN}", jArrayInfo.ClassTypes[0].Type);
                    tempString = tempString.Replace("{GTYPE}", jArrayInfo.GenericType);

                }
                else
                {
                    tempString = TemplateString.ValueTypeListInit;

                    tempString = tempString.Replace("{NAME}", jArrayInfo.Name);
                    tempString = tempString.Replace("{MNAME}", jArrayInfo.UsetDefineName);
                    tempString = tempString.Replace("{GTYPE}", jArrayInfo.GenericType);
                }
            }
            else
            {
                tempString = $"{jArrayInfo.Name} = new List<object>()";
            }


            return tempString;
        }

        private static string ExtractName(string declareString, int nameIndex)
        {
            StringBuilder name = new StringBuilder();

            int index = nameIndex;

            while(true)
            {
                index--;
                string temp = declareString.Substring(index, 1);

                if ( temp == " ")
                    break;
                else
                {
                    name.Insert(0, temp);
                }
            }

            
            index = nameIndex;
            while(true)
            {
                string temp = declareString.Substring(index, 1);
                index++;

                if (temp == " " || temp == ";" )
                    break;
                else
                {
                    name.Append(temp);
                }
            }

            //Debug.WriteLine(name.ToString());

            return name.ToString();
        }



    }

    

}
