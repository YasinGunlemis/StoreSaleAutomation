using Business;
using DataAccess.Concrete;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraPrinting;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Store
{
    public partial class FrmExpenses : Form
    {
        ExpenseManager expenseManager;
        Expense expense;
        decimal totalExpense = 0;
        string yearMonth;
        public FrmExpenses()
        {
            InitializeComponent();
            expenseManager = ExpenseManager.GetInstance();
        }

        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            ExpenseDatas();
            Clear();
        }

        void SumExpense()
        {
            totalExpense = TxtElectric.Text.ConDec() + TxtWater.Text.ConDec() + TxtGas.Text.ConDec() + TxtInternet.Text.ConDec() + TxtSalaries.Text.ConDec() + TxtExtraExpense.Text.ConDec();
            LblTotalExpense.Text = totalExpense.ToString() + " ₺";
        }

        private void TxtElectric_EditValueChanged(object sender, EventArgs e)
        {
            SumExpense();
        }

        private void TxtWater_EditValueChanged(object sender, EventArgs e)
        {
            SumExpense();
        }

        private void TxtGas_EditValueChanged(object sender, EventArgs e)
        {
            SumExpense();
        }

        private void TxtInternet_EditValueChanged(object sender, EventArgs e)
        {
            SumExpense();
        }

        private void TxtSalaries_EditValueChanged(object sender, EventArgs e)
        {
            SumExpense();
        }

        private void TxtExtraExpense_EditValueChanged(object sender, EventArgs e)
        {
            SumExpense();
        }

        void ExpenseDatas()
        {
            gridControl1.DataSource = expenseManager.GetDataTable();
            //gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.Columns["ID"].Visible = false;
            //gridView1.Columns["YEAR"].Width = 100;
            //gridView1.Columns["MONTH"].Width = 100;
            //gridView1.Columns["ELECTRIC"].Width = 100;
            //gridView1.Columns["WATER"].Width = 100;
            //gridView1.Columns["GAS"].Width = 100;
            //gridView1.Columns["INTERNET"].Width = 100;
            //gridView1.Columns["SALARIES"].Width = 100;
            //gridView1.Columns["EXTRA"].Width = 100;
            //gridView1.Columns["TOTALEXPENSE"].Width = 100;
            gridView1.Columns["EXPLANATION"].Width = 417;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            CmbYear.Text = (string)dataRow["YEAR"];
            CmbMonth.Text = (string)dataRow["MONTH"];
            LblId.Text = dataRow["ID"].ToString();
            TxtElectric.Text = dataRow["ELECTRIC"].ToString();
            TxtWater.Text = dataRow["WATER"].ToString();
            TxtGas.Text = dataRow["GAS"].ToString();
            TxtInternet.Text = dataRow["INTERNET"].ToString();
            TxtSalaries.Text = dataRow["SALARIES"].ToString();
            TxtExtraExpense.Text = dataRow["EXTRA"].ToString();
            RchExplanation.Text = dataRow["EXPLANATION"].ToString();
            LblTotalExpense.Text = dataRow["TOTALEXPENSE"].ToString() + " ₺";
            yearMonth = dataRow["YEAR"].ToString().Trim() + dataRow["MONTH"].ToString().Trim();
        }

        void Clear()
        {
            CmbYear.SelectedIndex = 0;
            CmbMonth.SelectedIndex = 0;
            LblId.Text = "";
            TxtElectric.Text = "";
            TxtWater.Text = "";
            TxtGas.Text = "";
            TxtInternet.Text = "";
            TxtSalaries.Text = "";
            TxtExtraExpense.Text = "";
            RchExplanation.Text = "";
            LblTotalExpense.Text = "";
        }

        private void BttnSave_Click(object sender, EventArgs e)
        {
            if (CmbYear.Text == "Year" || CmbMonth.Text == "Month")
            {
                MessageBox.Show("Please Select Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            expense = new Expense(CmbYear.Text.Trim(), CmbMonth.Text.Trim(), Decimal.Parse(TxtElectric.Text), Decimal.Parse(TxtWater.Text), Decimal.Parse(TxtGas.Text), Decimal.Parse(TxtInternet.Text), Decimal.Parse(TxtSalaries.Text), Decimal.Parse(TxtExtraExpense.Text), RchExplanation.Text, (totalExpense));
            string result = expenseManager.Add(expense);
            if (!result.Contains("Success"))
            {
                MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(result, "Entry Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ExpenseDatas();
            Clear();
        }

        private void BttnUpdate_Click(object sender, EventArgs e)
        {
            if (CmbYear.Text == "Year" || CmbMonth.Text == "Month")
            {
                MessageBox.Show("Please Select Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (LblId.Text == "-" || LblId.Text == "") return;
            expense = new Expense(LblId.Text.ConInt(), CmbYear.Text.Trim(), CmbMonth.Text.Trim(), Decimal.Parse(TxtElectric.Text), Decimal.Parse(TxtWater.Text), Decimal.Parse(TxtGas.Text), Decimal.Parse(TxtInternet.Text), Decimal.Parse(TxtSalaries.Text), Decimal.Parse(TxtExtraExpense.Text), yearMonth, RchExplanation.Text, (totalExpense));
            string result = expenseManager.Update(expense);
            if (!result.Contains("Success"))
            {
                MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(result, "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ExpenseDatas();
            Clear();
        }

        private void BttnDelete_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "-" || LblId.Text == "") return;
            DialogResult dr = MessageBox.Show("Are you sure you want to permanently delete this date expenses", "Delete Expense", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                expenseManager.Delete(LblId.Text.ConInt());
            }
            ExpenseDatas();
            Clear();
        }

        private void BttnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
