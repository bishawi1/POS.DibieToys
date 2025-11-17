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
    public class StockController : ControllerBase
    {
        private readonly IStockRepository repository;

        public StockController(IStockRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var stockList = await repository.getAllAsync();
            try
            {
                return Ok(new ResultModel()
                {
                    Data = stockList,
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
            }
        }

        
        
        [HttpGet]
        [Route("{Id:int}")]
        public async Task<IActionResult> getById(int Id)
        {
            Stock_Model stockModel = await repository.getByIdAsync(Id);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = stockModel,
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

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateStockRequestDto updateRequest)
        {
            try
            {
                Stock_Model model = new Stock_Model
                {
                    In_QNT = updateRequest.In_QNT,
                    Item_Unit_ID = updateRequest.Item_Unit_ID,
                    Out_QNT = updateRequest.Out_QNT,
                    Stock_ID = updateRequest.Stock_ID,
                    Stock_Notes = updateRequest.Stock_Notes,
                    Transaction_ID = updateRequest.Transaction_ID,
                    User_Name = updateRequest.User_Name,
                    Time_Stamp = General.GetCurrentTime()
                };
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

            }

        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                Stock_Model model = null;
                model = await repository.deleteAsync(id);
                if (model == null)
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
                //}
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
        public async Task<IActionResult> Create([FromBody] AddStockRequestDto createRequestDto)
        {
            try
            {
                Stock_Model model = new Stock_Model
                {
                    In_QNT = createRequestDto.In_QNT,
                    Item_Unit_ID = createRequestDto.Item_Unit_ID,
                    Out_QNT = createRequestDto.Out_QNT,
                    Stock_Notes = createRequestDto.Stock_Notes,
                    Transaction_ID = createRequestDto.Transaction_ID,
                    User_Name = createRequestDto.User_Name,
                    Time_Stamp = General.GetCurrentTime()
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
        [Route("StockDetails")]
        public async Task<IActionResult> StockDetails(stockDetailsCriteriaViewModel criteria)
        {
            var itemList = await repository.GetStockDetails(criteria);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = itemList,
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
            }
        }


        [HttpPost]
        public async Task<IActionResult> getAll(vStockQueryCriteriaViewModel criteria)
        {
            var itemList = await repository.getAllAsync(criteria);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = itemList,
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
            }
        }



    }
}
