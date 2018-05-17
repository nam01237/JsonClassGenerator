﻿namespace JSonCodeGenerator.Forms
{
    partial class MainForm
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
            this.usc_Input = new JSonCodeGenerator.Controls.InputControl();
            this.usc_CodeViewer = new JSonCodeGenerator.Controls.CodeViewer();
            this.SuspendLayout();
            // 
            // usc_Input
            // 
            this.usc_Input.Location = new System.Drawing.Point(0, -6);
            this.usc_Input.Name = "usc_Input";
            this.usc_Input.Size = new System.Drawing.Size(730, 313);
            this.usc_Input.TabIndex = 2;
            this.usc_Input.GenerateButtonClicked += new System.EventHandler<JSonCodeGenerator.Controls.GenerateButtonClickedEventArgs>(this.usc_Input_GenerateButtonClicked);
            // 
            // usc_CodeViewer
            // 
            this.usc_CodeViewer.Location = new System.Drawing.Point(1, 313);
            this.usc_CodeViewer.Name = "usc_CodeViewer";
            this.usc_CodeViewer.Size = new System.Drawing.Size(729, 349);
            this.usc_CodeViewer.TabIndex = 1;
            this.usc_CodeViewer.RenameButtonClicked += new System.EventHandler<JSonCodeGenerator.Controls.RenameButtonClickedEventArgs>(this.usc_CodeViewer_RenameButtonClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 661);
            this.Controls.Add(this.usc_Input);
            this.Controls.Add(this.usc_CodeViewer);
            this.Name = "MainForm";
            this.Text = "Json Class 코드 생성기";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.CodeViewer usc_CodeViewer;
        private Controls.InputControl usc_Input;
    }
}

