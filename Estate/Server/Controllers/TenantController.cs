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
    public class TenantController : BaseApiController
    {
        private readonly ITenantRepository _repo;

        public TenantController(ITenantRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetTenants()
        {
            return Ok(await _repo.GetTenants());
        }

        [HttpPost]
        public async Task<IActionResult> AddTenant(Tenant tenant)
        {
            var response = await _repo.AddTenant(tenant);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> EditTenant(Tenant tenant)
        {
            var response = await _repo.EditTenant(tenant);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTenant(int id)
        {
            var response = await _repo.DeleteTenant(id);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTenant(int id)
        {
            return Ok(await _repo.GetTenant(id));
        }

        [HttpGet("apartment/{apartmentId}")]
        public async Task<IActionResult> GetTenantForApartment(int apartmentId)
        {
            Console.WriteLine("test");
            return Ok(await _repo.GetTenantForApartment(apartmentId));
        }
    }
}
