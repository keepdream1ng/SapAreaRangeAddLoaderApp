﻿namespace SapAreaRangeAddLoader
{
    partial class Form1
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
            this.CreateLoads_button = new System.Windows.Forms.Button();
            this.Prefix_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateLoads_button
            // 
            this.CreateLoads_button.Location = new System.Drawing.Point(186, 26);
            this.CreateLoads_button.Name = "CreateLoads_button";
            this.CreateLoads_button.Size = new System.Drawing.Size(93, 23);
            this.CreateLoads_button.TabIndex = 0;
            this.CreateLoads_button.Text = "Create Loads";
            this.CreateLoads_button.UseVisualStyleBackColor = true;
            this.CreateLoads_button.Click += new System.EventHandler(this.CreateLoads_button_Click);
            // 
            // Prefix_textBox
            // 
            this.Prefix_textBox.Location = new System.Drawing.Point(40, 29);
            this.Prefix_textBox.Name = "Prefix_textBox";
            this.Prefix_textBox.Size = new System.Drawing.Size(100, 20);
            this.Prefix_textBox.TabIndex = 1;
            this.Prefix_textBox.TextChanged += new System.EventHandler(this.Prefix_textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 136);
            this.Controls.Add(this.Prefix_textBox);
            this.Controls.Add(this.CreateLoads_button);
            this.Name = "Form1";
            this.Text = "Area Range Loader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateLoads_button;
        private System.Windows.Forms.TextBox Prefix_textBox;
    }
}
