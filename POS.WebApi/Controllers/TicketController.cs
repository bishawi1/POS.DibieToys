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

    }
}
