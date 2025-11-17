using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.WebApi.Contracts;
using POS.WebApi.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace POS.WebApi.Repositories
{
    public class SQLVoucherRepository : IVoucherRepository
    {
        private readonly DataContext dbContext;
        public SQLVoucherRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<VoucherModel> createAsync(VoucherModel model)
        {
            int voucherID;
            if (dbContext.Voucher.Count() == 0)
                voucherID = 0;
            else
                voucherID = dbContext.Voucher.Max(r => r.Voucher_ID);
            model.Voucher_ID = voucherID + 1;
            await dbContext.Voucher.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<VoucherModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Voucher.AsQueryable();
            if (string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
            {
                if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    //qView = qView.Where(r => r. Book_Author_Desc.Contains(filterQuery));
                }
            }
            if (pageSize == 0)
            {
                return await qView.ToListAsync();
            }
            else
            {
                var skipResults = (pageNumber - 1) * pageSize;
                return await qView.Skip(skipResults).Take(pageSize).ToListAsync();
            }
        }
        public async Task<VoucherModel> getByIdAsync(int voucherID)
        {
            return await dbContext.Voucher.FirstOrDefaultAsync(r => r.Voucher_ID == voucherID);
        }
        public async Task<VoucherModel?> updateAsync(int voucherID, VoucherModel model)
        {
            dbContext.Voucher.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<VoucherModel?> deleteAsync(int voucherID)
        {
            var model = await dbContext.Voucher.FirstOrDefaultAsync(r => r.Voucher_ID == voucherID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Voucher.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }

        public async Task<List<VoucherTotalViewModel>> getVoucherSummary(VoucherQueryCriteriaViewModel criteria)
        {
            DateTime dtFromDate;
            DateTime dtToDate;

            var query = dbContext.VoucherQuery.AsQueryable();
            if (!string.IsNullOrEmpty(criteria.manualVoucherNo))
            {
                query = query.Where(r => r.Manual_Voucher_No == Convert.ToString(criteria.manualVoucherNo));
            }
            if (!string.IsNullOrEmpty(criteria.PayWayId))
                query = query.Where(r => r.Pay_Way_Id == Convert.ToByte(criteria.PayWayId));
            if (!string.IsNullOrEmpty(criteria.FromDate))
            {
                dtFromDate = General.convertToDate(criteria.FromDate);
                query = query.Where(r => r.Voucher_Date >= dtFromDate);
            }
            if (!string.IsNullOrEmpty(criteria.ToDate))
            {
                dtToDate = General.convertToDate(criteria.ToDate);
                query = query.Where(r => r.Voucher_Date < dtToDate.AddDays(1));
            }
            if (criteria.PersonId != null)
            {
                query = query.Where(r => r.Person_ID == criteria.PersonId);
            }
            if (criteria.PersonNo != null)
            {
                query = query.Where(r => r.Person_No == criteria.PersonNo);
            }
            if (!string.IsNullOrEmpty(criteria.PersonName))
            {
                query = query.Where(r => r.Person_Name.Contains(criteria.PersonName.Trim()));
            }
            if (criteria.VoucherId != null)
            {
                query = query.Where(r => r.Voucher_ID == criteria.VoucherId);
            }
            if (criteria.VoucherTypeId != 0)
            {
                query = query.Where(r => r.voucher_Type_ID == criteria.VoucherTypeId);
            }
            if (!string.IsNullOrEmpty(criteria.Details))
            {
                query = query.Where(r => r.Voucher_Details.Contains(criteria.Details.Trim()));
            }

            var groupedQuery= query.GroupBy(g => new { g.Pay_Way_Id, g.Pay_Way_Desc, g.voucher_Type_ID, g.Voucher_Type_Desc })
                .Select(r => new VoucherTotalViewModel
                {
                    voucher_Type_ID = r.Key.voucher_Type_ID,
                    Voucher_Type_Desc=r.Key.Voucher_Type_Desc,
                    Pay_Way_Id = r.Key.Pay_Way_Id,
                    Pay_Way_Desc = r.Key.Pay_Way_Desc,
                    Amount = r.Sum(s=> (s.Credit_Amount==0? s.Debit_Amount : s.Credit_Amount)),
            });
            var totalsList = await groupedQuery.ToListAsync();
            return totalsList;
            




        }

        public async Task<List<vVoucherModel>?> getVoucherQuery(VoucherQueryCriteriaViewModel criteria)
        {
            DateTime dtFromDate;
            DateTime dtToDate;

            var query = dbContext.VoucherQuery.AsQueryable();
            if (!string.IsNullOrEmpty(criteria.manualVoucherNo))
            {
                query = query.Where(r => r.Manual_Voucher_No == Convert.ToString(criteria.manualVoucherNo));
            }
            if (!string.IsNullOrEmpty(criteria.PayWayId))
                query = query.Where(r => r.Pay_Way_Id == Convert.ToByte(criteria.PayWayId));
            if (!string.IsNullOrEmpty(criteria.FromDate))
            {
                dtFromDate = General.convertToDate(criteria.FromDate);
                query = query.Where(r => r.Voucher_Date >= dtFromDate);
            }
            if (!string.IsNullOrEmpty(criteria.ToDate))
            {
                dtToDate = General.convertToDate(criteria.ToDate);
                query = query.Where(r => r.Voucher_Date < dtToDate.AddDays(1));
            }
            if (criteria.PersonId != null)
            {
                query = query.Where(r => r.Person_ID == criteria.PersonId);
            }
            if (criteria.PersonNo != null)
            {
                query = query.Where(r => r.Person_No == criteria.PersonNo);
            }
            if (!string.IsNullOrEmpty(criteria.PersonName))
            {
                query = query.Where(r => r.Person_Name.Contains(criteria.PersonName.Trim()));
            }
            if (criteria.VoucherId != null)
            {
                query = query.Where(r => r.Voucher_ID == criteria.VoucherId);
            }
            if (criteria.VoucherTypeId != 0)
            {
                query = query.Where(r => r.voucher_Type_ID == criteria.VoucherTypeId);
            }
            if (!string.IsNullOrEmpty(criteria.Details))
            {
                query = query.Where(r => r.Voucher_Details.Contains(criteria.Details.Trim()));
            }
            if (criteria.DebitsOnly)
            {
                query = query.Where(r => r.Person_ID>1);
            }
            return await query.ToListAsync();
        }

        public async Task<List<vPurchase_Invoice_Model>?> getPurchaseInvoiceQuery(PurchaseInvoiceQueryCriteriaViewModel criteria)
        {
            DateTime dtFromDate;
            DateTime dtToDate;

            var query = dbContext.vPurchase_Invoice.AsQueryable();
            if (criteria.VoucherId != null)
            {
                query = query.Where(r => r.Voucher_ID == criteria.VoucherId);
            }
            if (criteria.NotPaidOnly)
                query = query.Where(r => r.Remain_Amount > 0);
            if (!string.IsNullOrEmpty(criteria.FromDate))
            {
                dtFromDate = General.convertToDate(criteria.FromDate);
                query = query.Where(r => r.Voucher_Date >= dtFromDate);
            }
            if (!string.IsNullOrEmpty(criteria.ToDate))
            {
                dtToDate = General.convertToDate(criteria.ToDate);
                query = query.Where(r => r.Voucher_Date < dtToDate.AddDays(1));
            }
            if (criteria.PersonId != null)
            {
                query = query.Where(r => r.Person_ID == criteria.PersonId);
            }
            if (!string.IsNullOrEmpty(criteria.PersonName))
            {
                query = query.Where(r => r.Person_Name.Contains(criteria.PersonName.Trim()));
            }
            if (criteria.VoucherId != null)
            {
                query = query.Where(r => r.Voucher_ID == criteria.VoucherId);
            }
            if (!string.IsNullOrEmpty(criteria.Details))
            {
                query = query.Where(r => r.Voucher_Details.Contains(criteria.Details.Trim()));
            }
            return await query.ToListAsync();
        }

    }

}
