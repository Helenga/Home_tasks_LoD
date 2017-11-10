namespace EnglishTrainerApp
{
    partial class DictionarySelection
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
            this.listBox_availableDictionaries = new System.Windows.Forms.ListBox();
            this.label_availableDictionaries = new System.Windows.Forms.Label();
            this.button_loadDictionary = new System.Windows.Forms.Button();
            this.button_selectDictionary = new System.Windows.Forms.Button();
            this.openFileDialog_LoadDictionary = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // listBox_availableDictionaries
            // 
            this.listBox_availableDictionaries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_availableDictionaries.FormattingEnabled = true;
            this.listBox_availableDictionaries.Location = new System.Drawing.Point(13, 40);
            this.listBox_availableDictionaries.Name = "listBox_availableDictionaries";
            this.listBox_availableDictionaries.Size = new System.Drawing.Size(279, 173);
            this.listBox_availableDictionaries.TabIndex = 0;
            // 
            // label_availableDictionaries
            // 
            this.label_availableDictionaries.AutoSize = true;
            this.label_availableDictionaries.Location = new System.Drawing.Point(13, 13);
            this.label_availableDictionaries.Name = "label_availableDictionaries";
            this.label_availableDictionaries.Size = new System.Drawing.Size(106, 13);
            this.label_availableDictionaries.TabIndex = 1;
            this.label_availableDictionaries.Text = "Available dictionaries";
            // 
            // button_loadDictionary
            // 
            this.button_loadDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_loadDictionary.Location = new System.Drawing.Point(12, 276);
            this.button_loadDictionary.Name = "button_loadDictionary";
            this.button_loadDictionary.Size = new System.Drawing.Size(280, 23);
            this.button_loadDictionary.TabIndex = 2;
            this.button_loadDictionary.Text = "Load dictionary";
            this.button_loadDictionary.UseVisualStyleBackColor = true;
            this.button_loadDictionary.Click += new System.EventHandler(this.button_loadDictionary_Click);
            // 
            // button_selectDictionary
            // 
            this.button_selectDictionary.Location = new System.Drawing.Point(12, 238);
            this.button_selectDictionary.Name = "button_selectDictionary";
            this.button_selectDictionary.Size = new System.Drawing.Size(280, 23);
            this.button_selectDictionary.TabIndex = 3;
            this.button_selectDictionary.Text = "Select dictionary";
            this.button_selectDictionary.UseVisualStyleBackColor = true;
            this.button_selectDictionary.Click += new System.EventHandler(this.button_selectDictionary_Click);
            // 
            // openFileDialog_LoadDictionary
            // 
            this.openFileDialog_LoadDictionary.FileName = "openFileDialog_LoadDictionary";
            // 
            // DictionarySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(304, 311);
            this.Controls.Add(this.button_selectDictionary);
            this.Controls.Add(this.button_loadDictionary);
            this.Controls.Add(this.label_availableDictionaries);
            this.Controls.Add(this.listBox_availableDictionaries);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 350);
            this.Name = "DictionarySelection";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DictionarySelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_availableDictionaries;
        private System.Windows.Forms.Label label_availableDictionaries;
        private System.Windows.Forms.Button button_loadDictionary;
        private System.Windows.Forms.Button button_selectDictionary;
        private System.Windows.Forms.OpenFileDialog openFileDialog_LoadDictionary;
    }
}