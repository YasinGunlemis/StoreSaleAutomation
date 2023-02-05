using Business;
using DataAccess.Concrete;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp;
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
    public partial class FrmPersons : Form
    {
        CustomerManager customerManager;
        PersonnelManager personnelManager;
        Customer customer;
        string oldTrId;

        public FrmPersons()
        {
            InitializeComponent();
            customerManager = CustomerManager.GetInstance();
            personnelManager = PersonnelManager.GetInstance();
        }

        private void FrmPersons_Load(object sender, EventArgs e)
        {
            CustomerDatas();
            FillComboProvince();
            Clear();
        }

        void CustomerDatas()
        {
            gridControl1.DataSource = customerManager.GetDataTable();
            gridView1.Columns["ID"].Visible = false;
        }
        void FillComboProvince()
        {
            DataRow row1;
            DataTable dataTable;
            CmbProvince.ValueMember = "ID";
            CmbProvince.DisplayMember = "SEHIRADI";
            dataTable = personnelManager.GetProvince();
            CmbProvince.DataSource = dataTable;
            row1 = dataTable.NewRow();
            row1["SEHIRADI"] = "Please select bellow..."; //insert a blank row - you can even write something like  = "Please select bellow...";
            dataTable.Rows.InsertAt(row1, 0); //insert new to to index 0 (on top)
            CmbProvince.SelectedIndex = 0;
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
            dataTable.Rows.InsertAt(row1, 0); //insert new to to index 0 (on top)
            row1["ILCEADI"] = "Please select bellow..."; //insert a blank row - you can even write something like  = "Please select bellow...";
            CmbDistrict.SelectedIndex = 0;
        }
        void Clear()
        {
            LblId.Text = "";
            TxtName.Text = "";
            TxtSurname.Text = "";
            TxtEmail.Text = "";
            MskPhone1.Text = "";
            MskPhone2.Text = "";
            MskTrId.Text = "";
            RchAdress.Text = "";
            CmbProvince.SelectedIndex = 0;
            CmbDistrict.SelectedIndex = 0;
        }
        private void BttnSave_Click(object sender, EventArgs e)
        {
            customer = new Customer(MskTrId.Text, TxtName.Text, TxtSurname.Text, MskPhone1.Text, MskPhone2.Text, TxtEmail.Text, CmbProvince.Text, CmbDistrict.Text, RchAdress.Text);
            string result = customerManager.Add(customer);
            if (!result.Contains("Success"))
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CustomerDatas();
            Clear();
        }

        private void BttnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BttnUpdate_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "-" || LblId.Text == "") return;

            customer = new Customer(LblId.Text.ConInt(), MskTrId.Text, TxtName.Text, TxtSurname.Text, MskPhone1.Text, MskPhone2.Text, TxtEmail.Text, CmbProvince.Text, CmbDistrict.Text, RchAdress.Text, oldTrId);

            string result = customerManager.Update(customer);
            if (!result.Contains("Success"))
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CustomerDatas();
            Clear();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            LblId.Text = dataRow["ID"].ToString();
            TxtName.Text = dataRow["NAME"].ToString();
            TxtSurname.Text = dataRow["SURNAME"].ToString();
            TxtEmail.Text = dataRow["EMAIL"].ToString();
            MskPhone1.Text = dataRow["PHONE1"].ToString();
            MskPhone2.Text = dataRow["PHONE2"].ToString();
            oldTrId = dataRow["TR_ID"].ToString();
            MskTrId.Text = oldTrId;
            RchAdress.Text = dataRow["ADRESS"].ToString();
            CmbProvince.Text = dataRow["PROVINCE"].ToString();
            CmbDistrict.Text = dataRow["DISTRICT"].ToString();
        }

        private void BttnDelete_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "-" || LblId.Text == "") return;

            DialogResult dr = MessageBox.Show("Are you sure you want to permanently delete this person", "Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                customerManager.Delete(LblId.Text.ConInt());
            }
            CustomerDatas();
            Clear();
        }
    }
}
