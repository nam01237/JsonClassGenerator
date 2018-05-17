﻿namespace JSonCodeGenerator.Controls
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
            this.cbx_Filed = new System.Windows.Forms.CheckBox();
            this.cbx_Property = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PropertyFormat = new System.Windows.Forms.TextBox();
            this.txt_FeildFormat = new System.Windows.Forms.TextBox();
            this.txt_JsonString = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.pb_Caution = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Caution)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Filed);
            this.groupBox1.Controls.Add(this.cbx_Property);
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
            // cbx_Filed
            // 
            this.cbx_Filed.AutoSize = true;
            this.cbx_Filed.Location = new System.Drawing.Point(470, 181);
            this.cbx_Filed.Name = "cbx_Filed";
            this.cbx_Filed.Size = new System.Drawing.Size(79, 16);
            this.cbx_Filed.TabIndex = 7;
            this.cbx_Filed.Text = "Field 선언";
            this.cbx_Filed.UseVisualStyleBackColor = true;
            this.cbx_Filed.CheckedChanged += new System.EventHandler(this.cbx_Filed_CheckedChanged);
            // 
            // cbx_Property
            // 
            this.cbx_Property.AutoSize = true;
            this.cbx_Property.Checked = true;
            this.cbx_Property.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_Property.Location = new System.Drawing.Point(466, 17);
            this.cbx_Property.Name = "cbx_Property";
            this.cbx_Property.Size = new System.Drawing.Size(99, 16);
            this.cbx_Property.TabIndex = 6;
            this.cbx_Property.Text = "Property 선언";
            this.cbx_Property.UseVisualStyleBackColor = true;
            this.cbx_Property.CheckedChanged += new System.EventHandler(this.cbx_Property_CheckedChanged);
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
            this.txt_PropertyFormat.Location = new System.Drawing.Point(466, 36);
            this.txt_PropertyFormat.Multiline = true;
            this.txt_PropertyFormat.Name = "txt_PropertyFormat";
            this.txt_PropertyFormat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_PropertyFormat.Size = new System.Drawing.Size(237, 138);
            this.txt_PropertyFormat.TabIndex = 2;
            this.txt_PropertyFormat.Text = "public {TYPE} {NAME} {get; set;}";
            // 
            // txt_FeildFormat
            // 
            this.txt_FeildFormat.Enabled = false;
            this.txt_FeildFormat.Location = new System.Drawing.Point(470, 203);
            this.txt_FeildFormat.Multiline = true;
            this.txt_FeildFormat.Name = "txt_FeildFormat";
            this.txt_FeildFormat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_FeildFormat.Size = new System.Drawing.Size(237, 68);
            this.txt_FeildFormat.TabIndex = 1;
            this.txt_FeildFormat.Text = "public {TYPE} _{NAME};";
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
            // pb_Caution
            // 
            this.pb_Caution.Image = ((System.Drawing.Image)(resources.GetObject("pb_Caution.Image")));
            this.pb_Caution.InitialImage = null;
            this.pb_Caution.Location = new System.Drawing.Point(686, 9);
            this.pb_Caution.Name = "pb_Caution";
            this.pb_Caution.Size = new System.Drawing.Size(28, 25);
            this.pb_Caution.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Caution.TabIndex = 2;
            this.pb_Caution.TabStop = false;
            this.pb_Caution.MouseEnter += new System.EventHandler(this.pb_Caution_MouseEnter);
            this.pb_Caution.MouseLeave += new System.EventHandler(this.pb_Caution_MouseLeave);
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_Caution);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.groupBox1);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(730, 313);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Caution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PropertyFormat;
        private System.Windows.Forms.TextBox txt_FeildFormat;
        private System.Windows.Forms.TextBox txt_JsonString;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.CheckBox cbx_Filed;
        private System.Windows.Forms.CheckBox cbx_Property;
        private System.Windows.Forms.PictureBox pb_Caution;
    }
}
