using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace POS.Teller
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }
        public static void PrintToPrinter(DataTable oDatatable, string reportPath, ReportParameter[] parameters)
        {
            LocalReport report=new LocalReport();
            report.ReportPath=reportPath;
            ReportDataSource oSource = new ReportDataSource("DataSet1", oDatatable.Copy());


            report.DataSources.Clear();
            if (parameters != null)
            {
                report.EnableExternalImages = true;
                report.SetParameters(parameters);
            }

            report.DataSources.Add(oSource);
            report.Refresh();

            PageSettings pageSettings = new PageSettings();
            pageSettings.PaperSize=report.GetDefaultPageSettings().PaperSize;
            pageSettings.Landscape=report.GetDefaultPageSettings().IsLandscape;
            pageSettings.Margins=report.GetDefaultPageSettings().Margins;


            print(report, pageSettings);
        }
        public static void print(LocalReport report, PageSettings pageSettings, string printerName="")
        {

            string deviceInfo =
              $@"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>{pageSettings.PaperSize.Width / 100.0}in</PageWidth>
                <PageHeight>{pageSettings.PaperSize.Height / 100.0}in</PageHeight>
                <MarginTop>{pageSettings.Margins.Top / 100.0}in</MarginTop>
                <MarginLeft>{pageSettings.Margins.Left / 100.0}in</MarginLeft>
                <MarginRight>{pageSettings.Margins.Right / 100.0}in</MarginRight>
                <MarginBottom>{pageSettings.Margins.Bottom / 100.0}in</MarginBottom>
                </DeviceInfo>";
            Warning[] warnings;
            var streams = new System.Collections.Generic.List<System.IO.Stream>();
            report.Render("Image", deviceInfo, (name, fileNameExtension, encoding, mimeType, willSeek) =>
            {
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                streams.Add(stream);
                return stream;
            }, out warnings);
            foreach (var stream in streams)
                stream.Position = 0;
            if(streams == null || streams.Count == 0)
                throw new Exception("No Stream To Print.");
            using(PrintDocument printDocument=new PrintDocument())
            {
                printDocument.DefaultPageSettings = pageSettings;
                if(!printDocument.PrinterSettings.IsValid)
                    throw new Exception("Can't Find Printer.");
                else
                {
                    int currentPageIndex = 0;
                    printDocument.PrintPage += (sender, e) =>
                    {
                        Metafile pageImage = new Metafile(streams[currentPageIndex]);
                        Rectangle adjustedRect = new Rectangle(
                            e.PageBounds.Left - (int)e.PageSettings.HardMarginX,
                            e.PageBounds.Top - (int)e.PageSettings.HardMarginY,
                            e.PageBounds.Width,
                            e.PageBounds.Height);
                        e.Graphics.FillRectangle(Brushes.White, adjustedRect);
                        e.Graphics.DrawImage(pageImage, adjustedRect);
                        currentPageIndex++;
                        e.HasMorePages = (currentPageIndex < streams.Count);
                        e.Graphics.DrawRectangle(Pens.Red, adjustedRect);
                    };
                    printDocument.EndPrint += (sender, e) =>
                    {
                        if (streams != null)
                        { 
                            foreach (var stream in streams)
                                stream.Close();
                            streams=null;
                        }
                    };
                    printDocument.Print();
                }
            }
        }
        public void initForm(DataTable oDatatable, string reportPath, ReportParameter[] parameters, string printerName=null,int pageWidth = 0,int pageHight =0 )
        {
            reportViewer1.LocalReport.ReportPath = reportPath;
            ReportDataSource oSource = new ReportDataSource("DataSet1", oDatatable.Copy());


            reportViewer1.LocalReport.DataSources.Clear();
            if (parameters != null)
            {
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
            }

            PrinterSettings printerSettings = new PrinterSettings();
            if (!string.IsNullOrEmpty(printerName))
            {
                printerSettings.PrinterName = printerName; // Set the specific printer
            }
            if (pageWidth > 0 && pageHight > 0)
            {
                PageSettings pageSettings = new PageSettings(printerSettings);
                pageSettings.PaperSize = new PaperSize("Custom", pageWidth, pageHight); // Adjust paper size
                                                                                        //reportViewer1.Print(pageSettings);
            }

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.LocalReport.DataSources.Add(oSource);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
        //public void PrintReport(DataTable oDatatable, string reportPath, string printerName = null, int pageWidth = 0, int pageHight = 0, ReportParameter[] parameters)
        //{
        //    reportViewer1.LocalReport.ReportPath = reportPath;
        //    ReportDataSource oSource = new ReportDataSource("DataSet1", oDatatable.Copy());

        //    PrinterSettings printerSettings = new PrinterSettings();
        //    printerSettings.PrinterName = printerName; // Set the specific printer

        //    if (pageWidth > 0 && pageHight > 0)
        //    {
        //        PageSettings pageSettings = new PageSettings(printerSettings);
        //        pageSettings.PaperSize = new PaperSize("Custom", pageWidth, pageHight); // Adjust paper size
        //    //reportViewer1.Print(pageSettings);
        //    }


        //    reportViewer1.LocalReport.DataSources.Clear();
        //    if (parameters != null)
        //    {
        //        reportViewer1.LocalReport.EnableExternalImages = true;
        //        reportViewer1.LocalReport.SetParameters(parameters);
        //    }
        //    reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        //    reportViewer1.ZoomMode = ZoomMode.Percent;
        //    reportViewer1.ZoomPercent = 100;
        //    reportViewer1.LocalReport.DataSources.Add(oSource);
        //    reportViewer1.LocalReport.Refresh();
        //    reportViewer1.RefreshReport();





        //    //PrinterSettings printerSettings = new PrinterSettings();
        //    //printerSettings.PrinterName = "Your Printer Name"; // Set the specific printer
        //}


        private void ReportViewer_Load(object sender, EventArgs e)
        {


        }
    }
}
