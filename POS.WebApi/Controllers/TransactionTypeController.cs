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
    public class TransactionTypeController : ControllerBase
    {
        private readonly ITransaction_Type repository;

        public TransactionTypeController(ITransaction_Type repository)
        {
            this.repository = repository;
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
            Transaction_Type_Model stockModel = await repository.getByIdAsync(Convert.ToByte(Id));
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
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateTransactionTypeRequestDto updateRequest)
        {
            try
            {
                Transaction_Type_Model model = new()
                {
                    Transaction_Type_ID = updateRequest.Transaction_Type_ID,
                    Transaction_Type_Desc=updateRequest.Transaction_Type_Desc,
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
                Transaction_Type_Model model = null;
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
        public async Task<IActionResult> Create([FromBody] AddTransactionTypeRequestDto createRequestDto)
        {
            try
            {
                Transaction_Type_Model model = new()
                {
                    Transaction_Type_Desc=createRequestDto.Transaction_Type_Desc,
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
