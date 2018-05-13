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
        private static readonly string TEMPLATE_PATH = "Templeates";
        private static string _constructorTemplate;
        private static string _classTemplate;

        public static void LoadDefaultTemplate()
        {
            _classTemplate = File.ReadAllText(TEMPLATE_PATH + "\\DefaultClassTemplate.nmt");
        }

        public static void GenerateClassCode( )
        {

        }
    }
}
