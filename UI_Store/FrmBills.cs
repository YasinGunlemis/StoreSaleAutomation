using Business;
using DataAccess.Concrete;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.XtraGrid;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Store.Properties;

namespace UI_Store
{
    public partial class FrmBills : Form
    {
        BillManager billManager;
        ProductManager productManager;
        Bill bill, updateBill;
        int billId = -1;
        public int productId, deleteQuantity;
        public decimal price, total, quantity, billAmountDue = 0;
        public object[] infos = null;
        DataTable table, bills, billProducts;
        DataSet dataSet = new DataSet();
        public FrmBills()
        {
            InitializeComponent();
            billManager = BillManager.GetInstance();
            productManager = ProductManager.GetInstance();
        }

        private void FrmBills_Load(object sender, EventArgs e)
        {
            ProductsDataTable();
            FillCustomerCombo();
            AllBills();
        }

        void FillCustomerCombo()
        {
            DataRow row1;
            DataTable dataTable;
            CmbCustomers.DisplayMember = "CUSTOMER";
            dataTable = billManager.GetCustomers();
            CmbCustomers.DataSource = dataTable;
            row1 = dataTable.NewRow();
            row1["CUSTOMER"] = "Please select bellow..."; //insert a blank row - you can even write something like  = "Please select bellow...";
            dataTable.Rows.InsertAt(row1, 0); //insert new to to index 0 (on top=
            CmbCustomers.SelectedIndex = 0;
        }
        
        void AllBills()
        {
            //https://docs.devexpress.com/WindowsForms/2163/common-features/data-binding/how-to-bind-gridcontrol-to-database-and-implement-master-detail-mode-at-design-time
            //https://docs.devexpress.com/WindowsForms/2141/common-features/formatting-values/format-specifiers
            bills = billManager.GetBills();
            billProducts = billManager.GetBillProducts();
            
            dataSet.Tables.Add(bills);
            dataSet.Tables.Add(billProducts);

            dataSet.Relations.Add(bills.Columns["BILLID"], billProducts.Columns["BILLID"]);
            gridControl1.DataSource = dataSet;
            gridControl1.DataMember = bills.TableName;

            gridView1.Columns["BILL_AMOUNT_DUE"].DisplayFormat.FormatType = FormatType.Numeric;
            gridView1.Columns["BILL_AMOUNT_DUE"].DisplayFormat.FormatString = "c2";
            gridView1.Columns["DATETIME"].DisplayFormat.FormatType = FormatType.DateTime;
            gridView1.Columns["DATETIME"].DisplayFormat.FormatString = "f";

        }

        private void BttnOpenBill_Click(object sender, EventArgs e)
        {
            if (CmbCustomers.Text.Contains("select"))
            {
                MessageBox.Show("Please Select Customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bill = new Bill(CmbCustomers.Text, billAmountDue);
            billId = billManager.Add(bill);
            BttnOpenBill.Enabled = false;
            BttnAdd.Enabled = true;
            BttnChoose.Enabled = true;
            CmbCustomers.Enabled = false;
        }
        
        private void BttnChoose_Click(object sender, EventArgs e)
        {
            FrmProductsTable frmProductsTable = new FrmProductsTable();
            frmProductsTable.ShowDialog();
        }
        
        private void BttnAdd_Click(object sender, EventArgs e)
        {
            if (LblProduct.Text == "PRODUCT" || LblProductTotal.Text == "0.00")
            {
                MessageBox.Show("Please Select A Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (NudQuantity.Value <= 0)
            {
                MessageBox.Show("Please Select Product Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gridControl2.DataSource = AddProductToDT(productId, LblProduct.Text, NudQuantity.Value.ToString(), LblPrice.Text, LblProductTotal.Text, billId);
            gridView2.Columns["PRODUCTID"].Visible = false;
            gridView2.Columns["PRODUCT"].Width = 200;
            gridView2.RefreshData();

            BttnAddBill.Enabled = true;

            billAmountDue += total;
            LblAmountDue.Text = billAmountDue.ToString();
            LblAmountDue.Text = String.Format("{0:#,##0.##}", billAmountDue);
            
            productManager.ProductDecreaseOrIncrease("Decrease", productId, NudQuantity.Value.ConInt());
            
            Clear();
        }

        private void NudQuantity_ValueChanged(object sender, EventArgs e)
        {
            total = LblPrice.Text.ConDec() * NudQuantity.Value.ConDec();
            LblProductTotal.Text = String.Format("{0:#,##0.##}", total);
        }
        
        private void BttnAddBill_Click(object sender, EventArgs e)
        {
            updateBill = new Bill(billId, billAmountDue);
            billManager.Update(updateBill);
            billManager.InsertBillProducts(table);
            table.Clear();

            BttnOpenBill.Enabled = true;
            CmbCustomers.Enabled = true;
            BttnAdd.Enabled = false;
            BttnChoose.Enabled = false;

            CmbCustomers.SelectedIndex = 0;

            Clear();
            LblAmountDue.Text = "0.00";
            billAmountDue = 0;
            AllBills();
        }

        void ProductsDataTable()
        {
            table = new DataTable();
            table.TableName = "PRODUCTS";
            table.Columns.Add(new DataColumn("PRODUCTID", typeof(int)));
            table.Columns.Add(new DataColumn("PRODUCT", typeof(string)));
            table.Columns.Add(new DataColumn("QUANTITY", typeof(int)));
            table.Columns.Add(new DataColumn("SALEPRICE", typeof(decimal)));
            table.Columns.Add(new DataColumn("TOTAL_PRICE", typeof(decimal)));
            table.Columns.Add(new DataColumn("BILLID", typeof(int)));
        }

        DataTable AddProductToDT(int productId, string product, string quantity, string price, string total, int billId)
        {
            table.Rows.Add(productId, product, quantity, price, total, billId);
            return table;
        }

        private void ContxtBttnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView2.GetDataRow(gridView2.FocusedRowHandle)==null)
            {
                MessageBox.Show("Please Select the Row You Want to Delete ?","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DataRow dataRow = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            productId = dataRow["PRODUCTID"].ConInt();
            deleteQuantity = dataRow["QUANTITY"].ConInt();
            productManager.ProductDecreaseOrIncrease("Increase", productId, deleteQuantity);
            gridView2.DeleteSelectedRows();
        }

        void Clear()
        {
            LblProduct.Text = "PRODUCT";
            LblPrice.Text = "0.00";
            LblProductTotal.Text = "0.00";
            NudQuantity.Value = 0;
            Pctbox1.Image = null;
        }


    }
}
