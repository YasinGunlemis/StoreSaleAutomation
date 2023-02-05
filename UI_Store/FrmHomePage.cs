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
using System.Xml;

namespace UI_Store
{
    public partial class FrmHomePage : Form
    {
        ProductManager productManager;
        bool start = false;
        public FrmHomePage()
        {
            InitializeComponent();
            productManager = ProductManager.GetInstance();
        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            GridProductsDatas();

            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            webBrowser2.Navigate("https://mgm.gov.tr/eng/forecast-5days.aspx");

            News();
        }

        void News()
        {
            /*
             Turkish-News-RSS-Links
            https://gist.github.com/e-budur/983d969c0f6cf756bbbb60a2892aa964#file-turkish-news-rss-links
             */
            //XmlTextReader xmlReader = new XmlTextReader("https://rss.nytimes.com/services/xml/rss/nyt/World.xml");
            //XmlTextReader xmlReader = new XmlTextReader("https://feeds.skynews.com/feeds/rss/world.xml");
            XmlTextReader xmlReader = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmlReader.Read())
            {
                if(xmlReader.Name == "title")
                {
                listBox1.Items.Add(xmlReader.ReadString());
                }
            }
        }
        void GridProductsDatas()
        {
            if (start == false)
            {
                start = true;
                CmbPiece.SelectedIndex = 0;
                CmbNumber.SelectedIndex = 0;
            }
            gridControl1.DataSource = productManager.GetDecreasingProductsByPiece(CmbPiece.Text.ConInt());
            gridView1.Columns[0].Width = 200;
            gridControl3.DataSource = productManager.GetRecentlyAddedProducts(CmbNumber.Text.ConInt());
            gridView3.Columns[0].Width = 200;
        }
        private void CmbPiece_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = productManager.GetDecreasingProductsByPiece(CmbPiece.Text.ConInt());
            gridView1.Columns[0].Width = 200;
        }

        private void CmbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridControl3.DataSource = productManager.GetRecentlyAddedProducts(CmbNumber.Text.ConInt());
            gridView3.Columns[0].Width = 200;
        }
    }
}
