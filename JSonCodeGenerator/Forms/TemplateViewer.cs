using NJsonObject.Generate;
using System.Windows.Forms;

namespace JSonCodeGenerator.Forms
{
    public partial class TemplateViewer : Form
    {
        private TemplateType _selectedTemplateType;

        public TemplateViewer()
        {
            InitializeComponent();

            _selectedTemplateType = TemplateType.Class;

            SetTemplateString();

            btn_ChangeTemplate.Focus();
        }

        private void SetTemplateString()
        {
            txt_Class.Text = TemplateString.ClassTemplate;

            txt_File.Text = TemplateString.FileTemplate;
        }

        private void btn_ChangeTemplate_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TemplateString.ChangeTemplateFile(openFileDialog1.FileName, _selectedTemplateType);
                SetTemplateString();
            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                _selectedTemplateType = TemplateType.Class;
            else if (tabControl1.SelectedIndex == 1)
                _selectedTemplateType = TemplateType.File;
        }

        private void btn_Confirm_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
