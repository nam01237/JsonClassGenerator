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
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.trv_ClassInfo = new System.Windows.Forms.TreeView();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.btn_CopyCode = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            // btn_Rename
            // 
            this.btn_Rename.Location = new System.Drawing.Point(6, 16);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(104, 23);
            this.btn_Rename.TabIndex = 2;
            this.btn_Rename.Text = "이름 바꾸기(&R)";
            this.btn_Rename.UseVisualStyleBackColor = true;
            this.btn_Rename.Click += new System.EventHandler(this.btn_Rename_Click);
            // 
            // btn_CopyCode
            // 
            this.btn_CopyCode.Location = new System.Drawing.Point(205, 15);
            this.btn_CopyCode.Name = "btn_CopyCode";
            this.btn_CopyCode.Size = new System.Drawing.Size(128, 23);
            this.btn_CopyCode.TabIndex = 3;
            this.btn_CopyCode.Text = "클립보드에 복사(&C)";
            this.btn_CopyCode.UseVisualStyleBackColor = true;
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
    }
}
