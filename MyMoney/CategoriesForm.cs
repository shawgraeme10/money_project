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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myMoneyDataSet.CategoriesHits' table. You can move, or remove it, as needed.
            this.categoriesHitsTableAdapter.Fill(this.myMoneyDataSet.CategoriesHits);
            

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoriesHitsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesHitsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myMoneyDataSet);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // DeleteItem in properties must be set to none, otherwise this will delete after
            // the DeleteItem event is fired and will remove the wrong item in the DataGridView.

            if (categoriesHitsDataGridView.CurrentRow.Index >= 0)
            {
                
                string categoryName = categoriesHitsDataGridView.CurrentRow.Cells[1].Value.ToString();
                int hits = 0;
                int.TryParse(categoriesHitsDataGridView.CurrentRow.Cells[4].Value.ToString(), out hits);

                if (hits > 0)
                    MessageBox.Show(categoryName + " category is in use and may not be deleted.", "Delete Category");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Delete " + categoryName + "?", "Delete Category", MessageBoxButtons.YesNo))
                    {
                        categoriesHitsBindingSource.RemoveCurrent();
                        categoriesHitsTableAdapter.Update(myMoneyDataSet.CategoriesHits);
                    }
                }
            }
        }
    }
}
