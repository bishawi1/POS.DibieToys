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
    public class CitiesController : ControllerBase
    {
        private readonly ICityRepository cityRepository;

        public CitiesController(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var cityList = await cityRepository.getAllAsync();
            try
            {
                return Ok(new ResultModel()
                {
                    Data = cityList,
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
            CityModel cityModel = await cityRepository.getByIdAsync(Convert.ToByte(Id));
            try
            {
                return Ok(new ResultModel()
                {
                    Data = cityModel,
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
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateCityRequestDto updateRequest)
        {
            CityModel model = await cityRepository.getByIdAsync(Convert.ToByte(id));
            if (model == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    model.City_Notes = updateRequest.City_Notes;
                    model.City_Name = updateRequest.City_Name;
                    model = await cityRepository.updateAsync(Convert.ToByte(id), model);
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
                CityModel model = null;// await outSheetRepository.getByIdAsync(id);
                                       //if (bookStock == null)
                                       //{
                                       //    return NotFound();
                                       //}
                                       //else
                                       //{
                model = await cityRepository.deleteAsync(Convert.ToByte(id));
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
        public async Task<IActionResult> Create([FromBody] CreateCityRequestDto createRequestDto)
        {
            try
            {
                CityModel model = new CityModel()
                {
                    City_Name = createRequestDto.City_Name,
                    City_Notes = createRequestDto.City_Notes,
                    Time_Stamp = General.GetCurrentTime(),
                    User_Name = createRequestDto.User_Name,
                };
                model = await cityRepository.createAsync(model);
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
