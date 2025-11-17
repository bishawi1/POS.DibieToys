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
    public class Supply_TransactionController : ControllerBase
    {
        private readonly ISupply_TransactionRepository repository;

        public Supply_TransactionController(ISupply_TransactionRepository supply_transactionRepository)
        {
            repository = supply_transactionRepository;
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
        [HttpGet]
        [Route("{Id:int}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var oModel = await repository.getByIdAsync(Id);
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
        [Route("Detail/{Id:int}")]
        public async Task<IActionResult> getSupplyTransaction(int Id)
        {
            var oModel = await repository.getSupplyTransactionAsync(Id);
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
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateSupply_TransactionRequestDto updateRequest)
        {
            Supply_TransactionModel model = await repository.getByIdAsync(id);
            if (model == null)
            {

                return NotFound();
            }
            else
            {

                try
                {
                    model.Branch_ID=updateRequest.Branch_ID;
                    model.QNT = updateRequest.QNT;
                    model.Transaction_Notes = updateRequest.Transaction_Notes;
                    model.Supply_Transaction_ID = updateRequest.Supply_Transaction_ID;
                    model.IsActive = updateRequest.IsActive;
                    model.Item_Unit_ID = updateRequest.Item_Unit_ID;
                    model.Source_ID = updateRequest.Source_ID;
                    model.Time_Stamp = General.GetCurrentTime();
                    model.Transaction_Date = updateRequest.Transaction_Date;
                    model.User_Name = updateRequest.User_Name;

                    //            model.User_Name = updateRequest.User_Name;
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
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                Supply_TransactionModel model = null;
                model = await repository.deleteAsync(Convert.ToInt16(id)); if (model == null)
                {
                    return Ok(new ResultModel()
                    {
                        Data = null,
                        ErrorText = "Not Found",
                        StatusCode = "400"
                    });
                }
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
        public async Task<IActionResult> Create([FromBody] CreateSupply_TransactionRequestDto createRequestDto)
        {
            try
            {
                Supply_TransactionModel model = new Supply_TransactionModel()
                {
                    Branch_ID=createRequestDto.Branch_ID,
                    IsActive=createRequestDto.IsActive,
                    Item_Unit_ID=createRequestDto.Item_Unit_ID,
                    QNT=createRequestDto.QNT,
                    Source_ID=createRequestDto.Source_ID,
                    Time_Stamp=General.GetCurrentTime(),
                    Transaction_Date=createRequestDto.Transaction_Date,
                    Transaction_Notes=createRequestDto.Transaction_Notes,
                    User_Name=createRequestDto.User_Name,
                };
                model = await repository.createAsync(model);
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
        [Route("SupplyTransactionQuery")]
        public async Task<IActionResult> getSupplyTransactionQuery(vSupplyTransactionCriteriaViewModel criteria)
        {
            var supplyTransactions = await repository.getAllAsync(criteria);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = supplyTransactions,
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



    }
}
