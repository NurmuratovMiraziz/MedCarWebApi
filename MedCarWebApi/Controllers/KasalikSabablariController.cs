using MedCar.Service.IServices;
using MedCareWebApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedCareWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KasalikSabablariController : ControllerBase
    {
        IKasalikSababiService kasalikSababiService;

        public KasalikSabablariController(IKasalikSababiService kasalikSababiService)
        {
            this.kasalikSababiService = kasalikSababiService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(KasalikSababiAddDto kasalikSababiAddDto)
        {
            if (kasalikSababiAddDto is not null)
            {
                await kasalikSababiService.AddAsync(kasalikSababiAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await kasalikSababiService.GetAllAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, KasalikSababiAddDto kasalikSababiAddDto)
        {
            await kasalikSababiService.UpdateAsync(id, kasalikSababiAddDto);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await kasalikSababiService.DeleteAsync(id);

            return Ok();
        }
    }
}
