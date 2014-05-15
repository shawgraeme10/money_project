namespace MyMoney
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.balanceToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.registerDataGridView = new System.Windows.Forms.DataGridView();
            this.registerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerIdentifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDebitDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.registerCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myMoneyDataSet = new MyMoney.MyMoneyDataSet();
            this.addButton = new System.Windows.Forms.Button();
            this.noteLabel = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.identifierTextBox = new System.Windows.Forms.TextBox();
            this.identifierLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.categoriesTableAdapter = new MyMoney.MyMoneyDataSetTableAdapters.CategoriesTableAdapter();
            this.registerCategoryTableAdapter = new MyMoney.MyMoneyDataSetTableAdapters.RegisterCategoryTableAdapter();
            this.registerTableAdapter = new MyMoney.MyMoneyDataSetTableAdapters.RegisterTableAdapter();
            this.registerContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMoneyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.registerContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(738, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.categoriesToolStripMenuItem.Text = "Categories...";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.categoryToolStripMenuItem.Text = "Category...";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 369);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(738, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // balanceToolStripStatusLabel
            // 
            this.balanceToolStripStatusLabel.Name = "balanceToolStripStatusLabel";
            this.balanceToolStripStatusLabel.Size = new System.Drawing.Size(107, 17);
            this.balanceToolStripStatusLabel.Text = "balance goes here...";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.registerDataGridView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.addButton);
            this.splitContainer.Panel2.Controls.Add(this.noteLabel);
            this.splitContainer.Panel2.Controls.Add(this.noteTextBox);
            this.splitContainer.Panel2.Controls.Add(this.categoryComboBox);
            this.splitContainer.Panel2.Controls.Add(this.categoryLabel);
            this.splitContainer.Panel2.Controls.Add(this.amountTextBox);
            this.splitContainer.Panel2.Controls.Add(this.amountLabel);
            this.splitContainer.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer.Panel2.Controls.Add(this.descriptionLabel);
            this.splitContainer.Panel2.Controls.Add(this.identifierTextBox);
            this.splitContainer.Panel2.Controls.Add(this.identifierLabel);
            this.splitContainer.Panel2.Controls.Add(this.dateTimePicker);
            this.splitContainer.Panel2.Controls.Add(this.dateLabel);
            this.splitContainer.Size = new System.Drawing.Size(738, 345);
            this.splitContainer.SplitterDistance = 246;
            this.splitContainer.TabIndex = 2;
            // 
            // registerDataGridView
            // 
            this.registerDataGridView.AllowUserToAddRows = false;
            this.registerDataGridView.AllowUserToDeleteRows = false;
            this.registerDataGridView.AutoGenerateColumns = false;
            this.registerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.registerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerIDDataGridViewTextBoxColumn,
            this.registerDateTimeDataGridViewTextBoxColumn,
            this.registerIdentifierDataGridViewTextBoxColumn,
            this.registerAmountDataGridViewTextBoxColumn,
            this.registerDescriptionDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.registerNoteDataGridViewTextBoxColumn,
            this.isDebitDataGridViewCheckBoxColumn});
            this.registerDataGridView.DataSource = this.registerCategoryBindingSource;
            this.registerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.registerDataGridView.MultiSelect = false;
            this.registerDataGridView.Name = "registerDataGridView";
            this.registerDataGridView.ReadOnly = true;
            this.registerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registerDataGridView.Size = new System.Drawing.Size(738, 246);
            this.registerDataGridView.TabIndex = 0;
            this.registerDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.registerDataGridView_CellMouseDown);
            // 
            // registerIDDataGridViewTextBoxColumn
            // 
            this.registerIDDataGridViewTextBoxColumn.DataPropertyName = "registerID";
            this.registerIDDataGridViewTextBoxColumn.HeaderText = "registerID";
            this.registerIDDataGridViewTextBoxColumn.Name = "registerIDDataGridViewTextBoxColumn";
            this.registerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.registerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // registerDateTimeDataGridViewTextBoxColumn
            // 
            this.registerDateTimeDataGridViewTextBoxColumn.DataPropertyName = "registerDateTime";
            this.registerDateTimeDataGridViewTextBoxColumn.HeaderText = "Date";
            this.registerDateTimeDataGridViewTextBoxColumn.Name = "registerDateTimeDataGridViewTextBoxColumn";
            this.registerDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registerIdentifierDataGridViewTextBoxColumn
            // 
            this.registerIdentifierDataGridViewTextBoxColumn.DataPropertyName = "registerIdentifier";
            this.registerIdentifierDataGridViewTextBoxColumn.HeaderText = "ID";
            this.registerIdentifierDataGridViewTextBoxColumn.Name = "registerIdentifierDataGridViewTextBoxColumn";
            this.registerIdentifierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registerAmountDataGridViewTextBoxColumn
            // 
            this.registerAmountDataGridViewTextBoxColumn.DataPropertyName = "registerAmount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.registerAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.registerAmountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.registerAmountDataGridViewTextBoxColumn.Name = "registerAmountDataGridViewTextBoxColumn";
            this.registerAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registerDescriptionDataGridViewTextBoxColumn
            // 
            this.registerDescriptionDataGridViewTextBoxColumn.DataPropertyName = "registerDescription";
            this.registerDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.registerDescriptionDataGridViewTextBoxColumn.Name = "registerDescriptionDataGridViewTextBoxColumn";
            this.registerDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registerNoteDataGridViewTextBoxColumn
            // 
            this.registerNoteDataGridViewTextBoxColumn.DataPropertyName = "registerNote";
            this.registerNoteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.registerNoteDataGridViewTextBoxColumn.Name = "registerNoteDataGridViewTextBoxColumn";
            this.registerNoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDebitDataGridViewCheckBoxColumn
            // 
            this.isDebitDataGridViewCheckBoxColumn.DataPropertyName = "isDebit";
            this.isDebitDataGridViewCheckBoxColumn.HeaderText = "isDebit";
            this.isDebitDataGridViewCheckBoxColumn.Name = "isDebitDataGridViewCheckBoxColumn";
            this.isDebitDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDebitDataGridViewCheckBoxColumn.Visible = false;
            // 
            // registerCategoryBindingSource
            // 
            this.registerCategoryBindingSource.DataMember = "RegisterCategory";
            this.registerCategoryBindingSource.DataSource = this.myMoneyDataSet;
            // 
            // myMoneyDataSet
            // 
            this.myMoneyDataSet.DataSetName = "MyMoneyDataSet";
            this.myMoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(654, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(61, 20);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(140, 61);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(30, 13);
            this.noteLabel.TabIndex = 11;
            this.noteLabel.Text = "Note";
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(180, 48);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteTextBox.Size = new System.Drawing.Size(446, 44);
            this.noteTextBox.TabIndex = 4;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoriesBindingSource;
            this.categoryComboBox.DisplayMember = "categoryName";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(518, 21);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(108, 21);
            this.categoryComboBox.TabIndex = 3;
            this.categoryComboBox.ValueMember = "categoryID";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.myMoneyDataSet;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(515, 4);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Category";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(445, 21);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(66, 20);
            this.amountTextBox.TabIndex = 2;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(442, 4);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "Amount";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(180, 21);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(255, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(177, 4);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description";
            // 
            // identifierTextBox
            // 
            this.identifierTextBox.Location = new System.Drawing.Point(107, 21);
            this.identifierTextBox.Name = "identifierTextBox";
            this.identifierTextBox.Size = new System.Drawing.Size(63, 20);
            this.identifierTextBox.TabIndex = 3;
            // 
            // identifierLabel
            // 
            this.identifierLabel.AutoSize = true;
            this.identifierLabel.Location = new System.Drawing.Point(107, 4);
            this.identifierLabel.Name = "identifierLabel";
            this.identifierLabel.Size = new System.Drawing.Size(18, 13);
            this.identifierLabel.TabIndex = 2;
            this.identifierLabel.Text = "ID";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(16, 21);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(13, 4);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // registerCategoryTableAdapter
            // 
            this.registerCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // registerContextMenuStrip
            // 
            this.registerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.registerContextMenuStrip.Name = "registerContextMenuStrip";
            this.registerContextMenuStrip.Size = new System.Drawing.Size(106, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 391);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Money";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMoneyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.registerContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel balanceToolStripStatusLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView registerDataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox identifierTextBox;
        private System.Windows.Forms.Label identifierLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Button addButton;
        private MyMoneyDataSet myMoneyDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private MyMoneyDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource registerCategoryBindingSource;
        private MyMoneyDataSetTableAdapters.RegisterCategoryTableAdapter registerCategoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerIdentifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDebitDataGridViewCheckBoxColumn;
        private MyMoneyDataSetTableAdapters.RegisterTableAdapter registerTableAdapter;
        private System.Windows.Forms.ContextMenuStrip registerContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

