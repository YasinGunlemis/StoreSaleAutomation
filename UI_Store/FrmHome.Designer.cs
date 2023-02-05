namespace UI_Store
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BttnHomePage = new DevExpress.XtraBars.BarButtonItem();
            this.BttnPersonnels = new DevExpress.XtraBars.BarButtonItem();
            this.BttnCompanies = new DevExpress.XtraBars.BarButtonItem();
            this.BttnPersons = new DevExpress.XtraBars.BarButtonItem();
            this.BttnProducts = new DevExpress.XtraBars.BarButtonItem();
            this.BttnExpense = new DevExpress.XtraBars.BarButtonItem();
            this.BttnCmpBnkAccnts = new DevExpress.XtraBars.BarButtonItem();
            this.BttnContacts = new DevExpress.XtraBars.BarButtonItem();
            this.BttnBills = new DevExpress.XtraBars.BarButtonItem();
            this.BttnNotes = new DevExpress.XtraBars.BarButtonItem();
            this.BttnGraphcs = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RbbnPage1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.ribbonControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Orange;
            this.ribbonControl1.EmptyAreaImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ribbonControl1.HeaderAreaImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BttnHomePage,
            this.BttnPersonnels,
            this.BttnCompanies,
            this.BttnPersons,
            this.BttnProducts,
            this.BttnExpense,
            this.BttnCmpBnkAccnts,
            this.BttnContacts,
            this.BttnBills,
            this.BttnNotes,
            this.BttnGraphcs});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsPageCategories.AutoCorrectForeColor = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.OptionsStubGlyphs.ColorMode = DevExpress.Utils.Drawing.GlyphColorMode.Red;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(1344, 126);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // BttnHomePage
            // 
            this.BttnHomePage.Caption = "HOME PAGE";
            this.BttnHomePage.Id = 1;
            this.BttnHomePage.ImageOptions.Image = global::UI_Store.Properties.Resources.home;
            this.BttnHomePage.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnHomePage.ItemAppearance.Hovered.Options.UseFont = true;
            this.BttnHomePage.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnHomePage.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnHomePage.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnHomePage.ItemAppearance.Pressed.Options.UseFont = true;
            this.BttnHomePage.Name = "BttnHomePage";
            this.BttnHomePage.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BttnHomePage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnHomePage_ItemClick);
            // 
            // BttnPersonnels
            // 
            this.BttnPersonnels.Caption = "PERSONNELS";
            this.BttnPersonnels.Id = 2;
            this.BttnPersonnels.ImageOptions.Image = global::UI_Store.Properties.Resources.employees;
            this.BttnPersonnels.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnPersonnels.ItemAppearance.Hovered.Options.UseFont = true;
            this.BttnPersonnels.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnPersonnels.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnPersonnels.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnPersonnels.ItemAppearance.Pressed.Options.UseFont = true;
            this.BttnPersonnels.Name = "BttnPersonnels";
            this.BttnPersonnels.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BttnPersonnels.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnPersonnels_ItemClick);
            // 
            // BttnCompanies
            // 
            this.BttnCompanies.Caption = "COMPANIES";
            this.BttnCompanies.Id = 3;
            this.BttnCompanies.ImageOptions.Image = global::UI_Store.Properties.Resources.organization;
            this.BttnCompanies.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCompanies.ItemAppearance.Hovered.Options.UseFont = true;
            this.BttnCompanies.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCompanies.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnCompanies.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCompanies.ItemAppearance.Pressed.Options.UseFont = true;
            this.BttnCompanies.Name = "BttnCompanies";
            this.BttnCompanies.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BttnCompanies.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnCompanies_ItemClick);
            // 
            // BttnPersons
            // 
            this.BttnPersons.Caption = "PERSONS";
            this.BttnPersons.Id = 4;
            this.BttnPersons.ImageOptions.Image = global::UI_Store.Properties.Resources.shopping_cart;
            this.BttnPersons.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnPersons.ItemAppearance.Hovered.Options.UseFont = true;
            this.BttnPersons.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnPersons.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnPersons.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnPersons.ItemAppearance.Pressed.Options.UseFont = true;
            this.BttnPersons.Name = "BttnPersons";
            this.BttnPersons.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BttnPersons.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnPersons_ItemClick);
            // 
            // BttnProducts
            // 
            this.BttnProducts.Caption = "PRODUCTS";
            this.BttnProducts.Id = 5;
            this.BttnProducts.ImageOptions.Image = global::UI_Store.Properties.Resources.electronics;
            this.BttnProducts.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnProducts.ItemAppearance.Hovered.Options.UseFont = true;
            this.BttnProducts.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnProducts.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnProducts.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnProducts.ItemAppearance.Pressed.Options.UseFont = true;
            this.BttnProducts.Name = "BttnProducts";
            this.BttnProducts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BttnProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnProducts_ItemClick);
            // 
            // BttnExpense
            // 
            this.BttnExpense.Caption = "EXPENSES";
            this.BttnExpense.Id = 10;
            this.BttnExpense.ImageOptions.Image = global::UI_Store.Properties.Resources.expense;
            this.BttnExpense.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnExpense.ItemAppearance.Hovered.Options.UseFont = true;
            this.BttnExpense.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnExpense.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnExpense.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnExpense.ItemAppearance.Pressed.Options.UseFont = true;
            this.BttnExpense.Name = "BttnExpense";
            this.BttnExpense.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BttnExpense.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnExpense_ItemClick);
            // 
            // BttnCmpBnkAccnts
            // 
            this.BttnCmpBnkAccnts.Caption = "COMPANIES BANK ACCOUNTS";
            this.BttnCmpBnkAccnts.Id = 11;
            this.BttnCmpBnkAccnts.ImageOptions.Image = global::UI_Store.Properties.Resources.bank;
            this.BttnCmpBnkAccnts.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCmpBnkAccnts.ItemAppearance.Hovered.Options.UseFont = true;
            this.BttnCmpBnkAccnts.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCmpBnkAccnts.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnCmpBnkAccnts.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCmpBnkAccnts.ItemAppearance.Pressed.Options.UseFont = true;
            this.BttnCmpBnkAccnts.Name = "BttnCmpBnkAccnts";
            this.BttnCmpBnkAccnts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BttnCmpBnkAccnts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnCmpBnkAccnts_ItemClick);
            // 
            // BttnContacts
            // 
            this.BttnContacts.Caption = "CONTACTS";
            this.BttnContacts.Id = 12;
            this.BttnContacts.ImageOptions.Image = global::UI_Store.Properties.Resources.communicate11;
            this.BttnContacts.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnContacts.ItemAppearance.Hovered.Options.UseFont = true;
            this.BttnContacts.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnContacts.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnContacts.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnContacts.ItemAppearance.Pressed.Options.UseFont = true;
            this.BttnContacts.Name = "BttnContacts";
            this.BttnContacts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BttnContacts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnContacts_ItemClick);
            // 
            // BttnBills
            // 
            this.BttnBills.Caption = "  BILLS  ";
            this.BttnBills.Id = 13;
            this.BttnBills.ImageOptions.Image = global::UI_Store.Properties.Resources.bill;
            this.BttnBills.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnBills.ItemAppearance.Hovered.Options.UseFont = true;
            this.BttnBills.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnBills.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnBills.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnBills.ItemAppearance.Pressed.Options.UseFont = true;
            this.BttnBills.Name = "BttnBills";
            this.BttnBills.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BttnBills.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnBills_ItemClick);
            // 
            // BttnNotes
            // 
            this.BttnNotes.Caption = "NOTES";
            this.BttnNotes.Id = 14;
            this.BttnNotes.ImageOptions.Image = global::UI_Store.Properties.Resources.notepad;
            this.BttnNotes.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNotes.ItemAppearance.Hovered.Options.UseFont = true;
            this.BttnNotes.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNotes.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnNotes.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNotes.ItemAppearance.Pressed.Options.UseFont = true;
            this.BttnNotes.Name = "BttnNotes";
            this.BttnNotes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BttnNotes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnNotes_ItemClick);
            // 
            // BttnGraphcs
            // 
            this.BttnGraphcs.Caption = "GRAPHICS";
            this.BttnGraphcs.Id = 15;
            this.BttnGraphcs.ImageOptions.Image = global::UI_Store.Properties.Resources.graph;
            this.BttnGraphcs.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnGraphcs.ItemAppearance.Hovered.Options.UseFont = true;
            this.BttnGraphcs.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnGraphcs.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnGraphcs.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnGraphcs.ItemAppearance.Pressed.Options.UseFont = true;
            this.BttnGraphcs.Name = "BttnGraphcs";
            this.BttnGraphcs.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BttnGraphcs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnGraphcs_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.RbbnPage1,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BttnHomePage);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Home Page";
            // 
            // RbbnPage1
            // 
            this.RbbnPage1.ItemLinks.Add(this.BttnPersonnels);
            this.RbbnPage1.ItemLinks.Add(this.BttnProducts);
            this.RbbnPage1.ItemLinks.Add(this.BttnCmpBnkAccnts);
            this.RbbnPage1.ItemLinks.Add(this.BttnExpense);
            this.RbbnPage1.ItemLinks.Add(this.BttnContacts);
            this.RbbnPage1.ItemLinks.Add(this.BttnBills);
            this.RbbnPage1.ItemLinks.Add(this.BttnNotes);
            this.RbbnPage1.ItemLinks.Add(this.BttnGraphcs);
            this.RbbnPage1.Name = "RbbnPage1";
            this.RbbnPage1.Text = "Store";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnCompanies);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnPersons);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Customers";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "HOME PAGE";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = global::UI_Store.Properties.Resources.home;
            this.barButtonItem2.ItemAppearance.Hovered.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Pressed.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InTabControlHeader;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.True;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIFE STORE";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem BttnPersonnels;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem BttnCompanies;
        private DevExpress.XtraBars.BarButtonItem BttnProducts;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup RbbnPage1;
        public DevExpress.XtraBars.BarButtonItem BttnHomePage;
        public DevExpress.XtraBars.BarButtonItem BttnPersons;
        public DevExpress.XtraBars.BarButtonItem BttnExpense;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BttnContacts;
        private DevExpress.XtraBars.BarButtonItem BttnBills;
        private DevExpress.XtraBars.BarButtonItem BttnNotes;
        private DevExpress.XtraBars.BarButtonItem BttnGraphcs;
        public DevExpress.XtraBars.BarButtonItem BttnCmpBnkAccnts;
    }
}

