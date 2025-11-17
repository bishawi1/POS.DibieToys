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
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository itemRepository;
        private readonly IWebHostEnvironment env;

        public ItemController(IItemRepository itemRepository, IWebHostEnvironment env)
        {
            this.itemRepository = itemRepository;
            this.env = env;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var itemList = await itemRepository.getAllAsync("", "", "");
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
            ItemModel itemModel = await itemRepository.getByIdAsync(Convert.ToByte(Id));
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


        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateItemRequestModel updateRequest)
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
                ItemModel model = await itemRepository.updateAsync(updateRequest);
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

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                ItemModel model = null;// await outSheetRepository.getByIdAsync(id);
                                       //if (bookStock == null)
                                       //{
                                       //    return NotFound();
                                       //}
                                       //else
                                       //{
                model = await itemRepository.deleteAsync(id);
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
        public async Task<IActionResult> Create([FromBody] AddItemRequestModel createRequestDto)
        {
            try
            {
                ItemModel model = await itemRepository.createAsync(createRequestDto);
                //CityModel model = new CityModel()
                //{
                //    City_Name = createRequestDto.City_Name,
                //    City_Notes = createRequestDto.City_Notes,
                //    Time_Stamp = General.GetCurrentTime(),
                //    User_Name = createRequestDto.User_Name,
                //};
                //model = await cityRepository.createAsync(model);
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
        [Route("AddBeginQnt")]
        public async Task<IActionResult> AddBeginQnt([FromBody] AddItemUnitBeginQntRequestDto createRequestDto)
        {
            try
            {
                
                Item_Unit_Begin_Qnt_Model model = new Item_Unit_Begin_Qnt_Model()
                {
                    Item_Unit_ID=createRequestDto.Item_Unit_ID,
                    Stock_ID=createRequestDto.Stock_ID,
                    User_Name=createRequestDto.User_Name,
                    Time_Stamp=General.GetCurrentTime(),
                };
                model = await itemRepository.addBeginQntAsync(model,createRequestDto.Qnt);
                //CityModel model = new CityModel()
                //{
                //    City_Name = createRequestDto.City_Name,
                //    City_Notes = createRequestDto.City_Notes,
                //    Time_Stamp = General.GetCurrentTime(),
                //    User_Name = createRequestDto.User_Name,
                //};
                //model = await cityRepository.createAsync(model);
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
        [Route("upload/{itemId:int}")]
        public async Task<IActionResult> UploadFile(int itemId ,IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");
            string fileName=Guid.NewGuid().ToString();
            string extension = Path.GetExtension(file.FileName);
            string uploadedFileName=fileName + "." + extension;

            //var filePath = Path.Combine("Uploads", file.FileName);
            var uploadsFolder = Path.Combine(env.WebRootPath, "uploads");
            Directory.CreateDirectory(uploadsFolder); // Ensure folder exists
            var filePath = Path.Combine(uploadsFolder, uploadedFileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            var fileUri = $"{Request.Scheme}://{Request.Host}/uploads/{uploadedFileName}";

            ItemModel item = await itemRepository.updateItemFileUriAsync(itemId, $"uploads/{uploadedFileName}");
            ResultModel result = new()
            {
                Data = item,
                ErrorText = "",
                StatusCode = "200"
            };
            return Ok(result);
        }
        }
    }

