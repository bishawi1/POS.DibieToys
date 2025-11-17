using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.WebApi.Contracts;
using System.Net;

namespace POS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransaction repository;

        public TransactionController(ITransaction Repository)
        {
            repository = Repository;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var transactionList = await repository.getAllAsync();
            try
            {
                return Ok(new ResultModel()
                {
                    Data = transactionList,
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
            Transaction_Model stockModel = await repository.getByIdAsync(Id);
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
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateTransactionRequestDto updateRequest)
        {
            try
            {
                Transaction_Model model = new()
                {
                    Notes = updateRequest.Notes,
                    Reference_ID = updateRequest.Reference_ID,
                    Transaction_Date = updateRequest.Transaction_Date,
                    Transaction_ID = updateRequest.Transaction_ID,
                    Transaction_Type_ID=updateRequest.Transaction_Type_ID,
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
                Transaction_Model model = null;
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
        public async Task<IActionResult> Create([FromBody] AddTransactionRequestDto createRequestDto)
        {
            try
            {
                Transaction_Model model = new ()
                {
                    Notes=createRequestDto.Notes,
                    Reference_ID=createRequestDto.Reference_ID,
                    Transaction_Date=createRequestDto.Transaction_Date,
                    Transaction_Type_ID=createRequestDto.Transaction_Type_ID,
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


    }
}
