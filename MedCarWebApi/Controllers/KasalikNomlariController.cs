using MedCar.Service.IServices;
using MedCareServices.IRepository;
using MedCareWebApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedCareWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KasalikNomlariController : ControllerBase
    {
        IKasalikNomiService kasalikNomiService;

        public KasalikNomlariController(IKasalikNomiService kasalikNomiService)
        {
            this.kasalikNomiService = kasalikNomiService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(KasalikNomiAddDto kasalikNomiAddDto)
        {
            if (kasalikNomiAddDto is not null)
            {
                await kasalikNomiService.AddAsync(kasalikNomiAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await kasalikNomiService.GetAllAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, KasalikNomiAddDto kasalikNomiAddDto)
        {
            await kasalikNomiService.UpdateAsync(id, kasalikNomiAddDto);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await kasalikNomiService.DeleteAsync(id);

            return Ok();
        }

    }
}
