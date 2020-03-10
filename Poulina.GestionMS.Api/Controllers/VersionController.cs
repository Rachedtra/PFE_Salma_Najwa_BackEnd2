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
    public class VersionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VersionController(IMediator mediator)
        {
            _mediator = mediator;


        }
        // GET: api/Emp
        [HttpGet]
        public async Task<ActionResult<Versions>> GETAll()
        {
            var x = new GetAllQuery<Versions>();
            var result = await _mediator.Send(x);
            return Ok(result);
        }

        // GET: api/Emp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Versions>> Get(Guid id)
        {
            var k = new GetQueryByID<Versions>(id);
            var result = await _mediator.Send(k);
            return Ok(result);
        }

        // POST: api/Emp
        [HttpPost]
        public async Task<ActionResult<Versions>> PostAsync(Versions entity)
        {
            var k = new AddGeneric<Versions>(entity);
            var result = await _mediator.Send(k);
            return Ok(result);
        }

        // PUT: api/Emp/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Versions>> Put([FromBody] Versions etu)
        {
            var k = new PutGeneric<Versions>(etu);
            var result = await _mediator.Send(k);
            return Ok(result);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Versions>> Delete(Guid id)
        {
            var k = new DeleteGeniric<Versions>(id);
            var result = await _mediator.Send(k);
            return Ok(result);
        }
    }
}