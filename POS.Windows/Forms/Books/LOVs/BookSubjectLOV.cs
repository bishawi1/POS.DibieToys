using POS.Windows.Forms.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.Forms.Books.LOVs
{
    public partial class BookSubjectLOV : Form
    {
        public bool mboolAccepted = false;
        private byte mintBookSubjectId = 0;
        public DataTable moDataTable;
        public bool newBookSubject = false;
        public string bookSubjectDesc = string.Empty;
        public int bookSubjectId = 0;

        public BookSubjectLOV()
        {
            InitializeComponent();
        }
        public int getSelectedBookSubjectId()
        {
            if (newBookSubject)
                return bookSubjectId;
            else if (grdList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdList.Rows[grdList.CurrentCell.RowIndex].Cells[colBook_Subject_ID.Name].Value);
            }
        }
        public string getSelectedBookSubjectDesc()
        {
            if (newBookSubject)
                return bookSubjectDesc;
            if (grdList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdList.Rows[grdList.CurrentCell.RowIndex].Cells[colBook_Subject_Desc.Name].Value.ToString();
            }
        }

        private async Task applySearch()
        {

            try
            {

                if (string.IsNullOrEmpty(txtBook_Subject_Desc.Text.Trim()))
                {
                    moDataTable = General.SubjectsDatatable;
                    grdList.AutoGenerateColumns = false;
                    grdList.DataSource = moDataTable;
                }
                else
                {
                    DataRow[] rows = General.SubjectsDatatable.Select("Book_Subject_Desc Like '%" + txtBook_Subject_Desc.Text + "%'");
                    if (rows.Count() > 0)
                    {
                        grdList.AutoGenerateColumns = false;
                        grdList.DataSource = rows.CopyToDataTable();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void initForm()
        {
            applySearch();
            grdList.AutoGenerateColumns = false;
            grdList.DataSource = moDataTable;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            applySearch();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (grdList.CurrentRow != null)
            {
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Hide();
        }

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mboolAccepted = true;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemBrandDialog frm = new ItemBrandDialog();
            frm.initForm();
            frm.ShowDialog();
            if (frm.mboolAccepted)
            {
                newBookSubject = true;
                bookSubjectId = frm.LastAddedItemBrandId;
                bookSubjectDesc = frm.LastAddedItemBrandName;
                General.LoadBookSubjects();
                frm.Close();
                frm.Dispose();
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void txtBook_Subject_Desc_TextChanged(object sender, EventArgs e)
        {
            applySearch();
        }

        private void grdList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                mboolAccepted = true;
                this.Hide();
            }
        }
    }
}
