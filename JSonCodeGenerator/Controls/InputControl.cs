using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonObjectGenerator.analyze;
using JSonCodeGenerator.Forms;
using NJsonObject.etc;
using NJsonObject.Generate;

namespace JSonCodeGenerator.Controls
{
    public partial class InputControl : UserControl
    {
        private CautionForm cautionForm;

        public InputControl()
        {
            InitializeComponent();
            txt_JsonString.Text = TempStringReader.GetJsonString("..//..//..//temp.txt");
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            int declare = 0;

            if (cbx_Property.Checked)
                declare |= (int)DeclareContent.Property;
            if (cbx_Filed.Checked)
                declare |= (int)DeclareContent.Filed;

            GenerateButtonClickedEventArgs args = new GenerateButtonClickedEventArgs(txt_JsonString.Text, txt_FeildFormat.Text, txt_PropertyFormat.Text, declare);

            OnGenerateButtonClicked(args);
        }

        public event EventHandler<GenerateButtonClickedEventArgs> GenerateButtonClicked;

        protected virtual void OnGenerateButtonClicked(GenerateButtonClickedEventArgs args)
        {
            if(GenerateButtonClicked != null)
                GenerateButtonClicked(this, args);

        }

        private void txt_FeildFormat_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Property_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox) sender).Checked)
            {
                txt_PropertyFormat.Enabled = true;
            }
            else
            {
                txt_PropertyFormat.Enabled = false;
            }
        }

        private void cbx_Filed_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txt_FeildFormat.Enabled = true;
            }
            else
            {
               txt_FeildFormat.Enabled = false;
            }
        }

        private void cb_Caution_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Caution.Checked)
            {
                cautionForm = new CautionForm();
                cautionForm.Show();
                cautionForm.Location = Cursor.Position;
            }
            else
            {
                cautionForm.Close();
            }
        }
    }

    public class GenerateButtonClickedEventArgs : EventArgs
    {
        public string JsonString { get; set; }
        public string FieldFormat { get; set; }
        public string PropertyFormat { get; set; }
        public int DeclareMember { get; set; }

        public GenerateButtonClickedEventArgs(){ }

        public GenerateButtonClickedEventArgs(string jsonString, string fieldFormat, string propertyFormat, int declareMember)
        {
            JsonString = jsonString;
            FieldFormat = fieldFormat;
            PropertyFormat = propertyFormat;
            DeclareMember = declareMember;
        }
    }
}
