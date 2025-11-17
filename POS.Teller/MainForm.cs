using POS.Shared.Models;
using POS.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void initForm()
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            POSForm frm = new POSForm();
            frm.initForm();
            frm.MdiParent = this;
            frm.Show();
        }
        private void loadCommonData()
        {
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            General.LoadBanks();
            General.LoadItems(0);
            General.loadItemGroupsAsync();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.initForm();
            frm.ShowDialog();
            if (General.mboolLogedin)
            {
                if (General.branchId == 2)
                {
                    tsbtnTicket.Visible=false;
                }
                //mainCategoryComponent.pnlContentBase.BackColor = Color.White;
                //initForm();
                //pnlQuickAccessButtons.Width = this.Width / 60;
                loadCommonData();
            }
            else
            {
                frm.Close();
                frm.Dispose();
                this.Close();
            }
        }

        private void tsbtnTicket_Click(object sender, EventArgs e)
        {
            TicketDialog frm = new TicketDialog();
            frm.initForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbtnBackSales_Click(object sender, EventArgs e)
        {
            POSForm frm = new POSForm();
            frm.initForm(true);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
