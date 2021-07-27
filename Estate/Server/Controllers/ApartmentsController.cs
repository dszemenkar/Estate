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

        [HttpPost]
        public async Task<IActionResult> AddApartment(Apartment apartment)
        {
            return Ok(await _context.AddApartment(apartment));
        }
    }
}
