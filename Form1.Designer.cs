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
            themeSplitContainer = new SplitContainer();
            themeList = new ListBox();
            themeContentPanel = new TableLayoutPanel();
            themeControlPanel = new FlowLayoutPanel();
            btnApply = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)themeSplitContainer).BeginInit();
            themeSplitContainer.Panel1.SuspendLayout();
            themeSplitContainer.Panel2.SuspendLayout();
            themeSplitContainer.SuspendLayout();
            themeContentPanel.SuspendLayout();
            themeControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // themeSplitContainer
            // 
            themeSplitContainer.Dock = DockStyle.Fill;
            themeSplitContainer.FixedPanel = FixedPanel.Panel1;
            themeSplitContainer.Location = new Point(0, 0);
            themeSplitContainer.Name = "themeSplitContainer";
            // 
            // themeSplitContainer.Panel1
            // 
            themeSplitContainer.Panel1.Controls.Add(themeList);
            // 
            // themeSplitContainer.Panel2
            // 
            themeSplitContainer.Panel2.Controls.Add(themeContentPanel);
            themeSplitContainer.Size = new Size(800, 450);
            themeSplitContainer.SplitterDistance = 266;
            themeSplitContainer.TabIndex = 0;
            // 
            // themeList
            // 
            themeList.Dock = DockStyle.Fill;
            themeList.FormattingEnabled = true;
            themeList.IntegralHeight = false;
            themeList.ItemHeight = 15;
            themeList.Location = new Point(0, 0);
            themeList.Name = "themeList";
            themeList.Size = new Size(266, 450);
            themeList.TabIndex = 0;
            themeList.SelectedIndexChanged += themeList_SelectedIndexChanged;
            // 
            // themeContentPanel
            // 
            themeContentPanel.ColumnCount = 1;
            themeContentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            themeContentPanel.Controls.Add(themeControlPanel, 0, 0);
            themeContentPanel.Controls.Add(webView, 0, 1);
            themeContentPanel.Dock = DockStyle.Fill;
            themeContentPanel.Location = new Point(0, 0);
            themeContentPanel.Name = "themeContentPanel";
            themeContentPanel.RowCount = 2;
            themeContentPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            themeContentPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            themeContentPanel.Size = new Size(530, 450);
            themeContentPanel.TabIndex = 2;
            // 
            // themeControlPanel
            // 
            themeControlPanel.Controls.Add(btnApply);
            themeControlPanel.Dock = DockStyle.Fill;
            themeControlPanel.Location = new Point(3, 3);
            themeControlPanel.Name = "themeControlPanel";
            themeControlPanel.Size = new Size(524, 29);
            themeControlPanel.TabIndex = 0;
            // 
            // btnApply
            // 
            btnApply.Enabled = false;
            btnApply.Location = new Point(3, 3);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(95, 23);
            btnApply.TabIndex = 1;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(3, 38);
            webView.Name = "webView";
            webView.Size = new Size(524, 409);
            webView.Source = new Uri("https://putty.org.ru/themes/", UriKind.Absolute);
            webView.TabIndex = 1;
            webView.ZoomFactor = 1D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(themeSplitContainer);
            Name = "Form1";
            Text = "PuTTY Color Theme GUI";
            Load += Form1_Load;
            themeSplitContainer.Panel1.ResumeLayout(false);
            themeSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)themeSplitContainer).EndInit();
            themeSplitContainer.ResumeLayout(false);
            themeContentPanel.ResumeLayout(false);
            themeControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer themeSplitContainer;
        private ListBox themeList;
        private Button btnApply;
        private TableLayoutPanel themeContentPanel;
        private FlowLayoutPanel themeControlPanel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}