using POS.Client;
using POS.Shared.DTOs;
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

namespace POS.Windows.Lookups
{
    public partial class Source_Form : Form
    {
        public bool mboolNewRecord = true;
        public bool mboolAccepted = false;
        public int LastAddedSourceId = 0;
        public string LastAddedSourceDesc = string.Empty;
        public int mintSourceId = -99;
        private SourceModel model = null;
        public Source_Form()
        {
            InitializeComponent();
        }

        public short getSourceId()
        {
            return Convert.ToInt16(txtBook_Source_ID.Text);
        }
        public string getBookCatDesc()
        {
            return txtBook_Source_Desc.Text;
        }
        public bool validateForm()
        {
            bool valid = false;
            if (string.IsNullOrEmpty(txtBook_Source_Desc.Text.Trim()))
            {
                valid = false;
                MessageBox.Show("يرجى تحديد الوصف");
                txtBook_Source_Desc.Focus();
            }
            return valid;
        }
        public bool addBookSource()
        {
            bool saved = false;
            CreateSourceRequestDto model = new CreateSourceRequestDto()
            {
                Book_Source_Desc = txtBook_Source_Desc.Text.Trim(),
                Book_Source_Notes = txtBook_Source_Notes.Text.Trim(),
                User_Name = General.userSession.UserName
            };
            ResultModel result = SourceRepository.addSource(model);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        SourceModel bookCat = (SourceModel)result.Data;
                        txtBook_Source_ID.Text = bookCat.Book_Source_ID.ToString();
                        LastAddedSourceId = bookCat.Book_Source_ID;
                        LastAddedSourceDesc = bookCat.Book_Source_Desc;
                        saved = true;
                        return saved;
                    }
            return saved;
        }
        private bool editBookSource()
        {
            bool saved = false;
            UpdateSourceRequestDto modifyModel = new UpdateSourceRequestDto()
            {
                Book_Source_Desc = txtBook_Source_Desc.Text.Trim(),
                Book_Source_Notes = txtBook_Source_Notes.Text.Trim(),
                User_Name = General.userSession.UserName
            };
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result = SourceRepository.editBookSource(modifyModel, model.Book_Source_ID);
            if (result != null)
            {
                if (result.StatusCode == "200")
                    saved = true;
            }
            return saved;
        }
        public void showData()
        {
            txtBook_Source_ID.Text = model.Book_Source_ID.ToString();
            txtBook_Source_Desc.Text = model.Book_Source_Desc;
            txtBook_Source_Notes.Text = model.Book_Source_Notes;
        }
        public bool saveForm()
        {
            bool saved = false;
            if (mboolNewRecord)
            {
                saved = addBookSource();
            }
            else
            {
                saved = editBookSource();
            }
            return saved;
        }
        private async void getData()
        {
            ResultModel result = await SourceRepository.getSource(Convert.ToInt16(mintSourceId));
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    if (result.Data != null)
                    {
                        model = (SourceModel)result.Data;
                        showData();
                    }
                }
            }
        }

        public void initForm(int sourceId=-99)
        {

            mintSourceId = sourceId;
            if (sourceId < 0)
            {
                mboolNewRecord = true;
            }
            else
            {
                mboolNewRecord = false;
                getData();
            };

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (saveForm())
            {
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = true;
            this.Hide();
        }
    }
}
