namespace OpenHardwareMonitor.GUI
{
    partial class InfluxSettings
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
            this.Url = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.TextBox();
            this.InfluxEnabled = new System.Windows.Forms.CheckBox();
            this.Interval = new Aga.Controls.NumericTextBox();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.TagsTableView = new System.Windows.Forms.DataGridView();
            this.TagKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemplateJsonLabel = new System.Windows.Forms.Label();
            this.TemplateJson = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.SetJson = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.TemplateTableView = new System.Windows.Forms.DataGridView();
            this.VarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagsLabel = new System.Windows.Forms.Label();
            this.TemplateLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.InfluxUser = new System.Windows.Forms.TextBox();
            this.InfluxPassword = new System.Windows.Forms.TextBox();
            this.InfluxLoginLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.TagsTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemplateTableView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Url
            // 
            this.Url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Url.Location = new System.Drawing.Point(12, 12);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(453, 20);
            this.Url.TabIndex = 0;
            // 
            // UrlLabel
            // 
            this.UrlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(469, 15);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(97, 13);
            this.UrlLabel.TabIndex = 1;
            this.UrlLabel.Text = "InfluxDB Server Url";
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(469, 41);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(53, 13);
            this.DatabaseLabel.TabIndex = 3;
            this.DatabaseLabel.Text = "Database";
            // 
            // Database
            // 
            this.Database.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Database.Location = new System.Drawing.Point(12, 38);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(453, 20);
            this.Database.TabIndex = 2;
            // 
            // InfluxEnabled
            // 
            this.InfluxEnabled.AutoSize = true;
            this.InfluxEnabled.Location = new System.Drawing.Point(12, 116);
            this.InfluxEnabled.Name = "InfluxEnabled";
            this.InfluxEnabled.Size = new System.Drawing.Size(65, 17);
            this.InfluxEnabled.TabIndex = 4;
            this.InfluxEnabled.Text = "Enabled";
            this.InfluxEnabled.UseVisualStyleBackColor = true;
            this.InfluxEnabled.CheckedChanged += new System.EventHandler(this.OnEnabledChanged);
            // 
            // Interval
            // 
            this.Interval.AllowDecimalSeparator = false;
            this.Interval.AllowNegativeSign = false;
            this.Interval.Location = new System.Drawing.Point(83, 114);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(53, 20);
            this.Interval.TabIndex = 5;
            this.Interval.Text = "10";
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(142, 117);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(118, 13);
            this.IntervalLabel.TabIndex = 6;
            this.IntervalLabel.Text = "Push Interval (seconds)";
            // 
            // TagsTableView
            // 
            this.TagsTableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TagsTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TagsTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TagKey,
            this.TagValue});
            this.TagsTableView.Location = new System.Drawing.Point(3, 23);
            this.TagsTableView.Name = "TagsTableView";
            this.TagsTableView.Size = new System.Drawing.Size(337, 430);
            this.TagsTableView.TabIndex = 7;
            this.TagsTableView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnTagsCellValueChanged);
            // 
            // TagKey
            // 
            this.TagKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TagKey.HeaderText = "Tag Key";
            this.TagKey.Name = "TagKey";
            this.TagKey.Width = 72;
            // 
            // TagValue
            // 
            this.TagValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TagValue.HeaderText = "Tag Value";
            this.TagValue.Name = "TagValue";
            this.TagValue.Width = 81;
            // 
            // TemplateJsonLabel
            // 
            this.TemplateJsonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateJsonLabel.AutoSize = true;
            this.TemplateJsonLabel.Location = new System.Drawing.Point(469, 93);
            this.TemplateJsonLabel.Name = "TemplateJsonLabel";
            this.TemplateJsonLabel.Size = new System.Drawing.Size(159, 13);
            this.TemplateJsonLabel.TabIndex = 9;
            this.TemplateJsonLabel.Text = "Template JSON Key-Value Pairs";
            // 
            // TemplateJson
            // 
            this.TemplateJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateJson.Location = new System.Drawing.Point(12, 90);
            this.TemplateJson.Name = "TemplateJson";
            this.TemplateJson.Size = new System.Drawing.Size(351, 20);
            this.TemplateJson.TabIndex = 8;
            // 
            // Confirm
            // 
            this.Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Confirm.Location = new System.Drawing.Point(12, 605);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 10;
            this.Confirm.Text = "OK";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.OnConfirmSettings);
            // 
            // SetJson
            // 
            this.SetJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetJson.Location = new System.Drawing.Point(369, 88);
            this.SetJson.Name = "SetJson";
            this.SetJson.Size = new System.Drawing.Size(96, 23);
            this.SetJson.TabIndex = 11;
            this.SetJson.Text = "Apply Template";
            this.SetJson.UseVisualStyleBackColor = true;
            this.SetJson.Click += new System.EventHandler(this.OnApplyTemplate);
            // 
            // Apply
            // 
            this.Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Apply.Location = new System.Drawing.Point(93, 605);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 12;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.OnApplySettings);
            // 
            // TemplateTableView
            // 
            this.TemplateTableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TemplateTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VarName,
            this.VarValue});
            this.TemplateTableView.Location = new System.Drawing.Point(3, 23);
            this.TemplateTableView.Name = "TemplateTableView";
            this.TemplateTableView.Size = new System.Drawing.Size(263, 430);
            this.TemplateTableView.TabIndex = 13;
            // 
            // VarName
            // 
            this.VarName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VarName.HeaderText = "Var Name";
            this.VarName.Name = "VarName";
            this.VarName.ReadOnly = true;
            this.VarName.Width = 79;
            // 
            // VarValue
            // 
            this.VarValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VarValue.HeaderText = "Current Value";
            this.VarValue.Name = "VarValue";
            this.VarValue.ReadOnly = true;
            this.VarValue.Width = 96;
            // 
            // TagsLabel
            // 
            this.TagsLabel.AutoSize = true;
            this.TagsLabel.Location = new System.Drawing.Point(3, 7);
            this.TagsLabel.Name = "TagsLabel";
            this.TagsLabel.Size = new System.Drawing.Size(64, 13);
            this.TagsLabel.TabIndex = 14;
            this.TagsLabel.Text = "Global Tags";
            // 
            // TemplateLabel
            // 
            this.TemplateLabel.AutoSize = true;
            this.TemplateLabel.Location = new System.Drawing.Point(3, 7);
            this.TemplateLabel.Name = "TemplateLabel";
            this.TemplateLabel.Size = new System.Drawing.Size(50, 13);
            this.TemplateLabel.TabIndex = 15;
            this.TemplateLabel.Text = "Variables";
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(553, 605);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // InfluxUser
            // 
            this.InfluxUser.Location = new System.Drawing.Point(12, 64);
            this.InfluxUser.Name = "InfluxUser";
            this.InfluxUser.Size = new System.Drawing.Size(171, 20);
            this.InfluxUser.TabIndex = 17;
            // 
            // InfluxPassword
            // 
            this.InfluxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfluxPassword.Location = new System.Drawing.Point(189, 64);
            this.InfluxPassword.Name = "InfluxPassword";
            this.InfluxPassword.Size = new System.Drawing.Size(276, 20);
            this.InfluxPassword.TabIndex = 18;
            this.InfluxPassword.UseSystemPasswordChar = true;
            // 
            // InfluxLoginLabel
            // 
            this.InfluxLoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfluxLoginLabel.AutoSize = true;
            this.InfluxLoginLabel.Location = new System.Drawing.Point(469, 67);
            this.InfluxLoginLabel.Name = "InfluxLoginLabel";
            this.InfluxLoginLabel.Size = new System.Drawing.Size(86, 13);
            this.InfluxLoginLabel.TabIndex = 19;
            this.InfluxLoginLabel.Text = "User / Password";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 459);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TagsTableView);
            this.splitContainer1.Panel1.Controls.Add(this.TagsLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TemplateTableView);
            this.splitContainer1.Panel2.Controls.Add(this.TemplateLabel);
            this.splitContainer1.Size = new System.Drawing.Size(616, 456);
            this.splitContainer1.SplitterDistance = 343;
            this.splitContainer1.TabIndex = 0;
            // 
            // InfluxSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfluxLoginLabel);
            this.Controls.Add(this.InfluxPassword);
            this.Controls.Add(this.InfluxUser);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.SetJson);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.TemplateJsonLabel);
            this.Controls.Add(this.TemplateJson);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.InfluxEnabled);
            this.Controls.Add(this.DatabaseLabel);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.Url);
            this.Name = "InfluxSettings";
            this.Text = "InfluxDB Settings";
            ((System.ComponentModel.ISupportInitialize)(this.TagsTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemplateTableView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Url;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.TextBox Database;
        private System.Windows.Forms.CheckBox InfluxEnabled;
        private Aga.Controls.NumericTextBox Interval;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.DataGridView TagsTableView;
        private System.Windows.Forms.Label TemplateJsonLabel;
        private System.Windows.Forms.TextBox TemplateJson;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button SetJson;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagValue;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.DataGridView TemplateTableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarValue;
        private System.Windows.Forms.Label TagsLabel;
        private System.Windows.Forms.Label TemplateLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox InfluxUser;
        private System.Windows.Forms.TextBox InfluxPassword;
        private System.Windows.Forms.Label InfluxLoginLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}