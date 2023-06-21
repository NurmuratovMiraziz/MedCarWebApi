using MedCar.Service.IServices;
using MedCareWebApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedCareWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DavolanishJadvallariController : ControllerBase
    {
        IDavolanishJadvaliService davolanishJadvaliService;

        public DavolanishJadvallariController(IDavolanishJadvaliService davolanishJadvaliService)
        {
            this.davolanishJadvaliService = davolanishJadvaliService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(DavolanishJadvaliAddDto davolanishJadvaliAddDto)
        {
            if (davolanishJadvaliAddDto is not null)
            {
                await davolanishJadvaliService.AddAsync(davolanishJadvaliAddDto);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await davolanishJadvaliService.GetAllAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, DavolanishJadvaliAddDto davolanishJadvaliAddDto)
        {
            await davolanishJadvaliService.UpdateAsync(id, davolanishJadvaliAddDto);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await davolanishJadvaliService.DeleteAsync(id);

            return Ok();
        }
    }
}
