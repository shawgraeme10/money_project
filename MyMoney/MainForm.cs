using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMoney
{
    /* MyMoney is an application that presents a register that the user can record income and expenses with. Each entry has a
     * category that is a credit or a debit and categories can be defined in a separate menu option. Entries can be deleted and
     * a total balance is also shown.
     */
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CategoriesForm categoriesForm = new CategoriesForm())
            {
                categoriesForm.ShowDialog();
            }
            updateCategoryDropdown();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CategoryBreakdownForm categoryBreakdownForm = new CategoryBreakdownForm())
            {
                categoryBreakdownForm.ShowDialog();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Get Category
            int categoryID = Convert.ToInt32(categoryComboBox.SelectedValue);

            // Get amount
            decimal amount = 0.0m;
            decimal.TryParse(amountTextBox.Text, out amount);

            // determine if category is a debit, and adjust amount sign accordingly
            bool? isDebit = categoriesTableAdapter.IsCategoryDebit(categoryID);
            if (!isDebit.HasValue) 
                isDebit = false;
            amount = Math.Abs(amount);
            if (isDebit.Value == true)
                amount *= -1.0m;


            //Get date
            DateTime date;
            DateTime.TryParse(dateTimePicker.Value.ToShortDateString(), out date);

            try
            {
                // Perform insert
                registerTableAdapter.Insert(
                    categoryID,
                    string.IsNullOrWhiteSpace(identifierTextBox.Text) ? null : identifierTextBox.Text,
                    string.IsNullOrWhiteSpace(descriptionTextBox.Text) ? null : descriptionTextBox.Text,
                    string.IsNullOrWhiteSpace(noteTextBox.Text) ? null : noteTextBox.Text,
                    amount,
                    date);

                // Refresh dataset from database
                registerCategoryTableAdapter.Fill(myMoneyDataSet.RegisterCategory);

                // Clear add controls
                identifierTextBox.Text = "";
                descriptionTextBox.Text = "";
                amountTextBox.Text = "";
                noteTextBox.Text = "";

                updateBalance();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Please ensure you have filled in the Description, and Amount", "Warning: Missing items");
            }

        }

        private void updateBalance()
        {
            
            try
            {
                decimal? balance = registerTableAdapter.GetBalance();
                balanceToolStripStatusLabel.Text = string.Format("Balance: {0:C}", balance); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Getting Balance");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myMoneyDataSet.RegisterCategory' table. You can move, or remove it, as needed.
            this.registerCategoryTableAdapter.Fill(this.myMoneyDataSet.RegisterCategory);
            updateCategoryDropdown();
            updateBalance();
        }

        private void updateCategoryDropdown()
        {
            string displayMember = categoryComboBox.DisplayMember;
            string valueMember = categoryComboBox.ValueMember;
            categoryComboBox.DataSource = null;
            this.categoriesTableAdapter.Fill(this.myMoneyDataSet.Categories);
            categoryComboBox.DataSource = categoriesBindingSource;
            categoryComboBox.DisplayMember = displayMember;
            categoryComboBox.ValueMember = valueMember;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (registerDataGridView.CurrentRow.Index >= 0)
            {
                string registerIDString = registerDataGridView.Rows[registerDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
                int registerID = -1;
                if (int.TryParse(registerIDString, out registerID))
                {
                    if (DialogResult.Yes == MessageBox.Show("Delete row " + registerDataGridView.CurrentRow.Index + " ?", "Delete Entry", MessageBoxButtons.YesNo))
                    {
                        registerTableAdapter.Delete(registerID);
                        registerCategoryTableAdapter.Fill(myMoneyDataSet.RegisterCategory);
                        updateBalance();
                    }
                }
            }
        }

        private void registerDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                    registerDataGridView.CurrentCell = registerDataGridView.Rows[e.RowIndex].Cells[1];

                Point mousePoint = registerDataGridView.PointToClient(Cursor.Position);
                DataGridView.HitTestInfo hitTestInfo = registerDataGridView.HitTest(mousePoint.X, mousePoint.Y);
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                    registerContextMenuStrip.Show(registerDataGridView, mousePoint);
            }
        }
    }
}
