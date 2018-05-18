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

        private void btn_CopyCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_Code.Text);
        }

        private void btn_FindPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string path = folderBrowserDialog1.SelectedPath;
            txt_SavePath.Text = path;
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

        }

        public event EventHandler<RenameButtonClickedEventArgs> RenameButtonClicked;

        protected virtual void OnRenameButtonClicked(RenameButtonClickedEventArgs args)
        {
            if (RenameButtonClicked != null)
                RenameButtonClicked(this, args);
        }


        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            if (txt_SavePath.Text == "")
            {
                MessageBox.Show("저장 경로를 설정하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (trv_ClassInfo.TopNode == null)
            {
                MessageBox.Show("생성된 클래스가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OnSaveButtonClicked( new SaveButtonClickedEventArgs((ClassInfoTreeNode) trv_ClassInfo.TopNode , txt_SavePath.Text));
        }

        public event EventHandler<SaveButtonClickedEventArgs> SaveButtonClicked;

        protected virtual void OnSaveButtonClicked(SaveButtonClickedEventArgs args)
        {
            if (SaveButtonClicked != null)
                SaveButtonClicked(this, args);
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

    public class SaveButtonClickedEventArgs : EventArgs
    {
        public ClassInfoTreeNode RootNode{ get; set; }
        public string Path;

        public SaveButtonClickedEventArgs(ClassInfoTreeNode rootNode, string path)
        {
            RootNode = rootNode;
            Path = path;
        }
    }
}
