using Business;
using DataAccess.Concrete;
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
    public partial class FrmGraphics : Form
    {
        ProductManager productManager;
        BillManager billManager;
        public FrmGraphics()
        {
            InitializeComponent();
            productManager = ProductManager.GetInstance();
            billManager = BillManager.GetInstance();

        }
        private void FrmGraphics_Load(object sender, EventArgs e)
        {
            CmbGraphSelection.SelectedIndex = 0;
            ProductsChart();
        }

        void ProductsChart()
        {
            //https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesLabelBase.TextPattern
            //https://docs.devexpress.com/WindowsForms/6170/controls-and-libraries/chart-control/series/series-titles
            DataTable dataTable = productManager.GetProductsBy("Name", "");
            chartControl1.DataSource = dataTable;
            chartControl1.Series["Series 1"].ArgumentDataMember = dataTable.Columns[0].ColumnName;
            chartControl1.Series["Series 1"].ValueDataMembers.AddRange(new string[] { dataTable.Columns[1].ColumnName });

            //for (int i = 0; i < gridView1.RowCount; i++)
            //{
            //    DataRow dataRow = gridView1.GetDataRow(i);
            //    chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dataRow["PRODUCTNAME"]), dataRow["PIECE"].ConInt());
            //    chartControl1.Legend.TextVisible = true;
            //}
        }

        private void CmbGraphSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbGraphSelection.SelectedIndex == 0)
            {
                ProductsChart();
                CmbProduct.Visible = false;
                chartControl3.Visible = false;
                chartControl1.Visible = true;
            }else if (CmbGraphSelection.SelectedIndex == 1)
            {
                CmbProduct.Visible = true;
                chartControl3.Visible = true;
                chartControl1.Visible = false;
                ComboProductDatas();
            }           
        }

        void ComboProductDatas()
        {
            DataTable dataTable = productManager.GetProductsBy("Name", "");
            CmbProduct.DataSource = dataTable;
            CmbProduct.DisplayMember = "PRODUCTNAME";
            DataRow row1 = dataTable.NewRow();
            row1["PRODUCTNAME"] = "Please Select Product";
            dataTable.Rows.InsertAt(row1, 0); //insert new to to index 0 (on top)
            CmbProduct.SelectedIndex = 0;
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {            
            BrandChart(CmbProduct.Text);
        }

        void BrandChart(string brand)
        {
            DataTable dataTable = productManager.GetProductsBy("Brand", brand);
            chartControl3.DataSource = dataTable;
            //chartControl1.Titles.Add(new DevExpress.XtraCharts.ChartTitle() { Text = "Total " + brand + " : {TV}" });
            chartControl3.Series["Series 1"].ArgumentDataMember = dataTable.Columns[1].ColumnName;
            chartControl3.Series["Series 1"].ValueDataMembers.AddRange(new string[] { dataTable.Columns[2].ColumnName });
        }

        void BestSellingChart()
        {
            DataTable dataTable = billManager.GetBestLeastSelling(true);
            chartControl2.DataSource = dataTable;
            chartControl2.Series["Series 1"].ArgumentDataMember = dataTable.Columns[0].ColumnName;
            chartControl2.Series["Series 1"].ValueDataMembers.AddRange(new string[] { dataTable.Columns[1].ColumnName });
            chartControl2.Legend.Title.Text = "Best Selling Top 10\n";
        }
        private void BttnBestSelling_Click(object sender, EventArgs e)
        {
            BestSellingChart();
        }

        void LeastSellingChart()
        {
            DataTable dataTable = billManager.GetBestLeastSelling(false);
            chartControl2.DataSource = dataTable;
            chartControl2.Series["Series 1"].ArgumentDataMember = dataTable.Columns[0].ColumnName;
            chartControl2.Series["Series 1"].ValueDataMembers.AddRange(new string[] { dataTable.Columns[1].ColumnName });
            chartControl2.Legend.Title.Text = "Least Selling Top 10\n";
        }
        private void BttnLeastSelling_Click(object sender, EventArgs e)
        {
            LeastSellingChart();
        }
    }
}
