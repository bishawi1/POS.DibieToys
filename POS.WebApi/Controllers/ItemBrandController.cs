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
    public class ItemBrandController : ControllerBase
    {
        private readonly IItem_BrandRepository repository;

        public ItemBrandController(IItem_BrandRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var itemBrandList = await repository.getAllAsync("", "", "");
            try
            {
                return Ok(new ResultModel()
                {
                    Data = itemBrandList,
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
            Item_BrandModel itemModel = await repository.getByIdAsync(Convert.ToByte(Id));
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


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddItemBrandRequestDto createRequestDto)
        {
            try
            {
                Item_BrandModel model = await repository.createAsync(new Item_BrandModel
                {
                    Item_Brand_Name = createRequestDto.Item_Brand_Name
                });
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

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateItemBrandRequestDto updateRequest)
        {
            //ItemModel model = await itemRepository.getByIdAsync(Convert.ToByte(id));
            //if (model == null)
            //{
            //    return NotFound();
            //}
            //else
            //{

            try
            {
                Item_BrandModel model = await repository.updateAsync(id,new Item_BrandModel { Item_Brand_ID=updateRequest.Item_Brand_ID,Item_Brand_Name=updateRequest.Item_Brand_Name});
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


    }
}
