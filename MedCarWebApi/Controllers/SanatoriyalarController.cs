using MedCar.Service.IServices;
using MedCareWebApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedCareWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SanatoriyalarController : ControllerBase
    {
        ISanatoriyaService sanatoriyaService;

        public SanatoriyalarController(ISanatoriyaService sanatoriyaService)
        {
            this.sanatoriyaService = sanatoriyaService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(SanatoriyaAddDto sanatoriyaAddDto)
        {
            if (sanatoriyaAddDto is not null)
            {
                await sanatoriyaService.AddAsync(sanatoriyaAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await sanatoriyaService.GetAllAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, SanatoriyaAddDto sanatoriyaAddDto)
        {
            await sanatoriyaService.UpdateAsync(id, sanatoriyaAddDto);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await sanatoriyaService.DeleteAsync(id);

            return Ok();
        }
    }
}
