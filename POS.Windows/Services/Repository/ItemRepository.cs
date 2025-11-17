using Microsoft.Data.SqlClient;
using POS.DAL;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.Windows.Services.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Windows.Services.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly SqlConnection moConnection;

        public ItemRepository(SqlConnection connection)
        {
            this.moConnection = connection;
        }

        public DataTable GetItemGroup(int parentItemGroupId)
        {
            try
            {
                DataTable table = new DataTable();
                Item_Group item_Group = new Item_Group(moConnection);
                item_Group.Filter();
                item_Group.set_Item_Group_ID(0,Filter_Type.Not_Equel);
                item_Group.set_Parent_Item_Group_ID(parentItemGroupId,Filter_Type.Equal);
                item_Group.Apply_Filter();
                table = item_Group.Export_LOV();
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetItemGroup(string ItemGroupDesc)
        {
            try
            {
                DataTable table = new DataTable();
                Item_Group item_Group = new Item_Group(moConnection);
                item_Group.Filter();
                item_Group.set_Item_Group_ID(0,Filter_Type.Not_Equel);
                if (!string.IsNullOrEmpty(ItemGroupDesc))
                {
                    item_Group.set_Item_Group_Desc(ItemGroupDesc.Trim().Replace("  ", " "), Filter_Type.Contains);
                }
                item_Group.Apply_Filter();
                table = item_Group.Export_LOV();
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetUnitList()
        {
            try
            {
                DataTable table = new DataTable();
                Unit unit = new Unit(moConnection);
                unit.Filter();
                //if (!string.IsNullOrEmpty(ItemGroupDesc))
                //{
                //    item_Group.set_Item_Group_Desc(ItemGroupDesc.Trim().Replace("  ", " "), Filter_Type.Contains);
                //}
                unit.Apply_Filter();
                table = unit.Export_LOV();
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetItemBrandList(ItemBrandListCriteriaViewModel criteria)
        {
            try
            {
                DataTable table = new DataTable();
                Item_Brand brand = new Item_Brand(moConnection);
                brand.Filter();
                if(criteria != null)
                {
                    if(criteria.Item_Brand_ID!= null)
                    {
                        brand.set_Item_Brand_ID((long)criteria.Item_Brand_ID, Filter_Type.Equal);
                    }
                    if(!string.IsNullOrEmpty(criteria.Item_Brand_Name))
                    {
                        brand.set_Item_Brand_Name(criteria.Item_Brand_Name.Trim().Replace("  "," "), Filter_Type.Contains);
                    }                }
                //if (!string.IsNullOrEmpty(ItemGroupDesc))
                //{
                //    item_Group.set_Item_Group_Desc(ItemGroupDesc.Trim().Replace("  ", " "), Filter_Type.Contains);
                //}
                brand.Apply_Filter();
                table = brand.Export_LOV();
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Item_BrandModel GetItemBrand(int itemBrandId)
        {
            try
            {                
                Item_Brand itemBrand = new Item_Brand(moConnection);
                Item_BrandModel model = null;

                itemBrand.Filter();
                itemBrand.set_Item_Brand_ID((long)itemBrandId, Filter_Type.Equal);
                itemBrand.Apply_Filter();
                if (itemBrand.Record_Count() > 0)
                {
                    model = new Item_BrandModel()
                    {
                        Item_Brand_ID= (int)itemBrand.get_Item_Brand_ID(),
                        Item_Brand_Name=itemBrand.get_Item_Brand_Name()
                    };
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Item_BrandModel GetItemBrand(string itemBrandName)
        {
            try
            {
                Item_Brand itemBrand = new Item_Brand(moConnection);
                Item_BrandModel model = null;

                itemBrand.Filter();
                itemBrand.set_Item_Brand_Name(itemBrandName, Filter_Type.Equal);
                itemBrand.Apply_Filter();
                if (itemBrand.Record_Count() > 0)
                {
                    model = new Item_BrandModel()
                    {
                        Item_Brand_ID = (int)itemBrand.get_Item_Brand_ID(),
                        Item_Brand_Name = itemBrand.get_Item_Brand_Name()
                    };
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable GetItemUnitList(ItemListCriteriaViewModel criteria)
        {
            try
            {
                DataTable table = new DataTable();
                vItem_Unit itemUnit = new vItem_Unit(moConnection);

                itemUnit.Filter();
                if (criteria != null) {
                    if (criteria.Item_Group_ID != null)
                        itemUnit.set_Item_Group_ID((long)criteria.Item_Group_ID, Filter_Type.Equal);
                    if(criteria.Item_ID!=null)
                        itemUnit.set_Item_ID((long)criteria.Item_ID, Filter_Type.Equal);
                    if(!string.IsNullOrEmpty(criteria.Item_Desc))
                        itemUnit.set_Item_Desc(criteria.Item_Desc.Trim().Replace("  "," "),Filter_Type.Contains);
                    if (!string.IsNullOrEmpty(criteria.Barcode))
                        itemUnit.set_Barcode(criteria.Barcode.Trim().Replace("  ", " "), Filter_Type.Equal);
                }
                itemUnit.Apply_Filter();
                table = itemUnit.Export_LOV();
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddItem(AddItemRequestModel model)
        {
            bool boolSaved = false;
            using (SqlTransaction oTrans = moConnection.BeginTransaction())
            {
                try
                {
                    Item_Unit item_Unit = new Item_Unit(moConnection);
                    Item item = new Item(moConnection);
                    item.set_Transaction(oTrans);
                    item.Filter();
                    item.set_Item_ID( -99, Filter_Type.Equal);
                    item.Apply_Filter();
                    item.Add_New();
                    item.set_Item_Status_ID(0);
                    item.set_Item_Desc(model.Item_Desc.Trim());
                    if (!string.IsNullOrEmpty(model.ItemNotes))
                        item.set_Notes(model.ItemNotes.Trim());
                    //item.set_Item_No(item.Ret_Next_Item_ID().ToString());
                    item.set_User_Name(model.User_Name);
                    item.set_Item_Group_ID(model.ItemGroupID);
                    item.set_Item_Has_Expiry_Date(model.Has_Expiry_Date);
                    item.set_Time_Stamp(DateTime.Now);
                    item.Save_Item_Datails();


                    item_Unit.set_Transaction(oTrans);
                    item_Unit.Add_New();
                    item_Unit.set_Barcode(model.Barcode);
                    item_Unit.set_Is_Main_Unit(model.Is_Main_Unit);
                    item_Unit.set_Item_ID(item.get_Item_ID());
                    item_Unit.set_Item_Unit_Cost(model.Item_Unit_Cost);
                    item_Unit.set_Item_Unit_Price(model.Item_Unit_Price);
                    item_Unit.set_Unit_ID(model.UnitID);
                    item_Unit.set_User_Name(model.User_Name);
                    item_Unit.set_Time_Stamp(DateTime.Now);
                    item_Unit.Save_Item_Unit_Datails();
                    oTrans.Commit();
                    boolSaved = true;
                }
                catch (Exception)
                {
                    oTrans.Rollback();
                    throw;
                }
            }
            return boolSaved;
        }

        public bool UpdateItem(UpdateItemRequestModel model)
        {
            bool boolSaved = false;
            using (SqlTransaction oTrans = moConnection.BeginTransaction())
            {
                try
                {

                    Item_Unit item_Unit = new Item_Unit(moConnection);
                    Item item = new Item(moConnection);
                    item.set_Transaction(oTrans);
                    item.Filter();
                    item.set_Item_ID(model.Item_ID, Filter_Type.Equal);
                    item.Apply_Filter();
                    if (item.Record_Count() > 0)
                    {
                        item.set_Item_Desc(model.Item_Desc.Trim());
                        if (string.IsNullOrEmpty(model.ItemNotes))
                            item.set_Notes(string.Empty);
                        else
                        item.set_Notes(model.ItemNotes.Trim());
                    }
                    item.set_Item_Group_ID(model.ItemGroupID);
//                    item.set_Item_Has_Expiry_Date(model.Has_Expiry_Date);
                    item.Save_Item_Datails();


                    item_Unit.set_Transaction(oTrans);
                    item_Unit.Filter();
                    item_Unit.set_Item_Unit_ID(model.Item_Unit_Id,Filter_Type.Equal);
                    item_Unit.Apply_Filter();
                    if (item_Unit.Record_Count() > 0) 
                    {
                        item_Unit.set_Barcode(model.Barcode);
                        item_Unit.set_Is_Main_Unit(true);
                        item_Unit.set_Item_ID(item.get_Item_ID());
                        item_Unit.set_Item_Unit_Cost(model.Item_Unit_Cost);
                        item_Unit.set_Item_Unit_Price(model.Item_Unit_Price);
                        item_Unit.set_Unit_ID(model.UnitID);
                        //item_Unit.set_User_Name(model.User_Name);
                        //item_Unit.set_Time_Stamp(DateTime.Now);
                        item_Unit.Save_Item_Unit_Datails();
                    }
                    oTrans.Commit();
                    boolSaved = true;
                }
                catch (Exception)
                {
                    oTrans.Rollback();
                    throw;
                }
            }
            return boolSaved;
        }

        public vItem_UnitModel GetItemDetails(int itemId)
        {
            try
            {
                DataTable table = new DataTable();
                vItem_Unit itemUnit = new vItem_Unit(moConnection);
                vItem_UnitModel model = null;

                itemUnit.Filter();
                itemUnit.set_Item_ID((long) itemId, Filter_Type.Equal);
                itemUnit.Apply_Filter();
                if (itemUnit.Record_Count() > 0)
                {
                    model = new vItem_UnitModel()
                    {
                        Barcode=itemUnit.get_Barcode(),
                        Default_Unit=itemUnit.get_Default_Unit(),
                        Is_Main_Unit=itemUnit.get_Is_Main_Unit(),
                        Item_Desc=itemUnit.get_Item_Desc(),
                        Item_Group_Desc=itemUnit.get_Item_Group_Desc(),
                        Item_Group_ID= (short)itemUnit.get_Item_Group_ID(),
                        Item_Group_No=itemUnit.get_Item_Group_No(),
                        Item_ID= (int)itemUnit.get_Item_ID(),
                        Item_No=itemUnit.get_Item_No(),
                        Item_Unit_Cost=itemUnit.get_Item_Unit_Cost(),
                        Item_Unit_ID= (short)itemUnit.get_Item_Unit_ID(),
                        Item_Unit_Price=itemUnit.get_Item_Unit_Price(),
                        Qnt_In_Basic_Unit=itemUnit.get_Qnt_In_Basic_Unit(),
                        Unit_Desc=itemUnit.get_Unit_Desc(),
                        Unit_ID= (byte)itemUnit.get_Unit_ID(),
                        User_Name=itemUnit.get_User_Name(),
                        Time_Stamp=itemUnit.get_Time_Stamp(),
                        Notes=itemUnit.get_Notes(),
                    };
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
