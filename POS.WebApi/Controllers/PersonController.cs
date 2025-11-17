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
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }


        [HttpGet]
        public async Task<IActionResult> getAll()
        {

            var oList = await personRepository.getAllAsync();
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
        [Route("Query")]
        public async Task<IActionResult> getPersonQuery(PersonQueryCriteriaViewModel criteria)
        {
            var persons = await personRepository.getPersonQuery(criteria);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = persons,
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
        public async Task<IActionResult> GetPerson(int Id)
        {
            var oModel = await personRepository.getByIdAsync((Int16)Id);
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
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdatePersonRequestDto updateRequest)
        {
            PersonModel model = await personRepository.getByIdAsync((Int16)id);
            if (model == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    model.Person_ID=updateRequest.Person_ID;
                    model.Person_No = updateRequest.Person_ID.ToString();
                    model.Person_Notes = updateRequest.Person_Notes;
                    model.Sell_Discount_Percent = updateRequest.Sell_Discount_Percent;
                    model.Address = updateRequest.Address;
                    model.Commercial_Name = updateRequest.Commercial_Name;
                    model.Begining_Balance_Amount = updateRequest.Begining_Balance_Amount;
                    model.Mobile = updateRequest.Mobile;
                    model.Person_Account_ID = updateRequest.Person_Account_ID;
                    model.Person_Name = General.Recontruct(updateRequest.Person_Name);
                    model.User_Name = updateRequest.User_Name;
                    model.City_ID = updateRequest.City_ID;
                    model.Person_Cat_ID=updateRequest.Person_Cat_ID;

                    model = await personRepository.updateAsync(Convert.ToInt16(id), model);
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
                PersonModel model = null;// await outSheetRepository.getByIdAsync(id);
                                         //if (bookStock == null)
                                         //{
                                         //    return NotFound();
                                         //}
                                         //else
                                         //{
                model = await personRepository.deleteAsync(Convert.ToInt16(id));
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
        public async Task<IActionResult> Create([FromBody] CreatePersonRequestDto createRequestDto)
        {
            try
            {
                PersonModel model = new PersonModel()
                {
                    Address = createRequestDto.Address,
                    Begining_Balance_Amount = createRequestDto.Begining_Balance_Amount,
                    City_ID = createRequestDto.City_ID,
                    Commercial_Name = createRequestDto.Commercial_Name,
                    Person_Account_ID = createRequestDto.Person_Account_ID,
                    Person_Name = General.Recontruct(createRequestDto.Person_Name),
                    Person_Notes = createRequestDto.Person_Notes,
                    Sell_Discount_Percent = createRequestDto.Sell_Discount_Percent,
                    Time_Stamp = General.GetCurrentTime(),
                    User_Name = createRequestDto.User_Name,
                    Mobile=createRequestDto.Mobile,
                    Person_Cat_ID=createRequestDto.Person_Cat_ID,
                };
                model = await personRepository.createAsync(model);
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
        [Route("FinanceStatement")]
        public async Task<IActionResult> getFinanceStatement(PersonStatementOfAccountCriteriaViewModel criteria)
        {
            var Statement = await personRepository.getStatementOfAccount(criteria);
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








    }
}
