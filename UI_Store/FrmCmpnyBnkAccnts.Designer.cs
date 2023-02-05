namespace UI_Store
{
    partial class FrmCmpnyBnkAccnts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCmpnyBnkAccnts));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.LblSelectedValue = new System.Windows.Forms.Label();
            this.BttnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BttnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BttnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BttnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.TxtAccountNo = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DatePick = new DevExpress.XtraEditors.DateEdit();
            this.CmbCompany = new System.Windows.Forms.ComboBox();
            this.TxtBranch = new DevExpress.XtraEditors.TextEdit();
            this.CmbDistrict = new System.Windows.Forms.ComboBox();
            this.CmbProvince = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.MskPhone1 = new System.Windows.Forms.MaskedTextBox();
            this.MskIban = new System.Windows.Forms.MaskedTextBox();
            this.TxtBank = new DevExpress.XtraEditors.TextEdit();
            this.TxtAuthPerson = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePick.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePick.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAuthPerson.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridControl1.Location = new System.Drawing.Point(0, 205);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1341, 346);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.groupBox2.Controls.Add(this.checkedComboBoxEdit1);
            this.groupBox2.Controls.Add(this.LblSelectedValue);
            this.groupBox2.Controls.Add(this.BttnClear);
            this.groupBox2.Controls.Add(this.BttnSave);
            this.groupBox2.Controls.Add(this.BttnDelete);
            this.groupBox2.Controls.Add(this.BttnUpdate);
            this.groupBox2.Controls.Add(this.TxtAccountNo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DatePick);
            this.groupBox2.Controls.Add(this.CmbCompany);
            this.groupBox2.Controls.Add(this.TxtBranch);
            this.groupBox2.Controls.Add(this.CmbDistrict);
            this.groupBox2.Controls.Add(this.CmbProvince);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.LblId);
            this.groupBox2.Controls.Add(this.MskPhone1);
            this.groupBox2.Controls.Add(this.MskIban);
            this.groupBox2.Controls.Add(this.TxtBank);
            this.groupBox2.Controls.Add(this.TxtAuthPerson);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1341, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "120,20";
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(1183, 109);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.AllowMultiSelect = true;
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.checkedComboBoxEdit1.TabIndex = 80;
            this.checkedComboBoxEdit1.Visible = false;
            // 
            // LblSelectedValue
            // 
            this.LblSelectedValue.AutoSize = true;
            this.LblSelectedValue.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectedValue.ForeColor = System.Drawing.Color.White;
            this.LblSelectedValue.Location = new System.Drawing.Point(39, 187);
            this.LblSelectedValue.Name = "LblSelectedValue";
            this.LblSelectedValue.Size = new System.Drawing.Size(11, 15);
            this.LblSelectedValue.TabIndex = 79;
            this.LblSelectedValue.Text = "-";
            this.LblSelectedValue.Visible = false;
            // 
            // BttnClear
            // 
            this.BttnClear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.BttnClear.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnClear.Appearance.Options.UseBackColor = true;
            this.BttnClear.Appearance.Options.UseFont = true;
            this.BttnClear.Location = new System.Drawing.Point(940, 143);
            this.BttnClear.Name = "BttnClear";
            this.BttnClear.Size = new System.Drawing.Size(219, 23);
            this.BttnClear.TabIndex = 11;
            this.BttnClear.Text = "CLEAR";
            this.BttnClear.Click += new System.EventHandler(this.BttnClear_Click);
            // 
            // BttnSave
            // 
            this.BttnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(201)))));
            this.BttnSave.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnSave.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.BttnSave.Appearance.Options.UseBackColor = true;
            this.BttnSave.Appearance.Options.UseFont = true;
            this.BttnSave.Appearance.Options.UseForeColor = true;
            this.BttnSave.Location = new System.Drawing.Point(940, 41);
            this.BttnSave.Name = "BttnSave";
            this.BttnSave.Size = new System.Drawing.Size(219, 23);
            this.BttnSave.TabIndex = 8;
            this.BttnSave.Text = "SAVE";
            this.BttnSave.Click += new System.EventHandler(this.BttnSave_Click);
            // 
            // BttnDelete
            // 
            this.BttnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(201)))));
            this.BttnDelete.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnDelete.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BttnDelete.Appearance.Options.UseBackColor = true;
            this.BttnDelete.Appearance.Options.UseFont = true;
            this.BttnDelete.Appearance.Options.UseForeColor = true;
            this.BttnDelete.Location = new System.Drawing.Point(940, 109);
            this.BttnDelete.Name = "BttnDelete";
            this.BttnDelete.Size = new System.Drawing.Size(219, 23);
            this.BttnDelete.TabIndex = 10;
            this.BttnDelete.Text = "DELETE";
            this.BttnDelete.Click += new System.EventHandler(this.BttnDelete_Click);
            // 
            // BttnUpdate
            // 
            this.BttnUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.BttnUpdate.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnUpdate.Appearance.Options.UseBackColor = true;
            this.BttnUpdate.Appearance.Options.UseFont = true;
            this.BttnUpdate.Location = new System.Drawing.Point(940, 74);
            this.BttnUpdate.Name = "BttnUpdate";
            this.BttnUpdate.Size = new System.Drawing.Size(219, 23);
            this.BttnUpdate.TabIndex = 9;
            this.BttnUpdate.Text = "UPDATE";
            this.BttnUpdate.Click += new System.EventHandler(this.BttnUpdate_Click);
            // 
            // TxtAccountNo
            // 
            this.TxtAccountNo.Enabled = false;
            this.TxtAccountNo.Location = new System.Drawing.Point(554, 91);
            this.TxtAccountNo.Name = "TxtAccountNo";
            this.TxtAccountNo.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccountNo.Properties.Appearance.Options.UseFont = true;
            this.TxtAccountNo.Size = new System.Drawing.Size(233, 22);
            this.TxtAccountNo.TabIndex = 101;
            this.TxtAccountNo.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(469, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 71;
            this.label9.Text = "Account No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(508, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 70;
            this.label5.Text = "Date";
            // 
            // DatePick
            // 
            this.DatePick.EditValue = null;
            this.DatePick.Location = new System.Drawing.Point(554, 159);
            this.DatePick.Name = "DatePick";
            this.DatePick.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePick.Properties.Appearance.Options.UseFont = true;
            this.DatePick.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DatePick.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DatePick.Size = new System.Drawing.Size(233, 22);
            this.DatePick.TabIndex = 7;
            this.DatePick.Tag = "";
            // 
            // CmbCompany
            // 
            this.CmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCompany.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCompany.FormattingEnabled = true;
            this.CmbCompany.Location = new System.Drawing.Point(238, 25);
            this.CmbCompany.Name = "CmbCompany";
            this.CmbCompany.Size = new System.Drawing.Size(194, 23);
            this.CmbCompany.TabIndex = 0;
            this.CmbCompany.SelectedIndexChanged += new System.EventHandler(this.CmbCompany_SelectedIndexChanged);
            // 
            // TxtBranch
            // 
            this.TxtBranch.Location = new System.Drawing.Point(554, 122);
            this.TxtBranch.Name = "TxtBranch";
            this.TxtBranch.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBranch.Properties.Appearance.Options.UseFont = true;
            this.TxtBranch.Size = new System.Drawing.Size(233, 22);
            this.TxtBranch.TabIndex = 6;
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(238, 129);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(194, 23);
            this.CmbDistrict.TabIndex = 2;
            // 
            // CmbProvince
            // 
            this.CmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProvince.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProvince.FormattingEnabled = true;
            this.CmbProvince.Location = new System.Drawing.Point(238, 94);
            this.CmbProvince.Name = "CmbProvince";
            this.CmbProvince.Size = new System.Drawing.Size(194, 23);
            this.CmbProvince.TabIndex = 1;
            this.CmbProvince.SelectedIndexChanged += new System.EventHandler(this.CmbProvince_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(164, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 66;
            this.label12.Text = "Province";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(173, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 65;
            this.label13.Text = "District";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(493, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "Branch";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.White;
            this.LblId.Location = new System.Drawing.Point(39, 96);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(11, 15);
            this.LblId.TabIndex = 59;
            this.LblId.Text = "-";
            // 
            // MskPhone1
            // 
            this.MskPhone1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskPhone1.Location = new System.Drawing.Point(238, 164);
            this.MskPhone1.Mask = "(999) 000-0000";
            this.MskPhone1.Name = "MskPhone1";
            this.MskPhone1.Size = new System.Drawing.Size(194, 23);
            this.MskPhone1.TabIndex = 3;
            this.MskPhone1.Tag = "";
            // 
            // MskIban
            // 
            this.MskIban.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskIban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.MskIban.Location = new System.Drawing.Point(554, 57);
            this.MskIban.Margin = new System.Windows.Forms.Padding(4);
            this.MskIban.Mask = "TR00 0000 0000 0000 0000 0000 00";
            this.MskIban.Name = "MskIban";
            this.MskIban.Size = new System.Drawing.Size(233, 23);
            this.MskIban.TabIndex = 5;
            this.MskIban.TextChanged += new System.EventHandler(this.MskIban_TextChanged);
            // 
            // TxtBank
            // 
            this.TxtBank.Location = new System.Drawing.Point(554, 25);
            this.TxtBank.Name = "TxtBank";
            this.TxtBank.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBank.Properties.Appearance.Options.UseFont = true;
            this.TxtBank.Size = new System.Drawing.Size(233, 22);
            this.TxtBank.TabIndex = 4;
            this.TxtBank.Tag = "";
            // 
            // TxtAuthPerson
            // 
            this.TxtAuthPerson.Enabled = false;
            this.TxtAuthPerson.Location = new System.Drawing.Point(238, 60);
            this.TxtAuthPerson.Name = "TxtAuthPerson";
            this.TxtAuthPerson.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAuthPerson.Properties.Appearance.Options.UseFont = true;
            this.TxtAuthPerson.Size = new System.Drawing.Size(194, 22);
            this.TxtAuthPerson.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(182, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 58;
            this.label7.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(164, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 57;
            this.label8.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(505, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "Bank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Authorized Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(506, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "IBAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "ID";
            // 
            // FrmCmpnyBnkAccnts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 553);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCmpnyBnkAccnts";
            this.Text = "FrmCmpnyBnkAccnts";
            this.Load += new System.EventHandler(this.FrmCmpnyBnkAccnts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePick.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePick.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAuthPerson.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label LblId;
        public System.Windows.Forms.MaskedTextBox MskPhone1;
        public System.Windows.Forms.MaskedTextBox MskIban;
        public DevExpress.XtraEditors.TextEdit TxtBank;
        public DevExpress.XtraEditors.TextEdit TxtAuthPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.TextEdit TxtBranch;
        public System.Windows.Forms.ComboBox CmbDistrict;
        public System.Windows.Forms.ComboBox CmbProvince;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit DatePick;
        private System.Windows.Forms.ComboBox CmbCompany;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.TextEdit TxtAccountNo;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton BttnClear;
        private DevExpress.XtraEditors.SimpleButton BttnSave;
        private DevExpress.XtraEditors.SimpleButton BttnDelete;
        private DevExpress.XtraEditors.SimpleButton BttnUpdate;
        public System.Windows.Forms.Label LblSelectedValue;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
    }
}