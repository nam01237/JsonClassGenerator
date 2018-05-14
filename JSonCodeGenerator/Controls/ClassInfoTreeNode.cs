using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JSonCodeGenerator.Generate;
using NJsonObject.ObjectInfo;

namespace JSonCodeGenerator.Controls
{
    class ClassInfoTreeNode : TreeNode
    {
        public ClassInfoTreeNode()
        {

        }

        public ClassInfoTreeNode(JInfo jJInfo) : base()
        {
            JInfo = jJInfo;
            Text = jJInfo.ToString();

        }

        public JInfo JInfo { get; set; } 
        public string ClassCode { get; set; }
    }
}
