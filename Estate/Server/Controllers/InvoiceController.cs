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
    public class InvoiceController : BaseApiController
    {
        private readonly IInvoiceInterface _repo;

        public InvoiceController(IInvoiceInterface repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetInvoices()
        {
            return Ok(await _repo.GetInvoices());
        }

        [HttpGet("param/{param}")]
        public async Task<IActionResult> GetInvoicesWithParam(string param)
        {
            return Ok(await _repo.GetInvoicesWithParam(param));
        }

        [HttpGet("paramanduser/{param}")]
        public async Task<IActionResult> GetInvoicesWithParamAndUser(string param, AppUser user)
        {
            return Ok(await _repo.GetInvoicesWithParamAndUser(param, user));
        }

        [HttpPost("generate")]
        public async Task<IActionResult> GenerateAllInvoices(Invoice invoice)
        {
            var response = await _repo.GenerateAllInvoices(invoice);
            if (response.Data == 0)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpGet("line/{id}")]
        public async Task<IActionResult> GetInvoiceLines(int id)
        {
            return Ok(await _repo.GetInvoiceLines(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddInvoice(Invoice invoice)
        {
            var response = await _repo.AddInvoice(invoice);
            if (response.Data == 0)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> EditInvoice(Invoice invoice)
        {
            var response = await _repo.EditInvoice(invoice);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpPost("line")]
        public async Task<IActionResult> AddInvoiceLine(InvoiceLine line)
        {
            var response = await _repo.AddLine(line);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            return Ok(await _repo.DeleteInvoice(id));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInvoice(int id)
        {
            return Ok(await _repo.GetInvoice(id));
        }

        [HttpGet("invoiceno")]
        public async Task<IActionResult> GetInvoiceNo()
        {
            return Ok(await _repo.GetInvoiceNo());
        }

        [HttpGet("lineno/{id}")]
        public async Task<IActionResult> GetInvoiceLineNo(int id)
        {
            return Ok(await _repo.GetInvoiceLineNo(id));
        }

        [HttpPost("sendeinvoice")]
        public async Task<IActionResult> SendEInvoice(Invoice invoice)
        {
            return Ok(await _repo.SendEInvoice(invoice));
        }
    }
}
