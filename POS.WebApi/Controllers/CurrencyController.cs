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
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyRepository currencyRepository;
        public CurrencyController(ICurrencyRepository currencyRepository)
        {
            this.currencyRepository = currencyRepository;
        }
        [HttpGet]
        public async Task<IActionResult> getAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery, [FromQuery] string? sortBy, [FromQuery] bool? isAscending = true, [FromQuery] int? pageNumber = 1, [FromQuery] int? pageSize = 0)
        {
            var oList = await currencyRepository.getAllAsync(filterOn, filterQuery, sortBy, isAscending ?? true, pageNumber ?? 1, pageSize ?? 200);
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
            var oModel = await currencyRepository.getByIdAsync(Convert.ToByte(Id));
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
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateCurrencyRequestDto updateRequest)
        {
            CurrencyModel model = await currencyRepository.getByIdAsync(Convert.ToByte(id));
            if (model == null)
            {

                return NotFound();
            }
            else
            {
                try
                {
                    model.Currency_ID = updateRequest.Currency_ID;
                    model.Currency_Name = updateRequest.Currency_Name;
                    
                    model = await currencyRepository.updateAsync(Convert.ToByte(id), model);
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
                CurrencyModel model = null;
                model = await currencyRepository.deleteAsync(Convert.ToByte(id)); if (model == null)
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
        public async Task<IActionResult> Create([FromBody] CreateCurrencyRequestDto createRequestDto)
        {
            try
            {
                CurrencyModel model = new CurrencyModel()
                {
                    // Assign model properties
                    // Book_Author_Desc = createRequestDto.Book_Author_Desc,
                };
                model = await currencyRepository.createAsync(model);
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
