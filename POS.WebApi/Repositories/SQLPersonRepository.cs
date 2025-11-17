using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.WebApi;
using POS.WebApi.Contracts;
using POS.WebApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.WebApi.Repositories
{
    public class SQLPersonRepository : IPersonRepository
    {
        private readonly DataContext dbContext;
        public SQLPersonRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<PersonModel> createAsync(PersonModel model)
        {
            short personID;
            if (dbContext.Person.Count() == 0)
                personID = 0;
            else
                personID = dbContext.Person.Max(r => r.Person_ID);
            model.Person_ID = Convert.ToInt16( personID + 1);
            model.Person_No=model.Person_ID.ToString();
            await dbContext.Person.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<List<PersonModel>> getAllAsync()
        {
            var qView = dbContext.Person.AsQueryable();
                return await qView.ToListAsync();
        }
        public async Task<PersonModel> getByIdAsync(short personID)
        {
            return await dbContext.Person.FirstOrDefaultAsync(r => r.Person_ID == personID);
        }
        public async Task<PersonModel?> updateAsync(short personID, PersonModel model)
        {
            dbContext.Person.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<PersonModel?> deleteAsync(short personID)
        {
            var model = await dbContext.Person.FirstOrDefaultAsync(r => r.Person_ID == personID);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Person.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }

        public async Task<List<vPersonModel>?> getPersonQuery(PersonQueryCriteriaViewModel criteria)
        {
            var query = dbContext.PersonQuery.AsQueryable();
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
                query = query.Where(r => r.Person_Name.Contains(General.Recontruct(criteria.PersonName).Trim()));
            }
            if (criteria.CityId != null)
            {
                query = query.Where(r => r.City_ID == criteria.CityId);
            }
            if (!string.IsNullOrEmpty(criteria.CityName))
            {
                query = query.Where(r => r.City_Name.Contains(criteria.CityName.Trim()));
            }
            if (criteria.Person_Cat_ID != null)
            {
                if (criteria.Person_Cat_ID > 0)
                {
                    query = query.Where(r => r.Person_Cat_ID == criteria.Person_Cat_ID);
                }
            }
            return await query.ToListAsync();
        }
        private async Task<decimal> getPersonOpenBalance(int personId)
        {
            decimal balance = 0;
            PersonModel person=await dbContext.Person.FirstOrDefaultAsync(r => r.Person_ID == personId);
            if (person != null)
            {
                balance = (decimal)person.Begining_Balance_Amount;
            }
            return balance;
        }

        public async Task<List<vPersonStatementOfAccountModel>?> getStatementOfAccount(PersonStatementOfAccountCriteriaViewModel criteria)
        {
            DateTime dtFromDate;
            DateTime dtToDate;
            decimal balance = 0;
            List<vPersonStatementOfAccountModel> model = new List<vPersonStatementOfAccountModel>();
            var query = dbContext.VoucherQuery.AsQueryable();
            List<vVoucherModel> voucherLIst = null;
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
            voucherLIst= await query.ToListAsync();
            if (voucherLIst != null)
            {
                foreach (vVoucherModel voucher in voucherLIst) 
                {
                    balance += voucher.Debit_Amount;
                    balance -= voucher.Credit_Amount;
                    model.Add(new vPersonStatementOfAccountModel()
                    {
                        Person_ID=voucher.Person_ID,
                        Person_No = voucher.Person_No,  
                        Person_Name=voucher.Person_Name,
                        Voucher_ID=voucher.Voucher_ID,
                        Voucher_Date=voucher.Voucher_Date,
                        voucher_Type_ID=voucher.voucher_Type_ID,
                        Voucher_Type_Desc=voucher.Voucher_Type_Desc,
                        Manual_Voucher_No = voucher.Manual_Voucher_No,
                        Pay_Way_Id=voucher.Pay_Way_Id,
                        Pay_Way_Desc=voucher.Pay_Way_Desc,
                        Credit_Amount=voucher.Credit_Amount,
                        Debit_Amount = voucher.Debit_Amount,
                        Voucher_Currency_ID = voucher.Voucher_Currency_ID,
                        Currency_Symbol=voucher.Currency_Symbol,
                        Currency_Name=voucher.Currency_Name,
                        Voucher_Currency_Rate= voucher.Voucher_Currency_Rate,
                        Voucher_Details=voucher.Voucher_Details,
                        Cheque_Due_Date=voucher.Cheque_Due_Date,
                        Cheque_Bank_No=voucher.Cheque_Bank_No,
                        Bank_Name=voucher.Bank_Name,
                        Cheque_ID = voucher.Cheque_ID,
                        Cheque_No=voucher.Cheque_No,
                        User_Name=voucher.User_Name,
                        Time_Stamp=voucher.Time_Stamp,
                        Balance=balance
                    });
                }
            }
            decimal openBalance = await getPersonOpenBalance(criteria.PersonId);
            if (openBalance != 0)
            {
                model.Insert(0, new vPersonStatementOfAccountModel()
                {
                    Balance = openBalance,
                    Credit_Amount=(openBalance  > 0 ? 0 : openBalance),
                    Debit_Amount=(openBalance  <= 0 ? 0 : openBalance),
                    Person_ID = Convert.ToInt16(criteria.PersonId),
                    Voucher_Date=new DateTime(2025,06,01)
                });
            }
            return model;
        }


    }
}


