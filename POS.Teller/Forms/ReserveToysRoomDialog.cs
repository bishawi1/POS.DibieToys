using Microsoft.Identity.Client.Extensibility;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Teller.Forms
{
    public partial class ReserveToysRoomDialog : Form
    {
        private int reserveToyRoomId = 0;
        private bool newRecord = true;
        public bool mboolAccepted = false;
        public ReserveToysRoomDialog()
        {
            InitializeComponent();
        }
        private async void showDetails()
        {
            ReserveToysRoomCriteriaViewModel criteria = new ReserveToysRoomCriteriaViewModel();
            criteria.Reserve_Toy_Room_ID = reserveToyRoomId;
            ResultModel oResult = await Client.TicketRepository.GetReserveToysRoomList(criteria);
            if (oResult.StatusCode == "200")
            {
                List<Reserve_Toy_RoomModel> reserveList = (List<Reserve_Toy_RoomModel>)oResult.Data;
                if (reserveList.Count > 0)
                {
                    txtReserve_Toy_Room_ID.Text = reserveList[0].Reserve_Toy_Room_ID.ToString();
                    txtReserver_Name.Text = reserveList[0].Reserver_Name;
                    txtKids_No.Value = reserveList[0].Kids_No;
                    dtDue_Date.Value = reserveList[0].Due_Date;
                    dtDueTime.Value = reserveList[0].Due_Date;
                    txtAmount.Value = reserveList[0].Amount;
                    chkCanceled.Checked = reserveList[0].Canceled;
                    chkDone.Checked = reserveList[0].Done;
                    if (chkCanceled.Checked || chkDone.Checked)
                    {
                        btnCancelReserve.Enabled = false;
                        btnDoReserve.Enabled = false;
                    }
                }
            }
        }
        public void initForm()
        {

        }
        public void initForm(int ReserveToyRoomId)
        {
            this.reserveToyRoomId = ReserveToyRoomId;
            newRecord = false;
            showDetails();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Hide();
        }

        private bool validateReservation()
        {
            bool boolValid = true;
            if (string.IsNullOrEmpty(txtReserver_Name.Text))
            {
                MessageBox.Show("يرجى تحديد طالب الحجز");
                boolValid = false;
            }
            else if (txtKids_No.Value == 0)
            {
                MessageBox.Show("يرجى تحديد عدد الاطفال");
                boolValid = false;
            }
            return boolValid;
        }
        private bool addReservation()
        {
            bool boolAdded = false;
            try
            {
                ResultModel oResult;
                AddReserveToysRookRequestDto model = new AddReserveToysRookRequestDto();
                model.Reserver_Name = txtReserver_Name.Text;
                model.Kids_No = (int)txtKids_No.Value;
                model.Due_Date = new DateTime(dtDue_Date.Value.Year, dtDue_Date.Value.Month, dtDue_Date.Value.Day, dtDueTime.Value.Hour, dtDueTime.Value.Minute, dtDueTime.Value.Second);
                model.User_Name = General.userSession.UserName;
                model.Amount = txtAmount.Value;
                oResult = Client.TicketRepository.addReserveToysRoom(model);
                if (oResult.StatusCode == "200")
                {
                    Reserve_Toy_RoomModel reserve = (Reserve_Toy_RoomModel)oResult.Data;
                    boolAdded = false;
                    txtReserve_Toy_Room_ID.Text = reserve.Reserve_Toy_Room_ID.ToString();
                    return boolAdded;
                }
                else
                {
                    MessageBox.Show("حدث خطأ اثناء اضافة الحجز: " + oResult.ErrorText);
                }
                return boolAdded;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ اثناء اضافة الحجز: " + ex.Message);
                return boolAdded;
            }
        }
        private async Task<bool> editReservation()
        {
            bool boolEdited = false;
            try
            {
                ResultModel oResult;
                EditReserveToysRookRequestDto model = new EditReserveToysRookRequestDto();
                model.Reserver_Name = txtReserver_Name.Text;
                model.Reserve_Toy_Room_ID = reserveToyRoomId;
                model.Kids_No = (int)txtKids_No.Value;
                model.Due_Date = new DateTime(dtDue_Date.Value.Year, dtDue_Date.Value.Month, dtDue_Date.Value.Day, dtDueTime.Value.Hour, dtDueTime.Value.Minute, dtDueTime.Value.Second);
                model.User_Name = General.userSession.UserName;
                model.Amount = txtAmount.Value;
                model.Notes = txtNotes.Text.Trim();
                oResult = await Client.TicketRepository.editReserveToysRoom(model);
                if (oResult.StatusCode == "200")
                {
                    Reserve_Toy_RoomModel reserve = (Reserve_Toy_RoomModel)oResult.Data;
                    boolEdited = false;
                    txtReserve_Toy_Room_ID.Text = reserve.Reserve_Toy_Room_ID.ToString();
                    return boolEdited;
                }
                else
                {
                    MessageBox.Show("حدث خطأ اثناء اضافة الحجز: " + oResult.ErrorText);
                }
                return boolEdited;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ اثناء اضافة الحجز: " + ex.Message);
                return boolEdited;
            }
        }
        private async Task<bool> saveReservation()
        {
            bool boolSaved = false;
            if (newRecord)
            {
                boolSaved = addReservation();
            }
            else
            {
                boolSaved = await editReservation();
            }
            return boolSaved;
        }
        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (validateReservation())
            {
                if (await saveReservation())
                {
                    mboolAccepted = true;
                    this.Hide();
                }
            }
        }

        private async void btnDoReserve_Click(object sender, EventArgs e)
        {
            ResultModel oResult = await Client.TicketRepository.DoReserveToysRoom(reserveToyRoomId);
            if (oResult.StatusCode == "200")
            {
                MessageBox.Show("تم تنفيذ الحجز بنجاح");
                mboolAccepted = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("حدث خطأ اثناء تنفيذ الحجز: " + oResult.ErrorText);
            }
        }

        private async void btnCancelReserve_Click(object sender, EventArgs e)
        {
            ResultModel oResult = await Client.TicketRepository.cancelReserveToysRoom(reserveToyRoomId);
            if (oResult.StatusCode == "200")
            {
                MessageBox.Show("تم الغاء الحجز بنجاح");
                mboolAccepted = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("حدث خطأ اثناء تنفيذ الحجز: " + oResult.ErrorText);
            }

        }
    }
}
