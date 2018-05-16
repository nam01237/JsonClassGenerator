namespace JSonCodeGenerator.Controls
{
    partial class InputControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PropertyFormat = new System.Windows.Forms.TextBox();
            this.txt_FeildFormat = new System.Windows.Forms.TextBox();
            this.txt_JsonString = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_PropertyFormat);
            this.groupBox1.Controls.Add(this.txt_FeildFormat);
            this.groupBox1.Controls.Add(this.txt_JsonString);
            this.groupBox1.Location = new System.Drawing.Point(7, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Property 형식";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Field 형식";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Json 문자열";
            // 
            // txt_PropertyFormat
            // 
            this.txt_PropertyFormat.Location = new System.Drawing.Point(468, 134);
            this.txt_PropertyFormat.Multiline = true;
            this.txt_PropertyFormat.Name = "txt_PropertyFormat";
            this.txt_PropertyFormat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_PropertyFormat.Size = new System.Drawing.Size(237, 138);
            this.txt_PropertyFormat.TabIndex = 2;
            this.txt_PropertyFormat.Text = "public {TYPE} {NAME} {get; set;}";
            // 
            // txt_FeildFormat
            // 
            this.txt_FeildFormat.Location = new System.Drawing.Point(468, 38);
            this.txt_FeildFormat.Multiline = true;
            this.txt_FeildFormat.Name = "txt_FeildFormat";
            this.txt_FeildFormat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_FeildFormat.Size = new System.Drawing.Size(237, 68);
            this.txt_FeildFormat.TabIndex = 1;
            this.txt_FeildFormat.Text = "private {TYPE} _{NAME};";
            this.txt_FeildFormat.TextChanged += new System.EventHandler(this.txt_FeildFormat_TextChanged);
            // 
            // txt_JsonString
            // 
            this.txt_JsonString.Location = new System.Drawing.Point(6, 38);
            this.txt_JsonString.Multiline = true;
            this.txt_JsonString.Name = "txt_JsonString";
            this.txt_JsonString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_JsonString.Size = new System.Drawing.Size(456, 234);
            this.txt_JsonString.TabIndex = 0;
            this.txt_JsonString.Text = resources.GetString("txt_JsonString.Text");
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(7, 9);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(95, 25);
            this.btn_Generate.TabIndex = 1;
            this.btn_Generate.Text = "생성(&G)";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.groupBox1);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(730, 313);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PropertyFormat;
        private System.Windows.Forms.TextBox txt_FeildFormat;
        private System.Windows.Forms.TextBox txt_JsonString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Generate;
    }
}
