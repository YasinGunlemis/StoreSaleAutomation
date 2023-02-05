using Business;
using DataAccess.Concrete;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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

namespace UI_Store
{
    public partial class FrmProductsTable : Form
    {
        ProductManager productManager;
        string productname, brand, model;
        byte[] img = null;
        public FrmProductsTable()
        {
            InitializeComponent();
            productManager = ProductManager.GetInstance();
        }

        private void FrmProductsTable_Load(object sender, EventArgs e)
        {
            ProductDatas();
        }

        private void gridControl1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Double-Click Head of Row To Add", gridControl1);
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var form = (FrmBills)Application.OpenForms["FrmBills"];
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            form.productId = dr["ID"].ConInt();
            productname = dr["PRODUCTNAME"].ToString();   
            brand = dr["BRAND"].ToString();            
            model = dr["MODEL"].ToString();            
            form.LblProduct.Text = productname + " " + brand + " " + " " + model;
            form.LblPrice.Text =String.Format("{0:#,##0.##}", dr["SELLING"]);
            form.NudQuantity.Value = 1;
            //SQL'DE resim değeri null mu kontrolü yap değilse byte memorystream dönüşümü yap
            if (dr["IMAGE1"].ToString() != "")
            {
                img = (byte[])dr["IMAGE1"];
                if (img == null)
                {
                    form.Pctbox1.Image = null;
                }
                MemoryStream ms = new MemoryStream(img);
                form.Pctbox1.Image = Image.FromStream(ms);
            }
            else
            {
                form.Pctbox1.Image = null;
            }
            this.Close();
        }

        void ProductDatas()
        {
            gridControl1.DataSource = productManager.GetDataTable();

            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["BUYING"].Visible = false;
            gridView1.Columns["IMAGE1"].Visible = false;
            gridView1.Columns["IMAGE2"].Visible = false;
            gridView1.Columns["IMAGE3"].Visible = false;
            gridView1.Columns["DETAIL"].Visible = false;
        }

    }
}
