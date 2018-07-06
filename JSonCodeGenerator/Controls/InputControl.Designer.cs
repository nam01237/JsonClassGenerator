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
            this.txt_JsonString = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.cb_Caution = new System.Windows.Forms.CheckBox();
            this.gb_Modifier = new System.Windows.Forms.GroupBox();
            this.rb_Default = new System.Windows.Forms.RadioButton();
            this.rb_Protected = new System.Windows.Forms.RadioButton();
            this.rb_Public = new System.Windows.Forms.RadioButton();
            this.rb_Private = new System.Windows.Forms.RadioButton();
            this.gb_FieldType = new System.Windows.Forms.GroupBox();
            this.rb_Property = new System.Windows.Forms.RadioButton();
            this.rb_NormalVariable = new System.Windows.Forms.RadioButton();
            this.gb_Etc = new System.Windows.Forms.GroupBox();
            this.cb_Nullable = new System.Windows.Forms.CheckBox();
            this.gb_Custom = new System.Windows.Forms.GroupBox();
            this.txt_FormatString = new System.Windows.Forms.TextBox();
            this.cb_Custom = new System.Windows.Forms.CheckBox();
            this.cb_UpperFirst = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gb_Modifier.SuspendLayout();
            this.gb_FieldType.SuspendLayout();
            this.gb_Etc.SuspendLayout();
            this.gb_Custom.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_JsonString);
            this.groupBox1.Location = new System.Drawing.Point(7, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Json 문자열";
            // 
            // txt_JsonString
            // 
            this.txt_JsonString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_JsonString.Location = new System.Drawing.Point(6, 20);
            this.txt_JsonString.Multiline = true;
            this.txt_JsonString.Name = "txt_JsonString";
            this.txt_JsonString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_JsonString.Size = new System.Drawing.Size(440, 300);
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
            // cb_Caution
            // 
            this.cb_Caution.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_Caution.AutoSize = true;
            this.cb_Caution.Image = global::JSonCodeGenerator.Properties.Resources.caution;
            this.cb_Caution.Location = new System.Drawing.Point(686, 3);
            this.cb_Caution.Name = "cb_Caution";
            this.cb_Caution.Size = new System.Drawing.Size(30, 30);
            this.cb_Caution.TabIndex = 4;
            this.cb_Caution.UseVisualStyleBackColor = true;
            this.cb_Caution.CheckedChanged += new System.EventHandler(this.cb_Caution_CheckedChanged);
            // 
            // gb_Modifier
            // 
            this.gb_Modifier.Controls.Add(this.rb_Default);
            this.gb_Modifier.Controls.Add(this.rb_Protected);
            this.gb_Modifier.Controls.Add(this.rb_Public);
            this.gb_Modifier.Controls.Add(this.rb_Private);
            this.gb_Modifier.Location = new System.Drawing.Point(468, 42);
            this.gb_Modifier.Name = "gb_Modifier";
            this.gb_Modifier.Size = new System.Drawing.Size(248, 86);
            this.gb_Modifier.TabIndex = 5;
            this.gb_Modifier.TabStop = false;
            this.gb_Modifier.Text = "접근지정자";
            // 
            // rb_Default
            // 
            this.rb_Default.AutoSize = true;
            this.rb_Default.Location = new System.Drawing.Point(126, 55);
            this.rb_Default.Name = "rb_Default";
            this.rb_Default.Size = new System.Drawing.Size(60, 16);
            this.rb_Default.TabIndex = 3;
            this.rb_Default.Text = "default";
            this.rb_Default.UseVisualStyleBackColor = true;
            // 
            // rb_Protected
            // 
            this.rb_Protected.AutoSize = true;
            this.rb_Protected.Location = new System.Drawing.Point(126, 33);
            this.rb_Protected.Name = "rb_Protected";
            this.rb_Protected.Size = new System.Drawing.Size(75, 16);
            this.rb_Protected.TabIndex = 2;
            this.rb_Protected.Text = "protected";
            this.rb_Protected.UseVisualStyleBackColor = true;
            // 
            // rb_Public
            // 
            this.rb_Public.AutoSize = true;
            this.rb_Public.Location = new System.Drawing.Point(6, 55);
            this.rb_Public.Name = "rb_Public";
            this.rb_Public.Size = new System.Drawing.Size(57, 16);
            this.rb_Public.TabIndex = 1;
            this.rb_Public.Text = "public";
            this.rb_Public.UseVisualStyleBackColor = true;
            // 
            // rb_Private
            // 
            this.rb_Private.AutoSize = true;
            this.rb_Private.Checked = true;
            this.rb_Private.Location = new System.Drawing.Point(6, 33);
            this.rb_Private.Name = "rb_Private";
            this.rb_Private.Size = new System.Drawing.Size(60, 16);
            this.rb_Private.TabIndex = 0;
            this.rb_Private.TabStop = true;
            this.rb_Private.Text = "private";
            this.rb_Private.UseVisualStyleBackColor = true;
            // 
            // gb_FieldType
            // 
            this.gb_FieldType.Controls.Add(this.rb_Property);
            this.gb_FieldType.Controls.Add(this.rb_NormalVariable);
            this.gb_FieldType.Location = new System.Drawing.Point(468, 130);
            this.gb_FieldType.Name = "gb_FieldType";
            this.gb_FieldType.Size = new System.Drawing.Size(250, 49);
            this.gb_FieldType.TabIndex = 6;
            this.gb_FieldType.TabStop = false;
            this.gb_FieldType.Text = "필드 형식";
            // 
            // rb_Property
            // 
            this.rb_Property.AutoSize = true;
            this.rb_Property.Checked = true;
            this.rb_Property.Location = new System.Drawing.Point(6, 20);
            this.rb_Property.Name = "rb_Property";
            this.rb_Property.Size = new System.Drawing.Size(71, 16);
            this.rb_Property.TabIndex = 1;
            this.rb_Property.TabStop = true;
            this.rb_Property.Text = "프로퍼티";
            this.rb_Property.UseVisualStyleBackColor = true;
            // 
            // rb_NormalVariable
            // 
            this.rb_NormalVariable.AutoSize = true;
            this.rb_NormalVariable.Location = new System.Drawing.Point(126, 20);
            this.rb_NormalVariable.Name = "rb_NormalVariable";
            this.rb_NormalVariable.Size = new System.Drawing.Size(71, 16);
            this.rb_NormalVariable.TabIndex = 0;
            this.rb_NormalVariable.Text = "일반변수";
            this.rb_NormalVariable.UseVisualStyleBackColor = true;
            // 
            // gb_Etc
            // 
            this.gb_Etc.Controls.Add(this.cb_UpperFirst);
            this.gb_Etc.Controls.Add(this.cb_Nullable);
            this.gb_Etc.Location = new System.Drawing.Point(468, 181);
            this.gb_Etc.Name = "gb_Etc";
            this.gb_Etc.Size = new System.Drawing.Size(248, 69);
            this.gb_Etc.TabIndex = 7;
            this.gb_Etc.TabStop = false;
            this.gb_Etc.Text = "기타";
            // 
            // cb_Nullable
            // 
            this.cb_Nullable.AutoSize = true;
            this.cb_Nullable.Location = new System.Drawing.Point(7, 21);
            this.cb_Nullable.Name = "cb_Nullable";
            this.cb_Nullable.Size = new System.Drawing.Size(70, 16);
            this.cb_Nullable.TabIndex = 0;
            this.cb_Nullable.Text = "Nullable";
            this.cb_Nullable.UseVisualStyleBackColor = true;
            // 
            // gb_Custom
            // 
            this.gb_Custom.Controls.Add(this.txt_FormatString);
            this.gb_Custom.Controls.Add(this.cb_Custom);
            this.gb_Custom.Location = new System.Drawing.Point(469, 250);
            this.gb_Custom.Name = "gb_Custom";
            this.gb_Custom.Size = new System.Drawing.Size(247, 112);
            this.gb_Custom.TabIndex = 8;
            this.gb_Custom.TabStop = false;
            // 
            // txt_FormatString
            // 
            this.txt_FormatString.Enabled = false;
            this.txt_FormatString.Location = new System.Drawing.Point(5, 30);
            this.txt_FormatString.Multiline = true;
            this.txt_FormatString.Name = "txt_FormatString";
            this.txt_FormatString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_FormatString.Size = new System.Drawing.Size(236, 82);
            this.txt_FormatString.TabIndex = 1;
            this.txt_FormatString.Text = "[JsonProperty]\r\nprivate {TYPE} {NAME} { get; set;}";
            // 
            // cb_Custom
            // 
            this.cb_Custom.AutoSize = true;
            this.cb_Custom.Location = new System.Drawing.Point(5, 7);
            this.cb_Custom.Name = "cb_Custom";
            this.cb_Custom.Size = new System.Drawing.Size(168, 16);
            this.cb_Custom.TabIndex = 0;
            this.cb_Custom.Text = "사용자지정 필드 형식 사용";
            this.cb_Custom.UseVisualStyleBackColor = true;
            this.cb_Custom.CheckedChanged += new System.EventHandler(this.cb_Custom_CheckedChanged);
            // 
            // cb_UpperFirst
            // 
            this.cb_UpperFirst.AutoSize = true;
            this.cb_UpperFirst.Location = new System.Drawing.Point(126, 21);
            this.cb_UpperFirst.Name = "cb_UpperFirst";
            this.cb_UpperFirst.Size = new System.Drawing.Size(100, 16);
            this.cb_UpperFirst.TabIndex = 1;
            this.cb_UpperFirst.Text = "첫문자 대문자";
            this.cb_UpperFirst.UseVisualStyleBackColor = true;
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_Custom);
            this.Controls.Add(this.gb_Etc);
            this.Controls.Add(this.gb_Modifier);
            this.Controls.Add(this.cb_Caution);
            this.Controls.Add(this.gb_FieldType);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.groupBox1);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(730, 371);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Modifier.ResumeLayout(false);
            this.gb_Modifier.PerformLayout();
            this.gb_FieldType.ResumeLayout(false);
            this.gb_FieldType.PerformLayout();
            this.gb_Etc.ResumeLayout(false);
            this.gb_Etc.PerformLayout();
            this.gb_Custom.ResumeLayout(false);
            this.gb_Custom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_JsonString;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.CheckBox cb_Caution;
        private System.Windows.Forms.GroupBox gb_Modifier;
        private System.Windows.Forms.RadioButton rb_Protected;
        private System.Windows.Forms.RadioButton rb_Public;
        private System.Windows.Forms.RadioButton rb_Private;
        private System.Windows.Forms.RadioButton rb_Default;
        private System.Windows.Forms.GroupBox gb_FieldType;
        private System.Windows.Forms.RadioButton rb_Property;
        private System.Windows.Forms.RadioButton rb_NormalVariable;
        private System.Windows.Forms.GroupBox gb_Etc;
        private System.Windows.Forms.CheckBox cb_Nullable;
        private System.Windows.Forms.GroupBox gb_Custom;
        private System.Windows.Forms.TextBox txt_FormatString;
        private System.Windows.Forms.CheckBox cb_Custom;
        private System.Windows.Forms.CheckBox cb_UpperFirst;
    }
}
