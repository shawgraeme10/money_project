namespace MyMoney
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            this.categoriesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.categoriesHitsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesHitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myMoneyDataSet = new MyMoney.MyMoneyDataSet();
            this.closeButton = new System.Windows.Forms.Button();
            this.categoriesHitsTableAdapter = new MyMoney.MyMoneyDataSetTableAdapters.CategoriesHitsTableAdapter();
            this.tableAdapterManager = new MyMoney.MyMoneyDataSetTableAdapters.TableAdapterManager();
            this.categoriesHitsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriesHitsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesSplitContainer)).BeginInit();
            this.categoriesSplitContainer.Panel1.SuspendLayout();
            this.categoriesSplitContainer.Panel2.SuspendLayout();
            this.categoriesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesHitsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesHitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMoneyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesHitsBindingNavigator)).BeginInit();
            this.categoriesHitsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesSplitContainer
            // 
            this.categoriesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.categoriesSplitContainer.Name = "categoriesSplitContainer";
            this.categoriesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // categoriesSplitContainer.Panel1
            // 
            this.categoriesSplitContainer.Panel1.AutoScroll = true;
            this.categoriesSplitContainer.Panel1.Controls.Add(this.categoriesHitsDataGridView);
            // 
            // categoriesSplitContainer.Panel2
            // 
            this.categoriesSplitContainer.Panel2.Controls.Add(this.closeButton);
            this.categoriesSplitContainer.Size = new System.Drawing.Size(443, 343);
            this.categoriesSplitContainer.SplitterDistance = 266;
            this.categoriesSplitContainer.TabIndex = 0;
            // 
            // categoriesHitsDataGridView
            // 
            this.categoriesHitsDataGridView.AutoGenerateColumns = false;
            this.categoriesHitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesHitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.categoriesHitsDataGridView.DataSource = this.categoriesHitsBindingSource;
            this.categoriesHitsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesHitsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.categoriesHitsDataGridView.Name = "categoriesHitsDataGridView";
            this.categoriesHitsDataGridView.Size = new System.Drawing.Size(443, 266);
            this.categoriesHitsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "categoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "categoryID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "categoryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "categoryDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "isDebit";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Debit";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Hits";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hits";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // categoriesHitsBindingSource
            // 
            this.categoriesHitsBindingSource.DataMember = "CategoriesHits";
            this.categoriesHitsBindingSource.DataSource = this.myMoneyDataSet;
            // 
            // myMoneyDataSet
            // 
            this.myMoneyDataSet.DataSetName = "MyMoneyDataSet";
            this.myMoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(184, 18);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // categoriesHitsTableAdapter
            // 
            this.categoriesHitsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesHitsTableAdapter = this.categoriesHitsTableAdapter;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.RegisterTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyMoney.MyMoneyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriesHitsBindingNavigator
            // 
            this.categoriesHitsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoriesHitsBindingNavigator.BindingSource = this.categoriesHitsBindingSource;
            this.categoriesHitsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoriesHitsBindingNavigator.DeleteItem = null;
            this.categoriesHitsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categoriesHitsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.categoriesHitsBindingNavigatorSaveItem});
            this.categoriesHitsBindingNavigator.Location = new System.Drawing.Point(0, 318);
            this.categoriesHitsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoriesHitsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoriesHitsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoriesHitsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoriesHitsBindingNavigator.Name = "categoriesHitsBindingNavigator";
            this.categoriesHitsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoriesHitsBindingNavigator.Size = new System.Drawing.Size(443, 25);
            this.categoriesHitsBindingNavigator.TabIndex = 1;
            this.categoriesHitsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // categoriesHitsBindingNavigatorSaveItem
            // 
            this.categoriesHitsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriesHitsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriesHitsBindingNavigatorSaveItem.Image")));
            this.categoriesHitsBindingNavigatorSaveItem.Name = "categoriesHitsBindingNavigatorSaveItem";
            this.categoriesHitsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.categoriesHitsBindingNavigatorSaveItem.Text = "Save Data";
            this.categoriesHitsBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriesHitsBindingNavigatorSaveItem_Click);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 343);
            this.Controls.Add(this.categoriesHitsBindingNavigator);
            this.Controls.Add(this.categoriesSplitContainer);
            this.Name = "CategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            this.categoriesSplitContainer.Panel1.ResumeLayout(false);
            this.categoriesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesSplitContainer)).EndInit();
            this.categoriesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesHitsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesHitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMoneyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesHitsBindingNavigator)).EndInit();
            this.categoriesHitsBindingNavigator.ResumeLayout(false);
            this.categoriesHitsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer categoriesSplitContainer;
        private System.Windows.Forms.Button closeButton;
        private MyMoneyDataSet myMoneyDataSet;
        private System.Windows.Forms.BindingSource categoriesHitsBindingSource;
        private MyMoneyDataSetTableAdapters.CategoriesHitsTableAdapter categoriesHitsTableAdapter;
        private MyMoneyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoriesHitsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton categoriesHitsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView categoriesHitsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}