using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApp.Services.Repositories
{
    public class InvoiceRepository
    {
        private readonly SqlConnection moConnection;

        public InvoiceRepository(SqlConnection connection) 
        {
            this.moConnection = connection;
        }
        public DataTable GetInvoiceDetails(int invoiceId)
        {
            POS_DAL.Invoice_Detail invoice_Detail = new POS_DAL.Invoice_Detail(moConnection);
            DataTable dataTable;
            invoice_Detail.Filter();
            invoice_Detail.Apply_Filter();
            dataTable = invoice_Detail.Export_LOV();
            return dataTable;
        }

    }
}
