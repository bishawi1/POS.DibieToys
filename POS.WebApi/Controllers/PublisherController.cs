using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.Shared.DTOs;
using POS.Shared.DTOs.Books;
using POS.Shared.Models.Books;
using POS.WebApi.Contracts.Books;
using System.Net;

namespace POS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherRepository publisherRepository;
        public PublisherController(IPublisherRepository publisherRepository)
        {
            this.publisherRepository = publisherRepository;
        }
        [HttpGet]
        public async Task<IActionResult> getAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery, [FromQuery] string? sortBy, [FromQuery] bool? isAscending = true, [FromQuery] int? pageNumber = 1, [FromQuery] int? pageSize = 0)
        {
            var oList = await publisherRepository.getAllAsync(filterOn, filterQuery, sortBy, isAscending ?? true, pageNumber ?? 1, pageSize ?? 200);
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
            var oModel = await publisherRepository.getByIdAsync((short)Id);
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
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdatePublisherRequestDto updateRequest)
        {
            PublisherModel model = await publisherRepository.getByIdAsync((short)id);
            if (model == null)
            {

                return NotFound();
            }
            else
            {
                try
                {
                    model.Publisher_Desc = updateRequest.Publisher_Desc;
                    model = await publisherRepository.updateAsync(Convert.ToInt16(id), model);
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
                PublisherModel model = null;
                model = await publisherRepository.deleteAsync(Convert.ToInt16(id)); if (model == null)
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
        public async Task<IActionResult> Create([FromBody] CreatePublisherRequestDto createRequestDto)
        {
            try
            {
                PublisherModel model = new PublisherModel()
                {
                    Publisher_Desc=createRequestDto.Publisher_Desc,
                    Publisher_Notes=createRequestDto.Publisher_Notes,
                    Publisher_Status_Date=General.GetCurrentTime(),
                    Publisher_Status_ID=1,
                    User_Name=createRequestDto.User_Name,
                    Time_Stamp=General.GetCurrentTime(),
                   
                    // Assign model properties
                    // Book_Author_Desc = createRequestDto.Book_Author_Desc,
                };
                model = await publisherRepository.createAsync(model);
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
