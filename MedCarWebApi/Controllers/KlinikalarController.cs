using MedCar.Service.IServices;
using MedCareWebApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedCareWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KlinikalarController : ControllerBase
    {
        IKlinikaService klinikaService;

        public KlinikalarController(IKlinikaService klinikaService)
        {
            this.klinikaService = klinikaService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(KlinikaAddDto klinikaAddDto)
        {
            if (klinikaAddDto is not null)
            {
                await klinikaService.AddAsync(klinikaAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await klinikaService.GetAllAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, KlinikaAddDto klinikaAddDto)
        {
            await klinikaService.UpdateAsync(id, klinikaAddDto);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await klinikaService.DeleteAsync(id);

            return Ok();
        }
    }
}
