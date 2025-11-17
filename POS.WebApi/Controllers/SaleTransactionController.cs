using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.WebApi.Contracts;
using POS.WebApi.Repositories;
using System.Net;

namespace POS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleTransactionController : ControllerBase
    {
        private readonly ISaleTransaction repository;

        public SaleTransactionController(ISaleTransaction repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var saleTransactionList = await repository.getAllAsync();
            try
            {
                return Ok(new ResultModel()
                {
                    Data = saleTransactionList,
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
            Sale_Transaction_Model saleTransactionModel = await repository.getByIdAsync(Id);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = saleTransactionModel,
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
       // [Route("{id:int}")]
        [HttpPut]
        public async Task<IActionResult> update([FromBody] UpdateSaleTransactionDto updateRequest)
        {
            try
            {

                Sale_Transaction_Model model = await repository.updateSaleAsync(updateRequest);
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

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                Sale_Transaction_Model model = null;
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
        public async Task<IActionResult> Create([FromBody] AddSaleTransactionDto createRequestDto)
        {
            try
            {
                    Sale_Transaction_Model model = await repository.addSaleAsync(createRequestDto);
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
        [Route("Query")]
        public async Task<IActionResult> getAll(SalesQueryCriteriaViewModel criteria)
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

        [HttpPost]
        [Route("InvoiceReport")]
        public async Task<IActionResult> InvoiceReportData(InvoiceReportCriteriaViewModel criteria)
        {
            var itemList = await repository.getInvoiceReportDataAsync(criteria);
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
