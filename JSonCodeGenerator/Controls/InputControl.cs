using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSonCodeGenerator.Controls
{
    public partial class InputControl : UserControl
    {
        public InputControl()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            GenerateButtonClickedEventArgs args = new GenerateButtonClickedEventArgs(txt_JsonString.Text);

            OnGenerateButtonClicked(args);
        }

        public event EventHandler<GenerateButtonClickedEventArgs> GenerateButtonClicked;

        protected virtual void OnGenerateButtonClicked(GenerateButtonClickedEventArgs args)
        {
            if(GenerateButtonClicked != null)
                GenerateButtonClicked(this, args);
        }
    }

    public class GenerateButtonClickedEventArgs : EventArgs
    {
        public string JsonString { get; set; }

        public GenerateButtonClickedEventArgs()
        { }

        public GenerateButtonClickedEventArgs(string jsonString)
        {
            JsonString = jsonString;
        }
    }
}
