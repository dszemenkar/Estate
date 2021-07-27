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
        public async Task<IActionResult> GetApartments()
        {
            return Ok(await _repo.GetTenants());
        }

        [HttpPost]
        public async Task<IActionResult> AddApartment(Tenant tenant)
        {
            return Ok(await _repo.AddTenant(tenant));
        }

        [HttpPut]
        public async Task<IActionResult> EditApartment(Tenant tenant)
        {
            return Ok(await _repo.EditTenant(tenant));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApartment(int id)
        {
            return Ok(await _repo.DeleteTenant(id));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetApartment(int id)
        {
            return Ok(await _repo.GetTenant(id));
        }
    }
}
