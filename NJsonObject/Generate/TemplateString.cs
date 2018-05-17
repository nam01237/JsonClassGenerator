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

        public static void LoadDefaultTemplate()
        {
            ClassTemplate = File.ReadAllText(TEMPLATE_PATH + "\\DefaultClassTemplate.nmt");
            ValueTypeInit = File.ReadAllText(TEMPLATE_PATH + "\\ValueTypeInit.nmt");
            RefTypeInit = File.ReadAllText(TEMPLATE_PATH + "\\RefTypeInit.nmt");
            ValueTypeListInit = File.ReadAllText(TEMPLATE_PATH + "\\ValueTypeListInit.nmt");
            RefTypeListInit = File.ReadAllText(TEMPLATE_PATH + "\\RefTypeListInit.nmt");
        }

        
    }
}
