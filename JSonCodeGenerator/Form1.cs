using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JSonCodeGenerator.Controls;
using JSonCodeGenerator.Generate;
using Newtonsoft.Json.Linq;
using NJsonObject.Generate;
using NJsonObject.ObjectInfo;

namespace JSonCodeGenerator
{
    public partial class Form1 : Form
    {
        private JClassCreater _jClassCreater;
        private string _fieldFormat;
        private string _propertyFormat;

        public Form1()
        {
            InitializeComponent();
            InitializeInstance();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Template.LoadDefaultTemplate();
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

            JClassInfo temp = _jClassCreater.Create(jObject);
            ClassInfoTreeNode classInfoTreeNode = new ClassInfoTreeNode( temp );
            classInfoTreeNode.ClassCode =
                ClassCodeGenerator.GenerateClassCode(_fieldFormat, _propertyFormat, (JClassInfo)classInfoTreeNode.JInfo);

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


    }

    
}
