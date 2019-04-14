namespace NulledViewer
{
    partial class MainForm
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
            this.forumsTreeView = new System.Windows.Forms.TreeView();
            this.topicsDataGridView = new System.Windows.Forms.DataGridView();
            this.topicsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabs = new System.Windows.Forms.TabControl();
            this.forumTab = new System.Windows.Forms.TabPage();
            this.topicSearchButton = new System.Windows.Forms.Button();
            this.topicSearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.topicGoButton = new System.Windows.Forms.Button();
            this.topicNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.forumHtmlPanel = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
            this.pmTab = new System.Windows.Forms.TabPage();
            this.userPmSearchButton = new System.Windows.Forms.Button();
            this.userPmSearchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pmAllLabel = new System.Windows.Forms.Label();
            this.pmStatusLabel = new System.Windows.Forms.Label();
            this.pmFilterCheckBox2 = new System.Windows.Forms.CheckBox();
            this.pmFilterCheckBox1 = new System.Windows.Forms.CheckBox();
            this.pmPageNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.pmHtmlPanel = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
            this.pmPageLabel = new System.Windows.Forms.Label();
            this.pmPrevButton = new System.Windows.Forms.Button();
            this.pmNextButton = new System.Windows.Forms.Button();
            this.pmListBox = new System.Windows.Forms.ListBox();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colorSetButton1 = new System.Windows.Forms.Button();
            this.colorSetButton2 = new System.Windows.Forms.Button();
            this.backgroundColorTextBox = new System.Windows.Forms.TextBox();
            this.textColorTextBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pickButton1 = new System.Windows.Forms.Button();
            this.pickButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.topicsDataGridView)).BeginInit();
            this.tabs.SuspendLayout();
            this.forumTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicNumUpDown)).BeginInit();
            this.pmTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pmPageNumUpDown)).BeginInit();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ForumsTreeView
            // 
            this.forumsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.forumsTreeView.Location = new System.Drawing.Point(6, 11);
            this.forumsTreeView.Name = "ForumsTreeView";
            this.forumsTreeView.Size = new System.Drawing.Size(252, 572);
            this.forumsTreeView.TabIndex = 4;
            this.forumsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ForumsTreeView_AfterSelect);
            // 
            // TopicsDataGridView
            // 
            this.topicsDataGridView.AllowUserToAddRows = false;
            this.topicsDataGridView.AllowUserToDeleteRows = false;
            this.topicsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topicsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topicsID,
            this.topicsName});
            this.topicsDataGridView.Location = new System.Drawing.Point(264, 11);
            this.topicsDataGridView.Name = "TopicsDataGridView";
            this.topicsDataGridView.ReadOnly = true;
            this.topicsDataGridView.Size = new System.Drawing.Size(846, 291);
            this.topicsDataGridView.TabIndex = 5;
            // 
            // TopicsID
            // 
            this.topicsID.HeaderText = "ID";
            this.topicsID.Name = "TopicsID";
            this.topicsID.ReadOnly = true;
            // 
            // TopicsName
            // 
            this.topicsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.topicsName.HeaderText = "Name";
            this.topicsName.Name = "TopicsName";
            this.topicsName.ReadOnly = true;
            // 
            // Tabs
            // 
            this.tabs.Controls.Add(this.forumTab);
            this.tabs.Controls.Add(this.pmTab);
            this.tabs.Controls.Add(this.settingsTab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "Tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1123, 649);
            this.tabs.TabIndex = 7;
            // 
            // ForumTab
            // 
            this.forumTab.Controls.Add(this.topicSearchButton);
            this.forumTab.Controls.Add(this.topicSearchTextBox);
            this.forumTab.Controls.Add(this.label2);
            this.forumTab.Controls.Add(this.topicGoButton);
            this.forumTab.Controls.Add(this.topicNumUpDown);
            this.forumTab.Controls.Add(this.label1);
            this.forumTab.Controls.Add(this.forumHtmlPanel);
            this.forumTab.Controls.Add(this.forumsTreeView);
            this.forumTab.Controls.Add(this.topicsDataGridView);
            this.forumTab.Location = new System.Drawing.Point(4, 22);
            this.forumTab.Name = "ForumTab";
            this.forumTab.Padding = new System.Windows.Forms.Padding(3);
            this.forumTab.Size = new System.Drawing.Size(1115, 623);
            this.forumTab.TabIndex = 0;
            this.forumTab.Text = "Forum";
            this.forumTab.UseVisualStyleBackColor = true;
            // 
            // TopicSearchButton
            // 
            this.topicSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.topicSearchButton.Location = new System.Drawing.Point(754, 590);
            this.topicSearchButton.Name = "TopicSearchButton";
            this.topicSearchButton.Size = new System.Drawing.Size(75, 23);
            this.topicSearchButton.TabIndex = 12;
            this.topicSearchButton.Text = "By Topic";
            this.topicSearchButton.UseVisualStyleBackColor = true;
            this.topicSearchButton.Click += new System.EventHandler(this.TopicSearchButton_Click);
            // 
            // TopicSearchTextBox
            // 
            this.topicSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.topicSearchTextBox.Location = new System.Drawing.Point(580, 592);
            this.topicSearchTextBox.Name = "TopicSearchTextBox";
            this.topicSearchTextBox.Size = new System.Drawing.Size(157, 20);
            this.topicSearchTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search";
            // 
            // TopicGoButton
            // 
            this.topicGoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.topicGoButton.Location = new System.Drawing.Point(423, 590);
            this.topicGoButton.Name = "TopicGoButton";
            this.topicGoButton.Size = new System.Drawing.Size(75, 23);
            this.topicGoButton.TabIndex = 9;
            this.topicGoButton.Text = "Go";
            this.topicGoButton.UseVisualStyleBackColor = true;
            this.topicGoButton.Click += new System.EventHandler(this.TopicGoButton_Click);
            // 
            // TopicNumUpDown
            // 
            this.topicNumUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.topicNumUpDown.Location = new System.Drawing.Point(312, 593);
            this.topicNumUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.topicNumUpDown.Name = "TopicNumUpDown";
            this.topicNumUpDown.Size = new System.Drawing.Size(95, 20);
            this.topicNumUpDown.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TopicID";
            // 
            // ForumHtmlPanel
            // 
            this.forumHtmlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forumHtmlPanel.AutoScroll = true;
            this.forumHtmlPanel.BackColor = System.Drawing.SystemColors.Window;
            this.forumHtmlPanel.BaseStylesheet = null;
            this.forumHtmlPanel.Location = new System.Drawing.Point(264, 308);
            this.forumHtmlPanel.Name = "ForumHtmlPanel";
            this.forumHtmlPanel.Size = new System.Drawing.Size(846, 275);
            this.forumHtmlPanel.TabIndex = 6;
            this.forumHtmlPanel.Text = null;
            // 
            // PmTab
            // 
            this.pmTab.Controls.Add(this.userPmSearchButton);
            this.pmTab.Controls.Add(this.userPmSearchTextBox);
            this.pmTab.Controls.Add(this.label3);
            this.pmTab.Controls.Add(this.pmAllLabel);
            this.pmTab.Controls.Add(this.pmStatusLabel);
            this.pmTab.Controls.Add(this.pmFilterCheckBox2);
            this.pmTab.Controls.Add(this.pmFilterCheckBox1);
            this.pmTab.Controls.Add(this.pmPageNumUpDown);
            this.pmTab.Controls.Add(this.pmHtmlPanel);
            this.pmTab.Controls.Add(this.pmPageLabel);
            this.pmTab.Controls.Add(this.pmPrevButton);
            this.pmTab.Controls.Add(this.pmNextButton);
            this.pmTab.Controls.Add(this.pmListBox);
            this.pmTab.Location = new System.Drawing.Point(4, 22);
            this.pmTab.Name = "PmTab";
            this.pmTab.Padding = new System.Windows.Forms.Padding(3);
            this.pmTab.Size = new System.Drawing.Size(1115, 623);
            this.pmTab.TabIndex = 1;
            this.pmTab.Text = "PM";
            this.pmTab.UseVisualStyleBackColor = true;
            // 
            // UserPmSearchButton
            // 
            this.userPmSearchButton.Location = new System.Drawing.Point(809, 11);
            this.userPmSearchButton.Name = "UserPmSearchButton";
            this.userPmSearchButton.Size = new System.Drawing.Size(75, 23);
            this.userPmSearchButton.TabIndex = 15;
            this.userPmSearchButton.Text = "Search";
            this.userPmSearchButton.UseVisualStyleBackColor = true;
            this.userPmSearchButton.Click += new System.EventHandler(this.UserPmSearchButton_Click);
            // 
            // UserPmSearchTextBox
            // 
            this.userPmSearchTextBox.Location = new System.Drawing.Point(697, 13);
            this.userPmSearchTextBox.Name = "UserPmSearchTextBox";
            this.userPmSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.userPmSearchTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "User Name";
            // 
            // PmAllLabel
            // 
            this.pmAllLabel.AutoSize = true;
            this.pmAllLabel.Location = new System.Drawing.Point(97, 16);
            this.pmAllLabel.Name = "PmAllLabel";
            this.pmAllLabel.Size = new System.Drawing.Size(18, 13);
            this.pmAllLabel.TabIndex = 12;
            this.pmAllLabel.Text = "/0";
            // 
            // PmStatusLabel
            // 
            this.pmStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pmStatusLabel.AutoSize = true;
            this.pmStatusLabel.Location = new System.Drawing.Point(1024, 585);
            this.pmStatusLabel.Name = "PmStatusLabel";
            this.pmStatusLabel.Size = new System.Drawing.Size(69, 13);
            this.pmStatusLabel.TabIndex = 11;
            this.pmStatusLabel.Text = "Status: Done";
            this.pmStatusLabel.Visible = false;
            // 
            // PmFilterCheckBox2
            // 
            this.pmFilterCheckBox2.AutoSize = true;
            this.pmFilterCheckBox2.Location = new System.Drawing.Point(484, 15);
            this.pmFilterCheckBox2.Name = "PmFilterCheckBox2";
            this.pmFilterCheckBox2.Size = new System.Drawing.Size(129, 17);
            this.pmFilterCheckBox2.TabIndex = 10;
            this.pmFilterCheckBox2.Text = "Only Posts With Links";
            this.pmFilterCheckBox2.UseVisualStyleBackColor = true;
            this.pmFilterCheckBox2.CheckedChanged += new System.EventHandler(this.PmFilterCheckBox2_CheckedChanged);
            // 
            // PmFilterCheckBox1
            // 
            this.pmFilterCheckBox1.AutoSize = true;
            this.pmFilterCheckBox1.Location = new System.Drawing.Point(351, 15);
            this.pmFilterCheckBox1.Name = "PmFilterCheckBox1";
            this.pmFilterCheckBox1.Size = new System.Drawing.Size(109, 17);
            this.pmFilterCheckBox1.TabIndex = 9;
            this.pmFilterCheckBox1.Text = "Filter Single Posts";
            this.pmFilterCheckBox1.UseVisualStyleBackColor = true;
            this.pmFilterCheckBox1.CheckedChanged += new System.EventHandler(this.PmFilterCheckBox1_CheckedChanged);
            // 
            // PmPageNumUpDown
            // 
            this.pmPageNumUpDown.Location = new System.Drawing.Point(47, 14);
            this.pmPageNumUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pmPageNumUpDown.Name = "PmPageNumUpDown";
            this.pmPageNumUpDown.Size = new System.Drawing.Size(44, 20);
            this.pmPageNumUpDown.TabIndex = 8;
            this.pmPageNumUpDown.ValueChanged += new System.EventHandler(this.PmPageNumUpDown_ValueChanged);
            // 
            // PmHtmlPanel
            // 
            this.pmHtmlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pmHtmlPanel.AutoScroll = true;
            this.pmHtmlPanel.BackColor = System.Drawing.SystemColors.Window;
            this.pmHtmlPanel.BaseStylesheet = null;
            this.pmHtmlPanel.Location = new System.Drawing.Point(8, 241);
            this.pmHtmlPanel.Name = "PmHtmlPanel";
            this.pmHtmlPanel.Size = new System.Drawing.Size(1102, 333);
            this.pmHtmlPanel.TabIndex = 7;
            this.pmHtmlPanel.Text = null;
            // 
            // PmPageLabel
            // 
            this.pmPageLabel.AutoSize = true;
            this.pmPageLabel.Location = new System.Drawing.Point(9, 16);
            this.pmPageLabel.Name = "PmPageLabel";
            this.pmPageLabel.Size = new System.Drawing.Size(32, 13);
            this.pmPageLabel.TabIndex = 3;
            this.pmPageLabel.Text = "Page";
            // 
            // PmPrevButton
            // 
            this.pmPrevButton.Location = new System.Drawing.Point(155, 11);
            this.pmPrevButton.Name = "PmPrevButton";
            this.pmPrevButton.Size = new System.Drawing.Size(75, 23);
            this.pmPrevButton.TabIndex = 2;
            this.pmPrevButton.Text = "Prev Page";
            this.pmPrevButton.UseVisualStyleBackColor = true;
            this.pmPrevButton.Click += new System.EventHandler(this.PmPrevButton_Click);
            // 
            // PmNextButton
            // 
            this.pmNextButton.Location = new System.Drawing.Point(236, 11);
            this.pmNextButton.Name = "PmNextButton";
            this.pmNextButton.Size = new System.Drawing.Size(75, 23);
            this.pmNextButton.TabIndex = 1;
            this.pmNextButton.Text = "Next Page";
            this.pmNextButton.UseVisualStyleBackColor = true;
            this.pmNextButton.Click += new System.EventHandler(this.PmNextButton_Click);
            // 
            // PmListBox
            // 
            this.pmListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pmListBox.FormattingEnabled = true;
            this.pmListBox.Location = new System.Drawing.Point(8, 49);
            this.pmListBox.Name = "PmListBox";
            this.pmListBox.Size = new System.Drawing.Size(1102, 186);
            this.pmListBox.TabIndex = 0;
            this.pmListBox.SelectedIndexChanged += new System.EventHandler(this.PmListBox_SelectedIndexChanged);
            // 
            // SettingsTab
            // 
            this.settingsTab.Controls.Add(this.pickButton2);
            this.settingsTab.Controls.Add(this.pickButton1);
            this.settingsTab.Controls.Add(this.textColorTextBox);
            this.settingsTab.Controls.Add(this.backgroundColorTextBox);
            this.settingsTab.Controls.Add(this.colorSetButton2);
            this.settingsTab.Controls.Add(this.colorSetButton1);
            this.settingsTab.Controls.Add(this.label5);
            this.settingsTab.Controls.Add(this.label4);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "SettingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(1115, 623);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Background Color #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Text Color             #";
            // 
            // ColorSetButton1
            // 
            this.colorSetButton1.Location = new System.Drawing.Point(234, 13);
            this.colorSetButton1.Name = "ColorSetButton1";
            this.colorSetButton1.Size = new System.Drawing.Size(75, 23);
            this.colorSetButton1.TabIndex = 2;
            this.colorSetButton1.Text = "Set";
            this.colorSetButton1.UseVisualStyleBackColor = true;
            this.colorSetButton1.Click += new System.EventHandler(this.ColorSetButton1_Click);
            // 
            // ColorSetButton2
            // 
            this.colorSetButton2.Location = new System.Drawing.Point(234, 39);
            this.colorSetButton2.Name = "ColorSetButton2";
            this.colorSetButton2.Size = new System.Drawing.Size(75, 23);
            this.colorSetButton2.TabIndex = 3;
            this.colorSetButton2.Text = "Set";
            this.colorSetButton2.UseVisualStyleBackColor = true;
            this.colorSetButton2.Click += new System.EventHandler(this.ColorSetButton2_Click);
            // 
            // BackgroundColorTextBox
            // 
            this.backgroundColorTextBox.Location = new System.Drawing.Point(128, 15);
            this.backgroundColorTextBox.MaxLength = 6;
            this.backgroundColorTextBox.Name = "BackgroundColorTextBox";
            this.backgroundColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.backgroundColorTextBox.TabIndex = 4;
            // 
            // TextColorTextBox
            // 
            this.textColorTextBox.Location = new System.Drawing.Point(128, 41);
            this.textColorTextBox.MaxLength = 6;
            this.textColorTextBox.Name = "TextColorTextBox";
            this.textColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.textColorTextBox.TabIndex = 5;
            // 
            // PickButton1
            // 
            this.pickButton1.Location = new System.Drawing.Point(315, 13);
            this.pickButton1.Name = "PickButton1";
            this.pickButton1.Size = new System.Drawing.Size(75, 23);
            this.pickButton1.TabIndex = 6;
            this.pickButton1.Text = "Pick";
            this.pickButton1.UseVisualStyleBackColor = true;
            this.pickButton1.Click += new System.EventHandler(this.PickButton1_Click);
            // 
            // PickButton2
            // 
            this.pickButton2.Location = new System.Drawing.Point(315, 39);
            this.pickButton2.Name = "PickButton2";
            this.pickButton2.Size = new System.Drawing.Size(75, 23);
            this.pickButton2.TabIndex = 7;
            this.pickButton2.Text = "Pick";
            this.pickButton2.UseVisualStyleBackColor = true;
            this.pickButton2.Click += new System.EventHandler(this.PickButton2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 649);
            this.Controls.Add(this.tabs);
            this.Name = "MainForm";
            this.Text = "Nulled IPB Forum Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topicsDataGridView)).EndInit();
            this.tabs.ResumeLayout(false);
            this.forumTab.ResumeLayout(false);
            this.forumTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicNumUpDown)).EndInit();
            this.pmTab.ResumeLayout(false);
            this.pmTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pmPageNumUpDown)).EndInit();
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView forumsTreeView;
        private System.Windows.Forms.DataGridView topicsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicsName;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage forumTab;
        private System.Windows.Forms.TabPage pmTab;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel forumHtmlPanel;
        private System.Windows.Forms.ListBox pmListBox;
        private System.Windows.Forms.Button pmPrevButton;
        private System.Windows.Forms.Button pmNextButton;
        private System.Windows.Forms.Label pmPageLabel;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel pmHtmlPanel;
        private System.Windows.Forms.NumericUpDown pmPageNumUpDown;
        private System.Windows.Forms.CheckBox pmFilterCheckBox2;
        private System.Windows.Forms.CheckBox pmFilterCheckBox1;
        private System.Windows.Forms.Label pmStatusLabel;
        private System.Windows.Forms.Label pmAllLabel;
        private System.Windows.Forms.Button topicGoButton;
        private System.Windows.Forms.NumericUpDown topicNumUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button topicSearchButton;
        private System.Windows.Forms.TextBox topicSearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button userPmSearchButton;
        private System.Windows.Forms.TextBox userPmSearchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.TextBox textColorTextBox;
        private System.Windows.Forms.TextBox backgroundColorTextBox;
        private System.Windows.Forms.Button colorSetButton2;
        private System.Windows.Forms.Button colorSetButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pickButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button pickButton2;
    }
}