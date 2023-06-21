using MedCar.Service.IServices;
using MedCareWebApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedCareWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KutilganKasaliklarController : ControllerBase
    {
        IKutilganKasalikService kutilganKasalikService;

        public KutilganKasaliklarController(IKutilganKasalikService kutilganKasalikService)
        {
            this.kutilganKasalikService = kutilganKasalikService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(KutilganKasalikAddDto kutilganKasalikAddDto)
        {
            if (kutilganKasalikAddDto is not null)
            {
                await kutilganKasalikService.AddAsync(kutilganKasalikAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await kutilganKasalikService.GetAllAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, KutilganKasalikAddDto kutilganKasalikAddDto)
        {
            await kutilganKasalikService.UpdateAsync(id, kutilganKasalikAddDto);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await kutilganKasalikService.DeleteAsync(id);

            return Ok();
        }
    }
}
