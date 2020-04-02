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
    public class MethodController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MethodController(IMediator mediator)
        {
            _mediator = mediator;


        }
        // GET: api/Emp
        [HttpGet]
        public async Task<ActionResult<Methode>> GETAll()
        {
            var x = new GetAllQuery<Methode>();
            var result = await _mediator.Send(x);
            return Ok(result);
        }

        // GET: api/Emp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Methode>> Get(Guid id)
        {
            var k = new GetQueryByID<Methode>(id);
            var result = await _mediator.Send(k);
            return Ok(result);
        }

        // POST: api/Emp
        [HttpPost]
        public async Task<ActionResult<Methode>> PostAsync(Methode entity)
        {
            var k = new AddGeneric<Methode>(entity);
            var result = await _mediator.Send(k);
            return Ok(result);
        }

        // PUT: api/Emp/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Methode>> Put([FromBody] Methode etu)
        {
            var k = new PutGeneric<Methode>(etu);
            var result = await _mediator.Send(k);
            return Ok(result);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Methode>> Delete(Guid id)
        {
            var k = new DeleteGeniric<Methode>(id);
            var result = await _mediator.Send(k);
            return Ok(result);
        }
    }
}