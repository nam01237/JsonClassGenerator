using System;
using System.IO;

namespace NJsonObject.Generate
{
    public class TemplateString
    {
        private TemplateString()
        { }

        private static readonly string TEMPLATE_PATH = "..//..//Templeates";

        public static string ClassTemplate { get; private set; }
        public static string ValueTypeInit { get; private set; }
        public static string RefTypeInit { get; private set; }
        public static string ValueTypeListInit { get; private set; }
        public static string RefTypeListInit { get; private set; }
        public static string FileTemplate { get; private set; }

        public static void LoadDefaultTemplate()
        {
            ClassTemplate = File.ReadAllText(TEMPLATE_PATH + "\\DefaultClassTemplate.nmt");
            FileTemplate = File.ReadAllText(TEMPLATE_PATH + "\\DefaultFileTemplate.nmt");
            ValueTypeInit = File.ReadAllText(TEMPLATE_PATH + "\\ValueTypeInit.nmt");
            RefTypeInit = File.ReadAllText(TEMPLATE_PATH + "\\RefTypeInit.nmt");
            ValueTypeListInit = File.ReadAllText(TEMPLATE_PATH + "\\ValueTypeListInit.nmt");
            RefTypeListInit = File.ReadAllText(TEMPLATE_PATH + "\\RefTypeListInit.nmt");
        }

        public static void SelectTemplate(string path)
        {
            FileInfo templateInfo = new FileInfo(path);

            if (templateInfo.Extension != "nmt")
            {
                throw new InvalidTemplateFile("nmt 확장자 형식의 파일 경로를 지정 해 주세요");
            }

            string templateString = File.ReadAllText(path);
        }

    }
 
    public class InvalidTemplateFile : Exception
    {
        public InvalidTemplateFile()
        {
        }

        public InvalidTemplateFile(string message) : base(message)
        {
            
        }
    }

}
