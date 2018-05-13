using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSonCodeGenerator.Controls
{
    public partial class CodeViewer : UserControl
    {
        public CodeViewer()
        {
            InitializeComponent();
        }

        public void AddNode(TreeNode node)
        {
            trv_ClassInfo.Nodes.Add(node);
        }
    }
}
