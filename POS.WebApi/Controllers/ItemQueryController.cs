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
    public class ItemQueryController : ControllerBase
    {
        private readonly IvItem_UnitRepository itemQueryRepository;

        public ItemQueryController(IvItem_UnitRepository itemQueryRepository)
        {
            this.itemQueryRepository = itemQueryRepository;
        }
        [HttpGet]
        [Route("GenerateBarcode")]
        public async Task<IActionResult> generateBarcode()
        {
            try
            {
                string barcode= await itemQueryRepository.generateBarcode();
                return Ok(new ResultModel()
                {
                    Data = barcode,
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
        public async Task<IActionResult> getAll()
        {
            var itemList = await itemQueryRepository.getAllAsync("", "", "");
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
        public async Task<IActionResult> getAll(ItemListCriteriaViewModel criteria)
        {
            var itemList = await itemQueryRepository.getAllAsync(criteria);
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
        [Route("BranchItemUnits")]
        public async Task<IActionResult> getBranchItemUnits(Branch_ItemListCriteriaViewModel criteria)
        {
            var itemList = await itemQueryRepository.getAllAsync(criteria);
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

        [HttpGet]
        [Route("{Id:int}")]
        public async Task<IActionResult> getById(int Id)
        {
            vItem_UnitModel itemModel = await itemQueryRepository.getByIdAsync(Convert.ToInt16(Id));
            try
            {
                return Ok(new ResultModel()
                {
                    Data = itemModel,
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
