using POS.Shared.Models;
using POS.Shared.ViewModels;

namespace POS.WebApi.Contracts
{
    public interface ITicketRepository
    {
        public Task<List<TicketModel>> createAsync(TicketModel model);
        public Task<List<TicketModel>> getAllAsync(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending = true, int pageNumber = 1, int pageSize = 200);
        public Task<List<TicketModel>> getAllAsync(TicketListCriteriaViewModel criteria);
        public Task<TicketModel> getByIdAsync(int ticketId);
        public Task<TicketModel?> updateAsync(int ticketId, TicketModel model);
        public Task<TicketModel?> deleteAsync(int ticketId);


        public Task<Reserve_Toy_RoomModel> ReserveToysRookAsync(Reserve_Toy_RoomModel model);
        public Task<List<Reserve_Toy_RoomModel>> getReserveToysRoomAsync(ReserveToysRoomCriteriaViewModel criteria);
        public Task<Reserve_Toy_RoomModel> getReserveToysRoomIdAsync(int reserveToyRoomId);
        public Task<Reserve_Toy_RoomModel?> updateReserveToysRoomAsync(int reserveToyRoomId, Reserve_Toy_RoomModel model);
        public Task<Reserve_Toy_RoomModel> CancelReserveToysRoomAsync(int reserveToyRoomId);
        public Task<Reserve_Toy_RoomModel> DoReserveToysRoomAsync(int reserveToyRoomId);




    }
}
