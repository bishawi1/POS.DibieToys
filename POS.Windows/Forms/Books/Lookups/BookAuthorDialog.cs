using POS.Client;
using POS.Shared.DTOs;
using POS.Shared.DTOs.Books;
using POS.Shared.Models;
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
    public partial class BookAuthorDialog : Form
    {

        public bool mboolNewRecord = true;
        public bool mboolAccepted = false;
        public int LastAddedBookAuthorId = 0;
        public string LastAddedBookAuthorName = string.Empty;
        public int mintBookAuthorId = -99;
        private Book_AuthorModel model = null;

        public BookAuthorDialog()
        {
            InitializeComponent();
        }
        public short getBookAuthorId()
        {
            return Convert.ToInt16(txtBook_Author_ID.Text);
        }
        public string getBookAuthorName()
        {
            return txtBook_Author_Desc.Text;
        }
        public bool validateForm()
        {
            bool valid = false;
            if (string.IsNullOrEmpty(txtBook_Author_Desc.Text.Trim()))
            {
                valid = false;
                MessageBox.Show("يرجى تحديد الوصف");
                txtBook_Author_Desc.Focus();
            }
            return valid;
        }
        public bool addBookAuthor()
        {
            bool saved = false;
            CreateBook_AuthorRequestDto request = new CreateBook_AuthorRequestDto()
            {
                Book_Author_Desc = txtBook_Author_Desc.Text,
                Book_Author_Notes = txtBook_Author_Notes.Text,
                User_Name=General.currentUserName
            };
            ResultModel result = BookAuthorRepository.addBookAuthor(request);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        Book_AuthorModel bookAuthor = (Book_AuthorModel)result.Data;
                        txtBook_Author_ID.Text = bookAuthor.Book_Author_ID.ToString();
                        LastAddedBookAuthorId = bookAuthor.Book_Author_ID;
                        LastAddedBookAuthorName = bookAuthor.Book_Author_Desc;
                        saved = true;
                        return saved;
                    }
            return saved;
        }
        private bool editBookAuthor()
        {

            bool saved = false;
            UpdateBook_AuthorRequestDto modifyModel = new UpdateBook_AuthorRequestDto()
            {
                Book_Author_ID = Convert.ToInt32(txtBook_Author_ID.Text.Trim()),
                Book_Author_Desc = txtBook_Author_Desc.Text.Trim(),
                Book_Author_Notes=txtBook_Author_Notes.Text.Trim(),
                User_Name=General.currentUserName
            };
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result = BookAuthorRepository.editBookAuthor(modifyModel, model.Book_Author_ID);
            if (result != null)
            {
                if (result.StatusCode == "200")
                    saved = true;
            }
            return saved;
        }
        public void showData()
        {
            txtBook_Author_ID.Text = model.Book_Author_ID.ToString();
            txtBook_Author_Desc.Text = model.Book_Author_Desc;
            txtBook_Author_Notes.Text=model.Book_Author_Notes;
        }
        public bool saveForm()
        {
            bool saved = false;
            if (mboolNewRecord)
            {
                saved = addBookAuthor();
            }
            else
            {
                saved = editBookAuthor();
            }
            return saved;
        }
        private async void getData()
        {
            ResultModel result = await BookAuthorRepository.getBookAuthor(Convert.ToInt16(mintBookAuthorId));
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    if (result.Data != null)
                    {
                        model = (Book_AuthorModel)result.Data;
                        showData();
                    }
                }
            }
        }
        public void initForm(int bookAuthorId = -99)
        {

            mintBookAuthorId = bookAuthorId;
            if (bookAuthorId < 0)
            {
                mboolNewRecord = true;
            }
            else
            {
                mboolNewRecord = false;
                getData();
            }
            ;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (saveForm())
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
    }
}
