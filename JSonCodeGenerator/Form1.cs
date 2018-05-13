﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JSonCodeGenerator.Controls;
using Newtonsoft.Json.Linq;
using NJsonObject.Generate;
using NJsonObject.ObjectInfo;

namespace JSonCodeGenerator
{
    public partial class Form1 : Form
    {
        private JClassCreater _jClassCreater;
        private ClassInfoTreeNode classInfoTreeNode;

        public Form1()
        {
            InitializeComponent();
            InitializeInstance();
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

            JClassInfo temp = _jClassCreater.Create(jObject);
            classInfoTreeNode = new ClassInfoTreeNode( temp );
            SetNode(classInfoTreeNode);

            usc_CodeViewer.AddNode(classInfoTreeNode);
        }

        private void SetNode(ClassInfoTreeNode node)
        {
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
                foreach (JClassInfo item  in ((JArrayInfo)node.JInfo).ClassTypes)
                {
                    ClassInfoTreeNode childNode = new ClassInfoTreeNode(item);
                    node.Nodes.Add(childNode);

                    SetNode(childNode);
                }    
            }
        }
    }

    
}
