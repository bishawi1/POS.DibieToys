using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.WebApi.Contracts;
using System.Net;

namespace POS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketRepository repository;

        public TicketController(ITicketRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> getAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery, [FromQuery] string? sortBy, [FromQuery] bool? isAscending = true, [FromQuery] int? pageNumber = 1, [FromQuery] int? pageSize = 0)
        {
            var oList = await repository.getAllAsync(filterOn, filterQuery, sortBy, isAscending ?? true, pageNumber ?? 1, pageSize ?? 200);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = oList,
                    ErrorText = string.Empty,
                    StatusCode = "200"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultModel()
                {
                    Data = ex,
                    ErrorText = string.Empty,
                    StatusCode = HttpStatusCode.InternalServerError.ToString()
                });
                throw;
            }
        }


        [HttpPost]
        [Route("ListTicket")]
        public async Task<IActionResult> getTicketList(TicketListCriteriaViewModel criteria)
        {
            var Statement = await repository.getAllAsync(criteria);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = Statement,
                    ErrorText = string.Empty,
                    StatusCode = "200"
                });

            }
            catch (Exception ex)
            {
                return BadRequest(new ResultModel()
                {
                    Data = ex,
                    ErrorText = string.Empty,
                    StatusCode = HttpStatusCode.InternalServerError.ToString()
                });

                throw;
            }

        }


        [HttpGet]
        [Route("{Id:int}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var oModel = await repository.getByIdAsync((byte)Id);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = oModel,
                    ErrorText = string.Empty,
                    StatusCode = "200"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultModel()
                {
                    Data = ex,
                    ErrorText = string.Empty,
                    StatusCode = HttpStatusCode.InternalServerError.ToString()
                }); throw;
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateTicketRequestDto updateRequest)
        {
            TicketModel model = await repository.getByIdAsync(id);
            if (model == null)
            {

                return NotFound();
            }
            else
            {
                try
                {
                    model.Amount = updateRequest.Amount;
                    model.User_Name = updateRequest.User_Name;
                    model.Discount = updateRequest.Discount;
                    model.Kids_Count = updateRequest.Kids_Count;
                    model = await repository.updateAsync(id, model);
                    return Ok(new ResultModel()
                    {
                        Data = model,
                        ErrorText = string.Empty,
                        StatusCode = "200"
                    });
                }
                catch (Exception ex)
                {
                    return Ok(new ResultModel()
                    {
                        Data = ex,
                        StatusCode = "500",
                        ErrorText = ex.Message
                    });
                    throw;
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]  CreateTicketRequestDto createRequestDto)
        {
            try
            {
                List<TicketModel> list;
                TicketModel model = new TicketModel()
                {
                    Amount = createRequestDto.Amount,
                    Discount = createRequestDto.Discount,
                    User_Name = createRequestDto.User_Name,
                    Tim_Stamp = General.GetCurrentTime(),
                    Kids_Count = createRequestDto.Kids_Count,
                    Ticket_Date=General.GetCurrentDate(),                 
                    // Assign model properties
                    // Book_Author_Desc = createRequestDto.Book_Author_Desc,
                };
                list = await repository.createAsync(model);
                return Ok(new ResultModel()
                {
                    Data = list,
                    ErrorText = "",
                    StatusCode = "200"
                });
            }
            catch (Exception ex)
            {
                return Ok(new ResultModel()
                {
                    Data = null,
                    ErrorText = ex.Message.ToString(),
                    StatusCode = "500"
                });
            }
        }

        [HttpPost]
        [Route("ReserveToysRoom")]
        public async Task<IActionResult> ReserveToysRoom([FromBody]  AddReserveToysRookRequestDto createRequestDto)
        {
            try
            {
                Reserve_Toy_RoomModel model =new Reserve_Toy_RoomModel
                {
                    Amount = createRequestDto.Amount,
                    Canceled = false,
                    Done = false,
                    Time_Stamp = General.GetCurrentTime(),
                    Kids_No = createRequestDto.Kids_No,
                    Due_Date=General.GetCurrentDate(),
                    Notes = createRequestDto.Notes,
                    Reserver_Name=createRequestDto.Reserver_Name,
                    User_Name=createRequestDto.User_Name,
                    // Assign model properties
                    // Book_Author_Desc = createRequestDto.Book_Author_Desc,
                };
                model = await repository.ReserveToysRookAsync(model);
                return Ok(new ResultModel()
                {
                    Data = model,
                    ErrorText = "",
                    StatusCode = "200"
                });
            }
            catch (Exception ex)
            {
                return Ok(new ResultModel()
                {
                    Data = null,
                    ErrorText = ex.Message.ToString(),
                    StatusCode = "500"
                });
            }
        }

        [HttpPost]
        [Route("GetReserveToysRoomList")]
        public async Task<IActionResult> getReserveToysRoom(ReserveToysRoomCriteriaViewModel criteria)
        {
            var Statement = await repository.getReserveToysRoomAsync(criteria);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = Statement,
                    ErrorText = string.Empty,
                    StatusCode = "200"
                });

            }
            catch (Exception ex)
            {
                return BadRequest(new ResultModel()
                {
                    Data = ex,
                    ErrorText = string.Empty,
                    StatusCode = HttpStatusCode.InternalServerError.ToString()
                });

                throw;
            }

        }


        [HttpGet]
        [Route("GetReserveToysRoom{Id:int}")]
        public async Task<IActionResult> GetReserveToysRoom(int Id)
        {
            var oModel = await repository.getReserveToysRoomIdAsync(Id);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = oModel,
                    ErrorText = string.Empty,
                    StatusCode = "200"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultModel()
                {
                    Data = ex,
                    ErrorText = string.Empty,
                    StatusCode = HttpStatusCode.InternalServerError.ToString()
                }); throw;
            }
        }

        [HttpPost]
        [Route("EditReserveToysRoom")]
        public async Task<IActionResult> EditReserveToysRoom( [FromBody] EditReserveToysRookRequestDto updateRequest)
        {
            Reserve_Toy_RoomModel model = await repository.getReserveToysRoomIdAsync(updateRequest.Reserve_Toy_Room_ID);
            if (model == null)
            {

                return NotFound();
            }
            else
            {
                try
                {
                    model.Due_Date = DateTime.Now;
                    model.Notes=updateRequest.Notes;
                    model.Reserver_Name = updateRequest.Reserver_Name;
                    model.User_Name = updateRequest.User_Name;
                    model.Canceled = updateRequest.Canceled;
                    model.Done=updateRequest.Done;
                    model.Kids_No = updateRequest.Kids_No;
                    model.Amount = updateRequest.Amount;
                    model = await repository.updateReserveToysRoomAsync(updateRequest.Reserve_Toy_Room_ID, model);
                    return Ok(new ResultModel()
                    {
                        Data = model,
                        ErrorText = string.Empty,
                        StatusCode = "200"
                    });
                }
                catch (Exception ex)
                {
                    return Ok(new ResultModel()
                    {
                        Data = ex,
                        StatusCode = "500",
                        ErrorText = ex.Message
                    });
                    throw;
                }
            }
        }
        [HttpGet]
        [Route("CancelReserveToysRoom/{Id:int}")]
        public async Task<IActionResult> CancelReserveToysRoom(int Id)
        {
            var oModel = await repository.CancelReserveToysRoomAsync(Id);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = oModel,
                    ErrorText = string.Empty,
                    StatusCode = "200"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultModel()
                {
                    Data = ex,
                    ErrorText = string.Empty,
                    StatusCode = HttpStatusCode.InternalServerError.ToString()
                }); throw;
            }
        }

        [HttpGet]
        [Route("DoReserveToysRoom/{Id:int}")]
        public async Task<IActionResult> DoReserveToysRoom(int Id)
        {
            var oModel = await repository.DoReserveToysRoomAsync(Id);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = oModel,
                    ErrorText = string.Empty,
                    StatusCode = "200"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResultModel()
                {
                    Data = ex,
                    ErrorText = string.Empty,
                    StatusCode = HttpStatusCode.InternalServerError.ToString()
                }); throw;
            }
        }

    }
}
