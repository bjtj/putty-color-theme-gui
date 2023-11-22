namespace putty_color_theme_gui
{
    partial class PuttySessionListForm
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
            mainTable = new TableLayoutPanel();
            sessionList = new ListBox();
            buttonsPanel = new FlowLayoutPanel();
            btnApply = new Button();
            btnCancel = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSelectAll = new Button();
            btnUnselectAll = new Button();
            mainTable.SuspendLayout();
            buttonsPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainTable
            // 
            mainTable.ColumnCount = 1;
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTable.Controls.Add(sessionList, 0, 1);
            mainTable.Controls.Add(buttonsPanel, 0, 2);
            mainTable.Controls.Add(flowLayoutPanel1, 0, 0);
            mainTable.Dock = DockStyle.Fill;
            mainTable.Location = new Point(0, 0);
            mainTable.Name = "mainTable";
            mainTable.RowCount = 3;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            mainTable.Size = new Size(239, 372);
            mainTable.TabIndex = 0;
            // 
            // sessionList
            // 
            sessionList.Dock = DockStyle.Fill;
            sessionList.FormattingEnabled = true;
            sessionList.IntegralHeight = false;
            sessionList.ItemHeight = 15;
            sessionList.Location = new Point(3, 38);
            sessionList.Name = "sessionList";
            sessionList.SelectionMode = SelectionMode.MultiExtended;
            sessionList.Size = new Size(233, 296);
            sessionList.TabIndex = 0;
            sessionList.SelectedIndexChanged += sessionList_SelectedIndexChanged;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(btnApply);
            buttonsPanel.Controls.Add(btnCancel);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Location = new Point(3, 340);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(233, 29);
            buttonsPanel.TabIndex = 1;
            // 
            // btnApply
            // 
            btnApply.Enabled = false;
            btnApply.Location = new Point(3, 3);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 0;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(84, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSelectAll);
            flowLayoutPanel1.Controls.Add(btnUnselectAll);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(233, 29);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnSelectAll
            // 
            btnSelectAll.Location = new Point(3, 3);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(75, 23);
            btnSelectAll.TabIndex = 0;
            btnSelectAll.Text = "Select All";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // btnUnselectAll
            // 
            btnUnselectAll.Location = new Point(84, 3);
            btnUnselectAll.Name = "btnUnselectAll";
            btnUnselectAll.Size = new Size(87, 23);
            btnUnselectAll.TabIndex = 1;
            btnUnselectAll.Text = "Unselect All";
            btnUnselectAll.UseVisualStyleBackColor = true;
            btnUnselectAll.Click += btnUnselectAll_Click;
            // 
            // PuttySessionListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 372);
            Controls.Add(mainTable);
            Name = "PuttySessionListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PuTTY Sessions";
            Load += Form2_Load;
            mainTable.ResumeLayout(false);
            buttonsPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTable;
        private ListBox sessionList;
        private FlowLayoutPanel buttonsPanel;
        private Button btnApply;
        private Button btnCancel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSelectAll;
        private Button btnUnselectAll;
    }
}