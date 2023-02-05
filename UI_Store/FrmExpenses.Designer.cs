namespace UI_Store
{
    partial class FrmExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpenses));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BttnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BttnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BttnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BttnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.GrpCntrl = new DevExpress.XtraEditors.GroupControl();
            this.LblTotalExpense = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.TxtExtraExpense = new DevExpress.XtraEditors.TextEdit();
            this.TxtInternet = new DevExpress.XtraEditors.TextEdit();
            this.TxtSalaries = new DevExpress.XtraEditors.TextEdit();
            this.TxtGas = new DevExpress.XtraEditors.TextEdit();
            this.TxtWater = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.CmbYear = new System.Windows.Forms.ComboBox();
            this.CmbMonth = new System.Windows.Forms.ComboBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.LblId = new DevExpress.XtraEditors.LabelControl();
            this.RchExplanation = new System.Windows.Forms.RichTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtElectric = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpCntrl)).BeginInit();
            this.GrpCntrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtExtraExpense.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSalaries.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtWater.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtElectric.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridControl1.Location = new System.Drawing.Point(12, 146);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1320, 395);
            this.gridControl1.TabIndex = 24;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.BttnClear);
            this.panel1.Controls.Add(this.BttnSave);
            this.panel1.Controls.Add(this.BttnDelete);
            this.panel1.Controls.Add(this.BttnUpdate);
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 34);
            this.panel1.TabIndex = 25;
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
            // GrpCntrl
            // 
            this.GrpCntrl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.GrpCntrl.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.GrpCntrl.Appearance.Options.UseBackColor = true;
            this.GrpCntrl.Appearance.Options.UseBorderColor = true;
            this.GrpCntrl.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.GrpCntrl.AppearanceCaption.Options.UseBackColor = true;
            this.GrpCntrl.CaptionImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.GrpCntrl.Controls.Add(this.LblTotalExpense);
            this.GrpCntrl.Controls.Add(this.labelControl11);
            this.GrpCntrl.Controls.Add(this.TxtExtraExpense);
            this.GrpCntrl.Controls.Add(this.TxtInternet);
            this.GrpCntrl.Controls.Add(this.TxtSalaries);
            this.GrpCntrl.Controls.Add(this.TxtGas);
            this.GrpCntrl.Controls.Add(this.TxtWater);
            this.GrpCntrl.Controls.Add(this.labelControl9);
            this.GrpCntrl.Controls.Add(this.CmbYear);
            this.GrpCntrl.Controls.Add(this.CmbMonth);
            this.GrpCntrl.Controls.Add(this.labelControl10);
            this.GrpCntrl.Controls.Add(this.LblId);
            this.GrpCntrl.Controls.Add(this.RchExplanation);
            this.GrpCntrl.Controls.Add(this.labelControl5);
            this.GrpCntrl.Controls.Add(this.labelControl6);
            this.GrpCntrl.Controls.Add(this.labelControl7);
            this.GrpCntrl.Controls.Add(this.labelControl8);
            this.GrpCntrl.Controls.Add(this.labelControl3);
            this.GrpCntrl.Controls.Add(this.labelControl4);
            this.GrpCntrl.Controls.Add(this.TxtElectric);
            this.GrpCntrl.Controls.Add(this.labelControl2);
            this.GrpCntrl.Controls.Add(this.labelControl1);
            this.GrpCntrl.Location = new System.Drawing.Point(12, -1);
            this.GrpCntrl.Name = "GrpCntrl";
            this.GrpCntrl.Size = new System.Drawing.Size(1320, 101);
            this.GrpCntrl.TabIndex = 26;
            this.GrpCntrl.Text = "Expenses This Month";
            // 
            // LblTotalExpense
            // 
            this.LblTotalExpense.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalExpense.Appearance.Options.UseFont = true;
            this.LblTotalExpense.Location = new System.Drawing.Point(1225, 79);
            this.LblTotalExpense.Name = "LblTotalExpense";
            this.LblTotalExpense.Size = new System.Drawing.Size(35, 14);
            this.LblTotalExpense.TabIndex = 33;
            this.LblTotalExpense.Text = "0.00 ₺";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(1204, 52);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(77, 14);
            this.labelControl11.TabIndex = 32;
            this.labelControl11.Text = "Total Expense";
            // 
            // TxtExtraExpense
            // 
            this.TxtExtraExpense.EditValue = "Electric";
            this.TxtExtraExpense.Location = new System.Drawing.Point(795, 72);
            this.TxtExtraExpense.Name = "TxtExtraExpense";
            this.TxtExtraExpense.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExtraExpense.Properties.Appearance.Options.UseFont = true;
            this.TxtExtraExpense.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtExtraExpense.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.TxtExtraExpense.Properties.MaskSettings.Set("hideInsignificantZeros", null);
            this.TxtExtraExpense.Properties.MaskSettings.Set("mask", "n");
            this.TxtExtraExpense.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.Null);
            this.TxtExtraExpense.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.TxtExtraExpense.Properties.UseMaskAsDisplayFormat = true;
            this.TxtExtraExpense.Size = new System.Drawing.Size(80, 20);
            this.TxtExtraExpense.TabIndex = 5;
            this.TxtExtraExpense.EditValueChanged += new System.EventHandler(this.TxtExtraExpense_EditValueChanged);
            // 
            // TxtInternet
            // 
            this.TxtInternet.EditValue = "Electric";
            this.TxtInternet.Location = new System.Drawing.Point(587, 72);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInternet.Properties.Appearance.Options.UseFont = true;
            this.TxtInternet.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtInternet.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.TxtInternet.Properties.MaskSettings.Set("hideInsignificantZeros", null);
            this.TxtInternet.Properties.MaskSettings.Set("mask", "n");
            this.TxtInternet.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.Null);
            this.TxtInternet.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.TxtInternet.Properties.UseMaskAsDisplayFormat = true;
            this.TxtInternet.Size = new System.Drawing.Size(80, 20);
            this.TxtInternet.TabIndex = 3;
            this.TxtInternet.EditValueChanged += new System.EventHandler(this.TxtInternet_EditValueChanged);
            // 
            // TxtSalaries
            // 
            this.TxtSalaries.EditValue = "Electric";
            this.TxtSalaries.Location = new System.Drawing.Point(691, 72);
            this.TxtSalaries.Name = "TxtSalaries";
            this.TxtSalaries.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalaries.Properties.Appearance.Options.UseFont = true;
            this.TxtSalaries.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtSalaries.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.TxtSalaries.Properties.MaskSettings.Set("hideInsignificantZeros", null);
            this.TxtSalaries.Properties.MaskSettings.Set("mask", "n");
            this.TxtSalaries.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.Null);
            this.TxtSalaries.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.TxtSalaries.Properties.UseMaskAsDisplayFormat = true;
            this.TxtSalaries.Size = new System.Drawing.Size(80, 20);
            this.TxtSalaries.TabIndex = 4;
            this.TxtSalaries.EditValueChanged += new System.EventHandler(this.TxtSalaries_EditValueChanged);
            // 
            // TxtGas
            // 
            this.TxtGas.EditValue = "Electric";
            this.TxtGas.Location = new System.Drawing.Point(483, 72);
            this.TxtGas.Name = "TxtGas";
            this.TxtGas.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGas.Properties.Appearance.Options.UseFont = true;
            this.TxtGas.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtGas.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.TxtGas.Properties.MaskSettings.Set("hideInsignificantZeros", null);
            this.TxtGas.Properties.MaskSettings.Set("mask", "n");
            this.TxtGas.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.Null);
            this.TxtGas.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.TxtGas.Properties.UseMaskAsDisplayFormat = true;
            this.TxtGas.Size = new System.Drawing.Size(80, 20);
            this.TxtGas.TabIndex = 2;
            this.TxtGas.EditValueChanged += new System.EventHandler(this.TxtGas_EditValueChanged);
            // 
            // TxtWater
            // 
            this.TxtWater.EditValue = "Electric";
            this.TxtWater.Location = new System.Drawing.Point(379, 72);
            this.TxtWater.Name = "TxtWater";
            this.TxtWater.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWater.Properties.Appearance.Options.UseFont = true;
            this.TxtWater.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtWater.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.TxtWater.Properties.MaskSettings.Set("hideInsignificantZeros", null);
            this.TxtWater.Properties.MaskSettings.Set("mask", "n");
            this.TxtWater.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.Null);
            this.TxtWater.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.TxtWater.Properties.UseMaskAsDisplayFormat = true;
            this.TxtWater.Size = new System.Drawing.Size(80, 20);
            this.TxtWater.TabIndex = 1;
            this.TxtWater.EditValueChanged += new System.EventHandler(this.TxtWater_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(605, 52);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(45, 14);
            this.labelControl9.TabIndex = 31;
            this.labelControl9.Text = "Internet";
            // 
            // CmbYear
            // 
            this.CmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbYear.FormattingEnabled = true;
            this.CmbYear.Items.AddRange(new object[] {
            "Year",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017"});
            this.CmbYear.Location = new System.Drawing.Point(67, 72);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(80, 21);
            this.CmbYear.TabIndex = 7;
            // 
            // CmbMonth
            // 
            this.CmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMonth.FormattingEnabled = true;
            this.CmbMonth.Items.AddRange(new object[] {
            "Month",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CmbMonth.Location = new System.Drawing.Point(171, 72);
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(80, 21);
            this.CmbMonth.TabIndex = 8;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(890, 62);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(65, 14);
            this.labelControl10.TabIndex = 18;
            this.labelControl10.Text = "Explanation";
            // 
            // LblId
            // 
            this.LblId.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Appearance.Options.UseFont = true;
            this.LblId.Location = new System.Drawing.Point(23, 72);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(4, 14);
            this.LblId.TabIndex = 17;
            this.LblId.Text = "-";
            // 
            // RchExplanation
            // 
            this.RchExplanation.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RchExplanation.Location = new System.Drawing.Point(961, 49);
            this.RchExplanation.Name = "RchExplanation";
            this.RchExplanation.Size = new System.Drawing.Size(199, 41);
            this.RchExplanation.TabIndex = 6;
            this.RchExplanation.Text = "";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(95, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 14);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Year";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(797, 52);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 14);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Extra Expense";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(709, 52);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(44, 14);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Salaries";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(513, 52);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(20, 14);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Gas";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(402, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 14);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Water";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(305, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 14);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Electric";
            // 
            // TxtElectric
            // 
            this.TxtElectric.EditValue = "Electric";
            this.TxtElectric.Location = new System.Drawing.Point(286, 72);
            this.TxtElectric.Name = "TxtElectric";
            this.TxtElectric.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtElectric.Properties.Appearance.Options.UseFont = true;
            this.TxtElectric.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtElectric.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.TxtElectric.Properties.MaskSettings.Set("hideInsignificantZeros", null);
            this.TxtElectric.Properties.MaskSettings.Set("mask", "n");
            this.TxtElectric.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.Null);
            this.TxtElectric.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.TxtElectric.Properties.UseMaskAsDisplayFormat = true;
            this.TxtElectric.Size = new System.Drawing.Size(80, 20);
            this.TxtElectric.TabIndex = 0;
            this.TxtElectric.EditValueChanged += new System.EventHandler(this.TxtElectric_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(194, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Month";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ID";
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 553);
            this.Controls.Add(this.GrpCntrl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmExpenses";
            this.Text = "FrmExpenses";
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrpCntrl)).EndInit();
            this.GrpCntrl.ResumeLayout(false);
            this.GrpCntrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtExtraExpense.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSalaries.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtWater.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtElectric.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton BttnClear;
        private DevExpress.XtraEditors.SimpleButton BttnSave;
        private DevExpress.XtraEditors.SimpleButton BttnDelete;
        private DevExpress.XtraEditors.SimpleButton BttnUpdate;
        private DevExpress.XtraEditors.GroupControl GrpCntrl;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ComboBox CmbYear;
        private System.Windows.Forms.ComboBox CmbMonth;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl LblId;
        private System.Windows.Forms.RichTextBox RchExplanation;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtElectric;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtExtraExpense;
        private DevExpress.XtraEditors.TextEdit TxtInternet;
        private DevExpress.XtraEditors.TextEdit TxtSalaries;
        private DevExpress.XtraEditors.TextEdit TxtGas;
        private DevExpress.XtraEditors.TextEdit TxtWater;
        private DevExpress.XtraEditors.LabelControl LblTotalExpense;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}