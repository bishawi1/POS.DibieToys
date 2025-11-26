using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.WebApi.Contracts;
using POS.WebApi.Data;
using System.Collections.Generic;

namespace POS.WebApi.Repositories
{
    public class SQLTicketRepository : ITicketRepository
    {
        private readonly DataContext dbContext;

        public SQLTicketRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        private int generateTicketId()
        {
            int ticketId;
            if (dbContext.Ticket.Count() == 0)
            {
                ticketId = Convert.ToInt32($"{DateTime.Today.Year - 2000}{DateTime.Today.Month.ToString("00")}0001");
            }
            else
            {
                DateTime dtFirstMonthDay = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                var maxTicketId = dbContext.Ticket  
                .Where(r => r.Ticket_Date>= dtFirstMonthDay)
                .Select(r => (int?)r.Ticket_ID) // Cast to nullable to allow default
                .DefaultIfEmpty()              // Provide default value if empty
                .Max();
                //// ticketId = dbContext.Ticket.Where(r => r.Ticket_Date.Month == DateTime.Today.Month && r.Ticket_Date.Year == DateTime.Today.Year).Max(r => r.Ticket_ID);
                // if (ticketId == null)
                // {
                //     ticketId = Convert.ToInt32($"{DateTime.Today.Year - 2000}{DateTime.Today.Month.ToString("00")}0001");
                // }
                // else
                // {
                //     ticketId += 1;
                // }
                if (maxTicketId == null)
                {
                    ticketId = Convert.ToInt32($"{DateTime.Today.Year - 2000}{DateTime.Today.Month.ToString("00")}0000"); ;
                }
                else
                {
                    ticketId =Convert.ToInt32(maxTicketId);
                }
            }
            return ticketId;
        }
        public async Task<List<TicketModel>> createAsync(TicketModel model)
        {
            int ticketId;
            int batchNo = 0;
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    List <TicketModel> addedTickets=new List<TicketModel> ();
                    ticketId= generateTicketId();
                    if (dbContext.Ticket.Count() == 0)
                    {
                        batchNo = 0;
                    }
                    else
                    {
                        batchNo = dbContext.Ticket.Max(r => r.Batch_No);
                    }
                    batchNo += 1;
                    for(int index=0; index < model.Kids_Count; index++)
                    {
                        ticketId += 1;
                        TicketModel ticket=new TicketModel()
                        {
                            Amount = model.Amount,
                            Batch_No = batchNo,
                            Discount = model.Discount,
                            Kids_Count = model.Kids_Count,
                            Ticket_Date = model.Ticket_Date,
                            Ticket_ID = ticketId,
                            Ticket_No = ticketId,
                            Tim_Stamp = model.Tim_Stamp,
                            User_Name = model.User_Name,
                        };
                        await dbContext.Ticket.AddAsync(ticket);
                        await dbContext.SaveChangesAsync();
                        addedTickets.Add(ticket);
                    }
                    transaction.Commit();
                    return addedTickets;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }

        }
        public async Task<TicketModel?> deleteAsync(int ticketId)
        {
            var model = await dbContext.Ticket.FirstOrDefaultAsync(r => r.Ticket_ID == ticketId);
            if (model == null)
            {
                return null;
            }
            else
            {
                dbContext.Ticket.Remove(model);
                await dbContext.SaveChangesAsync();
            }
            return model;

        }
        public async Task<List<TicketModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200)
        {
            var qView = dbContext.Ticket.AsQueryable();
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
        public async Task<TicketModel> getByIdAsync(int ticketId)
        {
            return await dbContext.Ticket.FirstOrDefaultAsync(r => r.Ticket_ID == ticketId);
        }
        public async Task<TicketModel?> updateAsync(int ticketId, TicketModel model)
        {
            dbContext.Ticket.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<List<TicketModel>> getAllAsync(TicketListCriteriaViewModel criteria)
        {
            DateTime dtFromDate;
            DateTime dtToDate;
            List<TicketModel> ticketList = new List<TicketModel>();
            var query = dbContext.Ticket.AsQueryable();
            if (!string.IsNullOrEmpty(criteria.FromDate))
            {
                dtFromDate = General.convertToDate(criteria.FromDate);
                query = query.Where(r => r.Ticket_Date >= dtFromDate);
            }
            if (!string.IsNullOrEmpty(criteria.ToDate))
            {
                dtToDate = General.convertToDate(criteria.ToDate);
                query = query.Where(r => r.Ticket_Date < dtToDate.AddDays(1));
            }

            ticketList = await query.ToListAsync();
            return ticketList;
        }

        public async Task<Reserve_Toy_RoomModel> ReserveToysRookAsync(Reserve_Toy_RoomModel model)
        {
            int reserveToyRoomId=0;
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    Reserve_Toy_RoomModel addedTickets = new Reserve_Toy_RoomModel();
                    if (dbContext.Reserve_Toy_Room.Count() == 0)
                    {
                        reserveToyRoomId = 0;
                    }
                    else
                    {
                        reserveToyRoomId = dbContext.Reserve_Toy_Room.Max(r => r.Reserve_Toy_Room_ID);
                    }
                    reserveToyRoomId += 1;
                    model.Reserve_Toy_Room_ID = reserveToyRoomId;
                    await dbContext.Reserve_Toy_Room.AddAsync(model);
                    await dbContext.SaveChangesAsync();
                    transaction.Commit();
                    return addedTickets;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public async Task<List<Reserve_Toy_RoomModel>> getReserveToysRoomAsync(ReserveToysRoomCriteriaViewModel criteria)
        {
            DateTime dtFromDate;
            DateTime dtToDate;
            List<Reserve_Toy_RoomModel> reservationList = new List<Reserve_Toy_RoomModel>();
            var query = dbContext.Reserve_Toy_Room.AsQueryable();
            if(!string.IsNullOrEmpty(criteria.Reserver_Name))
            {
                query = query.Where(r => r.Reserver_Name.Contains(criteria.Reserver_Name));
            }
            if(!string.IsNullOrEmpty(criteria.Notes))
            {
                query = query.Where(r => r.Notes .Contains(criteria.Notes));
            }
            if (criteria.Kids_No.HasValue)
            {
                query = query.Where(r => r.Kids_No == criteria.Kids_No.Value);
            }
            if (criteria.Reserve_Toy_Room_ID.HasValue)
            {
                query = query.Where(r => r.Reserve_Toy_Room_ID == criteria.Reserve_Toy_Room_ID.Value);
            }
            if (criteria.getWaitingOnly)
            {
                query = query.Where(r => r.Canceled == false && r.Done==false);
                
            }
            if (criteria.getDoneOnly)
            {
                query = query.Where(r => r.Done == true);
            }
            if (criteria.getCanceledOnly)
            {
                query = query.Where(r => r.Canceled == true);
            }
            //if (!string.IsNullOrEmpty(criteria.FromDate))
            //{
            //    dtFromDate = General.convertToDate(criteria.FromDate);
            //    query = query.Where(r => r.Ticket_Date >= dtFromDate);
            //}
            //if (!string.IsNullOrEmpty(criteria.ToDate))
            //{
            //    dtToDate = General.convertToDate(criteria.ToDate);
            //    query = query.Where(r => r.Ticket_Date < dtToDate.AddDays(1));
            //}

            reservationList = await query.ToListAsync();
            return reservationList;

        }

        public async Task<Reserve_Toy_RoomModel> getReserveToysRoomIdAsync(int reserveToyRoomId)
        {
            return await dbContext.Reserve_Toy_Room.FirstOrDefaultAsync(r => r.Reserve_Toy_Room_ID == reserveToyRoomId);
        }

        public async Task<Reserve_Toy_RoomModel?> updateReserveToysRoomAsync(int reserveToyRoomId, Reserve_Toy_RoomModel model)
        {
            dbContext.Reserve_Toy_Room.Update(model);
            await dbContext.SaveChangesAsync();
            return model;
        }
        public async Task<Reserve_Toy_RoomModel?> CancelReserveToysRoomAsync(int reserveToyRoomId)
        {
            Reserve_Toy_RoomModel model = await dbContext.Reserve_Toy_Room.FirstOrDefaultAsync(r => r.Reserve_Toy_Room_ID == reserveToyRoomId);
            if(model== null)
            {
                throw new Exception("Not Found");
            }
            else
            {
                model.Canceled=true;
                model.Done = false;
                dbContext.Reserve_Toy_Room.Update(model);
                await dbContext.SaveChangesAsync();
                return model;
            }
        }

        public async Task<Reserve_Toy_RoomModel> DoReserveToysRoomAsync(int reserveToyRoomId)
        {
            Reserve_Toy_RoomModel model = await dbContext.Reserve_Toy_Room.FirstOrDefaultAsync(r => r.Reserve_Toy_Room_ID == reserveToyRoomId);
            if (model == null)
            {
                throw new Exception("Not Found");
            }
            else
            {
                model.Canceled = false;
                model.Done = true;
                dbContext.Reserve_Toy_Room.Update(model);
                await dbContext.SaveChangesAsync();
                return model;
            }

        }
    }
}

