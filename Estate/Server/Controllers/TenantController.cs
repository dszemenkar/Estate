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
            return Ok(await _repo.AddTenant(tenant));
        }

        [HttpPut]
        public async Task<IActionResult> EditTenant(Tenant tenant)
        {
            return Ok(await _repo.EditTenant(tenant));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTenant(int id)
        {
            return Ok(await _repo.DeleteTenant(id));
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
