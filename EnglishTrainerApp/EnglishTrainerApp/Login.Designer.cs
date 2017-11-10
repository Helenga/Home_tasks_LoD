namespace EnglishTrainerApp
{
    partial class Login
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
            this.textBox_NameInput = new System.Windows.Forms.TextBox();
            this.label_LoginInput = new System.Windows.Forms.Label();
            this.label_NotRegisteredPointer = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.linkLabel_Register = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox_NameInput
            // 
            this.textBox_NameInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NameInput.Location = new System.Drawing.Point(27, 52);
            this.textBox_NameInput.Name = "textBox_NameInput";
            this.textBox_NameInput.Size = new System.Drawing.Size(181, 20);
            this.textBox_NameInput.TabIndex = 0;
            // 
            // label_LoginInput
            // 
            this.label_LoginInput.AutoSize = true;
            this.label_LoginInput.Location = new System.Drawing.Point(24, 19);
            this.label_LoginInput.Name = "label_LoginInput";
            this.label_LoginInput.Size = new System.Drawing.Size(84, 13);
            this.label_LoginInput.TabIndex = 1;
            this.label_LoginInput.Text = "Enter your name";
            // 
            // label_NotRegisteredPointer
            // 
            this.label_NotRegisteredPointer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NotRegisteredPointer.AutoSize = true;
            this.label_NotRegisteredPointer.Location = new System.Drawing.Point(24, 128);
            this.label_NotRegisteredPointer.Name = "label_NotRegisteredPointer";
            this.label_NotRegisteredPointer.Size = new System.Drawing.Size(96, 13);
            this.label_NotRegisteredPointer.TabIndex = 2;
            this.label_NotRegisteredPointer.Text = "Not registered yet?";
            // 
            // button_Login
            // 
            this.button_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Login.Location = new System.Drawing.Point(27, 78);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(181, 23);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // linkLabel_Register
            // 
            this.linkLabel_Register.AutoSize = true;
            this.linkLabel_Register.Location = new System.Drawing.Point(24, 150);
            this.linkLabel_Register.Name = "linkLabel_Register";
            this.linkLabel_Register.Size = new System.Drawing.Size(46, 13);
            this.linkLabel_Register.TabIndex = 4;
            this.linkLabel_Register.TabStop = true;
            this.linkLabel_Register.Text = "Register";
            this.linkLabel_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Register_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(234, 281);
            this.Controls.Add(this.linkLabel_Register);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label_NotRegisteredPointer);
            this.Controls.Add(this.label_LoginInput);
            this.Controls.Add(this.textBox_NameInput);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_NameInput;
        private System.Windows.Forms.Label label_LoginInput;
        private System.Windows.Forms.Label label_NotRegisteredPointer;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.LinkLabel linkLabel_Register;
    }
}

