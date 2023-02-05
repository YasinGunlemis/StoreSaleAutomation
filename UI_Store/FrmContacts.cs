using Business;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Map.Native;

namespace UI_Store
{
    public partial class FrmContacts : Form
    {
        CustomerManager customerManager;
        CompanyManager companyManager;
        public FrmContacts()
        {
            InitializeComponent();
            customerManager = CustomerManager.GetInstance();
            companyManager = CompanyManager.GetInstance();
        }

        private void FrmContacts_Load(object sender, EventArgs e)
        {
            CompanyPersonDatas();
        }

        void CompanyPersonDatas()
        {
            gridControl1.DataSource = companyManager.GetDataTable();
            //gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.Columns["COMPANY"].Width = 170;
            gridView1.Columns["AUTH_STATUS"].Width = 130;
            gridView1.Columns["AUTH_NAME_SUR"].Width = 130;
            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["SECTOR"].Visible = false;
            gridView1.Columns["TAXOFFICE"].Visible = false;
            gridView1.Columns["SPECIALCODE1"].Visible = false;
            gridView1.Columns["SPECIALCODE2"].Visible = false;
            gridView1.Columns["SPECIALCODE3"].Visible = false;
            gridView1.Columns["IMAGE"].Visible = false;
            gridView1.Columns["TAXNO"].Visible = false;
            gridView1.Columns["PROVINCE"].Visible = false;
            gridView1.Columns["DISTRICT"].Visible = false;
            gridView1.Columns["ADRESS"].Visible = false;

            gridControl2.DataSource = customerManager.GetDataTable();
            gridView2.Columns["ID"].Visible = false;
            gridView2.Columns["TR_ID"].Visible = false;
            gridView2.Columns["PROVINCE"].Visible = false;
            gridView2.Columns["DISTRICT"].Visible = false;
            gridView2.Columns["ADRESS"].Visible = false;
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FrmMessages frmMessages = new FrmMessages();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            frmMessages.TxtEmail.Text = dr["EMAIL"].ToString();
            frmMessages.ShowDialog();
        }

        private void gridControl2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FrmMessages frmMessages = new FrmMessages();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            frmMessages.TxtEmail.Text = dr["EMAIL"].ToString();
            frmMessages.ShowDialog();
        }

        private void gridControl1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Double-Click Head of Row To Send Message",gridControl1);
        }

        private void gridControl2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Double-Click Head of Row To Send Message", gridControl2);
        }
    }
}
