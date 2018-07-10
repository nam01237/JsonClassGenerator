using System;
using System.Windows.Forms;
using JSonCodeGenerator.Forms;
using NJsonObject;
using System.Diagnostics;

namespace JSonCodeGenerator.Controls
{
    public partial class InputControl : UserControl
    {
        private CautionForm cautionForm;

        public InputControl()
        {
            InitializeComponent();
            //txt_JsonString.Text = TempStringReader.GetJsonString("..//..//..//temp.txt");
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            DeclareOption declareContent = 0;

            if (!cb_Custom.Checked)
            {
                if (rb_Default.Checked)
                    declareContent |= DeclareOption.Default;
                else if (rb_Private.Checked)
                    declareContent |= DeclareOption.Private;
                else if (rb_Protected.Checked)
                    declareContent |= DeclareOption.Protected;
                else if (rb_Public.Checked)
                    declareContent |= DeclareOption.Public;

                if (rb_NormalVariable.Checked)
                    declareContent |= DeclareOption.NormalField;
                else if (rb_Property.Checked)
                    declareContent |= DeclareOption.Property;

                if (cb_Nullable.Checked)
                    declareContent |= DeclareOption.Nullable;

                if (cb_UpperFirst.Checked)
                    declareContent |= DeclareOption.UpperFirstWord;

                OnGenerateButtonClicked(txt_JsonString.Text, txt_FormatString.Text, declareContent);

            }
            else
            {
                Debug.WriteLine("Generate 버튼 누름 - 커스텀");

                declareContent |= DeclareOption.CustomFormat;

                if (cb_Nullable.Checked)
                    declareContent |= DeclareOption.Nullable;

                if (cb_UpperFirst.Checked)
                    declareContent |= DeclareOption.UpperFirstWord;

                OnGenerateButtonClicked(txt_JsonString.Text, txt_FormatString.Text, declareContent);
            }

        }

        public event EventHandler<GenerateButtonClickedEventArgs> GenerateButtonClicked;

        protected virtual void OnGenerateButtonClicked(GenerateButtonClickedEventArgs args)
        {
            if (GenerateButtonClicked != null)
                GenerateButtonClicked(this, args);

        }

        protected virtual void OnGenerateButtonClicked(string jsonSting, string formatString, DeclareOption declareContent)
        {
            OnGenerateButtonClicked(new GenerateButtonClickedEventArgs(jsonSting, formatString, declareContent));
        }

        private void txt_FeildFormat_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Property_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Filed_CheckedChanged(object sender, EventArgs e)
        {

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

        private void cb_Custom_CheckedChanged(object sender, EventArgs e)
        {
            txt_FormatString.Enabled = cb_Custom.Checked;
            gb_Modifier.Enabled = !cb_Custom.Checked;
            gb_FieldType.Enabled = !cb_Custom.Checked;

        }

        private void btn_ShowTemplateViewer_Click(object sender, EventArgs e)
        {
            TemplateViewer templateViewer = new TemplateViewer();

            templateViewer.ShowDialog();
        }
    }

    public class GenerateButtonClickedEventArgs : EventArgs
    {
        public string JsonString { get; set; }
        public string FormatString { get; set; }
        public DeclareOption SelectedOption { get; set; }

        public GenerateButtonClickedEventArgs() { }

        public GenerateButtonClickedEventArgs(string jsonString, string formatString, DeclareOption declareOption)
        {
            JsonString = jsonString;
            FormatString = formatString;
            SelectedOption = declareOption;
        }
    }
}
