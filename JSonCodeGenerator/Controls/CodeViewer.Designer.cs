namespace JSonCodeGenerator.Controls
{
    partial class CodeViewer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CopyCode = new System.Windows.Forms.Button();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.trv_ClassInfo = new System.Windows.Forms.TreeView();
            this.txt_SavePath = new System.Windows.Forms.TextBox();
            this.btn_FindPath = new System.Windows.Forms.Button();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SaveFile);
            this.groupBox1.Controls.Add(this.btn_FindPath);
            this.groupBox1.Controls.Add(this.txt_SavePath);
            this.groupBox1.Controls.Add(this.btn_CopyCode);
            this.groupBox1.Controls.Add(this.btn_Rename);
            this.groupBox1.Controls.Add(this.txt_Code);
            this.groupBox1.Controls.Add(this.trv_ClassInfo);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_CopyCode
            // 
            this.btn_CopyCode.Location = new System.Drawing.Point(205, 15);
            this.btn_CopyCode.Name = "btn_CopyCode";
            this.btn_CopyCode.Size = new System.Drawing.Size(77, 23);
            this.btn_CopyCode.TabIndex = 3;
            this.btn_CopyCode.Text = "복사(&C)";
            this.btn_CopyCode.UseVisualStyleBackColor = true;
            this.btn_CopyCode.Click += new System.EventHandler(this.btn_CopyCode_Click);
            // 
            // btn_Rename
            // 
            this.btn_Rename.Location = new System.Drawing.Point(6, 16);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(128, 23);
            this.btn_Rename.TabIndex = 2;
            this.btn_Rename.Text = "클래스명 바꾸기(&R)";
            this.btn_Rename.UseVisualStyleBackColor = true;
            this.btn_Rename.Click += new System.EventHandler(this.btn_Rename_Click);
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(205, 44);
            this.txt_Code.Multiline = true;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Code.Size = new System.Drawing.Size(512, 290);
            this.txt_Code.TabIndex = 1;
            // 
            // trv_ClassInfo
            // 
            this.trv_ClassInfo.Location = new System.Drawing.Point(6, 44);
            this.trv_ClassInfo.Name = "trv_ClassInfo";
            this.trv_ClassInfo.Size = new System.Drawing.Size(194, 290);
            this.trv_ClassInfo.TabIndex = 0;
            this.trv_ClassInfo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_ClassInfo_AfterSelect);
            // 
            // txt_SavePath
            // 
            this.txt_SavePath.Location = new System.Drawing.Point(288, 15);
            this.txt_SavePath.Name = "txt_SavePath";
            this.txt_SavePath.Size = new System.Drawing.Size(289, 21);
            this.txt_SavePath.TabIndex = 4;
            // 
            // btn_FindPath
            // 
            this.btn_FindPath.Location = new System.Drawing.Point(583, 13);
            this.btn_FindPath.Name = "btn_FindPath";
            this.btn_FindPath.Size = new System.Drawing.Size(35, 23);
            this.btn_FindPath.TabIndex = 5;
            this.btn_FindPath.Text = "...";
            this.btn_FindPath.UseVisualStyleBackColor = true;
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.Location = new System.Drawing.Point(624, 13);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(93, 23);
            this.btn_SaveFile.TabIndex = 6;
            this.btn_SaveFile.Text = "파일 생성(&S)";
            this.btn_SaveFile.UseVisualStyleBackColor = true;
            // 
            // CodeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CodeViewer";
            this.Size = new System.Drawing.Size(728, 346);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TreeView trv_ClassInfo;
        private System.Windows.Forms.Button btn_CopyCode;
        private System.Windows.Forms.Button btn_Rename;
        private System.Windows.Forms.Button btn_SaveFile;
        private System.Windows.Forms.Button btn_FindPath;
        private System.Windows.Forms.TextBox txt_SavePath;
    }
}
