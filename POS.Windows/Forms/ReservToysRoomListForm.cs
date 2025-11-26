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

namespace POS.Windows.Forms
{
    public partial class ReservToysRoomListForm : Form
    {
        DataTable reserveList = new DataTable();
        public ReservToysRoomListForm()
        {
            InitializeComponent();
        }
        public void initForm()
        {
            cmbStatus.SelectedIndex=0;
        }
        private void showDetails()
        {
            if (grdLIst.CurrentRow != null)
            {
                int selectedID = Convert.ToInt32(grdLIst.CurrentRow.Cells[colReserve_Toy_Room_ID.Name].Value);
                ReserveToysRoomDialog frm = new ReserveToysRoomDialog();
                frm.initForm(selectedID);
                frm.ShowDialog();
            }
        }
        private async void btnGetData_Click(object sender, EventArgs e)
        {
            ReserveToysRoomCriteriaViewModel criteria = new ReserveToysRoomCriteriaViewModel();
            switch (cmbStatus.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    criteria.getWaitingOnly = true;
                    break;
                case 2:
                    criteria.getDoneOnly = true;
                    break;
                case 3:
                    criteria.getDoneOnly = false;
                    criteria.getCanceledOnly = true;
                    break;
            }
            if (!string.IsNullOrEmpty(txtReserver_Name.Text.Trim()))
            {
                criteria.Reserver_Name = txtReserver_Name.Text.Trim();
            }
            List<Reserve_Toy_RoomModel> list = new List<Reserve_Toy_RoomModel>();
            ResultModel oResult = await Client.TicketRepository.GetReserveToysRoomList(criteria);
            if (oResult.StatusCode == "200")
            {
                list = (List<Reserve_Toy_RoomModel>)oResult.Data;
                reserveList = General.ConvertToDataTable(list);
                grdLIst.AutoGenerateColumns = false;
                grdLIst.DataSource = reserveList;
            }
            else
            {
                MessageBox.Show(oResult.ErrorText);
            }

        }

        private void tsbtnNew_Item_Click(object sender, EventArgs e)
        {
            ReserveToysRoomDialog frm = new ReserveToysRoomDialog();
            frm.initForm();
            frm.ShowDialog();
        }

        private void tsbtnShowItemDetails_Click(object sender, EventArgs e)
        {
            showDetails();
        }
    }
}
