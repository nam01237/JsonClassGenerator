using System;
using System.Diagnostics;
using System.Windows.Forms;
using JSonCodeGenerator.Controls;
using Newtonsoft.Json.Linq;
using NJsonObject.Generate;
using NJsonObject.Generate.CodeGenerate;
using NJsonObject.ObjectInfo;
using NJsonObject;

namespace JSonCodeGenerator.Forms
{
    public partial class MainForm : Form
    {
        private JClassCreater _jClassCreater;
        private DeclareOption _declareOption;
        private string _formatString;

        public MainForm()
        {
            InitializeComponent();
            InitializeInstance();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            TemplateString.LoadDefaultTemplate();
        }

        private void InitializeInstance()
        {
            _jClassCreater = new JClassCreater();
        }

        private void usc_Input_GenerateButtonClicked(object sender, Controls.GenerateButtonClickedEventArgs e)
        {
            JObject jObject;

            try
            {
                jObject = JObject.Parse(e.JsonString);
            }
            catch (Exception exception)
            {
                MessageBox.Show("json object 생성중에 예외 발생\n" + exception.Message, "알림");
                return;
            };

            JClassInfo temp = _jClassCreater.Create(jObject);
            ClassInfoTreeNode classInfoTreeNode = new ClassInfoTreeNode(temp);

            _declareOption = e.SelectedOption;
            _formatString = e.FormatString;

            SetNode(classInfoTreeNode);

            usc_CodeViewer.ClearTreeView();
            usc_CodeViewer.AddNode(classInfoTreeNode);
            usc_CodeViewer.SetCodeText(classInfoTreeNode.ClassCode);
        }

        private void SetNode(ClassInfoTreeNode node)
        {
            #region
            if (node.JInfo is JClassInfo)
            {
                 ClassCodeGenerator.GenerateClassCode((JClassInfo)node.JInfo, _declareOption, _formatString);
                node.ClassCode = ((JClassInfo) node.JInfo).ClassCode;

                foreach (JInfo item in ((JClassInfo)node.JInfo).Properties)
                {
                    if (item is JClassInfo || item is JArrayInfo)
                    {
                        ClassInfoTreeNode childNode = new ClassInfoTreeNode(item);

                        node.Nodes.Add(childNode);

                        SetNode(childNode);

                    }
                }
            }
            else if (node.JInfo is JArrayInfo)
            {
                foreach (JClassInfo item in ((JArrayInfo)node.JInfo).ClassTypes)
                {
                    ClassInfoTreeNode childNode = new ClassInfoTreeNode(item);
                    node.Nodes.Add(childNode);

                    SetNode(childNode);
                }
            }
            #endregion
        }

        private void usc_CodeViewer_RenameButtonClicked(object sender, RenameButtonClickedEventArgs e)
        {
            ClassInfoTreeNode node = e.SelectedNode;

            if (node.JInfo is JArrayInfo)
            {
                return;
            }

            ClassInfoTreeNode parent = (ClassInfoTreeNode)node.Parent;

            InputBox inputBox = new InputBox();

            if (inputBox.ShowDialog() != DialogResult.OK)
                return;

            string inputString = inputBox.InputString;
            node.JInfo.Type = inputString;

            if (parent != null)
            {
                SetParentClassCode(parent, inputString);
            }

            node.Text = node.JInfo.ToString();
            ClassCodeGenerator.GenerateClassCode((JClassInfo)node.JInfo, _declareOption, _formatString);
            node.ClassCode = ((JClassInfo)node.JInfo).ClassCode;


            usc_CodeViewer.SetCodeText(node.ClassCode);
        }

        private void SetParentClassCode(ClassInfoTreeNode parent, string inputString)
        {
            JInfo parentInfo = parent.JInfo;

            if (parentInfo is JArrayInfo)
            {
                if (((JArrayInfo)parentInfo).GenericType != SharpType.Object)
                {
                    ((JArrayInfo)parentInfo).GenericType = inputString;
                    ((JArrayInfo)parentInfo).SetType();
                }

                parent.Text = parentInfo.ToString();
                ClassCodeGenerator.GenerateClassCode((JClassInfo)((ClassInfoTreeNode)parent.Parent).JInfo, _declareOption, _formatString);
                parent.ClassCode = ((JClassInfo)((ClassInfoTreeNode)parent.Parent).JInfo).ClassCode;
            }
            else
            {
                ClassCodeGenerator.GenerateClassCode((JClassInfo)parentInfo, _declareOption, _formatString);
                parent.ClassCode = ((JClassInfo)parentInfo).ClassCode;
            }
        }

        private void usc_CodeViewer_SaveButtonClicked(object sender, SaveButtonClickedEventArgs e)
        {
            InputBox inputBox = new InputBox();
            inputBox.SetMsgText("네임스페이스 입력");

            if (inputBox.ShowDialog() != DialogResult.OK)
                return;
            
            ClassFileCreater.CreateClassFile( (JClassInfo)e.RootNode.JInfo, e.Path, inputBox.InputString);
        }
    }


}
