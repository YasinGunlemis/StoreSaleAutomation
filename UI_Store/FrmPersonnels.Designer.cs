namespace UI_Store
{
    partial class FrmPersonnels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonnels));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BttnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.LblId = new DevExpress.XtraEditors.LabelControl();
            this.RchAdress = new System.Windows.Forms.RichTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.BttnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BttnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BttnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BttnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.GrpCntrl = new DevExpress.XtraEditors.GroupControl();
            this.Pctbox1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEmail = new DevExpress.XtraEditors.TextEdit();
            this.CmbAuth = new System.Windows.Forms.ComboBox();
            this.CmbDistrict = new System.Windows.Forms.ComboBox();
            this.CmbProvince = new System.Windows.Forms.ComboBox();
            this.MskPhone = new System.Windows.Forms.MaskedTextBox();
            this.MskTrId = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpCntrl)).BeginInit();
            this.GrpCntrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pctbox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridControl1.Location = new System.Drawing.Point(10, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1320, 327);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.Lime;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 5;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // BttnChoose
            // 
            this.BttnChoose.Appearance.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnChoose.Appearance.Options.UseFont = true;
            this.BttnChoose.Location = new System.Drawing.Point(71, 147);
            this.BttnChoose.Name = "BttnChoose";
            this.BttnChoose.Size = new System.Drawing.Size(75, 19);
            this.BttnChoose.TabIndex = 20;
            this.BttnChoose.Text = "Choose";
            this.BttnChoose.Click += new System.EventHandler(this.BttnChoose_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(832, 79);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(39, 14);
            this.labelControl10.TabIndex = 18;
            this.labelControl10.Text = "Adress";
            // 
            // LblId
            // 
            this.LblId.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Appearance.Options.UseFont = true;
            this.LblId.Location = new System.Drawing.Point(231, 94);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(4, 14);
            this.LblId.TabIndex = 17;
            this.LblId.Text = "-";
            // 
            // RchAdress
            // 
            this.RchAdress.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RchAdress.Location = new System.Drawing.Point(898, 31);
            this.RchAdress.Name = "RchAdress";
            this.RchAdress.Size = new System.Drawing.Size(276, 116);
            this.RchAdress.TabIndex = 8;
            this.RchAdress.Text = "";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(318, 40);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 14);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Auth";
            // 
            // BttnClear
            // 
            this.BttnClear.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnClear.Appearance.Options.UseFont = true;
            this.BttnClear.Location = new System.Drawing.Point(717, 6);
            this.BttnClear.Name = "BttnClear";
            this.BttnClear.Size = new System.Drawing.Size(75, 23);
            this.BttnClear.TabIndex = 5;
            this.BttnClear.Text = "CLEAR";
            this.BttnClear.Click += new System.EventHandler(this.BttnClear_Click);
            // 
            // BttnSave
            // 
            this.BttnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(179)))));
            this.BttnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnSave.Appearance.Options.UseBackColor = true;
            this.BttnSave.Appearance.Options.UseFont = true;
            this.BttnSave.Location = new System.Drawing.Point(474, 6);
            this.BttnSave.Name = "BttnSave";
            this.BttnSave.Size = new System.Drawing.Size(75, 23);
            this.BttnSave.TabIndex = 2;
            this.BttnSave.Text = "SAVE";
            this.BttnSave.Click += new System.EventHandler(this.BttnSave_Click);
            // 
            // BttnDelete
            // 
            this.BttnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(64)))));
            this.BttnDelete.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnDelete.Appearance.Options.UseBackColor = true;
            this.BttnDelete.Appearance.Options.UseFont = true;
            this.BttnDelete.Location = new System.Drawing.Point(636, 6);
            this.BttnDelete.Name = "BttnDelete";
            this.BttnDelete.Size = new System.Drawing.Size(75, 23);
            this.BttnDelete.TabIndex = 3;
            this.BttnDelete.Text = "DELETE";
            this.BttnDelete.Click += new System.EventHandler(this.BttnDelete_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(577, 137);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 14);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "District";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(571, 103);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 14);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Province";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(586, 34);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 14);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Phone";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.BttnClear);
            this.panel1.Controls.Add(this.BttnSave);
            this.panel1.Controls.Add(this.BttnDelete);
            this.panel1.Controls.Add(this.BttnUpdate);
            this.panel1.Location = new System.Drawing.Point(10, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 34);
            this.panel1.TabIndex = 24;
            // 
            // BttnUpdate
            // 
            this.BttnUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(94)))));
            this.BttnUpdate.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnUpdate.Appearance.Options.UseBackColor = true;
            this.BttnUpdate.Appearance.Options.UseFont = true;
            this.BttnUpdate.Location = new System.Drawing.Point(555, 6);
            this.BttnUpdate.Name = "BttnUpdate";
            this.BttnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BttnUpdate.TabIndex = 4;
            this.BttnUpdate.Text = "UPDATE";
            this.BttnUpdate.Click += new System.EventHandler(this.BttnUpdate_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(289, 139);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 14);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Surname";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(366, 136);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurname.Properties.Appearance.Options.UseFont = true;
            this.TxtSurname.Size = new System.Drawing.Size(135, 20);
            this.TxtSurname.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(312, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 14);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(366, 102);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.Size = new System.Drawing.Size(135, 20);
            this.TxtName.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(191, 94);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(310, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "TR-ID";
            // 
            // GrpCntrl
            // 
            this.GrpCntrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GrpCntrl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.GrpCntrl.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.GrpCntrl.Appearance.Options.UseBackColor = true;
            this.GrpCntrl.Appearance.Options.UseBorderColor = true;
            this.GrpCntrl.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.GrpCntrl.AppearanceCaption.Options.UseBackColor = true;
            this.GrpCntrl.CaptionImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.GrpCntrl.Controls.Add(this.Pctbox1);
            this.GrpCntrl.Controls.Add(this.labelControl9);
            this.GrpCntrl.Controls.Add(this.TxtEmail);
            this.GrpCntrl.Controls.Add(this.CmbAuth);
            this.GrpCntrl.Controls.Add(this.CmbDistrict);
            this.GrpCntrl.Controls.Add(this.CmbProvince);
            this.GrpCntrl.Controls.Add(this.MskPhone);
            this.GrpCntrl.Controls.Add(this.MskTrId);
            this.GrpCntrl.Controls.Add(this.BttnChoose);
            this.GrpCntrl.Controls.Add(this.labelControl10);
            this.GrpCntrl.Controls.Add(this.LblId);
            this.GrpCntrl.Controls.Add(this.RchAdress);
            this.GrpCntrl.Controls.Add(this.labelControl5);
            this.GrpCntrl.Controls.Add(this.labelControl6);
            this.GrpCntrl.Controls.Add(this.labelControl7);
            this.GrpCntrl.Controls.Add(this.labelControl8);
            this.GrpCntrl.Controls.Add(this.labelControl3);
            this.GrpCntrl.Controls.Add(this.TxtSurname);
            this.GrpCntrl.Controls.Add(this.labelControl4);
            this.GrpCntrl.Controls.Add(this.TxtName);
            this.GrpCntrl.Controls.Add(this.labelControl2);
            this.GrpCntrl.Controls.Add(this.labelControl1);
            this.GrpCntrl.Location = new System.Drawing.Point(10, 337);
            this.GrpCntrl.Name = "GrpCntrl";
            this.GrpCntrl.Size = new System.Drawing.Size(1320, 169);
            this.GrpCntrl.TabIndex = 22;
            this.GrpCntrl.Text = "Personnel ";
            // 
            // Pctbox1
            // 
            this.Pctbox1.Location = new System.Drawing.Point(28, 26);
            this.Pctbox1.Name = "Pctbox1";
            this.Pctbox1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Pctbox1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.Pctbox1.Size = new System.Drawing.Size(143, 118);
            this.Pctbox1.TabIndex = 32;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(588, 67);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(32, 14);
            this.labelControl9.TabIndex = 31;
            this.labelControl9.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(645, 67);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Properties.Appearance.Options.UseFont = true;
            this.TxtEmail.Size = new System.Drawing.Size(136, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // CmbAuth
            // 
            this.CmbAuth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAuth.FormattingEnabled = true;
            this.CmbAuth.Items.AddRange(new object[] {
            "Please select bellow...",
            "Authorized",
            "Worker"});
            this.CmbAuth.Location = new System.Drawing.Point(366, 32);
            this.CmbAuth.Name = "CmbAuth";
            this.CmbAuth.Size = new System.Drawing.Size(135, 21);
            this.CmbAuth.TabIndex = 0;
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(645, 134);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(136, 21);
            this.CmbDistrict.TabIndex = 7;
            // 
            // CmbProvince
            // 
            this.CmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProvince.FormattingEnabled = true;
            this.CmbProvince.Location = new System.Drawing.Point(645, 100);
            this.CmbProvince.Name = "CmbProvince";
            this.CmbProvince.Size = new System.Drawing.Size(136, 21);
            this.CmbProvince.TabIndex = 6;
            this.CmbProvince.SelectedIndexChanged += new System.EventHandler(this.CmbProvince_SelectedIndexChanged);
            // 
            // MskPhone
            // 
            this.MskPhone.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskPhone.Location = new System.Drawing.Point(645, 32);
            this.MskPhone.Mask = "(999) 000-0000";
            this.MskPhone.Name = "MskPhone";
            this.MskPhone.Size = new System.Drawing.Size(136, 22);
            this.MskPhone.TabIndex = 4;
            // 
            // MskTrId
            // 
            this.MskTrId.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTrId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.MskTrId.Location = new System.Drawing.Point(366, 67);
            this.MskTrId.Margin = new System.Windows.Forms.Padding(4);
            this.MskTrId.Mask = "00000000000";
            this.MskTrId.Name = "MskTrId";
            this.MskTrId.Size = new System.Drawing.Size(135, 22);
            this.MskTrId.TabIndex = 1;
            this.MskTrId.ValidatingType = typeof(int);
            // 
            // FrmPersonnels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 553);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrpCntrl);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPersonnels";
            this.Text = "FrmPersonnels";
            this.Load += new System.EventHandler(this.FrmPersonnels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpCntrl)).EndInit();
            this.GrpCntrl.ResumeLayout(false);
            this.GrpCntrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pctbox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BttnChoose;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl LblId;
        private System.Windows.Forms.RichTextBox RchAdress;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton BttnClear;
        private DevExpress.XtraEditors.SimpleButton BttnSave;
        private DevExpress.XtraEditors.SimpleButton BttnDelete;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton BttnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtSurname;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl GrpCntrl;
        private System.Windows.Forms.MaskedTextBox MskTrId;
        private System.Windows.Forms.MaskedTextBox MskPhone;
        private System.Windows.Forms.ComboBox CmbAuth;
        private System.Windows.Forms.ComboBox CmbDistrict;
        private System.Windows.Forms.ComboBox CmbProvince;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit TxtEmail;
        private DevExpress.XtraEditors.PictureEdit Pctbox1;
    }
}