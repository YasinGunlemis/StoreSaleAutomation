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
    public partial class FrmLoginScreen : Form
    {
        PersonnelManager personnelManager;

        public FrmLoginScreen()
        {
            InitializeComponent();
            personnelManager = PersonnelManager.GetInstance();
        }

        private void BttnLogin_Click(object sender, EventArgs e)
        {
            if (MskTrId.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Please Fill In Required Fields", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            object[] infos = personnelManager.Login(MskTrId.Text, TxtPassword.Text);

            if (infos == null)
            {
                MessageBox.Show("Wrong, Tr-ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Welcome " + infos[1],"Info",MessageBoxButtons.OK,MessageBoxIcon.Information);

            if (infos[3].ConInt() == 1)
            {
                ShowAuthorizedHomePage();
            }
            else
            {
                ShowWorkerHomePage();
            }    
        }

        void ShowAuthorizedHomePage()
        {
            FrmHome frmHome = new FrmHome();
            this.Hide();
            frmHome.Show();
        }

        void ShowWorkerHomePage()
        {
            FrmHome frmHome = new FrmHome();
            this.Hide();
            frmHome.BttnExpense.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            frmHome.BttnCmpBnkAccnts.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            frmHome.Show();
        }
    }
}
