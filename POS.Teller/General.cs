using Newtonsoft.Json;
using POS.Client;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.Models.Auth;
using POS.Shared.ViewModels;
using POS.Teller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Teller
{
    public class General
    {
        public static WaitingFormDialog _waitForm;
        public static byte branchId = 0;
        public static int currentTellerId = 0;

        public static UserSession userSession { get; set; }

        public static bool mboolLogedin = false;

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


        public static PrinterSettings getPrinter(string printerName)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                if (printer == printerName)
                {
                    printerSettings.PrinterName = printerName;
                }
            }     
            return printerSettings;
        }

        //public static event EventHandler OnWaitFormDispose;
        private static void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= OnLoaded;
            _waitForm.Close();
        }
        public static DataTable BanksDatatable;

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
        public static void Show_Wait_Form(string message)
        {
            bool cont = true;
            // don't display more than one wait form at a time

            if (_waitForm != null)
            {
                if (!_waitForm.IsDisposed)
                {
                    cont = false;
                    //if(OnWaitFormDispose != null)
                    //    OnWaitFormDispose.Invoke(null, null);
                }
                    
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
        public static string getStartupPath()
        {
            var GetDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            return GetDirectory.ToString();
        }
        public static DataTable ConvertToDataTable(object oModel)
        {
            return JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(oModel));
        }
        public static DataTable ItemsDatatable;
        public static List<Item_GroupModel> itemGroupsList;
        public static List<vBranch_Item_UnitModel> itemList;

        public static void LoadItems(int branchId)
        {
            //SQLvItem_UnitRepository repository = new SQLvItem_UnitRepository(General.dataContext);
            //repository.getAllAsync("", "", "");

            Branch_ItemListCriteriaViewModel criteria = new Branch_ItemListCriteriaViewModel();
            if(branchId>0)
                criteria.Branch_ID=General.branchId;
            //if (!string.IsNullOrEmpty(txtBarcode.Text))
            //    criteria.Barcode = txtBarcode.Text.Trim();
            //if (!string.IsNullOrEmpty(txtItem_Desc.Text.Trim()))
            //    criteria.Item_Desc = txtItem_Desc.Text.Trim();
            //if (!string.IsNullOrEmpty(txtItem_Group_ID.Text))
            //    criteria.Item_Group_ID = Convert.ToInt32(txtItem_Group_ID.Text);
            //General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result =Task.Run(async()=> await ItemQueryRepository.getAll(criteria)).Result;
            if (result.StatusCode == "200")
            {
                itemList = (List<vBranch_Item_UnitModel>)result.Data;
                //ItemsDatatable = General.ConvertToDataTable(result.Data);
            }
        }
   
        public static void loadItemGroupsAsync()
        {
            ////ResultModel result = Task.Run(async () => await POS.Client.ItemGroupRepository.getItemSubGroupList(0)).Result;
            ItemGroupRepository repository = new ItemGroupRepository();
            ResultModel result = Task.Run(async () => await repository.getAllAsync()).Result;
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    itemGroupsList = (List<Item_GroupModel>)result.Data;


                }
            }

        }
    
        public static List<Item_GroupModel> retSubItemGroupList(short parentItemGroupId)
        {
            List<Item_GroupModel> selectedItemGroups = itemGroupsList.Where(r =>r.Item_Group_ID != 0 && r.Parent_Item_Group_ID == parentItemGroupId).ToList();
            return selectedItemGroups;
        }
        public static List<vBranch_Item_UnitModel> retItemGroupItemList(short ItemGroupId)
        {
            //List<vBranch_Item_UnitModel> selectedItemGroups = itemList.Where(r => r.Item_Group_ID == ItemGroupId && r.QuickAccess==true && r.Branch_ID== General.branchId).ToList();
            List<vBranch_Item_UnitModel> selectedItemGroups = itemList.Where(r => r.Item_Group_ID == ItemGroupId && r.QuickAccess==true ).ToList();
            var distinctAges = selectedItemGroups
    .Select(p => new { p.Item_Unit_ID,
        p.Barcode,
        p.FileUrl,
        p.Item_Desc,
        p.Item_ID,
        p.Item_No,
        p.Item_Unit_Cost,
        p.Item_Unit_Price,
        p.RemainQNT}).OrderBy(s=>s.Item_Unit_Price)
    .Distinct() 
    .ToList();
            List<vBranch_Item_UnitModel> result = new List<vBranch_Item_UnitModel> ();
            foreach (var group in distinctAges)
            {
                result.Add(new vBranch_Item_UnitModel
                {
                    Item_Unit_ID = group.Item_Unit_ID,
                    Barcode = group.Barcode,
                    FileUrl = group.FileUrl,
                    Item_Desc = group.Item_Desc,
                    Item_ID = group.Item_ID,
                    Item_No = group.Item_No,
                    RemainQNT = group.RemainQNT,
                    Item_Unit_Price = group.Item_Unit_Price,
                    Item_Unit_Cost = group.Item_Unit_Cost,

                });
            }
            return result;
        }
        public static  vBranch_Item_UnitModel retItem(string barcode)
        {
            if(itemList== null)
            {
                LoadItems(General.branchId);
            }
            vBranch_Item_UnitModel selectedItemGroups = itemList.Where(r => r.Barcode == barcode ).FirstOrDefault();
            if (selectedItemGroups == null)
            {
                MessageBox.Show("الصنف غير معرف");
                return null;
            } else
            {
                return selectedItemGroups;
            }            
        }
        public static void drawLine(int x1, int y1, int x2, int y2, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            e.Graphics.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
