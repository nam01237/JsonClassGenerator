using System;
using System.Windows.Forms;
using JSonCodeGenerator.Controls;
using JSonCodeGenerator.Generate;
using Newtonsoft.Json.Linq;
using NJsonObject.Generate;
using NJsonObject.ObjectInfo;

namespace JSonCodeGenerator.Forms
{
    public partial class MainForm : Form
    {
        private JClassCreater _jClassCreater;
        private string _fieldFormat;
        private string _propertyFormat;
        private int _declareMember;

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
            }

            _fieldFormat = e.FieldFormat;
            _propertyFormat = e.PropertyFormat;
            _declareMember = e.DeclareMember;

            JClassInfo temp = _jClassCreater.Create(jObject);
            ClassInfoTreeNode classInfoTreeNode = new ClassInfoTreeNode(temp);
            //classInfoTreeNode.ClassCode = ClassCodeGenerator.GenerateClassCode(_fieldFormat, _propertyFormat,(JClassInfo) classInfoTreeNode.JInfo);

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
                node.ClassCode = ClassCodeGenerator.GenerateClassCode(_fieldFormat, _propertyFormat, (JClassInfo)node.JInfo, _declareMember);

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

            node.JInfo.Type = "asdf";

            if (parent != null)
            {
                if (parent.JInfo is JArrayInfo)
                {
                    if (((JArrayInfo)parent.JInfo).GenericType != "object")
                    {
                        ((JArrayInfo)parent.JInfo).GenericType = "asdf";
                    }

                    parent.Text = parent.JInfo.ToString();
                }
                else
                {
                    parent.ClassCode = ClassCodeGenerator.GenerateClassCode(_fieldFormat, _propertyFormat,
                        (JClassInfo)parent.JInfo, _declareMember);
                }
            }

            node.Text = node.JInfo.ToString();
            node.ClassCode = ClassCodeGenerator.GenerateClassCode(_fieldFormat, _propertyFormat, (JClassInfo)node.JInfo, _declareMember);

            usc_CodeViewer.SetCodeText(node.ClassCode);
        }
    }


}
