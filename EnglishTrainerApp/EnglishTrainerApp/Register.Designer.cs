namespace EnglishTrainerApp
{
    partial class Register
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
            this.label_LoginInput = new System.Windows.Forms.Label();
            this.textBox_nameInput = new System.Windows.Forms.TextBox();
            this.button_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_LoginInput
            // 
            this.label_LoginInput.AutoSize = true;
            this.label_LoginInput.Location = new System.Drawing.Point(23, 24);
            this.label_LoginInput.Name = "label_LoginInput";
            this.label_LoginInput.Size = new System.Drawing.Size(84, 13);
            this.label_LoginInput.TabIndex = 2;
            this.label_LoginInput.Text = "Enter your name";
            // 
            // textBox_nameInput
            // 
            this.textBox_nameInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nameInput.Location = new System.Drawing.Point(26, 56);
            this.textBox_nameInput.Name = "textBox_nameInput";
            this.textBox_nameInput.Size = new System.Drawing.Size(183, 20);
            this.textBox_nameInput.TabIndex = 3;
            // 
            // button_Register
            // 
            this.button_Register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Register.Location = new System.Drawing.Point(26, 82);
            this.button_Register.MinimumSize = new System.Drawing.Size(50, 20);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(183, 23);
            this.button_Register.TabIndex = 4;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(234, 281);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.textBox_nameInput);
            this.Controls.Add(this.label_LoginInput);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_LoginInput;
        private System.Windows.Forms.TextBox textBox_nameInput;
        private System.Windows.Forms.Button button_Register;
    }
}