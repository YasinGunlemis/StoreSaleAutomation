using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTabbedMdi;

namespace UI_Store
{
    public partial class FrmHome : Form
    {
        bool isActiv = false;
        public FrmHome()
        {
            InitializeComponent();
        }

        private void BttnProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmProducts frmProducts = new FrmProducts();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frmProducts.Name)
                {
                    item.Activate();
                    isActiv = true;
                }
            }
            if (!isActiv)
            {
                frmProducts.MdiParent = this;
                frmProducts.Show();
            }
            isActiv = false;
            return;
        }

        private void BttnPersonnels_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonnels frmPersonnels = new FrmPersonnels();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frmPersonnels.Name)
                {
                    item.Activate();
                    isActiv = true;
                }
            }
            if (!isActiv)
            {
                frmPersonnels.MdiParent = this;
                frmPersonnels.Show();
            }
            isActiv = false;
            return;
        }

        private void BttnCompanies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCompanies frmCompanies = new FrmCompanies();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frmCompanies.Name)
                {
                    item.Activate();
                    isActiv = true;
                }
            }
            if (!isActiv)
            {
                frmCompanies.MdiParent = this;
                frmCompanies.Show();
            }
            isActiv = false;
            return;
        }


        private void BttnCmpBnkAccnts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCmpnyBnkAccnts frmCmpnyBnkAccnts = new FrmCmpnyBnkAccnts();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frmCmpnyBnkAccnts.Name)
                {
                    item.Activate();
                    isActiv = true;
                }
            }
            if (!isActiv)
            {
                frmCmpnyBnkAccnts.MdiParent = this;
                frmCmpnyBnkAccnts.Show();
            }
            isActiv = false;
            return;
        }

        private void BttnPersons_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersons frmPersons = new FrmPersons();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frmPersons.Name)
                {
                    item.Activate();
                    isActiv = true;
                }
            }
            if (!isActiv)
            {
                frmPersons.MdiParent = this;
                frmPersons.Show();
            }
            isActiv = false;
            return;
        }

        private void BttnExpense_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmExpenses frmExpenses = new FrmExpenses();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frmExpenses.Name)
                {
                    item.Activate();
                    isActiv = true;
                }
            }
            if (!isActiv)
            {
                frmExpenses.MdiParent = this;
                frmExpenses.Show();
            }
            isActiv = false;
            return;
        }

        private void BttnContacts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmContacts frmContacts = new FrmContacts();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frmContacts.Name)
                {
                    item.Activate();
                    isActiv = true;
                }
            }
            if (!isActiv)
            {
                frmContacts.MdiParent = this;
                frmContacts.Show();
            }
            isActiv = false;
            return;
        }

        private void BttnBills_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBills frmBills = new FrmBills();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frmBills.Name)
                {
                    item.Activate();
                    isActiv = true;
                }
            }
            if (!isActiv)
            {
                frmBills.MdiParent = this;
                frmBills.Show();
            }
            isActiv = false;
            return;
        }

        private void BttnNotes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNotes frmNotes = new FrmNotes();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frmNotes.Name)
                {
                    item.Activate();
                    isActiv = true;
                }
            }
            if (!isActiv)
            {
                frmNotes.MdiParent = this;
                frmNotes.Show();
            }
            isActiv = false;
            return;
        }

        private void BttnGraphcs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGraphics frmStocks = new FrmGraphics();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frmStocks.Name)
                {
                    item.Activate();
                    isActiv = true;
                }
            }
            if (!isActiv)
            {
                frmStocks.MdiParent = this;
                frmStocks.Show();
            }
            isActiv = false;
            return;
        }


        
        private void BttnHomePage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHomePage frmHomePage = new FrmHomePage();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frmHomePage.Name)
                {
                    item.Activate();
                    isActiv = true;
                }
            }
            if (!isActiv)
            {
                frmHomePage.MdiParent = this;
                frmHomePage.Show();
            }
            isActiv = false;
            return;
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            FrmHomePage frmHomePage = new FrmHomePage();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == frmHomePage.Name)
                {
                    item.Activate();
                    isActiv = true;
                }
            }
            if (!isActiv)
            {
                frmHomePage.MdiParent = this;
                frmHomePage.Show();
            }
            isActiv = false;
            return;
        }
    }
}
