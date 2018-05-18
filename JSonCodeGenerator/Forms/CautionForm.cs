using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSonCodeGenerator.Forms
{
    public partial class CautionForm : Form
    {
        public CautionForm()
        {
            InitializeComponent();
        }

        private void CautionForm_Shown(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText("..//..//caution.txt");
        }
    }
}
