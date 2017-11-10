namespace EnglishTrainerApp
{
    partial class PersonalAccount
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
            this.label_LoggedAs = new System.Windows.Forms.Label();
            this.button_WatchStatistics = new System.Windows.Forms.Button();
            this.button_StartTraining = new System.Windows.Forms.Button();
            this.tabControl_Statistics = new System.Windows.Forms.TabControl();
            this.tabPage_Learned = new System.Windows.Forms.TabPage();
            this.listBox_Learned = new System.Windows.Forms.ListBox();
            this.tabPage_OnLearning = new System.Windows.Forms.TabPage();
            this.listBox_OnLearning = new System.Windows.Forms.ListBox();
            this.tabControl_Statistics.SuspendLayout();
            this.tabPage_Learned.SuspendLayout();
            this.tabPage_OnLearning.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_LoggedAs
            // 
            this.label_LoggedAs.AutoSize = true;
            this.label_LoggedAs.Location = new System.Drawing.Point(13, 13);
            this.label_LoggedAs.Name = "label_LoggedAs";
            this.label_LoggedAs.Size = new System.Drawing.Size(60, 13);
            this.label_LoggedAs.TabIndex = 0;
            this.label_LoggedAs.Text = "Logged as ";
            // 
            // button_WatchStatistics
            // 
            this.button_WatchStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_WatchStatistics.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_WatchStatistics.Location = new System.Drawing.Point(12, 71);
            this.button_WatchStatistics.Name = "button_WatchStatistics";
            this.button_WatchStatistics.Size = new System.Drawing.Size(281, 23);
            this.button_WatchStatistics.TabIndex = 1;
            this.button_WatchStatistics.Text = "Show statistics";
            this.button_WatchStatistics.UseVisualStyleBackColor = false;
            this.button_WatchStatistics.Click += new System.EventHandler(this.button_WatchStatistics_Click);
            // 
            // button_StartTraining
            // 
            this.button_StartTraining.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_StartTraining.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_StartTraining.Location = new System.Drawing.Point(12, 42);
            this.button_StartTraining.Name = "button_StartTraining";
            this.button_StartTraining.Size = new System.Drawing.Size(281, 23);
            this.button_StartTraining.TabIndex = 2;
            this.button_StartTraining.Text = "Start training";
            this.button_StartTraining.UseVisualStyleBackColor = false;
            this.button_StartTraining.Click += new System.EventHandler(this.button_StartTraining_Click);
            // 
            // tabControl_Statistics
            // 
            this.tabControl_Statistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Statistics.Controls.Add(this.tabPage_Learned);
            this.tabControl_Statistics.Controls.Add(this.tabPage_OnLearning);
            this.tabControl_Statistics.Location = new System.Drawing.Point(0, 101);
            this.tabControl_Statistics.Name = "tabControl_Statistics";
            this.tabControl_Statistics.SelectedIndex = 0;
            this.tabControl_Statistics.Size = new System.Drawing.Size(304, 209);
            this.tabControl_Statistics.TabIndex = 3;
            this.tabControl_Statistics.Visible = false;
            // 
            // tabPage_Learned
            // 
            this.tabPage_Learned.AutoScroll = true;
            this.tabPage_Learned.Controls.Add(this.listBox_Learned);
            this.tabPage_Learned.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Learned.Name = "tabPage_Learned";
            this.tabPage_Learned.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Learned.Size = new System.Drawing.Size(296, 183);
            this.tabPage_Learned.TabIndex = 0;
            this.tabPage_Learned.Text = "Learned";
            this.tabPage_Learned.UseVisualStyleBackColor = true;
            // 
            // listBox_Learned
            // 
            this.listBox_Learned.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Learned.FormattingEnabled = true;
            this.listBox_Learned.Location = new System.Drawing.Point(0, 2);
            this.listBox_Learned.Name = "listBox_Learned";
            this.listBox_Learned.Size = new System.Drawing.Size(296, 173);
            this.listBox_Learned.TabIndex = 0;
            // 
            // tabPage_OnLearning
            // 
            this.tabPage_OnLearning.AutoScroll = true;
            this.tabPage_OnLearning.Controls.Add(this.listBox_OnLearning);
            this.tabPage_OnLearning.Location = new System.Drawing.Point(4, 22);
            this.tabPage_OnLearning.Name = "tabPage_OnLearning";
            this.tabPage_OnLearning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_OnLearning.Size = new System.Drawing.Size(294, 181);
            this.tabPage_OnLearning.TabIndex = 1;
            this.tabPage_OnLearning.Text = "On learning";
            this.tabPage_OnLearning.UseVisualStyleBackColor = true;
            // 
            // listBox_OnLearning
            // 
            this.listBox_OnLearning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_OnLearning.FormattingEnabled = true;
            this.listBox_OnLearning.Location = new System.Drawing.Point(2, 4);
            this.listBox_OnLearning.Name = "listBox_OnLearning";
            this.listBox_OnLearning.Size = new System.Drawing.Size(292, 173);
            this.listBox_OnLearning.TabIndex = 1;
            // 
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(304, 311);
            this.Controls.Add(this.button_StartTraining);
            this.Controls.Add(this.button_WatchStatistics);
            this.Controls.Add(this.label_LoggedAs);
            this.Controls.Add(this.tabControl_Statistics);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 350);
            this.Name = "PersonalAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalAccount";
            this.tabControl_Statistics.ResumeLayout(false);
            this.tabPage_Learned.ResumeLayout(false);
            this.tabPage_OnLearning.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_LoggedAs;
        private System.Windows.Forms.Button button_WatchStatistics;
        private System.Windows.Forms.Button button_StartTraining;
        private System.Windows.Forms.TabControl tabControl_Statistics;
        private System.Windows.Forms.TabPage tabPage_Learned;
        private System.Windows.Forms.ListBox listBox_Learned;
        private System.Windows.Forms.TabPage tabPage_OnLearning;
        private System.Windows.Forms.ListBox listBox_OnLearning;
    }
}