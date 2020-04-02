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
    public class DomainController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DomainController(IMediator mediator)
        {
            _mediator = mediator;


        }
        // GET: api/Emp
        [HttpGet]
        public async Task<ActionResult<Domaine>> GETAll()
        {
            var x = new GetAllQuery<Domaine>();
            var result = await _mediator.Send(x);
            return Ok(result);
        }

        // GET: api/Emp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domaine>> Get(Guid id)
        {
            var k = new GetQueryByID<Domaine>(id);
            var result = await _mediator.Send(k);
            return Ok(result);
        }

        // POST: api/Emp
        [HttpPost]
        public async Task<ActionResult<Domaine>> PostAsync(Domaine entity)
        {
            var k = new AddGeneric<Domaine>(entity);
            var result = await _mediator.Send(k);
            return Ok(result);
        }

        // PUT: api/Emp/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Domaine>> Put([FromBody] Domaine etu)
        {
            var k = new PutGeneric<Domaine>(etu);
            var result = await _mediator.Send(k);
            return Ok(result);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Domaine>> Delete(Guid id)
        {
            var k = new DeleteGeniric<Domaine>(id);
            var result = await _mediator.Send(k);
            return Ok(result);
        }
    }
}