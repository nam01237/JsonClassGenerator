using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NJsonObject.ObjectInfo;

namespace NJsonObject.Generate.CodeGenerate
{
    public class ClassFileCreater
    {
        public static void CreateClassFile(JClassInfo jClassInfo, string path, string nameSpace)
        {
            foreach (var item in jClassInfo.Properties)
            {
                if (item is JClassInfo)
                    CreateClassFile((JClassInfo)item, path, nameSpace);

                if (item is JArrayInfo)
                {
                    foreach (var sub in ((JArrayInfo)item).ClassTypes)
                    {
                        CreateClassFile(sub, path, nameSpace);
                    }
                }
            }

            string filePath = $"{path}//{jClassInfo.Type}.cs";
            string templateString = TemplateString.FileTemplate;
            templateString = templateString.Replace("{CC}", jClassInfo.ClassCode);
            templateString = templateString.Replace("{NS}", nameSpace);

            File.WriteAllText(filePath, templateString);

        }
    }
}
