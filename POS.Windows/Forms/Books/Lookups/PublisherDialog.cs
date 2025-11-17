using POS.Client;
using POS.Shared.DTOs;
using POS.Shared.DTOs.Books;
using POS.Shared.Models;
using POS.Shared.Models.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.Forms.Books.Lookups
{
    public partial class PublisherDialog : Form
    {
        public bool mboolNewRecord = true;
        public bool mboolAccepted = false;
        public int LastAddedPublisherId = 0;
        public string LastAddedPublisherName = string.Empty;
        private PublisherModel model = null;
        public int mintPublisherId = -99;

        public PublisherDialog()
        {
            InitializeComponent();
        }
        public int getPublisherId()
        {
            return Convert.ToInt32(txtPublisher_ID.Text);
        }
        public string getPublisherName()
        {
            return txtPublisher_Desc.Text;
        }
        public bool validateForm()
        {
            bool valid = false;
            if (string.IsNullOrEmpty(txtPublisher_Desc.Text.Trim()))
            {
                valid = false;
                MessageBox.Show("يرجى تحديد الوصف");
            }
            return valid;
        }
        public bool addPublisher()
        {
            bool saved = false;
            CreatePublisherRequestDto model = new CreatePublisherRequestDto()
            {
                Publisher_Desc = txtPublisher_Desc.Text.Trim(),
                Publisher_Notes = txtPublisher_Notes.Text.Trim(),
                User_Name = General.currentUserName
            };
            ResultModel result = PublisherRepository.addPublisher(model);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        PublisherModel publisher = (PublisherModel)result.Data;
                        txtPublisher_ID.Text = publisher.Publisher_ID.ToString();
                        LastAddedPublisherId = publisher.Publisher_ID;
                        LastAddedPublisherName = publisher.Publisher_Desc;
                        saved = true;
                        return saved;
                    }
            return saved;
        }
        private bool editPublisher()
        {
            bool saved = false;
            UpdatePublisherRequestDto modifyModel = new UpdatePublisherRequestDto()
            {
                Publisher_ID = Convert.ToInt16(txtPublisher_ID.Text.Trim()),
                Publisher_Desc = txtPublisher_Desc.Text.Trim(),
                Publisher_Notes=txtPublisher_Notes.Text.Trim(),
                User_Name = General.currentUserName
            };
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result = PublisherRepository.editPublisher(modifyModel, model.Publisher_ID);
            if (result != null)
            {
                if (result.StatusCode == "200")
                    saved = true;
            }
            return saved;
        }
        public void showData()
        {
            txtPublisher_ID.Text = model.Publisher_ID.ToString();
            txtPublisher_Desc.Text = model.Publisher_Desc;
            txtPublisher_Notes.Text = model.Publisher_Notes;
        }
        private async void getData()
        {
            ResultModel result = await PublisherRepository.getPublisher(Convert.ToInt16(mintPublisherId));
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    if (result.Data != null)
                    {
                        model = (PublisherModel)result.Data;
                        showData();
                    }
                }
            }
        }
        public bool saveForm()
        {
            bool saved = false;
            if (mboolNewRecord)
            {
                saved = addPublisher();
            }
            else
            {
                saved = editPublisher();
            }
            return saved;
        }
        public void initForm(int publisherId = -99)
        {

            mintPublisherId = publisherId;
            if (publisherId < 0)
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
