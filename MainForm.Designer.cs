namespace putty_color_theme_gui
{
    partial class MainForm
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
            leftTableLayout = new TableLayoutPanel();
            themeListElement = new ListBox();
            labelThemes = new Label();
            contentTable = new TableLayoutPanel();
            themeControlPanel = new FlowLayoutPanel();
            btnApply = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)themeSplitContainer).BeginInit();
            themeSplitContainer.Panel1.SuspendLayout();
            themeSplitContainer.Panel2.SuspendLayout();
            themeSplitContainer.SuspendLayout();
            leftTableLayout.SuspendLayout();
            contentTable.SuspendLayout();
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
            themeSplitContainer.Panel1.Controls.Add(leftTableLayout);
            // 
            // themeSplitContainer.Panel2
            // 
            themeSplitContainer.Panel2.Controls.Add(contentTable);
            themeSplitContainer.Size = new Size(800, 450);
            themeSplitContainer.SplitterDistance = 266;
            themeSplitContainer.TabIndex = 0;
            // 
            // leftTableLayout
            // 
            leftTableLayout.ColumnCount = 1;
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftTableLayout.Controls.Add(themeListElement, 0, 1);
            leftTableLayout.Controls.Add(labelThemes, 0, 0);
            leftTableLayout.Dock = DockStyle.Fill;
            leftTableLayout.Location = new Point(0, 0);
            leftTableLayout.Name = "leftTableLayout";
            leftTableLayout.RowCount = 2;
            leftTableLayout.RowStyles.Add(new RowStyle());
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            leftTableLayout.Size = new Size(266, 450);
            leftTableLayout.TabIndex = 2;
            // 
            // themeListElement
            // 
            themeListElement.Dock = DockStyle.Fill;
            themeListElement.FormattingEnabled = true;
            themeListElement.IntegralHeight = false;
            themeListElement.ItemHeight = 15;
            themeListElement.Location = new Point(3, 24);
            themeListElement.Name = "themeListElement";
            themeListElement.Size = new Size(260, 423);
            themeListElement.TabIndex = 3;
            themeListElement.SelectedIndexChanged += themeList_SelectedIndexChanged;
            // 
            // labelThemes
            // 
            labelThemes.AutoSize = true;
            labelThemes.Location = new Point(3, 0);
            labelThemes.Name = "labelThemes";
            labelThemes.Padding = new Padding(0, 3, 0, 3);
            labelThemes.Size = new Size(51, 21);
            labelThemes.TabIndex = 2;
            labelThemes.Text = "Themes:";
            // 
            // contentTable
            // 
            contentTable.ColumnCount = 1;
            contentTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contentTable.Controls.Add(themeControlPanel, 0, 0);
            contentTable.Controls.Add(webView, 0, 1);
            contentTable.Dock = DockStyle.Fill;
            contentTable.Location = new Point(0, 0);
            contentTable.Name = "contentTable";
            contentTable.RowCount = 2;
            contentTable.RowStyles.Add(new RowStyle());
            contentTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentTable.Size = new Size(530, 450);
            contentTable.TabIndex = 2;
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
            btnApply.Click += OnApplyButtonClick;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(themeSplitContainer);
            Name = "MainForm";
            Text = "PuTTY Color Theme GUI";
            Load += Form1_Load;
            themeSplitContainer.Panel1.ResumeLayout(false);
            themeSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)themeSplitContainer).EndInit();
            themeSplitContainer.ResumeLayout(false);
            leftTableLayout.ResumeLayout(false);
            leftTableLayout.PerformLayout();
            contentTable.ResumeLayout(false);
            themeControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer themeSplitContainer;
        private Button btnApply;
        private TableLayoutPanel contentTable;
        private FlowLayoutPanel themeControlPanel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private TableLayoutPanel leftTableLayout;
        private ListBox themeListElement;
        private Label labelThemes;
    }
}