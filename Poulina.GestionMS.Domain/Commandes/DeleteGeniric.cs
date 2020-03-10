using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poulina.GestionMS.Domain.Commandes
{
    public class DeleteGeniric<T> : IRequest<string> where T : class
    {
        public DeleteGeniric(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; }
    }
}
