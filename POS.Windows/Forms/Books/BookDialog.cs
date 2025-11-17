using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS.Client;
using POS.Shared.DTOs;
using POS.Shared.DTOs.Books;
using POS.Shared.Models;
using POS.Shared.Models.Books;
using POS.Shared.ViewModels;
using POS.Windows.Forms.Books.LOVs;
using POS.Windows.LOVs;
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
    public partial class BookDialog : Form
    {
        vBooksModel bookModel;
        public bool Accepted = false;
        private bool newRecord = true;
        private int bookId = 0;
        private int itemId = 0;
        private int itemUnitId = 0;
        private string ISBN=string.Empty;
        public BookDialog()
        {
            InitializeComponent();
        }
        private void clearScreen()
        {
            txtBook_Author_Desc.Text = string.Empty;
            txtBook_Author_ID.Text = string.Empty;
            txtBook_ID.Text = string.Empty;
            txtBook_Publisher_ID.Text = string.Empty;
            txtBook_Subject_Desc.Text = string.Empty;
            txtBook_Subject_ID.Text = string.Empty;
            txtBook_Title.Text = string.Empty;
            txtItem_Unit_Cost.Value = 0;
            txtItem_Unit_Price.Value = 0;
            txtPublisher_Desc.Text = string.Empty;
            txtQNT.Value = 0;
        }
        private async void showData()
        {
            ResultModel result = await Client.BookRepository.getBook(bookId);
            if (result != null)
            {
                if (result.Data != null)
                {
                    vBooksModel model = (vBooksModel)result.Data;
                    bookModel = model;
                    if (model != null)
                    {
                        ISBN = model.Barcode;
                        txtBook_ID.Text = model.Book_ID.ToString();
                        txtBook_Author_Desc.Text = model.Book_Author_Desc;
                        txtBook_Author_ID.Text = model.Book_Author_ID.ToString();
                        txtBook_Publisher_ID.Text = model.Book_Publisher_ID.ToString();
                        txtPublisher_Desc.Text = model.Publisher_Desc;
                        txtBook_Subject_Desc.Text = model.Publisher_Desc;
                        txtBook_Subject_ID.Text = model.Book_Subject_ID.ToString();
                        txtBook_Subject_Desc.Text = model.Book_Subject_Desc;
                        txtBook_Title.Text = model.Book_Title;
                        txtItem_Unit_Price.Value = model.Item_Unit_Price;
                        txtItem_Unit_Cost.Value = (decimal)model.Item_Unit_Cost;
                        itemUnitId = model.Item_Unit_ID;
                        itemId = model.Item_ID;
                    }
                }
            }
        }
        public void initForm()
        {
            lblQNT.Visible = true;
            txtQNT.Visible = true;
            chkPrintLableAfterSave.Visible = true;
            btnPrintBarcode.Visible = false;
            tsbtnShowOpeningQntDialog.Visible = false;
            newRecord = true;
            clearScreen();
        }
        public void initForm(int bookId)
        {
            newRecord = false;
            lblQNT.Visible = false;
            txtQNT.Visible = false;
            this.bookId = bookId;
            showData();
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
                txtItem_Unit_Price.Focus();
            }
        }
        private void btnShow_Book_Subject_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Book_Subject_ID_LOV();
        }
        private bool validateBook()
        {
            bool valid = true;
            return valid;
        }

        private async Task<Item_UnitModel> addBook()
        {
            try
            {
                string barcode = await ItemRepository.generateBarcode();
                General.Show_Wait_Form(Constants.mstrWaitingMessage);
                CreateBookRequestDto request = new CreateBookRequestDto();
                request.Book_Subject_ID = Convert.ToByte(string.IsNullOrEmpty(txtBook_Subject_ID.Text) ? "0" : txtBook_Subject_ID.Text);
                request.Book_Publisher_ID = Convert.ToInt16(string.IsNullOrEmpty(txtBook_Publisher_ID.Text) ? "0" : txtBook_Publisher_ID.Text);
                request.Book_Cat_ID = 0;
                request.Book_Author_ID = Convert.ToInt32(string.IsNullOrEmpty(txtBook_Author_ID.Text) ? "0" : txtBook_Author_ID.Text);
                request.Book_Title = txtBook_Title.Text;
                request.ISBN = barcode;
                request.User_Name = General.userSession.UserName;
                request.ItemUnitCost = txtItem_Unit_Cost.Value;
                request.ItemUnitPrice = txtItem_Unit_Price.Value;
                request.Qnt = Convert.ToInt32(txtQNT.Value);

                ResultModel result = await Client.BookRepository.add(request);
                if (result != null)
                {
                    if (result.Data != null)
                    {
                        return (Item_UnitModel)result.Data;
                    }
                    else
                    {
                        MessageBox.Show(result.ErrorText);
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private async Task<bool> editBook()
        {
            bool saved = false;
            try
            {
                General.Show_Wait_Form(Constants.mstrWaitingMessage);
                UpdateBookRequestDto request = new UpdateBookRequestDto();
                request.Book_ID = Convert.ToInt32(txtBook_ID.Text);
                request.Book_Subject_ID = Convert.ToByte(string.IsNullOrEmpty(txtBook_Subject_ID.Text) ? "0" : txtBook_Subject_ID.Text);
                request.Book_Publisher_ID = Convert.ToInt16(string.IsNullOrEmpty(txtBook_Publisher_ID.Text) ? "0" : txtBook_Publisher_ID.Text);
                request.Book_Cat_ID = 0;
                request.Book_Author_ID = Convert.ToInt32(string.IsNullOrEmpty(txtBook_Author_ID.Text) ? "0" : txtBook_Author_ID.Text);
                request.Book_Title = txtBook_Title.Text;
                request.User_Name = General.userSession.UserName;
                request.ItemUnitCost = txtItem_Unit_Cost.Value;
                request.ItemUnitPrice = txtItem_Unit_Price.Value;
                request.Qnt = Convert.ToInt32(txtQNT.Value);
                ResultModel result = await Client.BookRepository.update(request);
                if (result != null)
                {
                    if (result.Data != null)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return saved;
        }
        private void printLable(PrintLabelViewModel model, bool needGenerateBarcode)
        {
            if (needGenerateBarcode)
            {
                // generateBarcode();
            }
            General.printLabel(model);
        }
        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (validateBook() == true)
            {
                if (newRecord == true)
                {
                    Item_UnitModel bookItemUnit = await addBook();
                    if (bookItemUnit != null)
                    {
                        if (chkPrintLableAfterSave.Checked == true)
                        {
                            string bookDesc = $"{txtBook_Title.Text}/{txtPublisher_Desc.Text}";
                            PrintLabelViewModel model = new PrintLabelViewModel()
                            {
                                Barcode = bookItemUnit.Barcode,
                                //Barcode_Image_Path = General.getStartupPath() + @"\myBarcodeResized.jpeg",// txtBarcode.Text,
                                Item_Unit_Price = bookItemUnit.Item_Unit_Price,
                                Item_Desc = bookDesc,
                                Item_Unit_ID = bookItemUnit.Item_Unit_ID
                            };
                            General.printLabel(model);
                        }
                        clearScreen();
                        newRecord = true;
                    }
                }
                else
                {
                    if (await editBook())
                    {
                        //clearScreen();
                        //newRecord = true;
                        Accepted = true;
                        this.Hide();
                    }
                }
            }
        }
        private void printLable()
        {
            PrintLabelViewModel model = new PrintLabelViewModel()
            {
                Barcode = bookModel.Barcode,
                Barcode_Image_Path = General.getStartupPath() + @"\myBarcodeResized.jpeg",// txtBarcode.Text,
                Item_Unit_Price = bookModel.Item_Unit_Price,
                Item_Desc = bookModel.Book_Title,
                Item_Unit_ID = bookModel.Item_Unit_ID
            };//
            //ReportParameter parImagePath = new ReportParameter("parImagePath", new Uri(model.Barcode_Image_Path).AbsoluteUri);
            //ReportParameter[] parameters = { parImagePath };
            General.printLabel(model);
        }

        private void tsbtnPrintLabel_Click(object sender, EventArgs e)
        {
            printLable();
        }

        private void tsbtnItemStockDetails_Click(object sender, EventArgs e)
        {
            ItemUnitStockDetailsForm frm = new ItemUnitStockDetailsForm();
            frm.initForm(bookModel.Item_Unit_ID);
            frm.ShowDialog();
        }

        private async void tsbtnDelete_ClickAsync(object sender, EventArgs e)
        {
            DialogResult reply = MessageBox.Show("هل تود الاستمرار في الحذ، في حال الاستمرار لا يمكن التراجع!", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (reply == DialogResult.Yes)
            {
                ResultModel result = await ItemRepository.delete(bookModel.Item_ID);
                if (result != null)
                {
                    if (result.StatusCode == "200")
                    {
                        MessageBox.Show("تم الحذف");
                        this.Close();
                        //mboolAccepted = true;
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(result.ErrorText);
                    }
                }
                ;
            }
        }

        private void txtBook_Author_ID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtBook_Author_ID_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBook_Author_ID.Text))
                Show_Book_Author_ID_LOV();
        }

        private void txtBook_Publisher_ID_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBook_Publisher_ID.Text))
                Show_Book_Publisher_ID_LOV();
        }

        private void txtBook_Subject_ID_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBook_Subject_ID.Text))
                Show_Book_Subject_ID_LOV();
        }

        private void tsbtnShowOpeningQntDialog_Click(object sender, EventArgs e)
        {
            ItemUnitBeginQntDialog frm = new ItemUnitBeginQntDialog();
            frm.MdiParent = this.MdiParent;
            frm.initForm(ISBN);
            frm.Show();
        }
    }
}
