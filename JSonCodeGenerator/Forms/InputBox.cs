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
    public partial class InputBox : Form
    {
        public string InputString { get; private set; }

        public InputBox()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_Input.Text == "")
            {
                lbl_notice.Text = "텍스트를 입력해주세요.";
                return;
            }

            DialogResult = DialogResult.OK;
            InputString = txt_Input.Text;
            Close();
        }

        public void SetMsgText(string text)
        {
            lbl_Message.Text = text;
        }
    }

   
}
