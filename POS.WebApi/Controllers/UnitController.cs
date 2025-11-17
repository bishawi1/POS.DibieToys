using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.Shared.DTOs;
using POS.WebApi.Contracts;
using System.Net;

namespace POS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly IUnitRepository repository;

        public UnitController(IUnitRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var unitList = await repository.getAllAsync("", "", "");
            try
            {
                return Ok(new ResultModel()
                {
                    Data = unitList,
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
