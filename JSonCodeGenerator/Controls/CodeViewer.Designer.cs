﻿namespace JSonCodeGenerator.Controls
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Code);
            this.groupBox1.Controls.Add(this.trv_ClassInfo);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(224, 32);
            this.txt_Code.Multiline = true;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Code.Size = new System.Drawing.Size(494, 290);
            this.txt_Code.TabIndex = 1;
            // 
            // trv_ClassInfo
            // 
            this.trv_ClassInfo.Location = new System.Drawing.Point(6, 32);
            this.trv_ClassInfo.Name = "trv_ClassInfo";
            this.trv_ClassInfo.Size = new System.Drawing.Size(212, 290);
            this.trv_ClassInfo.TabIndex = 0;
            // 
            // CodeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CodeViewer";
            this.Size = new System.Drawing.Size(729, 336);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TreeView trv_ClassInfo;
    }
}