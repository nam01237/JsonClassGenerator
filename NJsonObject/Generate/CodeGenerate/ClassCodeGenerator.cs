using System.Collections.Generic;
using System.Text;
using NJsonObject.ObjectInfo;

namespace NJsonObject.Generate
{
    public class ClassCodeGenerator
    {

        public static void GenerateClassCode(JClassInfo jClassInfo, DeclareOption declareOption, string formatString)
        {
            string fieldsString = "";

            if ((declareOption & DeclareOption.CustomFormat) == DeclareOption.CustomFormat)
            {
                fieldsString = CreateMemberString(jClassInfo.Properties, formatString, declareOption);
            }
            else
            {
                StringBuilder optionalFormat = new StringBuilder();

                optionalFormat.Append(SetModifider(declareOption));
                optionalFormat.Append(" {TYPE}");
                optionalFormat.Append(" {NAME} ");

                if ((declareOption & DeclareOption.Property) == DeclareOption.Property)
                    optionalFormat.Append(" {get; set;}");
                else if ((declareOption & DeclareOption.NormalField) == DeclareOption.NormalField)
                    optionalFormat.Append(";");

                fieldsString = CreateMemberString(jClassInfo.Properties, optionalFormat.ToString(), declareOption);

            }

            string classTemplate = TemplateString.ClassTemplate;

            classTemplate = classTemplate.Replace("{FD}", fieldsString);
            classTemplate = classTemplate.Replace("{CN}", jClassInfo.Type);

            jClassInfo.ClassCode = classTemplate;
        }


        private static string CreateMemberString(List<JInfo> members, string formatString, DeclareOption declareOption)
        {
            StringBuilder fieldString = new StringBuilder();

            foreach (var item in members)
            {
                string tempString = formatString;

                if ((declareOption & DeclareOption.Nullable) == DeclareOption.Nullable)
                {
                    if (item.Type == SharpType.Bool || item.Type == SharpType.Int || item.Type == SharpType.Double)
                        tempString = tempString.Replace("{TYPE}", "{TYPE}?");
                }

                tempString = tempString.Replace("{TYPE}", item.Type);
                int nameStart = tempString.IndexOf("{NAME}");

                if ((declareOption & DeclareOption.UpperFirstWord) == DeclareOption.UpperFirstWord)
                    tempString = tempString.Replace("{NAME}", (char.ToUpper(item.Name[0]) + item.Name.Substring(1)));
                else
                    tempString = tempString.Replace("{NAME}", item.Name);

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

            while (true)
            {
                index--;
                string temp = declareString.Substring(index, 1);

                if (temp == " ")
                    break;
                else
                {
                    name.Insert(0, temp);
                }
            }


            index = nameIndex;
            while (true)
            {
                string temp = declareString.Substring(index, 1);
                index++;

                if (temp == " " || temp == ";")
                    break;
                else
                {
                    name.Append(temp);
                }
            }

            return name.ToString();
        }

        public static string SetModifider(DeclareOption declareOption)
        {
            if ((declareOption & DeclareOption.Private) == DeclareOption.Private)
                return "[JsonProperty]private";

            if ((declareOption & DeclareOption.Protected) == DeclareOption.Protected)
                return "[JsonProperty]protected";

            if ((declareOption & DeclareOption.Public) == DeclareOption.Public)
                return "public";

            return "";
        }



    }



}
