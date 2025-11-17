using POS.Windows.Forms.Books.Lookups;
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
    public partial class PublisherLov : Form
    {
        public bool mboolAccepted = false;
        private byte mintPublisherId = 0;
        public DataTable moDataTable;
        public bool newPublisher = false;
        public string publisherName = string.Empty;
        public int publisherId = 0;
        public PublisherLov()
        {
            InitializeComponent();
        }
        public int getSelectedPublisherId()
        {
            if (newPublisher)
                return publisherId;
            else if (grdList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdList.Rows[grdList.CurrentCell.RowIndex].Cells[colPublisher_ID.Name].Value);
            }
        }
        public string getSelectedPublisherName()
        {
            if (newPublisher)
                return publisherName;
            if (grdList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdList.Rows[grdList.CurrentCell.RowIndex].Cells[colPublisher_Desc.Name].Value.ToString();
            }
        }

        private async Task applySearch()
        {

            try
            {

                if (string.IsNullOrEmpty(txtPublisherName.Text.Trim()))
                {
                    moDataTable = General.PublihersDatatable;
                    grdList.AutoGenerateColumns = false;
                    grdList.DataSource = moDataTable;
                }
                else
                {
                    DataRow[] rows = General.PublihersDatatable.Select("Publisher_Desc Like '%" + txtPublisherName.Text + "%'");
                    if (rows.Count() > 0)
                    {
                        grdList.AutoGenerateColumns = false;
                        grdList.DataSource = rows.CopyToDataTable();
                    }
                }
                //ItemBrandRepository repository = new ItemBrandRepository();
                //ResultModel result = await repository.getAllAsync();

                //moDataTable = General.ConvertToDataTable(result.Data);

                //grdBrandList.AutoGenerateColumns = false;
                //grdBrandList.DataSource = moDataTable;
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

        private void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mboolAccepted = true;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PublisherDialog frm = new PublisherDialog();
            frm.initForm();
            frm.ShowDialog();
            if (frm.mboolAccepted)
            {
                newPublisher = true;
                publisherId = frm.LastAddedPublisherId;
                publisherName = frm.LastAddedPublisherName;
                General.LoadPublishers();
                frm.Close();
                frm.Dispose();
                mboolAccepted = true;
                this.Hide();
            }

        }

        private void txtPublisherName_TextChanged(object sender, EventArgs e)
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

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
