using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlayBook
{
    public partial class AddOperation_Activity : Form
    {
        DateTime selectedDate = DateTime.Now;
        ExpenseTrackerDatabase database;
        Main_Activity formMain;
        public AddOperation_Activity(ExpenseTrackerDatabase db, Main_Activity form)
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.database = db;
            this.formMain = form;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dateTimePicker1.Value;
        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNameOp.Text) && !string.IsNullOrEmpty(textBoxCommentOp.Text)
    && !string.IsNullOrEmpty(textBoxSumOp.Text) && !string.IsNullOrEmpty(comboBox1.Text))
            {
                if (!textBoxSumOp.Text.Any(char.IsLetter) && !textBoxSumOp.Text.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
                {
                    string name = textBoxNameOp.Text;
                    double sum = Convert.ToDouble(textBoxSumOp.Text);
                    string category = comboBox1.Text;
                    string comment = textBoxCommentOp.Text;
                    database.InsertExpense(name, sum, category, selectedDate, comment);
                    MessageBox.Show("Успешно");
                    formMain.CountExpenses();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Введите корректную сумму!");
                }
            }
            else
            {
                MessageBox.Show("Заполните все данные!");
            }
        }
    }
}
