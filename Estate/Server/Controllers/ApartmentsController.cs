using Estate.Server.Data;
using Estate.Server.Interfaces;
using Estate.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Server.Controllers
{
    public class ApartmentsController : BaseApiController
    {
        private readonly IApartmentsRepository _context;

        public ApartmentsController(IApartmentsRepository context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetApartments()
        {
            return Ok(await _context.GetApartments());
        }

        [HttpGet("occupied")]
        public async Task<IActionResult> GetApartmentsWithTenants()
        {
            return Ok(await _context.GetApartmentsWithTenants());
        }

        [HttpPost]
        public async Task<IActionResult> AddApartment(Apartment apartment)
        {
            return Ok(await _context.AddApartment(apartment));
        }

        [HttpPut]
        public async Task<IActionResult> EditApartment(Apartment apartment)
        {
            var response = await _context.EditApartment(apartment);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApartment(int id)
        {
            var response = await _context.DeleteApartment(id);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetApartment(int id)
        {
            return Ok(await _context.GetApartment(id));
        }
    }
}
