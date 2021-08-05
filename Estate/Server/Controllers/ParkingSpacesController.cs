using Estate.Server.Interfaces;
using Estate.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Estate.Server.Controllers
{
    public class ParkingSpacesController : BaseApiController
    {
        private readonly IParkingInterface _repo;

        public ParkingSpacesController(IParkingInterface repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetParkingSpaces()
        {
            return Ok(await _repo.GetParkingSpaces());
        }

        [HttpPost]
        public async Task<IActionResult> AddParkingSpace(ParkingSpace parking)
        {
            var response = await _repo.AddParkingSpace(parking);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> EditParkingSpace(ParkingSpace parking)
        {
            var response = await _repo.EditParkingSpace(parking);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParkingSpace(int id)
        {
            var response = await _repo.DeleteParkingSpace(id);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetParkingSpace(int id)
        {
            return Ok(await _repo.GetParkingSpace(id));
        }
    }
}
