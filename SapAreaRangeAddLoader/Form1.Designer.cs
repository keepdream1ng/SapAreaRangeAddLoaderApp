namespace SapAreaRangeAddLoader
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
            this.LoadType_comboBox = new System.Windows.Forms.ComboBox();
            this.LoadValue_textBox = new System.Windows.Forms.TextBox();
            this.val_label = new System.Windows.Forms.Label();
            this.Pref_label = new System.Windows.Forms.Label();
            this.Type_label = new System.Windows.Forms.Label();
            this.AreaLoadType_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CreateLoads_button
            // 
            this.CreateLoads_button.Location = new System.Drawing.Point(292, 51);
            this.CreateLoads_button.Name = "CreateLoads_button";
            this.CreateLoads_button.Size = new System.Drawing.Size(93, 23);
            this.CreateLoads_button.TabIndex = 0;
            this.CreateLoads_button.Text = "Create Loads";
            this.CreateLoads_button.UseVisualStyleBackColor = true;
            this.CreateLoads_button.Click += new System.EventHandler(this.CreateLoads_button_Click);
            // 
            // Prefix_textBox
            // 
            this.Prefix_textBox.Location = new System.Drawing.Point(59, 51);
            this.Prefix_textBox.Name = "Prefix_textBox";
            this.Prefix_textBox.Size = new System.Drawing.Size(100, 20);
            this.Prefix_textBox.TabIndex = 1;
            this.Prefix_textBox.TextChanged += new System.EventHandler(this.Prefix_textBox_TextChanged);
            // 
            // LoadType_comboBox
            // 
            this.LoadType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoadType_comboBox.FormattingEnabled = true;
            this.LoadType_comboBox.Location = new System.Drawing.Point(165, 51);
            this.LoadType_comboBox.Name = "LoadType_comboBox";
            this.LoadType_comboBox.Size = new System.Drawing.Size(121, 21);
            this.LoadType_comboBox.TabIndex = 2;
            this.LoadType_comboBox.SelectionChangeCommitted += new System.EventHandler(this.LoadType_comboBox_SelectionChangeCommitted);
            // 
            // LoadValue_textBox
            // 
            this.LoadValue_textBox.Location = new System.Drawing.Point(13, 51);
            this.LoadValue_textBox.Name = "LoadValue_textBox";
            this.LoadValue_textBox.Size = new System.Drawing.Size(40, 20);
            this.LoadValue_textBox.TabIndex = 3;
            this.LoadValue_textBox.TextChanged += new System.EventHandler(this.LoadValue_textBox_TextChanged);
            // 
            // val_label
            // 
            this.val_label.AutoSize = true;
            this.val_label.Location = new System.Drawing.Point(13, 32);
            this.val_label.Name = "val_label";
            this.val_label.Size = new System.Drawing.Size(34, 13);
            this.val_label.TabIndex = 4;
            this.val_label.Text = "Value";
            // 
            // Pref_label
            // 
            this.Pref_label.AutoSize = true;
            this.Pref_label.Location = new System.Drawing.Point(60, 32);
            this.Pref_label.Name = "Pref_label";
            this.Pref_label.Size = new System.Drawing.Size(88, 13);
            this.Pref_label.TabIndex = 5;
            this.Pref_label.Text = "Load name prefix";
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.Location = new System.Drawing.Point(165, 31);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(54, 13);
            this.Type_label.TabIndex = 6;
            this.Type_label.Text = "Load type";
            // 
            // AreaLoadType_combobox
            // 
            this.AreaLoadType_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaLoadType_combobox.FormattingEnabled = true;
            this.AreaLoadType_combobox.Location = new System.Drawing.Point(165, 78);
            this.AreaLoadType_combobox.Name = "AreaLoadType_combobox";
            this.AreaLoadType_combobox.Size = new System.Drawing.Size(121, 21);
            this.AreaLoadType_combobox.TabIndex = 7;
            this.AreaLoadType_combobox.SelectionChangeCommitted += new System.EventHandler(this.AreaLoadType_combobox_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 111);
            this.Controls.Add(this.AreaLoadType_combobox);
            this.Controls.Add(this.Type_label);
            this.Controls.Add(this.Pref_label);
            this.Controls.Add(this.val_label);
            this.Controls.Add(this.LoadValue_textBox);
            this.Controls.Add(this.LoadType_comboBox);
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
        private System.Windows.Forms.ComboBox LoadType_comboBox;
        private System.Windows.Forms.TextBox LoadValue_textBox;
        private System.Windows.Forms.Label val_label;
        private System.Windows.Forms.Label Pref_label;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.ComboBox AreaLoadType_combobox;
    }
}

