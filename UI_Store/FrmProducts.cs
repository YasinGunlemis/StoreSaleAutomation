using Business;
using DataAccess.Concrete;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using DevExpress.Data.Helpers;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraMap;
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
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace UI_Store
{
    public partial class FrmProducts : Form
    {
        string[] filenames = new string[3];
        ProductManager productManager;
        Product product;
        byte[] image1, image2, image3;
        public FrmProducts()
        {
            InitializeComponent();
            productManager = ProductManager.GetInstance();
        }
        private void FrmProducts_Load(object sender, EventArgs e)
        {
            ProductDataTable();
            Clear();
        }
        void ProductDataTable()
        {
            gridControl1.DataSource = productManager.GetDataTable();
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Width = 100;
            gridView1.Columns[2].Width = 80;
            gridView1.Columns[3].Width = 100;
            gridView1.Columns[4].Width = 50;
            gridView1.Columns[5].Width = 60;
            gridView1.Columns[6].Width = 60;
            gridView1.Columns[7].Width = 60;
            gridView1.Columns[8].Width = 790;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.Columns[9].Visible = false;
            gridView1.Columns[10].Visible = false;
            gridView1.Columns[11].Visible = false;
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (imagaSlider1 != null)
            {
                imagaSlider1.Images.Clear();
            }

            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            LblId.Text = dataRow["ID"].ToString();
            TxtPrdctName.Text = dataRow["PRODUCTNAME"].ToString();
            TxtBrand.Text = dataRow["BRAND"].ToString();
            TxtModel.Text = dataRow["MODEL"].ToString();
            TxtYear.Text = dataRow["YEAR"].ToString();
            TxtPiece.Text = dataRow["PIECE"].ToString();
            TxtBuying.Text = dataRow["BUYING"].ToString();
            TxtSelling.Text = dataRow["SELLING"].ToString();
            RchDetail.Text = dataRow["DETAIL"].ToString();

            //condition ? value_if_true : value_if_false --> Ternary Operator

            if (dataRow["IMAGE1"].ToString() == "" && dataRow["IMAGE2"].ToString() == "" && dataRow["IMAGE3"].ToString() == "")
            {
                imagaSlider1.Images.Clear();
            }
            else if (dataRow["IMAGE1"].ToString() != "" && dataRow["IMAGE2"].ToString() == "" && dataRow["IMAGE3"].ToString() == "")
            {
                image1 = (byte[])dataRow["IMAGE1"];

                imagaSlider1.Images.Add(Image.FromStream(image1.ConMemoryStream()));

                frmImages.image1 = image1;
                frmImages.image2 = null;
                frmImages.image3 = null;
            }
            else if (dataRow["IMAGE1"].ToString() != "" && dataRow["IMAGE2"].ToString() != "" && dataRow["IMAGE3"].ToString() == "")
            {
                image1 = (byte[])dataRow["IMAGE1"];
                image2 = (byte[])dataRow["IMAGE2"];

                imagaSlider1.Images.Add(Image.FromStream(image1.ConMemoryStream()));
                imagaSlider1.Images.Add(Image.FromStream(image2.ConMemoryStream()));

                frmImages.image1 = image1;
                frmImages.image2 = image2;
                frmImages.image3 = null;
            }
            else if (dataRow["IMAGE1"].ToString() != "" && dataRow["IMAGE2"].ToString() != "" && dataRow["IMAGE3"].ToString() != "")
            {
                image1 = (byte[])dataRow["IMAGE1"];
                image2 = (byte[])dataRow["IMAGE2"];
                image3 = (byte[])dataRow["IMAGE3"];

                imagaSlider1.Images.Add(Image.FromStream(image1.ConMemoryStream()));
                imagaSlider1.Images.Add(Image.FromStream(image2.ConMemoryStream()));
                imagaSlider1.Images.Add(Image.FromStream(image3.ConMemoryStream()));

                frmImages.image1 = image1;
                frmImages.image2 = image2;
                frmImages.image3 = image3;
            }

        }
        private void BttnChoose_Click(object sender, EventArgs e)
        {
            imagaSlider1.Images.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select 3 images";
            ofd.Multiselect = true;
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;|JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            filenames = new string[ofd.FileNames.Length];
            DialogResult dr = ofd.ShowDialog();
            if (ofd.FileNames.Length > 3)
            {
                MessageBox.Show("You have selected more than 3 pictures, 3 of the selected pictures will be saved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (dr == DialogResult.OK)
            {
                filenames = ofd.FileNames;
                if (filenames.Length <= 3)
                {
                    for (int i = 0; i < filenames.Length; i++)
                    {
                        imagaSlider1.Images.Add(Image.FromFile(filenames[i]));

                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        imagaSlider1.Images.Add(Image.FromFile(filenames[i]));
                    }
                }
            }
            else
            {
                imagaSlider1.Images.Clear();
                filenames = null;
            }
        }

        byte[] FilenameToByteImage(string filename)
        {
            //byte[] img = null;
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            return br.ReadBytes((int)fs.Length);        //img = br.ReadBytes((int)fs.Length);
        }
        void Clear()
        {
            LblId.Text = "";
            TxtPrdctName.Text = "";
            TxtBrand.Text = "";
            TxtModel.Text = "";
            TxtYear.Text = "";
            TxtPiece.Text = "";
            TxtBuying.Text = "";
            TxtSelling.Text = "";
            RchDetail.Text = "";
            filenames = null;
            imagaSlider1.Images.Clear();
        }
        private void BttnSave_Click(object sender, EventArgs e)
        {
            if (TxtPiece.Text == "" || TxtBuying.Text == "" || TxtSelling.Text == "")
            {
                MessageBox.Show("Please Fill In The Required Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (filenames == null)
            {
                image1 = null; //new Byte[64]; Array.Clear(image1, 0, image1.Length);
                image2 = null; //new Byte[64]; Array.Clear(image2, 0, image2.Length);
                image3 = null; //new Byte[64]; Array.Clear(image3, 0, image3.Length);

                product = new Product(TxtPrdctName.Text, TxtBrand.Text, TxtModel.Text, TxtYear.Text, TxtPiece.Text.ConInt(), TxtBuying.Text.ConDec(), TxtSelling.Text.ConDec(), RchDetail.Text, image1, image2, image3);
                MessageBox.Show(productManager.Add(product), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (filenames.Length == 1)
            {
                image2 = null; //new Byte[64]; Array.Clear(image2, 0, image2.Length);
                image3 = null; //new Byte[64]; Array.Clear(image3, 0, image3.Length);

                product = new Product(TxtPrdctName.Text, TxtBrand.Text, TxtModel.Text, TxtYear.Text, TxtPiece.Text.ConInt(), TxtBuying.Text.ConDec(), TxtSelling.Text.ConDec(), RchDetail.Text, FilenameToByteImage(filenames[0]), image2, image3);
                MessageBox.Show(productManager.Add(product), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (filenames.Length == 2)
            {
                image3 = null; //new Byte[64]; Array.Clear(image3, 0, image3.Length);

                product = new Product(TxtPrdctName.Text, TxtBrand.Text, TxtModel.Text, TxtYear.Text, TxtPiece.Text.ConInt(), TxtBuying.Text.ConDec(), TxtSelling.Text.ConDec(), RchDetail.Text, FilenameToByteImage(filenames[0]), FilenameToByteImage(filenames[1]), image3);
                MessageBox.Show(productManager.Add(product), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                product = new Product(TxtPrdctName.Text, TxtBrand.Text, TxtModel.Text, TxtYear.Text, TxtPiece.Text.ConInt(), TxtBuying.Text.ConDec(), TxtSelling.Text.ConDec(), RchDetail.Text, FilenameToByteImage(filenames[0]), FilenameToByteImage(filenames[1]), FilenameToByteImage(filenames[2]));
                MessageBox.Show(productManager.Add(product), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            ProductDataTable();
            Clear();
        }
        private void BttnUpdate_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "-" || LblId.Text == "") return;
                if (TxtPiece.Text == "" || TxtBuying.Text == "" || TxtSelling.Text == "")
                {
                    MessageBox.Show("Please Fill In The Required Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            if (filenames == null)
            {
                image1 = null; //new Byte[64]; Array.Clear(image1, 0, image1.Length);
                image2 = null; //new Byte[64]; Array.Clear(image2, 0, image2.Length);
                image3 = null; //new Byte[64]; Array.Clear(image3, 0, image3.Length);

                product = new Product(LblId.Text.ConInt(), TxtPrdctName.Text, TxtBrand.Text, TxtModel.Text, TxtYear.Text, TxtPiece.Text.ConInt(), TxtBuying.Text.ConDec(), TxtSelling.Text.ConDec(), RchDetail.Text, image1, image2, image3);
                MessageBox.Show(productManager.Update(product), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (filenames.Length == 1)
            {
                image2 = null; //new Byte[64]; Array.Clear(image2, 0, image2.Length);
                image3 = null; //new Byte[64]; Array.Clear(image3, 0, image3.Length);

                product = new Product(LblId.Text.ConInt(), TxtPrdctName.Text, TxtBrand.Text, TxtModel.Text, TxtYear.Text, TxtPiece.Text.ConInt(), TxtBuying.Text.ConDec(), TxtSelling.Text.ConDec(), RchDetail.Text, FilenameToByteImage(filenames[0]), image2, image3);
                MessageBox.Show(productManager.Update(product), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (filenames.Length == 2)
            {
                image3 = null; //new Byte[64]; Array.Clear(image3, 0, image3.Length);

                product = new Product(LblId.Text.ConInt(), TxtPrdctName.Text, TxtBrand.Text, TxtModel.Text, TxtYear.Text, TxtPiece.Text.ConInt(), TxtBuying.Text.ConDec(), TxtSelling.Text.ConDec(), RchDetail.Text, FilenameToByteImage(filenames[0]), FilenameToByteImage(filenames[1]), image3);
                MessageBox.Show(productManager.Update(product), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                product = new Product(LblId.Text.ConInt(), TxtPrdctName.Text, TxtBrand.Text, TxtModel.Text, TxtYear.Text, TxtPiece.Text.ConInt(), TxtBuying.Text.ConDec(), TxtSelling.Text.ConDec(), RchDetail.Text, FilenameToByteImage(filenames[0]), FilenameToByteImage(filenames[1]), FilenameToByteImage(filenames[2]));
                MessageBox.Show(productManager.Update(product), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            ProductDataTable();
            Clear();
        }

        FrmImages frmImages = new FrmImages();
        private void imagaSlider1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmImages.ShowDialog();
        }

        private void imagaSlider1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Double-Click Show Large Image", imagaSlider1);
        }

        private void BttnDelete_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "-" || LblId.Text == "") return;
            MessageBox.Show(productManager.Delete(LblId.Text.ConInt()), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductDataTable();
        }
        private void BttnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
