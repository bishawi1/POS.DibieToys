using POS.Shared.DTOs;
using POS.Shared.ViewModels.Books;
using POS.Windows.Forms.Books.LOVs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.Forms.Books
{
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
        }
        private async void getData()
        {
            General.Show_Wait_Form(Constants.mstrWaitingMessage);

            vBookQueryCriteriaViewModel criteria = new vBookQueryCriteriaViewModel();
            if (!string.IsNullOrEmpty(txtBook_ID.Text.Trim()))
            {
                criteria.BookId = Convert.ToInt32(txtBook_ID.Text);
            }
            if (!string.IsNullOrEmpty(txtBook_Title.Text.Trim()))
            {
                criteria.BookTitle = txtBook_Title.Text.Trim();
            }
            if (!string.IsNullOrEmpty(txtBook_Author_ID.Text.Trim()))
            {
                criteria.BookAuthorId = Convert.ToInt32(txtBook_Author_ID.Text);
            }
            if (!string.IsNullOrEmpty(txtBook_Publisher_ID.Text.Trim()))
            {
                criteria.PublisherId = Convert.ToInt16(txtBook_Publisher_ID.Text);
            }
            if (!string.IsNullOrEmpty(txtBook_Subject_ID.Text.Trim()))
            {
                criteria.SubjectId = Convert.ToByte(txtBook_Subject_ID.Text);
            }
            if (!string.IsNullOrEmpty(txtBook_Author_Desc.Text.Trim()))
            {
                criteria.BookAuthorName = txtBook_Author_Desc.Text.Trim();
            }
            if (!string.IsNullOrEmpty(txtFromRemainQNT.Text.Trim()))
            {
                criteria.FromRemainBookCount = Convert.ToInt32(txtFromRemainQNT.Text);
            }
            if (!string.IsNullOrEmpty(txtToRemainQNT.Text.Trim()))
            {
                criteria.ToRemainBookCount = Convert.ToInt32(txtToRemainQNT.Text);
            }
            if (!string.IsNullOrEmpty(txtFromBookPrice.Text.Trim()))
            {
                criteria.FromBookPrice = Convert.ToInt32(txtFromBookPrice.Text);
            }
            if (!string.IsNullOrEmpty(txtToBookPrice.Text.Trim()))
            {
                criteria.ToBookPrice = Convert.ToInt32(txtToBookPrice.Text);
            }
            if (!string.IsNullOrEmpty(txtBarcode.Text.Trim()))
            {
                criteria.Barcode = txtBarcode.Text;
            }
            ResultModel result = await Client.BookRepository.getAll(criteria);
            if (result != null)
            {
                if (result.Data != null)
                {
                    DataTable dt = General.ConvertToDataTable(result.Data);
                    grdBookList.AutoGenerateColumns = false;
                    grdBookList.DataSource = dt;
                    txtRecordCount.Text = grdBookList.Rows.Count.ToString();
                }
            }
        }
        public void initForm()
        {
            txtBook_Author_ID.Text = string.Empty;
            txtBook_Publisher_ID.Text = string.Empty;
            txtBook_Subject_ID.Text = string.Empty;
            txtFromRemainQNT.Text = "1";
            txtToRemainQNT.Text = string.Empty;
            txtFromBookPrice.Text = string.Empty;
            txtToBookPrice.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (grdBookList.CurrentRow != null)
            {
                int bookId = Convert.ToInt32(grdBookList.CurrentRow.Cells[colBook_ID.Name].Value);
                BookDialog frm = new BookDialog();
                frm.initForm(bookId);
                frm.ShowDialog();
            }
        }
        private void Show_Book_Author_ID_LOV()
        {
            Book_AuthorLOV lov = new();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtBook_Author_ID.Text = lov.getSelectedBookAuthorId().ToString();
                txtBook_Author_Desc.Text = lov.getSelectedBookAuthorName();
                txtBook_Publisher_ID.Focus();
            }
        }
        private void btnShow_Book_Author_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Book_Author_ID_LOV();
        }
        private void Show_Book_Publisher_ID_LOV()
        {
            PublisherLov lov = new();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtBook_Publisher_ID.Text = lov.getSelectedPublisherId().ToString();
                txtPublisher_Desc.Text = lov.getSelectedPublisherName();
                txtBook_Subject_ID.Focus();
            }
        }
        private void btnShow_Book_Publisher_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Book_Publisher_ID_LOV();
        }
        private void Show_Book_Subject_ID_LOV()
        {
            BookSubjectLOV lov = new();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtBook_Subject_ID.Text = lov.getSelectedBookSubjectId().ToString();
                txtBook_Subject_Desc.Text = lov.getSelectedBookSubjectDesc();
            }
        }
        private void btnShow_Book_Subject_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Book_Subject_ID_LOV();
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            BookDialog frm = new BookDialog();
            frm.initForm();
            frm.ShowDialog();
        }

        private void BookListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getData();
            }
        }

        private void tsbtnBeginingQnt_Click(object sender, EventArgs e)
        {
            if (grdBookList.CurrentRow != null)
            {
                ItemUnitBeginQntDialog frm = new ItemUnitBeginQntDialog();
                frm.MdiParent = this.MdiParent;
                frm.initForm(Convert.ToString(grdBookList.CurrentRow.Cells[colBarcode.Name].Value));
                frm.Show();
            }
        }
    }
}
