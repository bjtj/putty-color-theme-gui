namespace putty_color_theme_gui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            sessionList = new ListBox();
            btnSelectTheme = new Button();
            btnSetDefault = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(sessionList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnSelectTheme);
            splitContainer1.Panel2.Controls.Add(btnSetDefault);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // sessionList
            // 
            sessionList.Dock = DockStyle.Fill;
            sessionList.FormattingEnabled = true;
            sessionList.ItemHeight = 15;
            sessionList.Location = new Point(0, 0);
            sessionList.Name = "sessionList";
            sessionList.Size = new Size(266, 450);
            sessionList.TabIndex = 0;
            // 
            // btnSelectTheme
            // 
            btnSelectTheme.Location = new Point(84, 3);
            btnSelectTheme.Name = "btnSelectTheme";
            btnSelectTheme.Size = new Size(95, 23);
            btnSelectTheme.TabIndex = 1;
            btnSelectTheme.Text = "Select Theme";
            btnSelectTheme.UseVisualStyleBackColor = true;
            btnSelectTheme.Click += btnSelectTheme_Click;
            // 
            // btnSetDefault
            // 
            btnSetDefault.Location = new Point(3, 3);
            btnSetDefault.Name = "btnSetDefault";
            btnSetDefault.Size = new Size(75, 23);
            btnSetDefault.TabIndex = 0;
            btnSetDefault.Text = "Set Default";
            btnSetDefault.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "PuTTY Color Theme GUI";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox sessionList;
        private Button btnSetDefault;
        private Button btnSelectTheme;
    }
}