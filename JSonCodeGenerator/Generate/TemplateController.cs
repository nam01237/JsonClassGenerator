using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSonCodeGenerator.Generate
{
    public class TemplateController
    {
        private TemplateController()
        { }

        private static readonly string TEMPLATE_PATH = "..//..//Templeates";

        public static string ClassTemplate { get; private set; }
        public static string InitValueFormat { get; private set; }
        public static string InitRefFormat { get; private set; }

        public static void LoadDefaultTemplate()
        {
            ClassTemplate = File.ReadAllText(TEMPLATE_PATH + "\\DefaultClassTemplate.nmt");
            InitValueFormat = File.ReadAllText(TEMPLATE_PATH + "\\InitValueFormat.nmt");
            InitRefFormat = File.ReadAllText(TEMPLATE_PATH + "\\InitRefFormat.nmt");
        }

        
    }
}
