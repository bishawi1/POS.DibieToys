using Microsoft.EntityFrameworkCore;
using POS.DAL.Contracts;
using POS.DAL.Data;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL.Repositories
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
            Int16 personId = dbContext.Persons.Max(r => r.Person_ID);
            model.Person_Name = General.Recontruct(model.Person_Name);
            model.Person_ID = (Int16)(personId + 1);
            model.Person_No = model.Person_No;
            await dbContext.Persons.AddAsync(model);
            await dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<PersonModel?> deleteAsync(short PersonId)
        {
            var model = await dbContext.Persons.FirstOrDefaultAsync(r => r.Person_ID == PersonId);
            if (model == null)
            {
                model.Person_ID = PersonId;
                dbContext.Update(model);
                await dbContext.SaveChangesAsync();
                return model;
            }
            else
            {
                model.Person_ID = PersonId;
                dbContext.Update(model);
                //dbContext.Persons.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;
        }

        public async Task<List<PersonModel>> GetAllAsync()
        {
            var qPersons = dbContext.Persons.AsQueryable();
            //qPersons = qPersons.Where(r => r.Person_Status_ID == 1);
            //if (string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
            //{
            //    if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
            //    {
                   // qPersons = qPersons.Where(r => r.Person_Name.Contains(General.Recontruct(filterQuery)));
                    //qAuthors = qAuthors.Where(r => EF.Functions.Like("Book_Author_Desc", "%" + filterQuery.Trim().Replace(" ", "%") + "%"));
             //   }
           // }
            return await qPersons.ToListAsync();
            //var skipResults = (pageNumber - 1) * pageSize;
            //return await qPersons.Skip(skipResults).Take(pageSize).ToListAsync();
        }

        public async Task<PersonModel> GetByIdAsync(short PersonId)
        {
            return await dbContext.Persons.FirstOrDefaultAsync(r => r.Person_ID == PersonId);
        }

        public async Task<List<vPersonModel>?> getPersonQuery(PersonQueryCriteriaViewModel criteria,
                                                                    string? sortBy, bool? isAscending = true,
                                                                    int pageNumber = 1, int pageSize = 2000)
        {
            var query = dbContext.PersonQuery.AsQueryable();
            //if (!string.IsNullOrEmpty(criteria.Person_Status_ID))
            //    query = query.Where(r => r.Person_Status_ID == Convert.ToByte(criteria.Person_Status_ID));
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
            return await query.ToListAsync();
            //var skipResults = (pageNumber - 1) * pageSize;
            //return await query.Skip(skipResults).Take(pageSize).ToListAsync();
        }

        public async Task<PersonModel?> updateAsync(short PersonId, PersonModel model)
        {
            model.Person_Name = General.Recontruct(model.Person_Name);
            dbContext.Persons.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
    }

}
