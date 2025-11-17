using POS.Windows.Forms.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.Forms.Books.LOVs
{
    public partial class Book_AuthorLOV : Form
    {
        public bool mboolAccepted = false;
        private byte mintBookAuthorId = 0;
        public DataTable moDataTable;
        public bool newBookAuthor = false;
        public string bookAuthorName = string.Empty;
        public int bookAuthorId = 0;

        public Book_AuthorLOV()
        {
            InitializeComponent();
        }
        public int getSelectedBookAuthorId()
        {
            if (newBookAuthor)
                return bookAuthorId;
            else if (grdList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdList.Rows[grdList.CurrentCell.RowIndex].Cells[colBook_Author_ID.Name].Value);
            }
        }
        public string getSelectedBookAuthorName()
        {
            if (newBookAuthor)
                return bookAuthorName;
            if (grdList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdList.Rows[grdList.CurrentCell.RowIndex].Cells[colBook_Author_Desc.Name].Value.ToString();
            }
        }

        private async Task applySearch()
        {

            try
            {

                if (string.IsNullOrEmpty(txtBook_Author_Desc.Text.Trim()))
                {
                    moDataTable = General.BookAuthorsDatatable;
                    grdList.AutoGenerateColumns = false;
                    grdList.DataSource = moDataTable;
                }
                else
                {
                    DataRow[] rows = General.BookAuthorsDatatable.Select("Book_Author_Desc Like '%" + txtBook_Author_Desc.Text + "%'");
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
            BookAuthorDialog frm = new BookAuthorDialog();
            frm.initForm();
            frm.ShowDialog();
            if (frm.mboolAccepted)
            {
                newBookAuthor = true;
                bookAuthorId = frm.LastAddedBookAuthorId;
                bookAuthorName = frm.LastAddedBookAuthorName;
                General.LoadBookAuthors();
                frm.Close();
                frm.Dispose();
                mboolAccepted = true;
                this.Hide();
            }

        }

        private void txtBook_Author_Desc_TextChanged(object sender, EventArgs e)
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
