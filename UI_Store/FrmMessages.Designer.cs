namespace UI_Store
{
    partial class FrmMessages
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEmail = new DevExpress.XtraEditors.TextEdit();
            this.RchMessage = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSubject = new DevExpress.XtraEditors.TextEdit();
            this.BttnSend = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(46, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "To";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(86, 12);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Properties.Appearance.Options.UseFont = true;
            this.TxtEmail.Size = new System.Drawing.Size(287, 22);
            this.TxtEmail.TabIndex = 1;
            // 
            // RchMessage
            // 
            this.RchMessage.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RchMessage.Location = new System.Drawing.Point(86, 71);
            this.RchMessage.Name = "RchMessage";
            this.RchMessage.Size = new System.Drawing.Size(287, 162);
            this.RchMessage.TabIndex = 2;
            this.RchMessage.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(28, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 15);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Subject";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 15);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Message";
            // 
            // TxtSubject
            // 
            this.TxtSubject.Location = new System.Drawing.Point(86, 40);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubject.Properties.Appearance.Options.UseFont = true;
            this.TxtSubject.Size = new System.Drawing.Size(287, 22);
            this.TxtSubject.TabIndex = 5;
            // 
            // BttnSend
            // 
            this.BttnSend.Appearance.BorderColor = System.Drawing.Color.Yellow;
            this.BttnSend.Appearance.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnSend.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.BttnSend.Appearance.Options.UseBorderColor = true;
            this.BttnSend.Appearance.Options.UseFont = true;
            this.BttnSend.Appearance.Options.UseForeColor = true;
            this.BttnSend.Location = new System.Drawing.Point(132, 238);
            this.BttnSend.Name = "BttnSend";
            this.BttnSend.Size = new System.Drawing.Size(181, 32);
            this.BttnSend.TabIndex = 6;
            this.BttnSend.Text = "SEND";
            this.BttnSend.Click += new System.EventHandler(this.BttnSend_Click);
            // 
            // FrmMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(396, 276);
            this.Controls.Add(this.BttnSend);
            this.Controls.Add(this.TxtSubject);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.RchMessage);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.labelControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMessages";
            this.Text = "FrmMessages";
            this.Load += new System.EventHandler(this.FrmMessages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox RchMessage;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtSubject;
        private DevExpress.XtraEditors.SimpleButton BttnSend;
        public DevExpress.XtraEditors.TextEdit TxtEmail;
    }
}