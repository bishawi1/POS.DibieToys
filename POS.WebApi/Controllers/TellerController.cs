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
    public class TellerController : ControllerBase
    {
        private readonly ITellerRepository tellerRepository;
        public TellerController(ITellerRepository tellerRepository)
        {
            this.tellerRepository = tellerRepository;
        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var oList = await tellerRepository.getAllAsync();
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
            var oModel = await tellerRepository.getByIdAsync(Id);
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
        [Route("GetByUser/{UserName}")]
        public async Task<IActionResult> GetByUser(string UserName)
        {
            var oModel = await tellerRepository.getByUserAsync(UserName);
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
        [Route("GetUserList")]
        public async Task<IActionResult> GetUserList()
        {
            var oModel = await tellerRepository.getUserListAsync();
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
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateTellerRequestDto updateRequest)
        {
            TellerModel model = await tellerRepository.getByIdAsync(id);
            if (model == null)
            {

                return NotFound();
            }
            else
            {
                try
                {
                    model.Teller_Name=updateRequest.Teller_Name;
                    model.Notes=updateRequest.Notes;
                    model.IsActive=updateRequest.IsActive;
                    model = await tellerRepository.updateAsync(model);

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
                TellerModel model = null;
                model = await tellerRepository.deleteAsync(id); if (model == null)
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
        public async Task<IActionResult> Create([FromBody] CreateTellerRequestDto createRequestDto)
        {
            try
            {
                TellerModel model = new TellerModel()
                {
                    IsActive=true,
                    Notes=createRequestDto.Notes,
                    Teller_Name=createRequestDto.Teller_Name,
                };
                model = await tellerRepository.createAsync(model);
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
