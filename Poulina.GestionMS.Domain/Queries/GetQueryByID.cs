using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poulina.GestionMS.Domain.Queries
{
    public class GetQueryByID<T> : IRequest<T> where T : class
    {
        public GetQueryByID(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}