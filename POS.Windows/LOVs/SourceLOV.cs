using POS.Windows.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.LOVs
{
    public partial class SourceLOV : Form
    {
        public bool mboolAccepted = false;
        public DataTable moDataTable;
        public bool newSource = false;
        public string bookSourceDesc = string.Empty;
        public int bookSourceId = 0;

        public SourceLOV(int bookSourceId)
        {
            this.bookSourceId = bookSourceId;
        }

        public SourceLOV()
        {
            InitializeComponent();
        }
        public void initForm()
        {
            grdBookSourceList.AutoGenerateColumns = false;
            grdBookSourceList.DataSource = General.SourcesDatatable;
        }
        public int getSelectedBookSourceId()
        {
            if (newSource)
                return bookSourceId;
            else if (grdBookSourceList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdBookSourceList.Rows[grdBookSourceList.CurrentCell.RowIndex].Cells[colBook_Source_ID.Name].Value);
            }
        }

        public string getSelectedBookSourceDesc()
        {
            if (newSource)
                return bookSourceDesc;
            else if (grdBookSourceList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdBookSourceList.Rows[grdBookSourceList.CurrentCell.RowIndex].Cells[colBook_Source_Desc.Name].Value.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (grdBookSourceList.CurrentRow != null)
            {
                mboolAccepted = true;
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Close();

        }
        private async void applySearch()
        {
            try
            {
                DataRow[] rows = General.SourcesDatatable.Select("Book_Source_Desc Like '%" + txtBooktxtSource_Name.Text + "%'");
                if (rows.Count() > 0)
                {
                    grdBookSourceList.AutoGenerateColumns = false;
                    grdBookSourceList.DataSource = rows.CopyToDataTable();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            applySearch();
        }

        private void grdBookSourceList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBooktxtSource_Name_TextChanged(object sender, EventArgs e)
        {
            applySearch();
        }

        private void txtBooktxtSource_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                grdBookSourceList.Focus();
            else if (e.KeyCode == Keys.Escape)
            {
                mboolAccepted = false;
                this.Hide();
            }
        }

        private void grdBookSourceList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Source_Form frm = new Source_Form();
            frm.initForm();
            frm.ShowDialog();
            if (frm.mboolAccepted)
            {
                newSource = true;
                bookSourceId = frm.LastAddedSourceId;
                bookSourceDesc = frm.LastAddedSourceDesc;
                frm.Close();
                frm.Dispose();
                mboolAccepted = true;
                this.Hide();

            }
        }

        private void grdBookSourceList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdBookSourceList.CurrentRow != null)
            {
                mboolAccepted = true;
                this.Close();
            }
        }
    }
}
