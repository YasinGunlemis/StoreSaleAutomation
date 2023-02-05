using Business;
using DataAccess.Concrete;
using DevExpress.XtraEditors;
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
    public partial class FrmCmpnyBnkAccnts : Form
    {
        BankManager bankManager;
        PersonnelManager personnelManager;
        CompanyManager companyManager;
        Bank bank;
        string oldAccountNo;
        public FrmCmpnyBnkAccnts()
        {
            InitializeComponent();
            personnelManager = PersonnelManager.GetInstance();
            companyManager = CompanyManager.GetInstance();
            bankManager = BankManager.GetInstance();
        }
        private void FrmCmpnyBnkAccnts_Load(object sender, EventArgs e)
        {
            CompanyBankDatas();
            FillCombos();
            //multiCombo();
            Clear();
        }

        private void BttnSave_Click(object sender, EventArgs e)
        {
            bank = new Bank(TxtBank.Text, CmbProvince.Text, CmbDistrict.Text, TxtBranch.Text, MskIban.Text, TxtAccountNo.Text, TxtAuthPerson.Text, MskPhone1.Text, DatePick.Text, LblSelectedValue.Text.ConInt());
            string result = bankManager.Add(bank);
            if (!result.Contains("Success"))
            {
                MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CompanyBankDatas();
            Clear();
        }
        private void BttnUpdate_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "-" || LblId.Text == "") return;
            bank = new Bank(LblId.Text.ConInt(), TxtBank.Text, CmbProvince.Text, CmbDistrict.Text, TxtBranch.Text, MskIban.Text, TxtAccountNo.Text, TxtAuthPerson.Text, MskPhone1.Text, DatePick.Text, LblSelectedValue.Text.ConInt(), oldAccountNo);
            string result = bankManager.Update(bank);
            if (!result.Contains("Success"))
            {
                MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CompanyBankDatas();
            Clear();
        }
        private void BttnDelete_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "-" || LblId.Text == "") return;
            if (MessageBox.Show("Are you sure you want to permanently delete this bank infos?", "Delete Bank Infos", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                MessageBox.Show(bankManager.Delete(LblId.Text.ConInt()), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CompanyBankDatas();
            }
        }
        private void BttnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void CompanyBankDatas()
        {
            gridControl1.DataSource = bankManager.GetDataTable();
            gridView1.Columns["ID"].Width = 20;
            gridView1.Columns["PROVINCE"].Width = 50;
            gridView1.Columns["DISTRICT"].Width = 50;
            gridView1.Columns["AUTHORIZED"].Width = 60;
            gridView1.Columns["PHONE"].Width = 60;
            gridView1.Columns["BRANCH"].Width = 60;
            gridView1.Columns["COMPANY"].Width = 120;
            gridView1.Columns["IBAN"].Width = 120;
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            LblId.Text = dataRow["ID"].ToString();
            DatePick.Text = dataRow["DATE"].ToString();
            MskIban.Text = dataRow["IBAN"].ToString();
            MskPhone1.Text = dataRow["PHONE"].ToString();
            TxtBranch.Text = dataRow["BRANCH"].ToString();
            TxtBank.Text = dataRow["BANK"].ToString();
            oldAccountNo = dataRow["ACCOUNTNO"].ToString();
            TxtAccountNo.Text = oldAccountNo;
            TxtAuthPerson.Text = dataRow["AUTHORIZED"].ToString();
            CmbCompany.Text = dataRow["COMPANY"].ToString();
            CmbProvince.Text = dataRow["PROVINCE"].ToString();
            CmbDistrict.Text = dataRow["DISTRICT"].ToString();
        }
        void FillCombos()
        {
            DataRow row1;
            DataTable dataTable1;
            CmbProvince.ValueMember = "ID";
            CmbProvince.DisplayMember = "SEHIRADI";
            dataTable1 = personnelManager.GetProvince();
            CmbProvince.DataSource = dataTable1;
            row1 = dataTable1.NewRow();
            row1["SEHIRADI"] = "Please select bellow..."; //insert a blank row - you can even write something like  = "Please select bellow...";
            dataTable1.Rows.InsertAt(row1, 0); //insert new to to index 0 (on top=
            CmbProvince.SelectedIndex = 0;

            DataRow row2;
            DataTable dataTable2;
            CmbCompany.ValueMember = "ID";
            CmbCompany.DisplayMember = "COMPANY";
            dataTable2 = companyManager.GetCompanyNames();
            CmbCompany.DataSource = dataTable2;
            row2 = dataTable2.NewRow();
            row2["COMPANY"] = "Please select company..."; //insert a blank row - you can even write something like  = "Please select bellow...";
            dataTable2.Rows.InsertAt(row2, 0); //insert new to to index 0 (on top=
            CmbCompany.SelectedIndex = 0;
        }
        private void CmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow row1;
            DataTable dataTable;
            CmbDistrict.ValueMember = "ID";
            CmbDistrict.DisplayMember = "ILCEADI";
            dataTable = personnelManager.GetDistrict(CmbProvince.SelectedIndex);
            CmbDistrict.DataSource = dataTable;
            row1 = dataTable.NewRow();
            dataTable.Rows.InsertAt(row1, 0); //insert new to to index 0 (on top=
            row1["ILCEADI"] = "Please select bellow..."; //insert a blank row - you can even write something like  = "Please select bellow...";
            CmbDistrict.SelectedIndex = 0;

        }
        private void CmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblSelectedValue.Text = CmbCompany.SelectedValue.ToString();
            if (CmbCompany.SelectedIndex == 0)
            {
                TxtAuthPerson.Text = "";
            }
            if (LblSelectedValue.Text != "")
            {
                TxtAuthPerson.Text = companyManager.AuthName(LblSelectedValue.Text.ConInt());
            }
        }
        private void MskIban_TextChanged(object sender, EventArgs e)
        {
            string word;
            word = MskIban.Text.Substring(23);
            TxtAccountNo.Text = word.Replace(" ", string.Empty);
        }
        void Clear()
        {
            CmbCompany.SelectedIndex = 0;
            CmbProvince.SelectedIndex = 0;
            CmbDistrict.SelectedIndex = 0;
            TxtBank.Text = "";
            TxtBranch.Text = "";
            TxtAccountNo.Text = "";
            TxtAuthPerson.Text = "";
            TxtAccountNo.Text = "";
            MskIban.Text = "";
            MskPhone1.Text = "";
            DatePick.Text = "";
            LblSelectedValue.Text = "";
            LblId.Text = "";
        }

        void multiCombo()
        {
            DataTable dt;
            dt = personnelManager.GetProvince();
            //dt.Columns.Add("SEHIRADI",typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                checkedComboBoxEdit1.Properties.Items.Add(row["SEHIRADI"]);
            }
            //CmbProvince.DisplayMember = "SEHIRADI";
            //CmbProvince.DataSource = dataTable1;
            //row1 = dt.NewRow();
            //row1["SEHIRADI"] = "Please select bellow..."; //insert a blank row - you can even write something like  = "Please select bellow...";
            //dt.Rows.InsertAt(row1, 0); //insert new to to index 0 (on top=
            //checkedComboBoxEdit1.SelectionStart = 0;
        }
    }
}
