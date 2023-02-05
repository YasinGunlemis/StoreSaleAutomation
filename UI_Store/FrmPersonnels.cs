using Business;
using DataAccess.Concrete;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors.Controls;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Store
{
    public partial class FrmPersonnels : Form
    {
        PersonnelManager personnelManager;
        Personnel personnel;
        string filename, oldTrId;
        byte[] img = null;
        public FrmPersonnels()
        {
            InitializeComponent();
            personnelManager = PersonnelManager.GetInstance();
        }
        private void FrmPersonnels_Load(object sender, EventArgs e)
        {
            personnelDataTable();
            FillComboProvince();
            Clear();
        }
        //İl combobox doldur
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
        //Seçilen ile göre ilin ilçelerini comboboxa doldur
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
        //SQL'deki tabloyu gridview'e aktar
        void personnelDataTable()
        {
            gridControl1.DataSource = personnelManager.GetDataTable();
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[10].Visible = false;
            gridView1.Columns[1].Width = 114;
            gridView1.Columns[2].Width = 114;
            gridView1.Columns[3].Width = 65;
            gridView1.Columns[4].Width = 65;
            gridView1.Columns[5].Width = 130;
            gridView1.Columns[6].Width = 115;
            gridView1.Columns[7].Width = 115;
            gridView1.Columns[8].Width = 115;
            gridView1.Columns[9].Width = 485;
            gridView1.OptionsView.ColumnAutoWidth = false;
        }
        //Gridview'de tıklanan satır verilerini araçlara aktar
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            LblId.Text = dataRow["ID"].ToString();
            TxtName.Text = dataRow["NAME"].ToString();
            TxtSurname.Text = dataRow["SURNAME"].ToString();
            oldTrId = dataRow["TR_ID"].ToString();
            MskTrId.Text = dataRow["TR_ID"].ToString();
            MskPhone.Text = dataRow["PHONE"].ToString();
            TxtEmail.Text = dataRow["EMAIL"].ToString();
            CmbAuth.Text = dataRow["POSITION"].ToString();
            CmbProvince.Text = dataRow["PROVINCE"].ToString();
            CmbDistrict.Text = dataRow["DISTRICT"].ToString();
            RchAdress.Text = dataRow["ADRESS"].ToString();

            //SQL'DE resim değeri null mu kontrolü yap değilse byte memorystream dönüşümü yap
            if (dataRow["IMAGE"].ToString() != "")
            {
                img = (byte[])dataRow["IMAGE"];
                if (img == null)
                {
                    Pctbox1.Image = null;
                }
                MemoryStream ms = new MemoryStream(img);
                Pctbox1.Image = Image.FromStream(ms);
            }
            else
            {
                Pctbox1.Image = null;
            }
        }
        //Resim seç butonu dosya yolunu alarak resmi pictureEdit'e aktar, sonra SQL'e kaydedilmesi için byte dönüşümü yap
        private void BttnChoose_Click(object sender, EventArgs e)
        {
            Pctbox1.Image = null;
            filename = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;*.webp;";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filename = ofd.FileName;
                Pctbox1.Image = Image.FromFile(filename);
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
            }
        }
        //Araçları herhangi bir işlemden snra temizle eski haline getir
        void Clear()
        {
            LblId.Text = "";
            TxtName.Text = "";
            TxtSurname.Text = "";
            MskTrId.Text = "";
            MskPhone.Text = "";
            TxtEmail.Text = "";
            CmbAuth.Text = "";
            CmbProvince.Text = "";
            CmbDistrict.Text = "";
            RchAdress.Text = "";
            img = null;
            Pctbox1.Image = null;
            CmbProvince.SelectedIndex = 0;
            CmbDistrict.SelectedIndex = 0;
            CmbAuth.SelectedIndex = 0;
            gridView1.ClearSelection();
        }
        //Araçlardaki değerleri al ve SQL'e kaydet, kontrolleri personnelManager snıfında yap
        private void BttnSave_Click(object sender, EventArgs e)
        {
            if (CmbAuth.SelectedIndex == 0) { MessageBox.Show("Please Select an Auth", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            personnel = new Personnel(MskTrId.Text, TxtName.Text, TxtSurname.Text, personnelManager.GetAuthId(CmbAuth.Text), MskPhone.Text, TxtEmail.Text, CmbProvince.Text, CmbDistrict.Text, RchAdress.Text, img);
            string result = personnelManager.Add(personnel);
            if (!result.Contains("Success"))
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            personnelDataTable();
        }
        //Araçlardaki değerleri al ve SQL'e güncelle, güncellenmek istenen personele yeni bir TC yazılıp başka bir personele aitse kayıt yapmaz, kontrolü SP personnelUpdate
        private void BttnUpdate_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "-"|| LblId.Text == "") return;
            if (CmbAuth.SelectedIndex == 0) { MessageBox.Show("Please Select an Auth", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            personnel = new Personnel(LblId.Text.ConInt(), MskTrId.Text, TxtName.Text, TxtSurname.Text, personnelManager.GetAuthId(CmbAuth.Text), MskPhone.Text, TxtEmail.Text, CmbProvince.Text, CmbDistrict.Text, RchAdress.Text, img, oldTrId);
            string result = personnelManager.Update(personnel);
            if (!result.Contains("Success"))
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personnelDataTable();
            Clear();
        }
        //Gridview'de seçilen personelin id değerini alıp SQL'den siler
        private void BttnDelete_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "-" || LblId.Text == "") return;
            DialogResult dr = MessageBox.Show("Are you sure you want to permanently delete this personnel", "Delete Personnel", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                personnelManager.Delete(LblId.Text.ConInt());
            }
            personnelDataTable();
            Clear();
        }
        //Temizle metodunu çalıştır
        private void BttnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
