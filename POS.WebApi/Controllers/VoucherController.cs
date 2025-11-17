using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.WebApi.Contracts;
using System.Net;

namespace POS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherRepository voucherRepository;
        public VoucherController(IVoucherRepository voucherRepository)
        {
            this.voucherRepository = voucherRepository;
        }
        [HttpGet]
        public async Task<IActionResult> getAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery, [FromQuery] string? sortBy, [FromQuery] bool? isAscending = true, [FromQuery] int? pageNumber = 1, [FromQuery] int? pageSize = 0)
        {
            var oList = await voucherRepository.getAllAsync(filterOn, filterQuery, sortBy, isAscending ?? true, pageNumber ?? 1, pageSize ?? 200);
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
            var oModel = await voucherRepository.getByIdAsync(Id);
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
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateVoucherRequestDto updateRequest)
        {
            VoucherModel model = await voucherRepository.getByIdAsync(id);
            if (model == null)
            {

                return NotFound();
            }
            else
            {
                try
                {
                    model.Cheque_Due_Date = updateRequest.Cheque_Due_Date;
                    model.Voucher_Date = updateRequest.Voucher_Date;
                    model.Voucher_Currency_Rate = updateRequest.Voucher_Currency_Rate;
                    model.Voucher_Currency_ID = updateRequest.Voucher_Currency_ID;
                    //model.Voucher_ID = updateRequest.Voucher_ID;
                    model.Pay_Way_Id = updateRequest.Pay_Way_Id;
                    model.Cheque_Bank_No = updateRequest.Cheque_Bank_No;
                    model.Cheque_ID= updateRequest.Cheque_ID;
                    model.Cheque_No = updateRequest.Cheque_No;
                    model.Manual_Voucher_No = updateRequest.Manual_Voucher_No;
                    model.Person_ID = updateRequest.Person_ID;
                    model.User_Name = updateRequest.User_Name;
                    model.Time_Stamp = General.GetCurrentTime();
                    model.Debit_Amount = updateRequest.Debit_Amount;
                    model.Credit_Amount = updateRequest.Credit_Amount;
                    model.Voucher_Details = updateRequest.Voucher_Details;
                    model.voucher_Type_ID = updateRequest.voucher_Type_ID;
                    model = await voucherRepository.updateAsync(id, model);
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
                VoucherModel model = null;
                model = await voucherRepository.deleteAsync(Convert.ToInt16(id)); if (model == null)
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
        public async Task<IActionResult> Create([FromBody] CreateVoucherRequestDto createRequestDto)
        {
            try
            {

                VoucherModel model = new VoucherModel()
                {
                    Cheque_Bank_No=createRequestDto.Cheque_Bank_No,
                    Cheque_Due_Date=createRequestDto.Cheque_Due_Date,
                    Cheque_ID=createRequestDto.Cheque_ID,
                    Cheque_No= createRequestDto.Cheque_No,
                    Manual_Voucher_No= createRequestDto.Manual_Voucher_No,
                    Pay_Way_Id = createRequestDto.Pay_Way_Id,
                    Person_ID= createRequestDto.Person_ID,
                    Time_Stamp=General.GetCurrentTime(),
                    User_Name= createRequestDto.User_Name,
                    Debit_Amount= createRequestDto.Debit_Amount,
                    Credit_Amount= createRequestDto.Credit_Amount,
                    Voucher_Currency_ID= createRequestDto.Voucher_Currency_ID,
                    Voucher_Currency_Rate = createRequestDto.Voucher_Currency_Rate,
                    Voucher_Date= createRequestDto.Voucher_Date,
                    Voucher_Details= createRequestDto.Voucher_Details,
                    voucher_Type_ID= createRequestDto.voucher_Type_ID
                };
                model = await voucherRepository.createAsync(model);
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
        public async Task<IActionResult> getVoucherQuery(VoucherQueryCriteriaViewModel criteria)
        {
            var vouchers = await voucherRepository.getVoucherQuery(criteria);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = vouchers,
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
        [Route("PurchaseInvoiceQuery")]
        public async Task<IActionResult> getPurchaseInvoiceQuery(PurchaseInvoiceQueryCriteriaViewModel criteria)
        {
            var invoices = await voucherRepository.getPurchaseInvoiceQuery(criteria);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = invoices,
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
        [Route("VoucherTotals")]
        public async Task<IActionResult> getVoucherTotals(VoucherQueryCriteriaViewModel criteria)
        {
            var vouchers = await voucherRepository.getVoucherSummary(criteria);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = vouchers,
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
