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
    public partial class CategoryBreakdownForm : Form
    {
        public CategoryBreakdownForm()
        {
            InitializeComponent();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            updateReport();
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            updateReport();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateReport()
        {
            categoryBreakdownTableAdapter.Fill(this.myMoneyDataSet.CategoryBreakdown, startDateTimePicker.Value, endDateTimePicker.Value);
        }

        private void CategoryBreakdownForm_Load(object sender, EventArgs e)
        {
            // Set the datetimepicker initial dates (1st and last day of the current month/year).
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            startDateTimePicker.Value = firstDayOfMonth;
            endDateTimePicker.Value = lastDayOfMonth;

            // Update the report
            updateReport();
        }
    }
}
