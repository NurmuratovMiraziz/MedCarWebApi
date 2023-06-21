using MedCar.Service.IServices;
using MedCareWebApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedCareWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BelgilariController : ControllerBase
    {
        IBelgisiService belgisiService;

        public BelgilariController(IBelgisiService belgisiService)
        {
            this.belgisiService = belgisiService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(BelgisiAddDto belgisiAddDto)
        {
            if (belgisiAddDto is not null)
            {
                await belgisiService.AddAsync(belgisiAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await belgisiService.GetAllAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, BelgisiAddDto belgisiAddDto)
        {
            await belgisiService.UpdateAsync(id, belgisiAddDto);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await belgisiService.DeleteAsync(id);

            return Ok();
        }
    }
}
