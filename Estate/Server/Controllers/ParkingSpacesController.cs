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
            return Ok(await _repo.AddParkingSpace(parking));
        }

        [HttpPut]
        public async Task<IActionResult> EditParkingSpace(ParkingSpace parking)
        {
            return Ok(await _repo.EditParkingSpace(parking));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParkingSpace(int id)
        {
            return Ok(await _repo.DeleteParkingSpace(id));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetParkingSpace(int id)
        {
            return Ok(await _repo.GetParkingSpace(id));
        }
    }
}
