using MedCar.Service.IServices;
using MedCareWebApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedCareWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ParhezTaomlarController : ControllerBase
    {
        IParhezTaomService parhezTaomService;

        public ParhezTaomlarController(IParhezTaomService parhezTaomService)
        {
            this.parhezTaomService = parhezTaomService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(ParhezTaomAddDto parhezTaomAddDto)
        {
            if (parhezTaomAddDto is not null)
            {
                await parhezTaomService.AddAsync(parhezTaomAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await parhezTaomService.GetAllAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, ParhezTaomAddDto parhezTaomAddDto)
        {
            await parhezTaomService.UpdateAsync(id, parhezTaomAddDto);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await parhezTaomService.DeleteAsync(id);

            return Ok();
        }
    }
}
