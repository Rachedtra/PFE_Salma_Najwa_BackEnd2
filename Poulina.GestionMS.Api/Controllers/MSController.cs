using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poulina.GestionMS.Domain.Commandes;
using Poulina.GestionMS.Domain.Interfaces;
using Poulina.GestionMS.Domain.Models;
using Poulina.GestionMS.Domain.Queries;

namespace Poulina.GestionMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MSController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MSController(IMediator mediator)
        {
            _mediator = mediator;


        }
        // GET: api/Emp
        [HttpGet]
        public async Task<ActionResult<MS>> GETAll()
        {
            var x = new GetAllQuery<MS>();
            var result = await _mediator.Send(x);
            return Ok(result);
        }

        // GET: api/Emp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MS>> Get(Guid id)
        {
            var k = new GetQueryByID<MS>(id);
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
        public async Task<ActionResult<MS>> Put([FromBody] MS etu)
        {
            var k = new PutGeneric<MS>(etu);
            var result = await _mediator.Send(k);
            return Ok(result);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MS>> Delete(Guid id)
        {
            var k = new DeleteGeniric<MS>(id);
            var result = await _mediator.Send(k);
            return Ok(result);
        }
    }
}