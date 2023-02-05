using Business;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Store;

namespace DataAccess.Abstract
{
    public partial class FrmCompanyDetails : Form
    {
        CompanyManager companyManager;
        PersonnelManager personnelManager;
        Company company;
        public byte[] img;
        public string oldTaxno, filename,province,distrrict;
        public FrmCompanyDetails()
        {
            InitializeComponent();
            companyManager = CompanyManager.GetInstance();
            personnelManager = PersonnelManager.GetInstance();
        }
        private void FrmCompanyDetails_Load(object sender, EventArgs e)
        {
            FillComboProvince();
            MskTaxno.Text = oldTaxno;
            CmbProvince.Text = province;
            CmbDistrict.Text = distrrict;
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
            dataTable.Rows.InsertAt(row1, 0); //insert new to to index 0 (on top=
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
            dataTable.Rows.InsertAt(row1, 0); //insert new to to index 0 (on top=
            row1["ILCEADI"] = "Please select bellow..."; //insert a blank row - you can even write something like  = "Please select bellow...";
            CmbDistrict.SelectedIndex = 0;
        }

        private void BttnChoose_Click(object sender, EventArgs e)
        {
            Pctbox1.Image = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;*.webp;";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filename = ofd.FileName;
            }
            if (filename != null)
            {
                Pctbox1.Image = Image.FromFile(filename);
            }
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
        }

        private void BttnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            Pctbox1.Image = null;
            MskTaxno.Text = "";
            TxtCompany.Text = "";
            TxtPosition.Text = "";
            TxtAuthPerson.Text = "";
            TxtSector.Text = "";
            MskPhone1.Text = "";
            MskPhone2.Text = "";
            TxtEmail.Text = "";
            MskFax.Text = "";
            CmbProvince.SelectedIndex = 0;
            CmbDistrict.SelectedIndex = 0;
            RchAdress.Text = "";
            TxtTaxOffice.Text = "";
            RchSC1.Text = "";
            RchSC2.Text = "";
            RchSC3.Text = "";
            TxtSC1.Text = "";
            TxtSC2.Text = "";
            TxtSC3.Text = "";
        }

        private void BttnUpdate_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "-" || LblId.Text == "") return;
            company = new Company(LblId.Text.ConInt(), img, MskTaxno.Text, TxtCompany.Text, TxtPosition.Text, TxtAuthPerson.Text, TxtSector.Text, MskPhone1.Text, MskPhone2.Text, TxtEmail.Text, MskFax.Text, CmbProvince.Text, CmbDistrict.Text, RchAdress.Text, TxtTaxOffice.Text, TxtSC1.Text, TxtSC2.Text, TxtSC3.Text, oldTaxno);
            string update = companyManager.Update(company);
            if (!update.Contains("Success"))
            {
                MessageBox.Show(update, "Update Company", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(update, "Update Company", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var form = (FrmCompanies)Application.OpenForms["FrmCompanies"];
            form.CompaniesDataTable();
            this.Close();
        }
    }
}
