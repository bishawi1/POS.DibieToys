using POS.Client;
using POS.Shared.DTOs;
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
    public partial class ItemUnitStockDetailsForm : Form
    {
        private int mlngItemUnitId = 0;
        public ItemUnitStockDetailsForm()
        {
            InitializeComponent();
        }
        public void initForm(int itemUnitId)
        {
            mlngItemUnitId = itemUnitId;
            GetData();
        }
        private async void GetData()
        {
            stockDetailsCriteriaViewModel criteria = new stockDetailsCriteriaViewModel()
            {
                Item_Unit_ID = mlngItemUnitId,
            };

            ResultModel result = await ItemQueryRepository.getStockDetails(criteria);
            if (result.StatusCode == "200")
            {
                if (result.Data != null)
                {
                    DataTable dt = General.ConvertToDataTable(result.Data);
                    grdDetails.AutoGenerateColumns = false;
                    grdDetails.DataSource = dt;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
