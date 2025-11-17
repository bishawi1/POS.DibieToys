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
    public class ItemGroupController : ControllerBase
    {
        private readonly IItem_GroupRepository repository;

        public ItemGroupController(IItem_GroupRepository repository)
        {
            this.repository = repository;
        }
 
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var itemList = await repository.getAllAsync("", "", "");
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
            Item_GroupModel itemModel = await repository.getByIdAsync(Convert.ToByte(Id));
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

        [HttpGet]
        [Route("SubItemGroups/{parentCategoryId:int}")]
        public async Task<IActionResult> getByParentCategory(int parentCategoryId)
        {
            List<Item_GroupModel> itemListModel = await repository.getSubItemGroupsAsync(Convert.ToInt16(parentCategoryId));
            try
            {
                return Ok(new ResultModel()
                {
                    Data = itemListModel,
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
        public async Task<IActionResult> Create([FromBody] AddItemGroupRequestDto createRequestDto)
        {
            try
            {
                Item_GroupModel toAddModel = new Item_GroupModel
                {
                    Item_Group_Desc=createRequestDto.Item_Group_Desc,
                    Item_Group_Notes=createRequestDto.Item_Group_Notes,
                    Leaf_Item_Group=createRequestDto.Leaf_Item_Group,
                    Parent_Item_Group_ID=createRequestDto.Parent_Item_Group_ID
                };
                Item_GroupModel model = await repository.createAsync(toAddModel);
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
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateItemGroupRequestDto updateRequest)
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
                Item_GroupModel toEditModel = new Item_GroupModel
                {
                    Item_Group_ID= updateRequest.Item_Group_ID,
                    Item_Group_No= updateRequest.Item_Group_No,
                    Item_Group_Desc = updateRequest.Item_Group_Desc,
                    Item_Group_Notes = updateRequest.Item_Group_Notes,
                    Leaf_Item_Group = updateRequest.Leaf_Item_Group,
                    Parent_Item_Group_ID = updateRequest.Parent_Item_Group_ID
                };
                Item_GroupModel model = await repository.updateAsync((short)id, toEditModel);
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
