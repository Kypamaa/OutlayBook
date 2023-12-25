using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace OutlayBook
{
    public partial class Main_Activity : Form
    {
        ExpenseTrackerDatabase db;
        public Main_Activity()
        {
            InitializeComponent();
            string projectPath = "C:\\Users\\Kypama\\Desktop\\OutlayBook\\ExpensesDatabase.db";
            db = new ExpenseTrackerDatabase(projectPath);
            db.CreateExpenseTable();
            CountExpenses();
        }

        public void CountExpenses()
        {
            flowLayoutPanel1.Controls.Clear();
            label2.Text = db.CalculateExpensesLast30Days().ToString();
            List<string> lastNExpenses = db.GetLastNExpenses(7);

            foreach (string expense in lastNExpenses)
            {
                Debug.WriteLine(expense);
                Label label = new Label
                {
                    AutoSize = true,
                    ForeColor = Color.Green,
                    Font = label3.Font,
                    Text = expense
                };
                flowLayoutPanel1.Controls.Add(label);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchOperation_Activity search = new SearchOperation_Activity(db);
            search.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOperation_Activity add = new AddOperation_Activity(db, this);
            add.Show();
        }
    }
}
