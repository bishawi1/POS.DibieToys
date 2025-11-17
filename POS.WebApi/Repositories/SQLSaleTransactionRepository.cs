using Microsoft.EntityFrameworkCore;
using POS.Shared;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.WebApi.Contracts;
using POS.WebApi.Data;
using System.Threading.Tasks;

namespace POS.WebApi.Repositories
{
    public class SQLSaleTransactionRepository : ISaleTransaction
    {
        private readonly DataContext dbContext;

        public SQLSaleTransactionRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Sale_Transaction_Model> createAsync(Sale_Transaction_Model model)
        {
            int saleTransactionId = 0;
            if (dbContext.Sale_Transaction.Count() == 0)
            {
                saleTransactionId = 0;
            }
            else
            {
                saleTransactionId = dbContext.Sale_Transaction.Max(r => r.Sale_Transaction_ID);
            }

            model.Sale_Transaction_ID = saleTransactionId + 1;
            await dbContext.Sale_Transaction.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }

        private async Task<Sale_Transaction_Item_Model> AddItem(Sale_Transaction_Item_Model model)
        {
            int saleTransactionItemId = 0;
            if (dbContext.Sale_Transaction_Item.Count() == 0)
            {
                saleTransactionItemId = 0;
            }
            else
            {
                saleTransactionItemId = dbContext.Sale_Transaction_Item.Max(r => r.Sale_Transaction_Item_ID); 
            }
            model.Sale_Transaction_Item_ID = saleTransactionItemId + 1;
            await dbContext.Sale_Transaction_Item.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        private async Task<Sale_Transaction_Item_Model> UpdateItem(Sale_Transaction_Item_Model model)
        {
            dbContext.Sale_Transaction_Item.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<Stock_Model> addItemStockAsync(Stock_Model model)
        {
            int stockId = 0;
            if (dbContext.Stock.Count() == 0)
            {
                stockId = 0;
            }
            else
            {
                stockId = dbContext.Stock.Max(r => r.Stock_ID);
            }

            model.Stock_ID = stockId + 1;
            await dbContext.Stock.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }

        private int addSaleInvoice(int saleTransactionID,decimal voucherAmount, decimal discountAmount,short customerId, string paymentNotes, string userName)
        {
            int voucherID = 0;
            try
            {
                paymentNotes = string.IsNullOrEmpty(paymentNotes) ? "مبيعات" : paymentNotes;

                // Add Sales Invoice
                VoucherModel voucher = new VoucherModel()
                {
                    Pay_Way_Id = 0,//model.PayWayId,
                    User_Name = userName,
                    Debit_Amount = voucherAmount - discountAmount,// - model.PaidAmount,
                    Credit_Amount = 0,
                    Voucher_Currency_ID = 1,
                    Voucher_Currency_Rate = 1,
                    Voucher_Date = DateTime.Today,
                    voucher_Type_ID = 3,//Sales Invoice
                    Time_Stamp = General.GetCurrentTime(),
                    Voucher_Details = paymentNotes,
                    Person_ID = customerId,
                    Manual_Voucher_No = saleTransactionID.ToString(),
                };
                if (dbContext.Voucher.Count() == 0)
                    voucherID = 0;
                else
                    voucherID = dbContext.Voucher.Max(r => r.Voucher_ID);
                voucher.Voucher_ID = voucherID + 1;
                dbContext.Voucher.Add(voucher);
                dbContext.SaveChanges();
                voucherID = voucher.Voucher_ID;
                return voucherID;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private int editSaleInvoice(int saleTransactionID,decimal voucherAmount, decimal discountAmount,short customerId, string paymentNotes, string userName)
        {
            int voucherID = 0;
            try
            {
                paymentNotes = string.IsNullOrEmpty(paymentNotes) ? "مبيعات" : paymentNotes;

                // Add Sales Invoice
                VoucherModel voucher = retSalesTransactionInvoice(saleTransactionID);
                if (voucher != null) 
                {
                    voucher.Pay_Way_Id = 0;//model.PayWayId,
                    voucher.User_Name = userName;
                    voucher.Debit_Amount = voucherAmount - discountAmount;// - model.PaidAmount,
                    voucher.Credit_Amount = 0;
                    voucher.Voucher_Currency_ID = 1;
                    voucher.Voucher_Currency_Rate = 1;
                    voucher.Voucher_Date = DateTime.Today;
                    voucher.voucher_Type_ID = 3;//Sales Invoice
                    voucher.Time_Stamp = General.GetCurrentTime();
                    voucher.Voucher_Details = paymentNotes;
                    voucher.Person_ID = customerId;
                    voucher.Manual_Voucher_No = saleTransactionID.ToString();
                    
                    
                    dbContext.Voucher.Update(voucher);
                    dbContext.SaveChanges();
                    voucherID = voucher.Voucher_ID;
                    return voucherID;
                };
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        private int addSalePayment(int saleTransactionID, byte payWayId,decimal voucherAmount,decimal DiscountAmount, decimal paidAmount, short customerId,string chequeNo, DateTime chequeDueDate,byte bankNo, string paymentNotes, string userName)
        {
            bool addPayment = false;
            int voucherID=0;
            try
            {
                VoucherModel voucher = new VoucherModel()
                {
                    Pay_Way_Id = payWayId,
                    User_Name = userName,
                    Debit_Amount = 0,
                    Credit_Amount = voucherAmount - DiscountAmount - paidAmount,
                    Voucher_Currency_ID = 1,
                    Voucher_Currency_Rate = 1,
                    Voucher_Date = DateTime.Today,
                    voucher_Type_ID = 1,
                    Time_Stamp = General.GetCurrentTime(),
                    Voucher_Details = paymentNotes,
                    Person_ID = customerId,
                    Manual_Voucher_No = saleTransactionID.ToString(),
                };
                if (payWayId == 1)
                {
                    addPayment = true;
                }
                else if (payWayId == 2)//Debits
                {
                    if (customerId == 2) // Online Sale
                    {
                        addPayment = false;
                    }
                    else if (paidAmount > 0)
                    {
                        voucher.Credit_Amount = paidAmount;
                        addPayment = true;
                    }
                }
                else if (payWayId == 3)//cheque
                {
                    voucher.Cheque_No = chequeNo;
                    voucher.Cheque_Due_Date = chequeDueDate;
                    voucher.Cheque_Bank_No = bankNo;
                    addPayment = true;
                }
                else if (payWayId == 4) // Bank Transfere
                {
                    addPayment = true;
                }
                else if (payWayId == 5)// Visa
                {
                    addPayment = true;
                }

                if (addPayment)
                {
                    if (dbContext.Voucher.Count() == 0)
                        voucherID = 0;
                    else
                        voucherID = dbContext.Voucher.Max(r => r.Voucher_ID);
                    voucher.Voucher_ID = voucherID + 1;
                    dbContext.Voucher.Add(voucher);
                    dbContext.SaveChanges();
                }
                return voucherID;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private int editSalePayment(int saleTransactionID, byte payWayId, decimal voucherAmount, decimal DiscountAmount, decimal paidAmount, short customerId, string chequeNo, DateTime chequeDueDate, byte bankNo, string paymentNotes, string userName)
        {
            bool addPayment = false;
            int voucherID = 0;
            try
            {
                VoucherModel voucher = retSalesTransactionPayment(saleTransactionID);
                if(voucher!=null) 
                {
                    voucher.Pay_Way_Id = payWayId;
                    voucher.User_Name = userName;
                    voucher.Debit_Amount = 0;
                    voucher.Credit_Amount = voucherAmount - DiscountAmount - paidAmount;
                    voucher.Voucher_Currency_ID = 1;
                    voucher.Voucher_Currency_Rate = 1;
                    voucher.Voucher_Date = DateTime.Today;
                    voucher.voucher_Type_ID = 1;
                    voucher.Time_Stamp = General.GetCurrentTime();
                    voucher.Voucher_Details = paymentNotes;
                    voucher.Person_ID = customerId;
                    voucher.Manual_Voucher_No = saleTransactionID.ToString();
                    if (payWayId == 1)
                    {
                        addPayment = true;
                    }
                    else if (payWayId == 2)//Debits
                    {
                        if (customerId == 2) // Online Sale
                        {
                            addPayment = false;
                        }
                        else if (paidAmount > 0)
                        {
                            voucher.Credit_Amount = paidAmount;
                            addPayment = true;
                        }
                    }
                    else if (payWayId == 3)//cheque
                    {
                        voucher.Cheque_No = chequeNo;
                        voucher.Cheque_Due_Date = chequeDueDate;
                        voucher.Cheque_Bank_No = bankNo;
                        addPayment = true;
                    }
                    else if (payWayId == 4) // Bank Transfere
                    {
                        addPayment = true;
                    }
                    else if (payWayId == 5)// Visa
                    {
                        addPayment = true;
                    }

                    if (addPayment)
                    {
                        dbContext.Voucher.Update(voucher);
                        dbContext.SaveChanges();
                    }
                    return voucher.Voucher_ID;
                };
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private VoucherModel retSalesTransactionInvoice(int salesTransactionId)
        {
            try
            {
                VoucherModel voucher= dbContext.Voucher.FirstOrDefault(r=>r.Manual_Voucher_No==salesTransactionId.ToString() && r.voucher_Type_ID == 3);
                return voucher;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private VoucherModel retSalesTransactionPayment(int salesTransactionId)
        {
            try
            {
                VoucherModel voucher = dbContext.Voucher.FirstOrDefault(r => r.Manual_Voucher_No == salesTransactionId.ToString() && r.voucher_Type_ID == 1);
                return voucher;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task<bool> DeleteItemUnitFromInvoice(int itemUnitId, int saleTransactionitemId)
        {
            try
            {
                Sale_Transaction_Item_Model item = await dbContext.Sale_Transaction_Item.FirstOrDefaultAsync(r => r.Sale_Transaction_Item_ID == saleTransactionitemId);
                if (item != null)
                {
                    Stock_Model stock = await dbContext.Stock.FirstOrDefaultAsync(r => r.Transaction_ID == saleTransactionitemId && r.Transaction_Type_ID == 1);
                    if (stock != null)
                    {
                        dbContext.Stock.Remove(stock);
                    }
                    dbContext.Sale_Transaction_Item.Remove(item);
                    dbContext.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return true;
                }
                    
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<Sale_Transaction_Model> updateSaleAsync(UpdateSaleTransactionDto model)
        {
            decimal voucherAmount = 0;
            int voucherID;
            bool addPayment = false;
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    Sale_Transaction_Model oSale = dbContext.Sale_Transaction.FirstOrDefault(r => r.Sale_Transaction_ID == model.Sale_Transaction_ID);
                    if(oSale == null)
                    {
                        throw new Exception("Not Found");
                    } 
                    else
                    {
                        oSale.IsActive = model.IsActive;
                        oSale.Teller_ID = model.Teller_ID;
                        oSale.Customer_ID = model.Customer_ID;
                        oSale.Branch_ID = model.Branch_ID;
                        oSale.Transaction_Notes = model.Transaction_Notes;
                        oSale.Transaction_Date = model.Transaction_Date;
                        oSale.User_Name = model.User_Name;
                        oSale.Time_Stamp = General.GetCurrentTime();
                        oSale.Delevery_Fees = model.Delevery_Fees;
                        oSale.Delevery_Place = model.Delevery_Place;
                        oSale.Delevery_Transaction_No = model.Delevery_Transaction_No;
                        oSale.Discount_Amount = model.DiscountAmount;
                    };
                    oSale = await updateAsync((int)model.Sale_Transaction_ID, oSale);
                    if (oSale != null)
                    {
                        foreach (ModifyTransactionItemRequest soldItem in model.items)
                        {
                            if (soldItem.Sale_Transaction_Item_ID == 0)
                            {
                                Sale_Transaction_Item_Model newSaleItem = new()
                                {
                                    Discount_Amount = soldItem.Discount_Amount,
                                    IsActive = soldItem.IsActive,
                                    Item_Unit_ID = soldItem.Item_Unit_ID,
                                    Item_Unit_Price = soldItem.Item_Unit_Price,
                                    Item_Unit_Cost = soldItem.Item_Unit_Cost,

                                    Item_Unit_Price_After_Discount = soldItem.Item_Unit_Price_After_Discount,
                                    Notes = soldItem.Notes,
                                    QNT = soldItem.QNT,
                                    User_Name = soldItem.User_Name,
                                    Time_Stamp = General.GetCurrentTime(),
                                    Sale_Transaction_ID = oSale.Sale_Transaction_ID,
                                };
                                voucherAmount += newSaleItem.Item_Unit_Price_After_Discount * newSaleItem.QNT;
                                newSaleItem = await AddItem(newSaleItem);
                                if (newSaleItem != null)
                                {
                                    Stock_Model stock_Model = new()
                                    {
                                        Branch_ID=model.Branch_ID,
                                        In_QNT = 0,
                                        Out_QNT = soldItem.QNT,
                                        Item_Unit_ID = soldItem.Item_Unit_ID,
                                        Transaction_ID = (int)soldItem.Sale_Transaction_Item_ID,
                                        User_Name = soldItem.User_Name,
                                        Time_Stamp = General.GetCurrentTime(),
                                        Stock_Notes = string.Empty,
                                        Transaction_Type_ID = 1
                                    };
                                    stock_Model = await addItemStockAsync(stock_Model);
                                    if (stock_Model != null)
                                    {
                                        Transaction_Model transaction_ = new Transaction_Model()
                                        {

                                            Reference_ID = newSaleItem.Sale_Transaction_Item_ID,
                                            Transaction_Type_ID = Convert.ToByte(TransactionEnum.Sales),//Sales
                                            Transaction_Date = DateTime.Today,
                                            Time_Stamp = General.GetCurrentTime(),
                                            Notes = string.Empty,
                                            User_Name = model.User_Name
                                        };
                                        int transactionId;
                                        if (dbContext.Transaction.Count() == 0)
                                            transactionId = 0;
                                        else
                                            transactionId = dbContext.Transaction.Max(r => r.Transaction_ID);
                                        transaction_.Transaction_ID = transactionId + 1;

                                        dbContext.Transaction.Add(transaction_);
                                        dbContext.SaveChanges();
                                    }
                                }

                            }
                            else
                            {
                                int qntBeforeEdit = 0;
                                Sale_Transaction_Item_Model newSaleItem = dbContext.Sale_Transaction_Item.FirstOrDefault(r => r.Sale_Transaction_Item_ID == soldItem.Sale_Transaction_Item_ID);
                                if (newSaleItem != null) {
                                    qntBeforeEdit = newSaleItem.QNT;
                                    newSaleItem.Discount_Amount = soldItem.Discount_Amount;
                                    newSaleItem.IsActive = soldItem.IsActive;
                                    newSaleItem.Item_Unit_ID = soldItem.Item_Unit_ID;
                                    newSaleItem.Item_Unit_Price = soldItem.Item_Unit_Price;
                                    newSaleItem.Item_Unit_Price_After_Discount = soldItem.Item_Unit_Price_After_Discount;
                                    newSaleItem.Notes = soldItem.Notes;
                                    newSaleItem.QNT = soldItem.QNT;
                                    newSaleItem.User_Name = soldItem.User_Name;
                                    newSaleItem.Time_Stamp = General.GetCurrentTime();
                                    newSaleItem.Sale_Transaction_ID = oSale.Sale_Transaction_ID;
                                };
                                voucherAmount += newSaleItem.Item_Unit_Price_After_Discount * newSaleItem.QNT;
                                newSaleItem = await UpdateItem(newSaleItem);
                                if (newSaleItem != null)
                                {
                                    Stock_Model stock_Model = dbContext.Stock.FirstOrDefault(r => r.Transaction_ID == soldItem.Sale_Transaction_Item_ID && r.Transaction_Type_ID == 1 && r.Item_Unit_ID == soldItem.Item_Unit_ID && r.Out_QNT==qntBeforeEdit);
                                    if( stock_Model !=null)
                                    {
                                        stock_Model.Branch_ID=model.Branch_ID;
                                        stock_Model.In_QNT = 0;
                                        stock_Model.Out_QNT = soldItem.QNT;
                                        stock_Model.Item_Unit_ID = soldItem.Item_Unit_ID;
                                        stock_Model.Transaction_ID = (int)soldItem.Sale_Transaction_Item_ID;
                                        stock_Model.User_Name = soldItem.User_Name;
                                        stock_Model.Time_Stamp = General.GetCurrentTime();
                                        stock_Model.Stock_Notes = string.Empty;
                                        stock_Model.Transaction_Type_ID = 1;
                                    };
                                    dbContext.Stock.Update(stock_Model);
                                    dbContext.SaveChanges();
                                }

                            }
                        }
                    }
                    if (model.Sale_Transaction_ID == 0)
                    {
                        string paymentNotes = string.IsNullOrEmpty(model.PaymentNotes) ? "مبيعات" : model.PaymentNotes;
                        voucherID=addSaleInvoice((int)model.Sale_Transaction_ID, voucherAmount,model.DiscountAmount,model.Customer_ID,"",model.User_Name);
                        if (voucherID != 0)
                        {
                            voucherID=addSalePayment((int)model.Sale_Transaction_ID, model.PayWayId, voucherAmount, model.DiscountAmount, model.PaidAmount, model.Customer_ID, model.Cheque_No, (DateTime)model.Cheque_Due_Date, (byte)model.Bank_NO, paymentNotes, model.User_Name);
                        }
                    }
                    else
                    {
                        string paymentNotes = string.IsNullOrEmpty(model.PaymentNotes) ? "مبيعات" : model.PaymentNotes;
                        voucherID = editSaleInvoice((int)model.Sale_Transaction_ID, voucherAmount, model.DiscountAmount, model.Customer_ID, "", model.User_Name);
                        if (voucherID != 0)
                        {
                            voucherID = editSalePayment((int)model.Sale_Transaction_ID, model.PayWayId, voucherAmount, model.DiscountAmount, model.PaidAmount, model.Customer_ID, model.Cheque_No, (DateTime)model.Cheque_Due_Date, (byte)model.Bank_NO, paymentNotes, model.User_Name);
                        }
                    }

                    if (model.DeletedSalesTransactionItems.Count > 0)
                    {
                        foreach(int item in model.DeletedSalesTransactionItems)
                        {
                               await DeleteItemUnitFromInvoice(0,item);

                        }
                    }

                    transaction.Commit();
                    return oSale;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }

            }
        }

        public async Task<Sale_Transaction_Model> addSaleAsync(AddSaleTransactionDto model)
        {
            decimal voucherAmount = 0;
            int voucherID;
            bool addPayment = false;
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    Sale_Transaction_Model newSale = new()
                    {
                        IsActive = model.IsActive,
                        Teller_ID = model.Teller_ID,
                        Customer_ID = model.Customer_ID,
                        Branch_ID = model.Branch_ID,
                        IsBacked = model.IsBacked,
                        Transaction_Notes = model.Transaction_Notes,
                        Transaction_Date = model.Transaction_Date,
                        User_Name = model.User_Name,
                        Time_Stamp = General.GetCurrentTime(),
                        Delevery_Fees=model.Delevery_Fees,
                        Delevery_Place=model.Delevery_Place,
                        Delevery_Transaction_No=model.Delevery_Transaction_No,
                        Discount_Amount=model.DiscountAmount
                    };
                    newSale = await createAsync(newSale);
                    if (newSale != null)
                    {
                        foreach(ModifyTransactionItemRequest soldItem in model.items)
                        {
                            Sale_Transaction_Item_Model newSaleItem = new()
                            {
                                Discount_Amount=soldItem.Discount_Amount,
                                IsActive=soldItem.IsActive,    
                                Item_Unit_ID=soldItem.Item_Unit_ID,
                                Item_Unit_Price=soldItem.Item_Unit_Price,
                                Item_Unit_Cost=soldItem.Item_Unit_Cost,
                                Item_Unit_Price_After_Discount=soldItem.Item_Unit_Price_After_Discount,
                                Notes=soldItem.Notes,
                                QNT=soldItem.QNT,
                                User_Name=soldItem.User_Name,
                                Time_Stamp=General.GetCurrentTime(),
                                Sale_Transaction_ID=newSale.Sale_Transaction_ID,
                            };
                            voucherAmount += newSaleItem.Item_Unit_Price_After_Discount * newSaleItem.QNT;
                            newSaleItem = await AddItem(newSaleItem);
                            if (newSaleItem != null)
                            {
                                Stock_Model stock_Model = new()
                                {
                                    Branch_ID=model.Branch_ID,
                                    In_QNT = newSale.IsBacked ? soldItem.QNT : 0,
                                    Out_QNT = newSale.IsBacked ? 0 : soldItem.QNT,
                                    Item_Unit_ID = soldItem.Item_Unit_ID,
                                    Transaction_ID = newSaleItem.Sale_Transaction_Item_ID,
                                    User_Name = soldItem.User_Name,
                                    Time_Stamp = General.GetCurrentTime(),
                                    Stock_Notes = string.Empty,
                                    Transaction_Type_ID = Convert.ToInt32(newSale.IsBacked ? TransactionEnum.BackSales : TransactionEnum.Sales)
                                };
                                stock_Model=await addItemStockAsync(stock_Model);
                                if(stock_Model != null) 
                                {
                                    Transaction_Model transaction_ = new Transaction_Model()
                                    {

                                        Reference_ID =newSaleItem.Sale_Transaction_Item_ID,
                                        Transaction_Type_ID = Convert.ToByte(TransactionEnum.Sales),//Sales
                                        Transaction_Date = DateTime.Today,
                                        Time_Stamp=General.GetCurrentTime(),
                                        Notes=string.Empty,
                                        User_Name=model.User_Name
                                    };
                                    int transactionId;
                                    if (dbContext.Transaction.Count() == 0)
                                        transactionId = 0;
                                    else
                                        transactionId = dbContext.Transaction.Max(r => r.Transaction_ID);
                                    transaction_.Transaction_ID = transactionId + 1;

                                    dbContext.Transaction.Add(transaction_);
                                    dbContext.SaveChanges();
                                }
                            }
                        }
                    }
                    string paymentNotes = string.IsNullOrEmpty(model.PaymentNotes) ? "مبيعات" : model.PaymentNotes;

                    // Add Sales Invoice
                    VoucherModel voucher = new VoucherModel()
                    {
                        Pay_Way_Id = 0,//model.PayWayId,
                        User_Name = model.User_Name,
                        Debit_Amount = newSale.IsBacked ? 0 : voucherAmount - model.DiscountAmount,// - model.PaidAmount,
                        Credit_Amount = newSale.IsBacked ? voucherAmount - model.DiscountAmount : 0,
                        Voucher_Currency_ID = 1,
                        Voucher_Currency_Rate = 1,
                        Voucher_Date = DateTime.Today,
                        voucher_Type_ID = Convert.ToByte(newSale.IsBacked ? VoucherTypeEnum.BackSalesTransaction : VoucherTypeEnum.SalesInvoice),//Sales Invoice
                        Time_Stamp = General.GetCurrentTime(),
                        Voucher_Details = paymentNotes,
                        Person_ID = (short)model.Customer_ID,
                        Manual_Voucher_No = newSale.Sale_Transaction_ID.ToString(),
                    };
                    if (dbContext.Voucher.Count() == 0)
                        voucherID = 0;
                    else
                        voucherID = dbContext.Voucher.Max(r => r.Voucher_ID);
                    voucher.Voucher_ID = voucherID + 1;
                    dbContext.Voucher.Add(voucher);
                    dbContext.SaveChanges();

                    // Prepare for Payment

                    voucher = new VoucherModel() 
                    {
                         Pay_Way_Id = model.PayWayId,
                         User_Name=model.User_Name,
                         Debit_Amount=newSale.IsBacked ? voucherAmount - model.DiscountAmount - model.PaidAmount : 0,
                         Credit_Amount= newSale.IsBacked ? 0 : voucherAmount - model.DiscountAmount - model.PaidAmount,
                         Voucher_Currency_ID=1,
                         Voucher_Currency_Rate=1,
                         Voucher_Date=DateTime.Today,
                         voucher_Type_ID= Convert.ToByte(newSale.IsBacked ? VoucherTypeEnum.Sarf : VoucherTypeEnum.Qabd),
                         Time_Stamp=General.GetCurrentTime(),
                         Voucher_Details = paymentNotes,
                         Person_ID= (short)model.Customer_ID,
                        Manual_Voucher_No = newSale.Sale_Transaction_ID.ToString(),
                    };
                    if (model.PayWayId == 1)
                    {
                        addPayment = true;
                    }
                    else if (model.PayWayId == 2)//Debits
                    {
                        if (model.Customer_ID == 2) // Online Sale
                        {
                            addPayment = false;
                        } 
                        else if (model.PaidAmount > 0)
                        {
                            voucher.Credit_Amount = model.PaidAmount;
                            addPayment = true;
                        }
                    }
                    else if (model.PayWayId == 3)//cheque
                    {
                        voucher.Cheque_No = model.Cheque_No;
                        voucher.Cheque_Due_Date=model.Cheque_Due_Date;
                        voucher.Cheque_Bank_No=model.Bank_NO;
                        addPayment = true;
                    }
                    else if (model.PayWayId == 4) // Bank Transfere
                    {
                        addPayment = true;
                    }
                    else if (model.PayWayId == 5)// Visa
                    {
                        addPayment = true;
                    }

                    if (addPayment)
                    {
                        if (dbContext.Voucher.Count() == 0)
                            voucherID = 0;
                        else
                            voucherID = dbContext.Voucher.Max(r => r.Voucher_ID);
                        voucher.Voucher_ID = voucherID + 1;
                        dbContext.Voucher.Add(voucher);
                        dbContext.SaveChanges();
                    }




                    transaction.Commit();
                    return newSale;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }

            }
        }

        public async Task<Sale_Transaction_Model?> deleteAsync(int saleTransactionId)
        {

            var model = await dbContext.Sale_Transaction.FirstOrDefaultAsync(r => r.Sale_Transaction_ID == saleTransactionId);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Sale_Transaction.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;        }

        public async Task<List<Sale_Transaction_Model>> getAllAsync()
        {
            var qView = dbContext.Sale_Transaction.AsQueryable();
            return await qView.ToListAsync();

        }

        public async Task<Sale_Transaction_Model> getByIdAsync(int saleTransactionId)
        {
            return await dbContext.Sale_Transaction.FirstOrDefaultAsync(r => r.Sale_Transaction_ID == saleTransactionId);
        }

        public async Task<Sale_Transaction_Model?> updateAsync(int saleTransactionId, Sale_Transaction_Model model)
        {
            dbContext.Sale_Transaction.Update(model);
            await dbContext.SaveChangesAsync();
            return model;

        }

        public async Task<List<vSales_TransactonModel>> getAllAsync(SalesQueryCriteriaViewModel criteria)
        {
            var qView = dbContext.SalesQuery.AsQueryable();
            DateTime fromDate= DateTime.MinValue;
            DateTime toDate= DateTime.MinValue;
            if (!string.IsNullOrEmpty(criteria.From_Transaction_Date))
            {
                fromDate = General.convertToDate(criteria.From_Transaction_Date);
            }
            if (!string.IsNullOrEmpty(criteria.To_Transaction_Date))
            {
                toDate = General.convertToDate(criteria.To_Transaction_Date);
            }
            if (criteria != null)
            {
                if (criteria.DebitSalesOnly)
                {
                    qView = qView.Where(r => r.Customer_ID > 2);
                }
                if (criteria.Sale_Transaction_ID != null)
                {
                    qView = qView.Where(r => r.Sale_Transaction_ID == criteria.Sale_Transaction_ID);
                }
                if (!string.IsNullOrEmpty(criteria.Teller_Name))
                {
                    qView = qView.Where(r => r.Teller_Name.Contains(criteria.Teller_Name));
                }
                if (!string.IsNullOrEmpty(criteria.Transaction_Notes))
                {
                    qView = qView.Where(r => r.Transaction_Notes.Contains(criteria.Transaction_Notes));
                }
                if (criteria.Teller_ID != null)
                {
                    qView = qView.Where(r => r.Teller_ID.Equals(criteria.Teller_ID));
                }
                if(criteria.From_Amount != null) 
                {
                    qView = qView.Where(r => r.Amount>=criteria.From_Amount);
                }
                if (criteria.To_Amount != null)
                {
                    qView = qView.Where(r => r.Amount <= criteria.To_Amount);
                }
                if (fromDate>DateTime.MinValue)
                {
                    qView = qView.Where(r => r.Transaction_Date >= fromDate);
                }
                if (toDate > DateTime.MinValue)
                {
                    qView = qView.Where(r => r.Transaction_Date <= toDate);
                }
                if (criteria.Sales_Person_ID != null)
                {
                    if (criteria.Sales_Person_ID > 0)
                    {
                        qView = qView.Where(r => r.Customer_ID == criteria.Sales_Person_ID);
                    }
                }
                if (criteria.PayStatusId > 0)
                {
                    if (criteria.PayStatusId == 1)
                    {
                        qView = qView.Where(r => r.RemainAmount > 0);
                    }
                    else
                    {
                        qView = qView.Where(r => r.RemainAmount <= 0);
                    }
                }
            }
            try
            {
                return await qView.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
            return await qView.ToListAsync();

        }

        public async Task<List<vInvoiceReportModel>> getInvoiceReportDataAsync(InvoiceReportCriteriaViewModel criteria)
        {
            var qView = dbContext.vInvoiceReport.AsQueryable();
            if (criteria != null)
            {
                if (criteria.Sale_Transaction_ID != null)
                {
                    qView = qView.Where(r => r.Sale_Transaction_ID == criteria.Sale_Transaction_ID);
                }
            }
            try
            {
                return await qView.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
