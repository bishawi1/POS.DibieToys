using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }
        public void initForm(DataTable oDatatable, string reportPath, ReportParameter[] parameters )
        {
            reportViewer1.LocalReport.ReportPath = reportPath;
            ReportDataSource oSource = new ReportDataSource("DataSet1", oDatatable.Copy());


            reportViewer1.LocalReport.DataSources.Clear();
            if (parameters != null)
            {
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
            }

            reportViewer1.LocalReport.DataSources.Add(oSource);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {


        }
    }
}
