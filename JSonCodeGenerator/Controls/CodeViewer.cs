using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NJsonObject.ObjectInfo;

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

        public void SetCodeText(string text)
        {
            txt_Code.Text = text;
        }

        public void ClearTreeView()
        {
            trv_ClassInfo.Nodes.Clear();
        }

        private void trv_ClassInfo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txt_Code.Text = "";

            ClassInfoTreeNode selecteNode = (ClassInfoTreeNode)trv_ClassInfo.SelectedNode;

            if (selecteNode.JInfo is JClassInfo)
            {
                txt_Code.Text = selecteNode.ClassCode;
            }
        }

        private void btn_Rename_Click(object sender, EventArgs e)
        {
            if (trv_ClassInfo.SelectedNode == null)
            {
                MessageBox.Show("바꿀 항목을 선택하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OnRenameButtonClicked(new RenameButtonClickedEventArgs((ClassInfoTreeNode) trv_ClassInfo.SelectedNode));

            //trv_ClassInfo.Invalidate();
        }

        public event EventHandler<RenameButtonClickedEventArgs> RenameButtonClicked;

        protected virtual void OnRenameButtonClicked(RenameButtonClickedEventArgs args)
        {
            if (RenameButtonClicked != null)
                RenameButtonClicked(this, args);

        }

    }

    public class RenameButtonClickedEventArgs : EventArgs
    {
        public ClassInfoTreeNode SelectedNode { get; set; }

        public RenameButtonClickedEventArgs(ClassInfoTreeNode selectedNode)
        {
            SelectedNode = selectedNode;
        }
    }
}
