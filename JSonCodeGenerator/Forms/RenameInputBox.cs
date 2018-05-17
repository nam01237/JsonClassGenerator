using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSonCodeGenerator.Forms
{
    public partial class RenameInputBox : Form
    {
        public string InputString { get; private set; }

        public RenameInputBox()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_ReName.Text == "")
            {
                lbl_notice.Text = "바꿀 클래스명을 입력해주세요.";
                return;
            }

            DialogResult = DialogResult.OK;
            InputString = txt_ReName.Text;
            Close();
        }
    }
}
