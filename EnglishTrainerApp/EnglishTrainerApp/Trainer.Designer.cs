namespace EnglishTrainerApp
{
    partial class Trainer
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
            this.label_Word = new System.Windows.Forms.Label();
            this.label_Translation = new System.Windows.Forms.Label();
            this.button_false = new System.Windows.Forms.Button();
            this.button_true = new System.Windows.Forms.Button();
            this.label_helper = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Word
            // 
            this.label_Word.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Word.AutoSize = true;
            this.label_Word.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Word.Location = new System.Drawing.Point(123, 63);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(78, 37);
            this.label_Word.TabIndex = 0;
            this.label_Word.Text = "word";
            this.label_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Translation
            // 
            this.label_Translation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Translation.AutoSize = true;
            this.label_Translation.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Translation.Location = new System.Drawing.Point(122, 110);
            this.label_Translation.Name = "label_Translation";
            this.label_Translation.Size = new System.Drawing.Size(103, 45);
            this.label_Translation.TabIndex = 1;
            this.label_Translation.Text = "translation";
            this.label_Translation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_false
            // 
            this.button_false.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_false.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_false.Location = new System.Drawing.Point(210, 207);
            this.button_false.Name = "button_false";
            this.button_false.Size = new System.Drawing.Size(112, 62);
            this.button_false.TabIndex = 2;
            this.button_false.Text = "NO";
            this.button_false.UseVisualStyleBackColor = false;
            this.button_false.Click += new System.EventHandler(this.button_false_Click);
            // 
            // button_true
            // 
            this.button_true.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_true.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_true.Location = new System.Drawing.Point(12, 207);
            this.button_true.Name = "button_true";
            this.button_true.Size = new System.Drawing.Size(112, 62);
            this.button_true.TabIndex = 3;
            this.button_true.Text = "YES";
            this.button_true.UseVisualStyleBackColor = false;
            this.button_true.Click += new System.EventHandler(this.button_true_Click);
            // 
            // label_helper
            // 
            this.label_helper.AllowDrop = true;
            this.label_helper.AutoEllipsis = true;
            this.label_helper.AutoSize = true;
            this.label_helper.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_helper.Location = new System.Drawing.Point(7, 9);
            this.label_helper.Name = "label_helper";
            this.label_helper.Size = new System.Drawing.Size(315, 26);
            this.label_helper.TabIndex = 4;
            this.label_helper.Text = "Is the translation correct for this word?";
            this.label_helper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.PowderBlue;
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Start.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.Location = new System.Drawing.Point(74, 63);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(177, 116);
            this.button_Start.TabIndex = 5;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(334, 281);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_helper);
            this.Controls.Add(this.button_true);
            this.Controls.Add(this.button_false);
            this.Controls.Add(this.label_Translation);
            this.Controls.Add(this.label_Word);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 320);
            this.Name = "Trainer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Word;
        private System.Windows.Forms.Label label_Translation;
        private System.Windows.Forms.Button button_false;
        private System.Windows.Forms.Button button_true;
        private System.Windows.Forms.Label label_helper;
        private System.Windows.Forms.Button button_Start;
    }
}