using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using NJsonObject.ObjectInfo;

namespace NJsonObject.Generate
{
    public class ClassCodeGenerator
    {

        public static void GenerateClassCode(JClassInfo jClassInfo, DeclareOption declareOption, string formatString)
        {
            string fieldsString;

            if ( (declareOption & DeclareOption.CustomFormat) == DeclareOption.CustomFormat)
            {
                if((declareOption & DeclareOption.UpperFirstWord) == DeclareOption.UpperFirstWord)
                    fieldsString = CreateMemberString(jClassInfo.Properties, formatString, true);
                else
                    fieldsString = CreateMemberString(jClassInfo.Properties, formatString);
            }
        }

        public static void GenerateClassCode(string fieldFormat, string propertyFormat, JClassInfo jClassInfo, int declareMember)
        {
            string fields = "";

            if ((declareMember & (int) DeclareOption.NormalField) == (int) DeclareOption.NormalField)
                fields = CreateMemberString(jClassInfo.Properties, fieldFormat);

            string properties = "";

            if ((declareMember & (int) DeclareOption.Property) == (int) DeclareOption.Property)
                properties = CreateMemberString(jClassInfo.Properties, propertyFormat, true);

            string classTemplate = TemplateString.ClassTemplate;

            classTemplate = classTemplate.Replace("{CN}", jClassInfo.Type);
            classTemplate = classTemplate.Replace("{FD}", fields);
            classTemplate = classTemplate.Replace("{PROP}", properties);

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

                //tempString = tempString.Replace("{MNAME}", item.UsetDefineName);

                item.UsetDefineName = ExtractName(tempString, nameStart);
                fieldString.AppendLine();
                fieldString.Append("\t");
                fieldString.Append(tempString);

            }

            return fieldString.ToString();
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

            return name.ToString();
        }



    }

    

}
