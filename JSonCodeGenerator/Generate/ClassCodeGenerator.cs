﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NJsonObject.ObjectInfo;

namespace JSonCodeGenerator.Generate
{
    public class ClassCodeGenerator
    {

        public static string GenerateClassCode(string fieldFormat, string propertyFormat, JClassInfo jClassInfo)
        {
            string fields = CreateMemberString(jClassInfo.Properties, fieldFormat);

            List<JInfo> upperInfos = new List<JInfo>();
            string constructor = CreateConstructorString(jClassInfo.Properties);

            foreach (JInfo item in jClassInfo.Properties)
            {
                JClassInfo temp = new JClassInfo{ Name = char.ToUpper(item.Name[0]) + item.Name.Substring(1) , Type = item.Type }; 

                upperInfos.Add(temp);
            }

            string properties = CreateMemberString(upperInfos, propertyFormat);

            string classTemplate = TemplateController.ClassTemplate;

            classTemplate = classTemplate.Replace("{CN}", jClassInfo.Name);
            classTemplate = classTemplate.Replace("{FD}", fields);
            classTemplate = classTemplate.Replace("{PROP}", properties);
            classTemplate = classTemplate.Replace("{CONS}", constructor);

            File.WriteAllText("..//..//temp.txt", classTemplate);

            return classTemplate;
        }

        private static string CreateMemberString(List<JInfo> members, string formatString)
        {
            StringBuilder fieldString = new StringBuilder();

            foreach (var item in members)
            {
                string tempString = formatString;

                tempString = tempString.Replace("{TYPE}", item.Type);
                tempString = tempString.Replace("{NAME}", item.Name);

                fieldString.AppendLine();
                fieldString.Append("\t");
                fieldString.Append(tempString);

            }

            return fieldString.ToString();
        }

        private static string CreateConstructorString(List<JInfo> members)
        {
            StringBuilder constructorString = new StringBuilder();

            foreach (var item in members)
            {
                string tempString;

                if (item is JClassInfo)
                {
                    tempString = TemplateController.InitRefFormat;
                }
                else
                {
                    tempString = TemplateController.InitValueFormat;
                }

                tempString = tempString.Replace("{TYPE}", item.Type);
                tempString = tempString.Replace("{NAME}", item.Name);

                constructorString.AppendLine();
                constructorString.Append("\t\t");
                constructorString.Append(tempString);
            }

            return constructorString.ToString();
        }
         
    }
}
