using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using POS.Client;
using POS.DAL.Contracts;
using POS.DAL.Data;
using POS.Shared.DTOs;
using POS.Shared.Models.Auth;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows
{
    public static class General
    {
        public static WaitingFormDialog _waitForm;

        public static DataContext dataContext;
        public static string currentUserName;
        public static int currentUserId;
        public static bool mboolLogedin = false;

        public static string connectionString = "";// ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        public static Microsoft.Data.SqlClient.SqlConnection connection;//= new Microsoft.Data.SqlClient.SqlConnection(connectionString);
        public static bool dataLoaded { get; set; } = false;


        public static UserSession userSession { get; set; }

        public static string IP_Address = "";
        public static string ComputerName = "";
        public static byte defaultUnitId = 4;
        
        
        public static DataTable ItemGroupsDatatable;
        public static DataTable UnitsDatatable;
        public static DataTable ItemBrandsDatatable;
        public static DataTable BookAuthorsDatatable;

        public static DataTable PublihersDatatable;
        //public static DataTable BookCatsDatatable;
        public static DataTable BranchesDatatable;
        //public static DataTable StoreRoomsDatatable;
        public static DataTable SourcesDatatable;
        //public static DataTable BookCoversDatatable;
        //public static DataTable BookSizesDatatable;
        //public static DataTable SeriesesDatatable;
        public static DataTable SubjectsDatatable;
        //public static DataTable PublishersDatatable;
        //public static DataTable BookListsDatatable;
        public static DataTable CitiesDatatable;
        public static DataTable CurrenciesDatatable;
        public static DataTable BanksDatatable;

        public static byte defaultSupplyBranchId = 2;
        public static void ResizeImage(string inputPath, string outputPath, int width, int height)
        {
            using (Image image = Image.FromFile(inputPath))
            {
                Bitmap resizedImage = new Bitmap(width, height);
                using (Graphics graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.DrawImage(image, 0, 0, width, height);
                }
                resizedImage.Save(outputPath, ImageFormat.Jpeg);
            }
        }

        static void OpenGoogleMaps(double latitude, double longitude)
        {
            string url = $"https://www.google.com/maps?q={latitude},{longitude}";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        public static void navigateLocation()
        {
            double latitude = 37.7749;  // Example: San Francisco
            double longitude = -122.4194;
            OpenGoogleMaps(latitude, longitude);
        }

        public static string getCityName(byte cityId)
        {
            if (General.CitiesDatatable != null)
            {
                DataRow[] rows = General.CitiesDatatable.Select("City_ID = " + cityId.ToString());
                if (rows.Count() > 0)
                {
                    return rows[0]["City_Name"].ToString();
                }
            }
            return "";
        }
        public static bool HaveInternetConnection()
        {
            using (var ping = new Ping())
            {
                try
                {
                    bool result = true;
                    // In the method Send we can pass the IP or the Address
                    var checkPing = ping.Send("www.google.com");
                    if (checkPing.Status != IPStatus.Success)
                    {
                        result = false;
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static string RetMessageText(string ErrorCode)
        {
            string strErrorText = string.Empty;
            if (ErrorCode == "401")
            {
                strErrorText = "اسم/كلمة المرور غير صحيحة، يرجى اعادة المحاولة!";
            }

            return strErrorText;
        }
        public static void verifyHotLogin(string strUserName, string strPassword, bool boolAdminKey = true)
        {
            System.Data.DataSet oDataSet = new System.Data.DataSet();
            DataTable oDataTable = new DataTable();
            try
            {
                oDataTable.TableName = "LoginData";

                if (strUserName == "")
                {
                    MessageBox.Show("يرجى ادخال اسم المستخدم");
                }
                else if (strPassword.Trim() == "")
                {
                    MessageBox.Show("اسم المستخدم اوكلمة المرور غير صحيحة");
                }
                else
                {
                    UserSession oUserSession;
                    ResultModel oResult;
                    oResult = POS.Client.AuthRepository.login(strUserName, strPassword);
                    if (oResult.StatusCode == "200")
                    {
                        oUserSession = (UserSession)oResult.Data;
                        General.userSession = oUserSession;
                        mboolLogedin = true;
                    }
                    else
                    {
                        MessageBox.Show(RetMessageText(oResult.StatusCode));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void getComputerName()
        {
            //System.Environment.MachineName or
            ComputerName = Dns.GetHostName();
        }
        public static void getComputerIP()
        {
            //System.Environment.MachineName or
            int index = 0;
            foreach (var ip in Dns.GetHostByName(Environment.MachineName).AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IP_Address = ip.ToString();
                    break;
                }
            }
            IP_Address = Dns.GetHostByName(Environment.MachineName).AddressList[0].ToString();
        }

        public static string getCurrencyName(byte currencyId)
        {
            if (General.CurrenciesDatatable != null)
            {
                DataRow[] rows = General.CurrenciesDatatable.Select("Currency_Id = " + currencyId.ToString());
                if (rows.Count() > 0)
                {
                    return rows[0]["Currency_Name"].ToString();
                }
            }
            return "";
        }

        public static string getUnitDesc(byte unitId)
        {
            if (General.UnitsDatatable != null)
            {
                DataRow[] rows = General.UnitsDatatable.Select("Unit_Id = " + unitId.ToString());
                if (rows.Count() > 0)
                {
                    return rows[0]["Unit_Desc"].ToString();
                }
            }
            return "";
        }
        public static string getItemBrandName(byte itemBrandId)
        {
            if (General.ItemBrandsDatatable != null)
            {
                DataRow[] rows = General.ItemBrandsDatatable.Select("Item_Brand_ID = " + itemBrandId.ToString());
                if (rows.Count() > 0)
                {
                    return rows[0]["Item_Brand_Name"].ToString();
                }
            }
            return "";
        }
        public static string getBookAuthorName(byte bookAuthorId)
        {
            if (General.BookAuthorsDatatable != null)
            {
                DataRow[] rows = General.BookAuthorsDatatable.Select("Book_Author_ID = " + bookAuthorId.ToString());
                if (rows.Count() > 0)
                {
                    return rows[0]["Book_Author_Desc"].ToString();
                }
            }
            return "";
        }

        public static string GetPublisherName(byte publisherId)
        {
            if (General.PublihersDatatable != null)
            {
                DataRow[] rows = General.PublihersDatatable.Select("Publisher_ID = " + publisherId.ToString());
                if (rows.Count() > 0)
                {
                    return rows[0]["Publisher_Desc"].ToString();
                }
            }
            return "";
        }

        public static string getStartupPath()
        {
            var GetDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            return GetDirectory.ToString();
        }
        public static async Task<bool> LoadSources()
        {
            ResultModel oResult;
            oResult = await SourceRepository.getAllAsync();
            if (oResult.StatusCode == "200")
            {
                if (oResult.Data != null)
                {
                    SourcesDatatable = General.ConvertToDataTable(oResult.Data);
                }
            }
            return true;
        }
        public static async Task<bool> LoadCities()
        {
            ResultModel oResult;
            //POS.Client.General.dataContext = General.dataContext;
            POS.Client.CityRepository repository = new();

            oResult = await CityRepository.getAllAsync();

            if (oResult.StatusCode == "200")
            {
                if (oResult.Data != null)
                {
                    CitiesDatatable = General.ConvertToDataTable(oResult.Data);
                }
            }
            return true;
        }
        public static async Task<bool> LoadBanks()
        {
            ResultModel oResult;
            BankRepository oRepos = new BankRepository();
            oResult = await oRepos.getAllAsync();
            if (oResult.StatusCode == "200")
            {
                if (oResult.Data != null)
                {
                    BanksDatatable = General.ConvertToDataTable(oResult.Data);
                }
            }
            return true;
        }
        public static async Task<bool> LoadPublishers()
        {
            ResultModel oResult;
            oResult = await PublisherRepository.getAllAsync();
            if (oResult.StatusCode == "200")
            {
                if (oResult.Data != null)
                {
                    PublihersDatatable = General.ConvertToDataTable(oResult.Data);
                }
            }
            return true;
        }   
        public static async Task<bool> LoadBranches()
        {
            ResultModel oResult;
            oResult = await BranchRepository.getAllAsync();
            if (oResult.StatusCode == "200")
            {
                if (oResult.Data != null)
                {
                    BranchesDatatable = General.ConvertToDataTable(oResult.Data);
                }
            }
            return true;
        }           
        public static async Task<bool> LoadCurrencies()
        {
            ResultModel oResult;
            //POS.Client.General.dataContext = General.dataContext;
            POS.Client.CurrencyRepository repository = new();

            oResult = await repository.getAllAsync();

            if (oResult.StatusCode == "200")
            {
                if (oResult.Data != null)
                {
                    CurrenciesDatatable = General.ConvertToDataTable(oResult.Data);
                }
            }
            return true;
        }
        public static async Task<bool> LoadItemGroups()
        {
            ItemGroupRepository repository = new ItemGroupRepository();
            ResultModel result = await repository.getAllAsync();
            if (result.StatusCode == "200")
            {
                ItemGroupsDatatable = General.ConvertToDataTable(result.Data);
                
            }
            return true;
        }
        public static async Task<bool> LoadUnits()
        {
            UnitRepository repository = new UnitRepository();
            ResultModel result = await repository.getAllAsync();
            if (result.StatusCode == "200")
            {
                UnitsDatatable = General.ConvertToDataTable(result.Data);

            }
            return true;
        }
        public static async Task<bool> LoadItemBrands()
        {
            ItemBrandRepository repository = new ItemBrandRepository();
            ResultModel result = await repository.getAllAsync();
            if (result.StatusCode == "200")
            {
                ItemBrandsDatatable = General.ConvertToDataTable(result.Data);

            }
            return true;
        }
        public static async Task<bool> LoadBookAuthors()
        {
            //Client.BookAuthorRepository repository = new BookAuthorRepository();
            ResultModel result = await Client.BookAuthorRepository.getAllAsync();
            if (result.StatusCode == "200")
            {
                BookAuthorsDatatable = General.ConvertToDataTable(result.Data);

            }
            return true;
        }
        public static async Task<bool> LoadBookSubjects()
        {
            //Client.BookAuthorRepository repository = new BookAuthorRepository();
            ResultModel result = await Client.BookSubjectRepository.getAllAsync();
            if (result.StatusCode == "200")
            {
                SubjectsDatatable = General.ConvertToDataTable(result.Data);

            }
            return true;
        }
        public static string getSourceName(short sourceId)
        {
            if (General.SourcesDatatable != null)
            {
                DataRow[] rows = General.SourcesDatatable.Select("Book_Source_ID = " + sourceId.ToString());
                if (rows.Count() > 0)
                {
                    return rows[0]["Book_Source_Desc"].ToString();
                }
            }
            return "";
        }
        public static string getItemGroupDesc(short itemGroupId)
        {
            if (General.ItemGroupsDatatable != null)
            {
                DataRow[] rows = General.ItemGroupsDatatable.Select("Item_Group_ID = " + itemGroupId.ToString());
                if (rows.Count() > 0)
                {
                    return rows[0]["Item_Group_Desc"].ToString();
                }
            }
            return "";
        }


        private static void initLabelDataTable(DataTable oLabelTable)
        {
            oLabelTable.Columns.Add("Item_Unit_ID", System.Type.GetType("System.Int32"));
            oLabelTable.Columns.Add("Item_Desc", System.Type.GetType("System.String"));
            oLabelTable.Columns.Add("Item_Unit_Price", System.Type.GetType("System.Decimal"));
            oLabelTable.Columns.Add("Barcode", System.Type.GetType("System.String"));
            //oLabelTable.Columns.Add("Location", System.Type.GetType("System.String"));
        }
        public static void printLabel(PrintLabelViewModel model, ReportParameter[] parameters=null)
        {
            LabelCountDialog frm = new LabelCountDialog();
            if (model.BookCount == 0)
                frm.ShowDialog();
            else
            {
                frm.mboolAccepted = true;
                frm.mintRecordCount = model.BookCount;
            }
            if (frm.mboolAccepted)
            {
                DataTable oLabelTable = new DataTable();
                initLabelDataTable(oLabelTable);
                DataRow row = null;
                oLabelTable.Rows.Clear();
                for (int index = 0; index < frm.mintRecordCount; index++)
                {
                    row = oLabelTable.NewRow();
                    row["Item_Unit_ID"] = index;// Convert.ToInt32(txtBook_ID.Text);
                    row["Item_Desc"] = model.Item_Desc;// txtBook_Title.Text.Trim();
                    row["Item_Unit_Price"] = model.Item_Unit_Price;// txtISBN.Text.Trim();
                    row["Barcode"] = model.Barcode;// Convert.ToSingle(txtBook_Price.Text);
                    //row["Location"] = model.Location;// grdBookStock.Rows[grdBookStock.CurrentRow.Index].Cells[colLocation.Name].Value.ToString();
                    oLabelTable.Rows.Add(row);
                }
                ReportViewer report = new ReportViewer();
                report.initForm(oLabelTable.Copy(), General.getStartupPath() + @"\Reports\BookLabelReport.rdlc",parameters);
                report.Show();
            }
            frm.Close();
            frm.Dispose();
        }

        private static void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= OnLoaded;
            _waitForm.Close();
        }
        public static void Show_Wait_Form(string message)
        {
            bool cont = true;
            // don't display more than one wait form at a time

            if (_waitForm != null)
            {
                if (!_waitForm.IsDisposed)
                    cont = false;
            }
            if (cont == true)
            {
                _waitForm = new WaitingFormDialog();
                _waitForm.setMessage(message);  // "Loading data. Please wait..."
                _waitForm.TopMost = true;
                _waitForm.StartPosition = FormStartPosition.CenterScreen;
                _waitForm.Show();
                _waitForm.Refresh();

                // force the wait window to display for at least 700ms so it doesn't just flash on the screen
                System.Threading.Thread.Sleep(700);
                Application.Idle += OnLoaded;
            }
        }
        public static Double roundAmount(double amount)
        {
            double dig = (amount % 1);
            if (dig != 0 && dig < 0.5)
                amount = ((amount - dig) + 0.5);
            else if (dig != 0 && dig > 0.5)
                amount = ((amount - dig) + 1);

            return amount;
        }
        public static void ControlReceivedFocus(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.LightCyan;
            //Debug.WriteLine(sender + " received focus.");
        }
        public static void ControlLeaveFocus(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = default(Color);
        }
        public static void initMyControls(Control parenrControl)
        {
            //List<Control> c = Controls.OfType<TextBox>().Cast<Control>().ToList();

            foreach (Control control in parenrControl.Controls)
            {
                if (control.HasChildren)
                    initMyControls(control);
                else
                {
                    control.Enter += ControlReceivedFocus;
                    control.Leave += ControlLeaveFocus;
                }
            }
        }

        public static Microsoft.Data.SqlClient.SqlConnection retConnection()
        {
            try
            {
                if (connection != null)
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        return connection;
                    }
                    return connection;
                }
                else
                {
                    connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                    connection.Open();
                    return connection;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        //private static string _connectionString = @"Data Source=DESKTOP-JAEO25B\SQLEXPRESS;Initial Catalog=POS_ALKamal;User Id=sa;Password=allah;TrustServerCertificate=True;MultipleActiveResultSets=True";
        public static DataTable ConvertToDataTable(object oModel)
        {
            return JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(oModel));
        }

        //private static string _connectionString = @"Data Source=DESKTOP-82VGFT3\SQLEXPRESS;Initial Catalog=POS_ALKamal;User Id=sa;Password=allah;TrustServerCertificate=True;MultipleActiveResultSets=True";
        //private static SqlConnection _connection;
        //public static SqlConnection Connection 
        //{
        //    get 
        //    {
        //        if(_connection==null)
        //        {
        //            try
        //            {
        //                _connection = new SqlConnection();
        //                _connection.ConnectionString = _connectionString;
        //                _connection.Open();
        //            }
        //            catch (Exception ex)
        //            {
        //                throw ex;
        //            }

        //        }
        //        return _connection;
        //    }
        //    set
        //    {
        //        _connection = value;
        //    }
        //}



    }
}
