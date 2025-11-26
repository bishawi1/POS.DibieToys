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
    public partial class TicketListForm : Form
    {
        public TicketListForm()
        {
            InitializeComponent();
        }
        public void initForm()
        {

        }
        private async Task applySearch()
        {
            TicketListCriteriaViewModel criteria = new TicketListCriteriaViewModel();
            if (txtFromTicketDate.Checked)
            {
                criteria.FromDate = $"{txtFromTicketDate.Value.Day}-{txtFromTicketDate.Value.Month}-{txtFromTicketDate.Value.Year}";
            }
            if (txtToTicketDate.Checked)
            {
                criteria.ToDate = $"{txtToTicketDate.Value.Day}-{txtToTicketDate.Value.Month}-{txtToTicketDate.Value.Year}";
            }
            ResultModel result = await Client.TicketRepository.getAllAsync(criteria);
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    List<TicketModel> tickets = (List<TicketModel>)result.Data;
                    DataTable dt = General.ConvertToDataTable(tickets);
                    grdTicketList.AutoGenerateColumns = false;
                    grdTicketList.DataSource = dt;
                }
                else
                {
                    MessageBox.Show(result.ErrorText);
                }
            }
            else
            {
                grdTicketList.Rows.Clear();
            }
        }
        private void btnApplySearch_Click(object sender, EventArgs e)
        {
            applySearch();
        }

        private void btnReservationList_Click(object sender, EventArgs e)
        {
        }
    }
}
