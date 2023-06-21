using MedCar.Service.IServices;
using MedCareWebApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedCareWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DavoUsullariController : ControllerBase
    {
        IDavoUsuliService davoUsuliService;

        public DavoUsullariController(IDavoUsuliService davoUsuliService)
        {
            this.davoUsuliService = davoUsuliService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(DavoUsuliAddDto davoUsuliAddDto)
        {
            if (davoUsuliAddDto is not null)
            {
                await davoUsuliService.AddAsync(davoUsuliAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await davoUsuliService.GetAllAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, DavoUsuliAddDto davoUsuliAddDto)
        {
            await davoUsuliService.UpdateAsync(id, davoUsuliAddDto);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await davoUsuliService.DeleteAsync(id);

            return Ok();
        }
    }
}
