using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poulina.GestionMS.Domain.Commandes;
using Poulina.GestionMS.Domain.Models;
using Poulina.GestionMS.Domain.Queries;

namespace Poulina.GestionMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LanguageController(IMediator mediator)
        {
            _mediator = mediator;


        }
        // GET: api/Emp
        [HttpGet]
        public async Task<ActionResult<Language>> GETAll()
        {
            var x = new GetAllQuery<Language>();
            var result = await _mediator.Send(x);
            return Ok(result);
        }

        // GET: api/Emp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Language>> Get(Guid id)
        {
            var k = new GetQueryByID<Language>(id);
            var result = await _mediator.Send(k);
            return Ok(result);
        }

        // POST: api/Emp
        [HttpPost]
        public async Task<ActionResult<MS>> PostAsync(MS entity)
        {
            var k = new AddGeneric<MS>(entity);
            var result = await _mediator.Send(k);
            return Ok(result);
        }

        // PUT: api/Emp/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Language>> Put([FromBody] Language etu)
        {
            var k = new PutGeneric<Language>(etu);
            var result = await _mediator.Send(k);
            return Ok(result);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Language>> Delete(Guid id)
        {
            var k = new DeleteGeniric<Language>(id);
            var result = await _mediator.Send(k);
            return Ok(result);
        }
    }
}