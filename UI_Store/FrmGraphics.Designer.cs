namespace UI_Store
{
    partial class FrmGraphics
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel2 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle2 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGraphics));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.CmbGraphSelection = new System.Windows.Forms.ComboBox();
            this.CmbProduct = new System.Windows.Forms.ComboBox();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.BttnLeastSelling = new DevExpress.XtraEditors.SimpleButton();
            this.BttnBestSelling = new DevExpress.XtraEditors.SimpleButton();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1344, 553);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.CmbGraphSelection);
            this.xtraTabPage1.Controls.Add(this.CmbProduct);
            this.xtraTabPage1.Controls.Add(this.chartControl1);
            this.xtraTabPage1.Controls.Add(this.chartControl3);
            this.xtraTabPage1.ImageOptions.Image = global::UI_Store.Properties.Resources.shelf1;
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1342, 525);
            this.xtraTabPage1.Text = "Products";
            // 
            // CmbGraphSelection
            // 
            this.CmbGraphSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGraphSelection.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbGraphSelection.FormattingEnabled = true;
            this.CmbGraphSelection.Items.AddRange(new object[] {
            "Products - Piece",
            "Brand - Piece"});
            this.CmbGraphSelection.Location = new System.Drawing.Point(15, 43);
            this.CmbGraphSelection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbGraphSelection.Name = "CmbGraphSelection";
            this.CmbGraphSelection.Size = new System.Drawing.Size(156, 27);
            this.CmbGraphSelection.TabIndex = 3;
            this.CmbGraphSelection.SelectedIndexChanged += new System.EventHandler(this.CmbGraphSelection_SelectedIndexChanged);
            // 
            // CmbProduct
            // 
            this.CmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProduct.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProduct.FormattingEnabled = true;
            this.CmbProduct.Location = new System.Drawing.Point(15, 81);
            this.CmbProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbProduct.Name = "CmbProduct";
            this.CmbProduct.Size = new System.Drawing.Size(156, 27);
            this.CmbProduct.TabIndex = 2;
            this.CmbProduct.Visible = false;
            this.CmbProduct.SelectedIndexChanged += new System.EventHandler(this.CmbProduct_SelectedIndexChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.LeftOutside;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartControl1.Name = "chartControl1";
            pieSeriesLabel1.ColumnIndent = 1;
            pieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            pieSeriesLabel1.TextPattern = "{A} - {VP:P} ({V:.##})";
            series1.Label = pieSeriesLabel1;
            series1.LegendTextPattern = "{A} : {V}";
            series1.Name = "Series 1";
            seriesTitle1.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            seriesTitle1.Indent = 8;
            seriesTitle1.MaxLineCount = 1;
            seriesTitle1.Text = "TOTAL PRODUCTS : {TV}";
            seriesTitle1.Visibility = DevExpress.Utils.DefaultBoolean.True;
            pieSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(1342, 525);
            this.chartControl1.TabIndex = 1;
            // 
            // chartControl3
            // 
            this.chartControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl3.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.LeftOutside;
            this.chartControl3.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.chartControl3.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl3.Location = new System.Drawing.Point(0, 0);
            this.chartControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartControl3.Name = "chartControl3";
            pieSeriesLabel2.ColumnIndent = 1;
            pieSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            pieSeriesLabel2.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            pieSeriesLabel2.TextPattern = "{A} - {VP:P} ({V:.##})";
            series2.Label = pieSeriesLabel2;
            series2.LegendTextPattern = "{A} : {V}";
            series2.Name = "Series 1";
            seriesTitle2.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            seriesTitle2.Indent = 8;
            seriesTitle2.MaxLineCount = 1;
            seriesTitle2.Text = "TOTAL PRODUCTS : {TV}";
            seriesTitle2.Visibility = DevExpress.Utils.DefaultBoolean.True;
            pieSeriesView2.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle2});
            series2.View = pieSeriesView2;
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl3.Size = new System.Drawing.Size(1342, 525);
            this.chartControl3.TabIndex = 4;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.BttnLeastSelling);
            this.xtraTabPage2.Controls.Add(this.BttnBestSelling);
            this.xtraTabPage2.Controls.Add(this.chartControl2);
            this.xtraTabPage2.ImageOptions.Image = global::UI_Store.Properties.Resources.growth;
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1342, 525);
            this.xtraTabPage2.Text = "Sales";
            // 
            // BttnLeastSelling
            // 
            this.BttnLeastSelling.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnLeastSelling.Appearance.Options.UseFont = true;
            this.BttnLeastSelling.ImageOptions.Image = global::UI_Store.Properties.Resources.arrow_down;
            this.BttnLeastSelling.Location = new System.Drawing.Point(1171, 14);
            this.BttnLeastSelling.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BttnLeastSelling.Name = "BttnLeastSelling";
            this.BttnLeastSelling.Size = new System.Drawing.Size(159, 27);
            this.BttnLeastSelling.TabIndex = 2;
            this.BttnLeastSelling.Text = "Least Selling";
            this.BttnLeastSelling.Click += new System.EventHandler(this.BttnLeastSelling_Click);
            // 
            // BttnBestSelling
            // 
            this.BttnBestSelling.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnBestSelling.Appearance.Options.UseFont = true;
            this.BttnBestSelling.ImageOptions.Image = global::UI_Store.Properties.Resources.arrow_up;
            this.BttnBestSelling.Location = new System.Drawing.Point(15, 14);
            this.BttnBestSelling.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BttnBestSelling.Name = "BttnBestSelling";
            this.BttnBestSelling.Size = new System.Drawing.Size(159, 27);
            this.BttnBestSelling.TabIndex = 1;
            this.BttnBestSelling.Text = "Best Selling";
            this.BttnBestSelling.Click += new System.EventHandler(this.BttnBestSelling_Click);
            // 
            // chartControl2
            // 
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram1;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl2.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartControl2.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl2.Legend.Margins.Bottom = 10;
            this.chartControl2.Legend.Margins.Left = 10;
            this.chartControl2.Legend.Margins.Right = 10;
            this.chartControl2.Legend.Margins.Top = 10;
            this.chartControl2.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.None;
            this.chartControl2.Legend.Name = "Legend";
            this.chartControl2.Legend.TextVisible = false;
            this.chartControl2.Legend.Title.DXFont = new DevExpress.Drawing.DXFont("Cambria", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.chartControl2.Legend.Title.Text = "Sales\r\n";
            this.chartControl2.Legend.Title.Visible = true;
            this.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl2.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.PaletteName = "Blue Warm";
            sideBySideBarSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesLabel1.TextOrientation = DevExpress.XtraCharts.TextOrientation.BottomToTop;
            sideBySideBarSeriesLabel1.TextPattern = "{A}";
            series3.Label = sideBySideBarSeriesLabel1;
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series3.Name = "Series 1";
            sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient;
            series3.View = sideBySideBarSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl2.Size = new System.Drawing.Size(1342, 525);
            this.chartControl2.TabIndex = 0;
            // 
            // FrmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 553);
            this.Controls.Add(this.xtraTabControl1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmGraphics";
            this.Text = "Graphs";
            this.Load += new System.EventHandler(this.FrmGraphics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.ComboBox CmbProduct;
        private System.Windows.Forms.ComboBox CmbGraphSelection;
        private DevExpress.XtraEditors.SimpleButton BttnLeastSelling;
        private DevExpress.XtraEditors.SimpleButton BttnBestSelling;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl3;
    }
}