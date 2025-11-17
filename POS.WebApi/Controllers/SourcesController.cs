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
    public class SourcesController : ControllerBase
    {
        private readonly ISourceRepository sourceRepository;

        public SourcesController(ISourceRepository sourceRepository)
        {
            this.sourceRepository = sourceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var oList = await sourceRepository.getAllAsync();
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
            var oModel = await sourceRepository.getByIdAsync(Convert.ToInt16(Id));
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
                });

                throw;
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateSourceRequestDto updateRequest)
        {
            SourceModel model = await sourceRepository.getByIdAsync(Convert.ToInt16(id));
            if (model == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    model.Book_Source_Desc = updateRequest.Book_Source_Desc;
                    model.Book_Source_Notes = updateRequest.Book_Source_Notes;
                    model.User_Name = updateRequest.User_Name;
                    model = await sourceRepository.updateAsync(Convert.ToInt16(id), model);
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
                SourceModel model = null;// await outSheetRepository.getByIdAsync(id);
                                         //if (bookStock == null)
                                         //{
                                         //    return NotFound();
                                         //}
                                         //else
                                         //{
                model = await sourceRepository.deleteAsync(Convert.ToInt16(id));
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
        public async Task<IActionResult> Create([FromBody] CreateSourceRequestDto createRequestDto)
        {
            try
            {
                SourceModel model = new SourceModel()
                {
                    Book_Source_Desc = createRequestDto.Book_Source_Desc,
                    Book_Source_Notes = createRequestDto.Book_Source_Notes,
                    Book_Source_Status_Date = General.GetCurrentDate(),// DateTime.Today,
                    Book_Source_Status_ID = 1,
                    Person_ID = createRequestDto.Person_ID,
                    Time_Stamp = General.GetCurrentTime(),
                    User_Name = createRequestDto.User_Name
                };
                model = await sourceRepository.createAsync(model);
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
        [Route("BookSourceQuery")]
        public async Task<IActionResult> getBookSourceQuery([FromBody] BookSourceQueryCriteriaViewModel criteria)
        {
            try
            {
                List<BookSourceQueryModel> oList = await sourceRepository.BookSourceQuery(criteria);
                return Ok(new ResultModel()
                {
                    Data = oList,
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
