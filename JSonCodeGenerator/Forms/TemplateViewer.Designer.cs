namespace JSonCodeGenerator.Forms
{
    partial class TemplateViewer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateViewer));
            this.txt_Class = new System.Windows.Forms.TextBox();
            this.btn_ChangeTemplate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpg_Class = new System.Windows.Forms.TabPage();
            this.tpg_File = new System.Windows.Forms.TabPage();
            this.txt_File = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpg_Class.SuspendLayout();
            this.tpg_File.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Class
            // 
            this.txt_Class.Location = new System.Drawing.Point(6, 6);
            this.txt_Class.Multiline = true;
            this.txt_Class.Name = "txt_Class";
            this.txt_Class.ReadOnly = true;
            this.txt_Class.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Class.Size = new System.Drawing.Size(324, 277);
            this.txt_Class.TabIndex = 0;
            // 
            // btn_ChangeTemplate
            // 
            this.btn_ChangeTemplate.Location = new System.Drawing.Point(2, 3);
            this.btn_ChangeTemplate.Name = "btn_ChangeTemplate";
            this.btn_ChangeTemplate.Size = new System.Drawing.Size(137, 30);
            this.btn_ChangeTemplate.TabIndex = 1;
            this.btn_ChangeTemplate.Text = "템플릿 파일 변경(&C)";
            this.btn_ChangeTemplate.UseVisualStyleBackColor = true;
            this.btn_ChangeTemplate.Click += new System.EventHandler(this.btn_ChangeTemplate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "템플릿 파일|*.nmt";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpg_Class);
            this.tabControl1.Controls.Add(this.tpg_File);
            this.tabControl1.Location = new System.Drawing.Point(3, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 315);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpg_Class
            // 
            this.tpg_Class.Controls.Add(this.txt_Class);
            this.tpg_Class.Location = new System.Drawing.Point(4, 22);
            this.tpg_Class.Name = "tpg_Class";
            this.tpg_Class.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_Class.Size = new System.Drawing.Size(336, 289);
            this.tpg_Class.TabIndex = 0;
            this.tpg_Class.Text = "클래스";
            this.tpg_Class.UseVisualStyleBackColor = true;
            // 
            // tpg_File
            // 
            this.tpg_File.Controls.Add(this.txt_File);
            this.tpg_File.Location = new System.Drawing.Point(4, 22);
            this.tpg_File.Name = "tpg_File";
            this.tpg_File.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_File.Size = new System.Drawing.Size(336, 289);
            this.tpg_File.TabIndex = 1;
            this.tpg_File.Text = "파일";
            this.tpg_File.UseVisualStyleBackColor = true;
            // 
            // txt_File
            // 
            this.txt_File.Location = new System.Drawing.Point(6, 6);
            this.txt_File.Multiline = true;
            this.txt_File.Name = "txt_File";
            this.txt_File.ReadOnly = true;
            this.txt_File.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_File.Size = new System.Drawing.Size(324, 277);
            this.txt_File.TabIndex = 3;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(262, 3);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 30);
            this.btn_Confirm.TabIndex = 3;
            this.btn_Confirm.Text = "확인(&O)";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // TemplateViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 353);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_ChangeTemplate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TemplateViewer";
            this.Text = "클래스 템플릿 설정";
            this.tabControl1.ResumeLayout(false);
            this.tpg_Class.ResumeLayout(false);
            this.tpg_Class.PerformLayout();
            this.tpg_File.ResumeLayout(false);
            this.tpg_File.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Class;
        private System.Windows.Forms.Button btn_ChangeTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpg_Class;
        private System.Windows.Forms.TabPage tpg_File;
        private System.Windows.Forms.TextBox txt_File;
        private System.Windows.Forms.Button btn_Confirm;
    }
}