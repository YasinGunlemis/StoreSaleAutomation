using Business;
using DataAccess.Concrete;
using DevExpress.XtraRichEdit.Model;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UI_Store.FrmNotes;

namespace UI_Store
{
    public partial class FrmNotes : Form
    {
        NoteManager noteManager;
        Entity.Note note; 
        public FrmNotes()
        {
            InitializeComponent();
            noteManager = NoteManager.GetInstance();
        }

        private void FrmNotes_Load(object sender, EventArgs e)
        {
            NoteDatas();
            Clear();
        }

        void NoteDatas()
        {
            gridControl1.DataSource = noteManager.GetDataTable();
        }

        private void BttnSave_Click(object sender, EventArgs e)
        {
            note = new Entity.Note(dateEdit1.Text, timeEdit1.Text, TxtTitle.Text, RchNote.Text, TxtCreator.Text, TxtToWho.Text);
            string result = noteManager.Add(note);
            if (!result.Contains("success"))
            {
                MessageBox.Show(result, "Note Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(result, "Note Save",MessageBoxButtons.OK,MessageBoxIcon.Information);
            NoteDatas();
            Clear();
        }

        private void BttnUpdate_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "-" || LblId.Text == "") return;
            note = new Entity.Note(LblId.Text.ConInt(),dateEdit1.Text, timeEdit1.Text, TxtTitle.Text, RchNote.Text, TxtCreator.Text, TxtToWho.Text);
            string result = noteManager.Update(note);
            if (!result.Contains("success"))
            {
                MessageBox.Show(result, "Note Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(result, "Note Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NoteDatas();
            Clear();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            LblId.Text = dataRow["NOTEID"].ToString();
            dateEdit1.Text = dataRow["NOTEDATE"].ToString();
            timeEdit1.Text = dataRow["NOTETIME"].ToString();
            TxtTitle.Text = dataRow["NOTETITLE"].ToString();
            RchNote.Text = dataRow["NOTEDETAIL"].ToString();
            TxtCreator.Text = dataRow["NOTECREATOR"].ToString();
            TxtToWho.Text = dataRow["NOTETO"].ToString();

            gridView1.Columns["NOTEID"].Visible = false;
            gridView1.Columns["NOTEDETAIL"].Visible = false;
        }

        private void BttnDelete_Click(object sender, EventArgs e)
        {
            if (LblId.Text == "-" || LblId.Text == "") return;
            if (MessageBox.Show("Are you sure you want to permanently delete this note?","Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(noteManager.Delete(LblId.Text.ConInt()),"Info",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            NoteDatas();
            Clear();
        }

        void Clear()
        {
            dateEdit1.Text = "";
            timeEdit1.Text = "";
            TxtTitle.Text = "";
            TxtCreator.Text = "";
            TxtToWho.Text = "";
            RchNote.Text = "";
            LblId.Text = "";
        }

        private void BttnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
