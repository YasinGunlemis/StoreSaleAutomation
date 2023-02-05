namespace UI_Store
{
    partial class FrmCompanies
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanies));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAXNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAUTH_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAUTH_NAME_SUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSECTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROVINCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISTRICT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAXOFFICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPECIALCODE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPECIALCODE2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPECIALCODE3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BttnAddCompany = new DevExpress.XtraEditors.SimpleButton();
            this.BttnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.Lime;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetails,
            this.colID,
            this.colIMAGE,
            this.colTAXNO,
            this.colCOMPANY,
            this.colAUTH_STATUS,
            this.colAUTH_NAME_SUR,
            this.colSECTOR,
            this.colPHONE1,
            this.colPHONE2,
            this.colEMAIL,
            this.colFAX,
            this.colPROVINCE,
            this.colDISTRICT,
            this.colADRESS,
            this.colTAXOFFICE,
            this.colSPECIALCODE1,
            this.colSPECIALCODE2,
            this.colSPECIALCODE3});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsNavigation.UseOfficePageNavigation = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 50;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colDetails
            // 
            this.colDetails.Caption = "Details";
            this.colDetails.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colDetails.FieldName = "DETAILS";
            this.colDetails.Name = "colDetails";
            this.colDetails.Visible = true;
            this.colDetails.VisibleIndex = 18;
            this.colDetails.Width = 85;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            serializableAppearanceObject1.Options.UseFont = true;
            serializableAppearanceObject1.Options.UseForeColor = true;
            toolTipItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipItem1.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            toolTipItem1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            toolTipItem1.Appearance.Options.UseFont = true;
            toolTipItem1.Appearance.Options.UseForeColor = true;
            toolTipItem1.Text = "Show Details";
            superToolTip1.Items.Add(toolTipItem1);
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Show Details", "Show Details", superToolTip1, DevExpress.Utils.ToolTipAnchor.Cursor)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 69;
            // 
            // colIMAGE
            // 
            this.colIMAGE.FieldName = "IMAGE";
            this.colIMAGE.Name = "colIMAGE";
            this.colIMAGE.Visible = true;
            this.colIMAGE.VisibleIndex = 1;
            this.colIMAGE.Width = 76;
            // 
            // colTAXNO
            // 
            this.colTAXNO.FieldName = "TAXNO";
            this.colTAXNO.Name = "colTAXNO";
            this.colTAXNO.Visible = true;
            this.colTAXNO.VisibleIndex = 2;
            this.colTAXNO.Width = 68;
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            this.colCOMPANY.Visible = true;
            this.colCOMPANY.VisibleIndex = 3;
            this.colCOMPANY.Width = 68;
            // 
            // colAUTH_STATUS
            // 
            this.colAUTH_STATUS.FieldName = "AUTH_STATUS";
            this.colAUTH_STATUS.Name = "colAUTH_STATUS";
            this.colAUTH_STATUS.Visible = true;
            this.colAUTH_STATUS.VisibleIndex = 4;
            this.colAUTH_STATUS.Width = 68;
            // 
            // colAUTH_NAME_SUR
            // 
            this.colAUTH_NAME_SUR.FieldName = "AUTH_NAME_SUR";
            this.colAUTH_NAME_SUR.Name = "colAUTH_NAME_SUR";
            this.colAUTH_NAME_SUR.Visible = true;
            this.colAUTH_NAME_SUR.VisibleIndex = 5;
            this.colAUTH_NAME_SUR.Width = 68;
            // 
            // colSECTOR
            // 
            this.colSECTOR.FieldName = "SECTOR";
            this.colSECTOR.Name = "colSECTOR";
            this.colSECTOR.Visible = true;
            this.colSECTOR.VisibleIndex = 6;
            this.colSECTOR.Width = 68;
            // 
            // colPHONE1
            // 
            this.colPHONE1.FieldName = "PHONE1";
            this.colPHONE1.Name = "colPHONE1";
            this.colPHONE1.Visible = true;
            this.colPHONE1.VisibleIndex = 7;
            this.colPHONE1.Width = 68;
            // 
            // colPHONE2
            // 
            this.colPHONE2.FieldName = "PHONE2";
            this.colPHONE2.Name = "colPHONE2";
            this.colPHONE2.Visible = true;
            this.colPHONE2.VisibleIndex = 8;
            this.colPHONE2.Width = 68;
            // 
            // colEMAIL
            // 
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 9;
            this.colEMAIL.Width = 68;
            // 
            // colFAX
            // 
            this.colFAX.FieldName = "FAX";
            this.colFAX.Name = "colFAX";
            this.colFAX.Visible = true;
            this.colFAX.VisibleIndex = 10;
            this.colFAX.Width = 68;
            // 
            // colPROVINCE
            // 
            this.colPROVINCE.FieldName = "PROVINCE";
            this.colPROVINCE.Name = "colPROVINCE";
            this.colPROVINCE.Visible = true;
            this.colPROVINCE.VisibleIndex = 11;
            this.colPROVINCE.Width = 68;
            // 
            // colDISTRICT
            // 
            this.colDISTRICT.FieldName = "DISTRICT";
            this.colDISTRICT.Name = "colDISTRICT";
            this.colDISTRICT.Visible = true;
            this.colDISTRICT.VisibleIndex = 12;
            this.colDISTRICT.Width = 68;
            // 
            // colADRESS
            // 
            this.colADRESS.FieldName = "ADRESS";
            this.colADRESS.Name = "colADRESS";
            this.colADRESS.Visible = true;
            this.colADRESS.VisibleIndex = 13;
            this.colADRESS.Width = 68;
            // 
            // colTAXOFFICE
            // 
            this.colTAXOFFICE.FieldName = "TAXOFFICE";
            this.colTAXOFFICE.Name = "colTAXOFFICE";
            this.colTAXOFFICE.Visible = true;
            this.colTAXOFFICE.VisibleIndex = 14;
            this.colTAXOFFICE.Width = 68;
            // 
            // colSPECIALCODE1
            // 
            this.colSPECIALCODE1.FieldName = "SPECIALCODE1";
            this.colSPECIALCODE1.Name = "colSPECIALCODE1";
            this.colSPECIALCODE1.Visible = true;
            this.colSPECIALCODE1.VisibleIndex = 15;
            this.colSPECIALCODE1.Width = 68;
            // 
            // colSPECIALCODE2
            // 
            this.colSPECIALCODE2.FieldName = "SPECIALCODE2";
            this.colSPECIALCODE2.Name = "colSPECIALCODE2";
            this.colSPECIALCODE2.Visible = true;
            this.colSPECIALCODE2.VisibleIndex = 16;
            this.colSPECIALCODE2.Width = 68;
            // 
            // colSPECIALCODE3
            // 
            this.colSPECIALCODE3.FieldName = "SPECIALCODE3";
            this.colSPECIALCODE3.Name = "colSPECIALCODE3";
            this.colSPECIALCODE3.Visible = true;
            this.colSPECIALCODE3.VisibleIndex = 17;
            this.colSPECIALCODE3.Width = 68;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridControl1.DataMember = "CompanyList";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1320, 484);
            this.gridControl1.TabIndex = 26;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_STORE_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "CompanyList";
            storedProcQuery1.StoredProcName = "CompanyList";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.BttnAddCompany);
            this.panel1.Controls.Add(this.BttnDelete);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 57);
            this.panel1.TabIndex = 51;
            // 
            // BttnAddCompany
            // 
            this.BttnAddCompany.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.BttnAddCompany.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnAddCompany.Appearance.Options.UseBackColor = true;
            this.BttnAddCompany.Appearance.Options.UseFont = true;
            this.BttnAddCompany.Location = new System.Drawing.Point(3, 18);
            this.BttnAddCompany.Name = "BttnAddCompany";
            this.BttnAddCompany.Size = new System.Drawing.Size(200, 20);
            this.BttnAddCompany.TabIndex = 2;
            this.BttnAddCompany.Text = "ADD NEW COMPANY";
            this.BttnAddCompany.Click += new System.EventHandler(this.BttnAddCompany_Click);
            // 
            // BttnDelete
            // 
            this.BttnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(64)))));
            this.BttnDelete.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnDelete.Appearance.Options.UseBackColor = true;
            this.BttnDelete.Appearance.Options.UseFont = true;
            this.BttnDelete.Location = new System.Drawing.Point(209, 18);
            this.BttnDelete.Name = "BttnDelete";
            this.BttnDelete.Size = new System.Drawing.Size(200, 20);
            this.BttnDelete.TabIndex = 3;
            this.BttnDelete.Text = "DELETE COMPANY";
            this.BttnDelete.Click += new System.EventHandler(this.BttnDelete_Click);
            // 
            // FrmCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCompanies";
            this.Text = "FrmCompanies";
            this.Load += new System.EventHandler(this.FrmCompanies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIMAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colTAXNO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY;
        private DevExpress.XtraGrid.Columns.GridColumn colAUTH_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colAUTH_NAME_SUR;
        private DevExpress.XtraGrid.Columns.GridColumn colSECTOR;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONE1;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONE2;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colFAX;
        private DevExpress.XtraGrid.Columns.GridColumn colPROVINCE;
        private DevExpress.XtraGrid.Columns.GridColumn colDISTRICT;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colTAXOFFICE;
        private DevExpress.XtraGrid.Columns.GridColumn colSPECIALCODE1;
        private DevExpress.XtraGrid.Columns.GridColumn colSPECIALCODE2;
        private DevExpress.XtraGrid.Columns.GridColumn colSPECIALCODE3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colDetails;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton BttnAddCompany;
        private DevExpress.XtraEditors.SimpleButton BttnDelete;
    }
}