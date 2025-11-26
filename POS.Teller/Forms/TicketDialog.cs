using Newtonsoft.Json.Linq;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POS.Teller.Forms
{
    public partial class TicketDialog : Form
    {
        public TicketDialog()
        {
            InitializeComponent();
        }
        public void initForm(bool isBacked = false)
        {
            txtAmount.Text = "20";
            txtAmount_To_Pay.Text = "20";
            txtKids_Count.Text = "1";
            txtTotal_Amount.Text = "20";
            txtDiscount.Text = "0";
        }
        private void doCalculation()
        {
            txtAmount_To_Pay.Text = Convert.ToString(Convert.ToInt32(txtKids_Count.Text) * Convert.ToDecimal(txtAmount.Text) - Convert.ToDecimal(txtDiscount.Text));
            txtTotal_Amount.Text = Convert.ToString(Convert.ToInt32(txtKids_Count.Text) * Convert.ToDecimal(txtAmount.Text));
            txtKids_Count.Focus();
        }
        private void btnShow_Kids_Count_Calculator_Click(object sender, EventArgs e)
        {
            NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                txtKids_Count.Text = Convert.ToString(frm.Result);
                doCalculation();
            }

        }

        private void btnShow_Discount_Calculator_Click(object sender, EventArgs e)
        {
            NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                txtDiscount.Text = Convert.ToString(frm.Result);
                doCalculation();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<TicketModel> addTicket()
        {
            CreateTicketRequestDto requestDto = new CreateTicketRequestDto()
            {
                Amount = Convert.ToDecimal(txtAmount.Text),
                Discount = Convert.ToDecimal(txtDiscount.Text),
                Kids_Count = Convert.ToByte(txtKids_Count.Text),
                User_Name = "Admin"
            };
            try
            {
                ResultModel result = Client.TicketRepository.addTicket(requestDto);
                if (result != null)
                {
                    if (result.Data != null)
                    {
                        return (List<TicketModel>)result.Data;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void printTicket(List<TicketModel> tickets)
        {
            //List<TicketModel> tickets = new List<TicketModel>();

            //for(int index=0;index < Convert.ToByte(txtKids_Count.Text); index++)
            //{
            //    tickets.Add(ticket);
            //};
            DataTable dt = General.ConvertToDataTable(tickets);
            //ReportViewer report = new ReportViewer();
            //report.initForm(dt.Copy(), General.getStartupPath() + @"\Reports\TicketReport.rdlc", null);
            //report.Show();
            ReportViewer.PrintToPrinter(dt.Copy(), General.getStartupPath() + @"\Reports\TicketReport.rdlc", null);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            List<TicketModel> model = addTicket();
            if (model == null)
            {
                MessageBox.Show("لم تتم الاضافة");
            }
            else
            {
                printTicket(model);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
