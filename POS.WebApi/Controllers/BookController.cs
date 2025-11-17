using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.Shared.DTOs;
using POS.Shared.DTOs.Books;
using POS.Shared.Models;
using POS.Shared.Models.Books;
using POS.Shared.ViewModels;
using POS.Shared.ViewModels.Books;
using POS.WebApi.Contracts;
using POS.WebApi.Contracts.Books;
using System.Net;

namespace POS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;
        private readonly IItemRepository itemRepository;

        public BookController(IBookRepository bookRepository, IItemRepository itemRepository)
        {
            this.bookRepository = bookRepository;
            this.itemRepository = itemRepository;
        }
        [HttpGet]
        public async Task<IActionResult> getAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery, [FromQuery] string? sortBy, [FromQuery] bool? isAscending = true, [FromQuery] int? pageNumber = 1, [FromQuery] int? pageSize = 0)
        {
            var oList = await bookRepository.getAllAsync(filterOn, filterQuery, sortBy, isAscending ?? true, pageNumber ?? 1, pageSize ?? 200);
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
            var oModel = await bookRepository.getByIdAsync(Id);
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
        public async Task<IActionResult> update([FromRoute] int id, [FromBody] UpdateBookRequestDto updateRequest)
        {
            BookModel model = await bookRepository.getByIdAsync(id);
            if (model == null)
            {

                return NotFound();
            }
            else
            {
                try
                {
                    model.Book_Subject_ID = updateRequest.Book_Subject_ID;
                    model.Book_Publisher_ID=updateRequest.Book_Publisher_ID;
                    model.Book_Author_ID=updateRequest.Book_Author_ID;
                    model.Book_Cat_ID=updateRequest.Book_Cat_ID;
                    model.Book_Title=updateRequest.Book_Title;
                    model = await bookRepository.updateAsync(Convert.ToInt16(id), model,updateRequest.ItemUnitPrice,updateRequest.ItemUnitCost,itemRepository);
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
                BookModel model = null;
                model = await bookRepository.deleteAsync(Convert.ToInt16(id)); if (model == null)
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
        public async Task<IActionResult> Create([FromBody] CreateBookRequestDto createRequestDto)
        {
            try
            {
                Item_UnitModel itemUnit = null;
                BookModel model = new BookModel()
                {
                    Book_Author_ID=createRequestDto.Book_Author_ID,
                    Book_Cat_ID=createRequestDto.Book_Cat_ID,
                    Book_Publisher_ID=createRequestDto.Book_Publisher_ID,
                    Book_Subject_ID=createRequestDto.Book_Subject_ID,
                    Book_Title=createRequestDto.Book_Title,
                    Time_Stamp=General.GetCurrentTime(),
                    User_Name = createRequestDto.User_Name,
                    Book_Notes=createRequestDto.Book_Notes,
                };
                model = await bookRepository.createAsync(model,createRequestDto.ItemUnitPrice,createRequestDto.ItemUnitCost,createRequestDto.Qnt,createRequestDto.ISBN, itemRepository);
                if (model != null)
                {
                    itemUnit = await bookRepository.getBookItemUnit(model.Book_ID);
                }
                return Ok(new ResultModel()
                {
                    Data = itemUnit,
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
        [Route("BookQuery")]
        public async Task<IActionResult> getBookQuery(vBookQueryCriteriaViewModel criteria)
        {
            var books = await bookRepository.getAllAsync(criteria);
            try
            {
                return Ok(new ResultModel()
                {
                    Data = books,
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
        [Route("Detail/{Id:int}")]
        public async Task<IActionResult> getSupplyTransaction(int Id)
        {
            var oModel = await bookRepository.getBookAsync(Id);
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

    }
}
